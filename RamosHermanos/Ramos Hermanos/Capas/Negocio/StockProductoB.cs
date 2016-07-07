using System;
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
    class StockProductoB
    {
        public static bool ExisteStock(int idProducto)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM stockProducto
                             WHERE idProducto = @idProducto";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idProducto", idProducto);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static void UpdateStock(StockProductoEntity stockProducto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SET @@sql_safe_updates = 0; 
                                 UPDATE stockProducto
                                 SET stockMinimo = @stockMinimo, stockMaximo = @stockMaximo, stockActual = @stockActual, fechaActualizacion = @fechaActualizacion
                                 WHERE idProducto = @idProducto;
                                 SET @@sql_safe_updates = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("idProducto", stockProducto.idProducto);
                cmd.Parameters.AddWithValue("@stockMinimo", stockProducto.stockMinimo);
                cmd.Parameters.AddWithValue("@stockMaximo", stockProducto.stockMaximo);
                cmd.Parameters.AddWithValue("@stockActual", stockProducto.stockActual);
                cmd.Parameters.AddWithValue("@fechaActualizacion", stockProducto.fechaActualizacion);
                
                cmd.ExecuteNonQuery();

                // MessageBox.Show("Cliente Actualizado!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void UpdateStock2(StockProductoEntity stockProducto)
        {
            try
            {
                MySQL.ConnectDB();

                string queryConsulta = @"SELECT * FROM stockProducto WHERE idProducto = @idProducto";

                MySqlCommand cmdConsulta = new MySqlCommand(queryConsulta, MySQL.sqlcnx);

                cmdConsulta.Parameters.AddWithValue("@idProducto", stockProducto.idProducto);

                //Buscamos valor anterior del stockActual
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmdConsulta);

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

                //cmd.Parameters.AddWithValue("@idProducto", stockProducto.idProducto);
                //cmd.Parameters.AddWithValue("@stockActual", stockProducto.stockActual);
                //cmd.Parameters.AddWithValue("@fechaActualizacion", DateTime.Now);
                //cmd.Parameters.AddWithValue("@valorAnterior", stockProducto.valorAnterior);
                //cmd.Parameters.AddWithValue("@valorNuevo", stockProducto.valorNuevo);

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
                else
                {
                    int valorResultante = stockProducto.valorNuevo + stockProducto.valorAnterior;
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

        public static StockProductoEntity BuscarStock(int idProducto)
        {
            try
            {
                MySQL.ConnectDB();

                StockProductoEntity stockP = new StockProductoEntity();

                string query = @"SELECT SP.stockMinimo, SP.stockMaximo, SPL.stockActual as stockActual, SPL.stockNuevo as stockNuevo
                                FROM stockProducto SP
                                INNER JOIN stockProductoLog SPL ON SPL.idProducto = SP.idProducto
                                WHERE SP.idProducto = @idProducto and idStockProductoLog = (SELECT MAX(idStockProductoLog) FROM stockProductoLog WHERE idProducto = @idProducto)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", idProducto);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    stockP.stockMinimo = Convert.ToInt32(row["stockMinimo"]);
                    stockP.stockMaximo = Convert.ToInt32(row["stockMaximo"]);
                    stockP.stockActual = Convert.ToInt32(row["stockActual"]);
                    stockP.stockNuevo = Convert.ToInt32(row["stockNuevo"]);
                    //stockP.fechaActualizacion = Convert.ToDateTime(row["fechaActualizacion"]);

                    MySQL.DisconnectDB();
                }

                return stockP;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void ActualizarStock(LogStockProductoEntity logStock)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO stockProductoLog (operacion, comprobante, idProducto, cantidad, stockActual, stockNuevo)
                                VALUES (@operacion, @comprobante, @idProducto, @cantidad, @stockActual, @stockNuevo)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@operacion", logStock.operacion);
                cmd.Parameters.AddWithValue("@comprobante", logStock.comprobante);
                cmd.Parameters.AddWithValue("@idProducto", logStock.idProducto);
                cmd.Parameters.AddWithValue("@cantidad", logStock.cantidad);
                cmd.Parameters.AddWithValue("@stockActual", logStock.stockNuevo);

                if (logStock.operacion == "P")
                {
                    cmd.Parameters.AddWithValue("@stockNuevo", logStock.stockNuevo + logStock.cantidad);
                }
                else if (logStock.operacion == "V")
                {
                    cmd.Parameters.AddWithValue("@stockNuevo", logStock.stockNuevo - logStock.cantidad);
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

        public static void InsertStock(StockProductoEntity stock)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO stockproducto (idProducto, stockMinimo, stockMaximo, stockActual,fechaActualizacion) 
                                 VALUES (@idProducto, @stockMinimo, @stockMaximo, 0, @fechaActualizacion)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idproducto", stock.idProducto);
                cmd.Parameters.AddWithValue("@stockMinimo", stock.stockMinimo);
                cmd.Parameters.AddWithValue("@stockMaximo", stock.stockMaximo);
                cmd.Parameters.AddWithValue("@stockActual", stock.stockActual);
                cmd.Parameters.AddWithValue("@fechaActualizacion", stock.fechaActualizacion);

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

        public static void cargardgvStock(DataGridView dgv, TextBox idProducto)
        {
            try
            {
                MySQL.ConnectDB();
                string query = @"SELECT P.idStock,PRO.producto,PRO.idProducto,P.stockMinimo,P.stockMaximo,P.stockActual,P.fechaActualizacion
                            FROM stockProducto P
                            INNER JOIN productos PRO on PRO.idProducto = P.idProducto
                            WHERE P.idProducto=@idProducto
                            ORDER BY fechaActualizacion DESC";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", idProducto.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idProducto"]),
                    Convert.ToString(dr["producto"]),
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

                string query = @"(SELECT 'VENTA' as operacion, SPL.comprobante as A, F.fechaFactura as B, SPL.cantidad as C, SPL.stockNuevo as D
                                FROM stockProductoLog SPL
                                INNER JOIN Facturas F ON F.idFactura = SPL.comprobante
                                INNER JOIN itemsFactura IIF ON IIF.factura = F.idFactura
                                WHERE SPL.idProducto = @producto and operacion = 'V') 
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

        public static bool DisponiblidadStock(int idProducto, int cantidad)
        {
            MySQL.ConnectDB();

            string query = @"SELECT * 
                            FROM stockProductoLog
                            WHERE idProducto = @idProducto and idStockProductoLog = (SELECT MAX(idStockProductoLog) FROM stockproductolog WHERE idProducto = @idProducto)";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idProducto", idProducto);

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);

            if (Convert.ToInt32(dt.Rows[0]["stockNuevo"].ToString()) < cantidad)
            {
                MessageBox.Show("No hay stock disponible!");
                return false;
            }
            else
                return true;
        }
    }
}
