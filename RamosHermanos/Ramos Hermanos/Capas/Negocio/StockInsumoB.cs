﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;

namespace RamosHermanos.Capas.Negocio
{
    class StockInsumoB
    {
        public static bool ExisteStock(int idInsumo)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM stockInsumos
                             WHERE idInsumo = @idInsumo";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idInsumo", idInsumo);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static StockInsumoEntity BuscarStock(int idInsumo)
        {
            try
            {
                MySQL.ConnectDB();

                StockInsumoEntity stockI = new StockInsumoEntity();

                string query = @"SELECT SI.stockMinimo, SI.stockMaximo, MAX(SIL.stockActual) as stockActual, MAX(SIL.stockNuevo) as stockNuevo
                                FROM stockInsumos SI
                                INNER JOIN stockInsumoLog SIL ON SIL.idInsumo = SI.idInsumo
                                WHERE SI.idInsumo = @idInsumo";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", idInsumo);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    stockI.stockMinimo = Convert.ToInt32(row["stockMinimo"]);
                    stockI.stockMaximo = Convert.ToInt32(row["stockMaximo"]);
                    stockI.stockActual = Convert.ToInt32(row["stockActual"]);
                    stockI.stockNuevo = Convert.ToInt32(row["stockNuevo"]);
                    //stockP.fechaActualizacion = Convert.ToDateTime(row["fechaActualizacion"]);

                    MySQL.DisconnectDB();
                }

                return stockI;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void UpdateStockInicial(StockInsumoEntity stockInsumo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SET @@sql_safe_updates = 0; 
                                 UPDATE stockInsumos
                                 SET stockMinimo = @stockMinimo, stockMaximo = @stockMaximo, fechaActualizacion = @fechaActualizacion
                                 WHERE idInsumo = @idInsumo;
                                 SET @@sql_safe_updates = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", stockInsumo.idInsumo);
                cmd.Parameters.AddWithValue("@stockMinimo", stockInsumo.stockMinimo);
                cmd.Parameters.AddWithValue("@stockMaximo", stockInsumo.stockMaximo);
                cmd.Parameters.AddWithValue("@stockActual", stockInsumo.stockActual);
                cmd.Parameters.AddWithValue("@fechaActualizacion", stockInsumo.fechaActualizacion);

                cmd.ExecuteNonQuery();

                // MessageBox.Show("Cliente Actualizado!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void UpdateStockUpdate(StockProductoEntity stockProducto)
        {
            try
            {
                //Buscamos valor anterior del stockActual
                MySQL.ConnectDB();

                string queryConsultaStock = @"SELECT * FROM stockProducto WHERE idProducto = @idProducto";

                MySqlCommand cmdConsultaStock = new MySqlCommand(queryConsultaStock, MySQL.sqlcnx);

                cmdConsultaStock.Parameters.AddWithValue("@idProducto", stockProducto.idProducto);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmdConsultaStock);

                da.Fill(dt);
                DataRow dr = dt.Rows[0];

                stockProducto.stockActual = Convert.ToInt32(dr["stockActual"].ToString());

                //Hacemos la actualizacion del stock

                string query = @"SET @@sql_safe_updates = 0; 
                                 UPDATE stockProducto
                                 SET stockActual = @stockActual, fechaActualizacion = @fechaActualizacion
                                 WHERE idProducto = @idProducto;
                                 SET @@sql_safe_updates = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                if (stockProducto.valorAnterior < stockProducto.valorNuevo)
                {
                    int valorResultante = stockProducto.valorNuevo - stockProducto.valorAnterior;
                    stockProducto.stockActual = stockProducto.stockActual - valorResultante;

                    cmd.Parameters.AddWithValue("@idProducto", stockProducto.idProducto);
                    cmd.Parameters.AddWithValue("@stockActual", stockProducto.stockActual);
                    cmd.Parameters.AddWithValue("@fechaActualizacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@valorAnterior", stockProducto.valorAnterior);
                    cmd.Parameters.AddWithValue("@valorNuevo", stockProducto.valorNuevo);

                    cmd.ExecuteNonQuery();
                }
                else if (stockProducto.valorAnterior > stockProducto.valorNuevo)
                {
                    int valorResultante = stockProducto.valorAnterior - stockProducto.valorNuevo;
                    stockProducto.stockActual = stockProducto.stockActual + valorResultante;

                    cmd.Parameters.AddWithValue("@idProducto", stockProducto.idProducto);
                    cmd.Parameters.AddWithValue("@stockActual", stockProducto.stockActual);
                    cmd.Parameters.AddWithValue("@fechaActualizacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@valorAnterior", stockProducto.valorAnterior);
                    cmd.Parameters.AddWithValue("@valorNuevo", stockProducto.valorNuevo);

                    cmd.ExecuteNonQuery();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void UpdateStockInsert(StockInsumoEntity stockInsumo, string carga)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "";

                if (carga == "C")
                {
                    string queryLess = @"SET @@sql_safe_updates = 0; 
                                 UPDATE stockInsumos
                                SET stockActual = stockActual - @valorNuevo, fechaActualizacion = @fechaActualizacion
                                WHERE idInsumo = @idInsumo;
                                 SET @@sql_safe_updates = 1";

                    query = queryLess;
                }
                else if (carga == "D")
                {
                    string queryPlus = @"SET @@sql_safe_updates = 0; 
                                 UPDATE stockInsumos
                                SET stockActual = stockActual + @valorNuevo, fechaActualizacion = @fechaActualizacion
                                WHERE idInsumo = @idInsumo;
                                 SET @@sql_safe_updates = 1";

                    query = queryPlus;
                }

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", stockInsumo.idInsumo);
                cmd.Parameters.AddWithValue("@stockActual", stockInsumo.stockActual);
                cmd.Parameters.AddWithValue("@fechaActualizacion", DateTime.Now);
                cmd.Parameters.AddWithValue("@valorAnterior", stockInsumo.valorAnterior);
                cmd.Parameters.AddWithValue("@valorNuevo", stockInsumo.valorNuevo);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void ActualizarStock(LogStockInsumoEntity logStock)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO stockInsumoLog (operacion, comprobante, idInsumo, cantidad, stockActual, stockNuevo)
                                VALUES (@operacion, @comprobante, @idInsumo, @cantidad, @stockActual, @stockNuevo)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@operacion", logStock.operacion);
                cmd.Parameters.AddWithValue("@comprobante", logStock.comprobante);
                cmd.Parameters.AddWithValue("@idInsumo", logStock.idInsumo);
                cmd.Parameters.AddWithValue("@cantidad", logStock.cantidad);
                cmd.Parameters.AddWithValue("@stockActual", logStock.stockNuevo);

                if (logStock.operacion == "P")
                {
                    cmd.Parameters.AddWithValue("@stockNuevo", logStock.stockNuevo + logStock.cantidad);
                }
                else if (logStock.operacion == "V")
                {
                    cmd.Parameters.AddWithValue("@stockNuevo", logStock.stockActual - logStock.cantidad);
                }

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void InsertStock(StockInsumoEntity stock)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO stockinsumos (idInsumo, stockMinimo, stockMaximo, fechaActualizacion) 
                                 VALUES (@idInsumo, @stockMinimo, @stockMaximo, @fechaActualizacion)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idinsumo", stock.idInsumo);
                cmd.Parameters.AddWithValue("@stockMinimo", stock.stockMinimo);
                cmd.Parameters.AddWithValue("@stockMaximo", stock.stockMaximo);
                cmd.Parameters.AddWithValue("@fechaActualizacion", DateTime.Now);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Stock Guardado!");
                MySQL.DisconnectDB();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void cargardgvStock(DataGridView dgv, TextBox idInsumo)
        {
            try
            {
                MySQL.ConnectDB();

                dgv.DataSource = null;

                string query = @"SELECT I.idStock,INS.insumo,INS.idInsumo,I.stockMinimo,I.stockMaximo,I.stockActual,I.fechaActualizacion
                            FROM stockInsumos I
                            INNER JOIN insumos INS on INS.idInsumo = I.idInsumo
                            WHERE I.idInsumo=@idInsumo
                            ORDER BY fechaActualizacion DESC";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", idInsumo.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idInsumo"]),
                    Convert.ToString(dr["insumo"]),
                    Convert.ToString(dr["stockMinimo"]),
                    Convert.ToString(dr["stockMaximo"]),
                    Convert.ToString(dr["stockActual"]),
                    Convert.ToString(dr["fechaActualizacion"]));
                }

                dr.Close();
                MySQL.ConnectDB();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "ERROR");
                throw;
            }
        }
        public static void StockLogDGV(DataGridView dgv, TextBox producto)
        {
            try
            {
                MySQL.ConnectDB();
                //                string query = @"(SELECT 'VENTA' as operacion, FI.factura as A, F.fechaFactura as B, FI.cantidad as C
                //                                FROM itemsfactura FI
                //                                INNER JOIN Facturas F ON FI.factura = F.idFactura
                //                                WHERE producto = @producto) 
                //                                UNION 
                //                                (SELECT 'PRODUCCION' as operacion, IP.produccion as A, P.fechaProduccion as B, IP.cantidad as C
                //                                FROM ItemsProduccion IP
                //                                INNER JOIN Produccion P ON IP.produccion = P.idProduccion
                //                                WHERE producto = @producto)";

                string query = @"(SELECT 'COMPRA' as operacion, SIL.comprobante as A, F.fechaFactura as B, SIL.cantidad as C, SIL.stockNuevo as D
                                FROM stockInsumoLog SIL
                                INNER JOIN Facturas F ON F.idFactura = SIL.comprobante
                                INNER JOIN itemsFactura IIF ON IIF.factura = F.idFactura
                                WHERE SIL.idInsumo= @insumo and operacion = 'C') 
                                UNION 
                                (SELECT 'PRODUCCION' as operacion, SPL.comprobante as A, P.fechaProduccion as B, SPL.cantidad as C, SPL.stockNuevo as D 
                                FROM stockProductoLog SPL
                                INNER JOIN Produccion P ON P.idProduccion = SPL.comprobante
                                INNER JOIN itemsProduccion IIP ON IIP.produccion = P.idProduccion
                                WHERE SPL.idProducto = @producto and operacion = 'P')";


                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@producto", producto.Text);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                dgv.DataSource = dt;
                dgv.AutoGenerateColumns = false;

                MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "ERROR");
                throw;
            }
        }

        public static bool DisponibilidadStock(int idInsumo, int cantidad)
        {
            MySQL.ConnectDB();

            string query = @"SELECT stockActual
                            FROM stockInsumos
                            WHERE idInsumo = @idInsumo";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idInsumo", idInsumo);

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            int stockDisponible = Convert.ToInt32(dt.Rows[0]["stockActual"].ToString());

            if (stockDisponible < cantidad)
            {
                MessageBox.Show("Disponibilidad stock: " + stockDisponible + " unidades");
                return false;
            }
            else
                return true;
        }
    }
}