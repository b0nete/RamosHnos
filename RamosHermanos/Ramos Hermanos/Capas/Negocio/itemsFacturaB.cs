﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Datos;

namespace RamosHermanos.Capas.Negocio
{
    class itemsFacturaB
    {
        public static itemFacturaEntity BuscarItemFacturaDGV(itemFacturaEntity itemFactura, DataGridView dgv, TextBox txtTotal)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"(SELECT FI.idItemFactura, FI.factura, FI.producto as codProducto, FI.cantidad, REPLACE(FI.precioUnitario, '.', ',') as precioUnitario, FI.subTotal, P.producto, FI.carga
                                 FROM itemsFactura FI
                                 INNER JOIN Productos P ON P.idProducto = FI.producto
                                 WHERE FI.factura = @factura and FI.carga = 'C')
                                 UNION
                                 (SELECT FI.idItemFactura, FI.factura, FI.producto as codProducto, FI.cantidad, -(FI.precioUnitario) as precioUnitario, FI.subTotal, P.producto, FI.carga
                                 FROM itemsFactura FI
                                 INNER JOIN Productos P ON P.idProducto = FI.producto
                                 WHERE FI.factura = @factura and FI.carga = 'D')";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@factura", itemFactura.factura);

                    MySqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        dgv.Rows.Add(
                            Convert.ToString(dr["codProducto"]),
                            Convert.ToString(dr["producto"]),
                            Convert.ToString(dr["cantidad"]),
                            Convert.ToString(dr["precioUnitario"]),
                            Convert.ToString(dr["subTotal"]),
                            Convert.ToString(dr["carga"]));
                    }

                    dr.Close();

                double c;
                double total = 0;

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    c = Convert.ToDouble(row.Cells["colSubTotal"].Value.ToString());
                    total = Convert.ToDouble(c + total);
                }

                txtTotal.Text = Convert.ToString(total);
                MySQL.DisconnectDB();

                return itemFactura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static int BuscarCantidadAnterior(int idFactura, int idProducto, string carga)
        {
            try
            {
                //Buscamos valor anterior del itemFactura
                MySQL.ConnectDB();

                int cantidad;

                string queryConsultaValor = @"SELECT *
                                              FROM itemsFactura 
                                              WHERE factura = @idFactura and producto = @producto and carga = @carga";

                MySqlCommand cmdConsultaValor = new MySqlCommand(queryConsultaValor, MySQL.sqlcnx);

                cmdConsultaValor.Parameters.AddWithValue("@idFactura", idFactura);
                cmdConsultaValor.Parameters.AddWithValue("@producto", idProducto);
                cmdConsultaValor.Parameters.AddWithValue("@carga", carga);

                DataTable dtValor = new DataTable();
                MySqlDataAdapter daValor = new MySqlDataAdapter(cmdConsultaValor);

                daValor.Fill(dtValor);

                if (dtValor.Rows.Count == 0)
                {
                    cantidad = 0;
                }
                else
                {
                    DataRow drValor = dtValor.Rows[0];
                    cantidad = Convert.ToInt32(drValor["cantidad"].ToString());
                }

                MySQL.DisconnectDB();
                return cantidad;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static bool ExisteItemFactura(itemFacturaEntity itemFactura)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM itemsFactura
                             WHERE producto = @producto and factura = @factura and carga = @carga";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@producto", itemFactura.producto);
            cmd.Parameters.AddWithValue("@factura", itemFactura.factura);
            cmd.Parameters.AddWithValue("@carga", itemFactura.carga);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static bool ExisteAguaItemFactura(itemFacturaEntity itemFactura)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) 
FROM itemsFactura
WHERE (producto = 1 or producto = 2 or producto = 3  or producto = 4 or producto = 5 or producto = 6) and factura = @factura and carga = @carga";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@factura", itemFactura.factura);
            cmd.Parameters.AddWithValue("@carga", itemFactura.carga);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static DataTable BuscarAguas(itemFacturaEntity itemFactura)
        {
            try
            {
                MySQL.ConnectDB();

                DataTable dt = new DataTable();

                string query = @"SELECT *
FROM itemsFactura 
WHERE factura = @factura and (producto =  1 or producto =  2 or producto =  3 or producto =  4 or producto =  5 or producto =  6) and carga = @carga";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@factura", itemFactura.factura);
                cmd.Parameters.AddWithValue("@carga", itemFactura.carga);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado != 0)
                {                    
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);
                }

                MySQL.DisconnectDB();
                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static itemFacturaEntity CargarDgvVentas(itemFacturaEntity item, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT I.iditemFactura, I.factura, I.producto, I.cantidad, I.precioUnitario, I.subTotal , P.producto
                                FROM itemsFactura I
                                INNER JOIN productos P on P.idProducto = I.producto
                                WHERE I.factura = @factura";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@factura", item.factura);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    //item.codProducto = Convert.ToInt32(row["codProducto"]);
                    item.cantidad = Convert.ToInt32(row["cantidad"]);
                    item.factura = Convert.ToString(row["factura"]);
                    item.precioUnitario = Convert.ToDouble(row["precioUnitario"]);
                    item.subTotal = Convert.ToDouble(row["subTotal"]);

                    
                    MySQL.DisconnectDB();
                }

                return item;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static itemFacturaEntity InsertItemFactura(itemFacturaEntity itemFactura)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO itemsFactura (factura, producto, cantidad, precioUnitario, subTotal, carga) 
                                 VALUES (@factura, @producto, @cantidad, @precioUnitario, @subTotal, @carga)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@factura", itemFactura.factura);
                cmd.Parameters.AddWithValue("@producto", itemFactura.producto);
                cmd.Parameters.AddWithValue("@cantidad", itemFactura.cantidad);
                cmd.Parameters.AddWithValue("@precioUnitario", itemFactura.precioUnitario);
                cmd.Parameters.AddWithValue("@subTotal", itemFactura.subTotal);
                cmd.Parameters.AddWithValue("@carga", itemFactura.carga);

                cmd.ExecuteNonQuery();                                

                MySQL.DisconnectDB();

                return itemFactura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static itemFacturaEntity UpdateItemFactura(itemFacturaEntity itemFactura)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE itemsFactura
                                 SET cantidad = @cantidad, precioUnitario = @precioUnitario, subTotal = @subTotal
                                 WHERE producto = @producto and factura = @factura and carga = @carga";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@factura", itemFactura.factura);
                cmd.Parameters.AddWithValue("@producto", itemFactura.producto);
                cmd.Parameters.AddWithValue("@cantidad", itemFactura.cantidad);
                cmd.Parameters.AddWithValue("@precioUnitario", itemFactura.precioUnitario);
                cmd.Parameters.AddWithValue("@subTotal", itemFactura.subTotal);
                cmd.Parameters.AddWithValue("@carga", itemFactura.carga);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();

                return itemFactura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void InsertCargaFactura(itemFacturaEntity itemFactura, DataGridView dgv)
        {
            try
            {
                 MySQL.ConnectDB();

                string query = @"UPDATE itemsFactura
                                 SET (@factura, @producto, @cantidad, @precioUnitario, @subTotal)
                                 WHERE factura = @factura";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                
                cmd.Parameters.AddWithValue("@factura", itemFactura.factura);
                cmd.Parameters.AddWithValue("@producto", itemFactura.producto);
                cmd.Parameters.AddWithValue("@cantidad", itemFactura.cantidad);
                cmd.Parameters.AddWithValue("@precioUnitario", itemFactura.precioUnitario);
                cmd.Parameters.AddWithValue("@subTotal", itemFactura.subTotal);

                cmd.ExecuteNonQuery();
                                
                MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex); 
                throw;
            }
        }

        public static void DeleteItemsFactura(int idFactura)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SET SQL_SAFE_UPDATES = 0;
                                 DELETE FROM itemsFactura
                                 WHERE factura = @idFactura";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idFactura", idFactura);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
                throw;
            }
        }

//(SELECT 'VENTA' as operacion, FI.factura as A, F.fechaFactura as B, FI.cantidad as C
//FROM itemsfactura FI
//INNER JOIN Facturas F ON FI.factura = F.idFactura
//WHERE producto = 1) 
//UNION 
//(SELECT 'PRODUCCION' as operacion, IP.produccion as A, P.fechaProduccion as B, IP.cantidad as C
//FROM ItemsProduccion IP
//INNER JOIN Produccion P ON IP.produccion = P.idProduccion
//WHERE producto = 5)

//        public static void InsertItemFactura2(DataGridView dgv)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                itemFacturaEntity itemFactura = new itemFacturaEntity();

//                string query = @"INSERT INTO itemsFactura (factura, producto, cantidad, precioUnitario, subTotal) 
//                                 VALUES (@factura, @producto, @cantidad, @precioUnitario, @subTotal)";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@factura", itemFactura.factura);
//                cmd.Parameters.AddWithValue("@producto", itemFactura.producto);
//                cmd.Parameters.AddWithValue("@cantidad", itemFactura.cantidad);
//                cmd.Parameters.AddWithValue("@precioUnitario", itemFactura.precioUnitario);
//                cmd.Parameters.AddWithValue("@subTotal", itemFactura.subTotal);                

//                cmd.ExecuteNonQuery();

//                //MessageBox.Show("Cliente Guardado!");
//                MySQL.DisconnectDB();
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }

        //private void btGuardar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        SqlConnection conx = new SqlConnection(datosConx);
        //        conx.Open();
        //        SqlCommand cmd = new SqlCommand("INSERT INTO (FechaDatos) VALUES (@nombre)", conx);

        //        foreach (DataGridViewRow row in datosVer.Rows)
        //        {
        //            cmd.Parameters.Clear();

        //            string Nombre = row.Cells[0].Value.ToString();
        //            cmd.Parameters.AddWithValue("@nombre", Nombre);

        //            cmd.ExecuteNonQuery();

        //        }
        //    }
        //    catch (Exception ed)
        //    {
        //        MessageBox.Show(ed.Message);
        //    }
        //}
    }
}
