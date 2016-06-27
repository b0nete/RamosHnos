using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Negocio
{
    class ProduccionB
    {
//        public static bool ExisteCliente(ClienteEntity cliente)
//        {
//            MySQL.ConnectDB();

//            string query = @"SELECT COUNT(*) FROM Clientes
//                             WHERE numDoc = @numDoc";

//            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
//            cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

//            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

//            if (resultado == 0)
//                return false;
//            else
//                return true;
//        }

//        public static ClienteEntity UpdateCliente(ClienteEntity cliente)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = @"SET @@sql_safe_updates = 0; 
//                                 UPDATE Clientes
//                                 SET fechaalta = @fechaAlta, tipodoc = @tipoDoc, numdoc = @numDoc, sexo = @sexo, cuil =  @cuil, nombre = @nombre, apellido = @apellido, estadoCivil = @estadoCivil, condicionIVA = @condicionIVA, tipoCliente = @tipoCliente, estado = @estado
//                                 WHERE numDoc = @numDoc;
//                                 SET @@sql_safe_updates = 1";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@fechaAlta", cliente.fechaAlta);
//                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
//                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
//                cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
//                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
//                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
//                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
//                cmd.Parameters.AddWithValue("@estadoCivil", cliente.estadoCivil);
//                cmd.Parameters.AddWithValue("@condicionIVA", cliente.condicionIVA);
//                cmd.Parameters.AddWithValue("@tipoCliente", cliente.tipoCliente);
//                cmd.Parameters.AddWithValue("@estado", cliente.estado);

//                cmd.ExecuteNonQuery();

//                MessageBox.Show("Cliente Actualizado!");
//                return cliente;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }


        public static void InsertProduccion(ProduccionEntity produccion, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Produccion (fechaProduccion, descripcion) 
                                 VALUES (@fechaProduccion, @descripcion);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fechaProduccion", produccion.fechaProduccion);
                cmd.Parameters.AddWithValue("@descripcion", produccion.descripcion);

                produccion.idProduccion = Convert.ToInt32(cmd.ExecuteScalar());
                txt.Text = Convert.ToString(produccion.idProduccion);

                //MessageBox.Show("Produccion Guardada!");
                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void ListProduccion(DataGridView dgvList)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT idProduccion as colProduccion, fechaProduccion as colFecha, descripcion as colDescripcion
                                FROM Produccion P";

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query, MySQL.sqlcnx);

                da.Fill(dt);

                dgvList.DataSource = dt;

                MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

//        public static ClienteEntity BuscarClienteDOC(ClienteEntity cliente)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = "SELECT * FROM Clientes WHERE numDoc = @numDoc";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

//                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
//                if (resultado != 0)
//                {
//                    DataTable dt = new DataTable();
//                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

//                    da.Fill(dt);

//                    DataRow row = dt.Rows[0];

//                    cliente.idCliente = Convert.ToInt32(row["idCliente"]);
//                    cliente.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
//                    cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
//                    cliente.sexo = Convert.ToString(row["sexo"]);
//                    cliente.cuil = Convert.ToString(row["cuil"]);
//                    cliente.apellido = Convert.ToString(row["apellido"]);
//                    cliente.nombre = Convert.ToString(row["nombre"]);
//                    cliente.estadoCivil = Convert.ToString(row["estadoCivil"]);
//                    cliente.condicionIVA = Convert.ToString(row["condicionIVA"]);
//                    cliente.tipoCliente = Convert.ToInt32(row["tipoCliente"]);
//                    cliente.estado = Convert.ToBoolean(row["estado"]);

//                    MySQL.DisconnectDB();
//                }

//                return cliente;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }

        public static DataTable GenerarGraficoDiario(int producto, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                DataTable dt = new DataTable();

                MySQL.ConnectDB();

                string query = @"SELECT DATE_FORMAT(P.fechaProduccion,'%m/%d/%Y') as fechaProduccion, IP.producto, SUM(IP.cantidad) as Cantidad
                                FROM ItemsProduccion IP
                                INNER JOIN Produccion P ON P.idProduccion = IP.produccion
                                INNER JOIN Productos PP ON IP.Producto = PP.idProducto
                                WHERE IP.producto = @producto and (fechaProduccion >= @fechaDesde and fechaProduccion <= @fechaHasta)
                                GROUP BY fechaProduccion
                                ";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@producto", producto);
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static DataTable GenerarGraficoMensual(int producto, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                DataTable dt = new DataTable();

                MySQL.ConnectDB();

                string query = @"SELECT DATE_FORMAT(P.fechaProduccion,'%M') as fechaProduccion, IP.producto, SUM(IP.cantidad) as Cantidad
                                FROM ItemsProduccion IP
                                INNER JOIN Produccion P ON P.idProduccion = IP.produccion
                                INNER JOIN Productos PP ON IP.Producto = PP.idProducto
                                WHERE IP.producto = @producto and (fechaProduccion >= @fechaDesde and fechaProduccion <= @fechaHasta)
                                GROUP BY MONTH(fechaProduccion)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@producto", producto);
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static DataTable GenerarGraficoAnual(int producto, DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                DataTable dt = new DataTable();

                MySQL.ConnectDB();

                string query = @"SELECT DATE_FORMAT(P.fechaProduccion,'%Y') as fechaProduccion, SUM(IP.cantidad) as Cantidad
                                FROM ItemsProduccion IP
                                INNER JOIN Produccion P ON P.idProduccion = IP.produccion
                                INNER JOIN Productos PP ON IP.Producto = PP.idProducto
                                WHERE IP.producto = @producto and (fechaProduccion >= @fechaDesde and fechaProduccion <= @fechaHasta)
                                GROUP BY YEAR(fechaProduccion)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@producto", producto);
                cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde);
                cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
