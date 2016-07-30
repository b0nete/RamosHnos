using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace RamosHermanos.Capas.Negocio
{
    class ComprasB
    {
        public static DataRow BuscarCompraID(int idCompra)
        {
            try
            {
                MySQL.ConnectDB();

                DataTable dt = new DataTable();

                string query = @"SELECT idCompras, C.tipoFactura, C.numFactura, C.fechaEntrega, C.fechaVencimiento, C.proveedor, P.cuit, P.condicionIVA, P.razonSocial, fecha, observaciones, total, C.estado, tipofactura, C.formaPago
                                FROM Compras C
                                INNER JOIN Proveedores P ON C.proveedor = P.idProveedor
                                WHERE idCompras = @idCompra";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCompra", idCompra);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("La Compra NO existe!");
                }
                else
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);
                }

                DataRow dr = dt.Rows[0];

                MySQL.DisconnectDB();

                return dr;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ComprasEntity UpdateCompra(ComprasEntity compra)
        {
            try
            {
                MySQL.ConnectDB();

                //Buscamos valores originales, para que en el caso de no tener algún valor para actualizar se actualize con los valores originales para no obtener 0 o NULL.

                string query = "SELECT * FROM Compras WHERE idCompras = @idCompra";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCompra", compra.idCompras);

                string query1 = @"UPDATE Compras 
                                 SET tipoFactura = @tipoFactura, fecha = @fecha, fechaVencimiento = @fechaVencimiento, fechaEntrega = @fechaEntrega, formaPago = @formaPago, cliente = @cliente, domicilio = @domicilio, observaciones = @observaciones, total = @total, estado = @estado
                                 WHERE idFactura = @idFactura";

                MySqlCommand cmd1 = new MySqlCommand(query1, MySQL.sqlcnx);

                cmd1.ExecuteNonQuery();

                //MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return compra;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }

        }

        public static ComprasEntity InsertCompras(ComprasEntity compras, TextBox txtid)
        {
            try
            {
                MySQL.ConnectDB();
                string query = @"INSERT INTO compras (tipoFactura, numFactura, fecha, fechaEntrega, fechaVencimiento, proveedor, observaciones, total, estado, formaPago)
                                 VALUES (@tipoFactura, @numFactura, @fecha, @fechaEntrega, @fechaVencimiento, @proveedor, @observaciones, @total, @estado, @formaPago);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoFactura", compras.tipoFactura);
                cmd.Parameters.AddWithValue("@numFactura", compras.numFactura);
                cmd.Parameters.AddWithValue("@fecha", compras.fecha);
                cmd.Parameters.AddWithValue("@fechaEntrega", compras.fechaEntrega);
                cmd.Parameters.AddWithValue("@fechaVencimiento", compras.fechaVencimiento);
                cmd.Parameters.AddWithValue("@proveedor", compras.proveedor);
                cmd.Parameters.AddWithValue("@observaciones", compras.observaciones);
                cmd.Parameters.AddWithValue("@total", compras.total);
                cmd.Parameters.AddWithValue("@estado", compras.estado);
                cmd.Parameters.AddWithValue("@formaPago", compras.formaPago);

                txtid.Text = Convert.ToString(cmd.ExecuteScalar());

                MySQL.DisconnectDB();

                return compras;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "ERROR");
                throw;
            }
        }

        public static void ListCompras(DataGridView dgvList, string WHERE)
        {
            try
            {
                MySQL.ConnectDB();

                string addQuery = "";

                string query = @"SELECT idCompras as colCompra, fecha as colFecha, P.razonSocial as colProveedor, total as colTotal, C.estado as colEstado
                                FROM Compras C
                                INNER JOIN Proveedores P ON P.idProveedor = C.proveedor
                                WHERE total > 0";

                DataTable dt = new DataTable();

                if (WHERE == "Pagado")
                {
                    addQuery = " and C.estado = 'Pagado'";
                }
                else if (WHERE == "Pendiente")
                {

                    addQuery = " and C.estado = 'Pendiente'";
                }

                MySqlDataAdapter da = new MySqlDataAdapter(query + addQuery, MySQL.sqlcnx);

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

        public static DataTable SearchPagas(int idProveedor, DataGridView dgvMovimientos)
        {
            try
            {
                MySQL.ConnectDB();
                DataTable dt = new DataTable();

                string query = @"SELECT tipofactura, fecha, numFactura, fechaVencimiento, total, formaPago
                                FROM Compras C
                                INNER JOIN Proveedores P ON P.idProveedor = C.proveedor
                                WHERE proveedor = @proveedor and C.estado = 'Pagado' and total > 0";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                cmd.Parameters.AddWithValue("@proveedor", idProveedor);

                int resultado = 1;
                if (resultado == 0)
                {
                    //MessageBox.Show("No existen facturas pagas!");
                }
                else
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvMovimientos.AutoGenerateColumns = false;
                    dgvMovimientos.DataSource = dt;
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

        public static DataTable SearchPendientes(int idProveedor, DataGridView dgvMovimientos)
        {
            try
            {
                MySQL.ConnectDB();
                DataTable dt = new DataTable();

                string query = @"SELECT tipofactura, fecha, numFactura, fechaVencimiento, total, formaPago
                                FROM Compras C
                                INNER JOIN Proveedores P ON P.idProveedor = C.proveedor
                                WHERE proveedor = @proveedor and C.estado = 'Pendiente' and total > 0";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                cmd.Parameters.AddWithValue("@proveedor", idProveedor);

                int resultado = 1;
                if (resultado == 0)
                {
                    //MessageBox.Show("No existen facturas pendientes!");
                }
                else
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    dgvMovimientos.AutoGenerateColumns = false;
                    dgvMovimientos.DataSource = dt;
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

        public static DataTable GenerarGraficoAnual()
        {
            try
            {
                DataTable dt = new DataTable();

                MySQL.ConnectDB();

                string query = @"SELECT SUM(total) as Total, DATE_FORMAT(fecha, '%Y') as año
                                 FROM Compras
                                 WHERE YEAR(fecha) >= 2000 and YEAR(fecha) <= 3000
                                 GROUP BY YEAR(fecha)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

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

        public static DataTable GenerarGraficoMensual()
        {
            try
            {
                DataTable dt = new DataTable();

                MySQL.ConnectDB();

                string query = @"SET lc_time_names = 'es_UY';
SELECT SUM(total) as Total, CONCAT(UCASE(SUBSTRING(MONTHNAME(fecha), 1, 1)),LCASE(SUBSTRING(MONTHNAME(fecha), 2))) as mes
                                 FROM Compras
                                 WHERE MONTH(fecha) >= 1 and MONTH(fecha) <= 12
                                 GROUP BY MONTH(fecha)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

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

        public static DataTable GenerarGraficoDiario()
        {
            try
            {
                DataTable dt = new DataTable();

                MySQL.ConnectDB();

                string query = @"SET lc_time_names = 'es_UY';
SELECT SUM(total) as Total, CONCAT(UCASE(SUBSTRING(DAYNAME(fecha), 1, 1)),LCASE(SUBSTRING(DAYNAME(fecha), 2))) as dia
                                 FROM Compras
                                 WHERE DAY(fecha) >= 1 and DAY(fecha) <= 31
                                 GROUP BY dayofweek(fecha)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

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

        public static string totalCompras()
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT SUM(total)
                                 FROM Compras";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                string retorno = Convert.ToString(cmd.ExecuteScalar());

                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string cantidadCompras()
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT COUNT(idCompras)
                                FROM Compras
                                WHERE total <> 0";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                string retorno = Convert.ToString(cmd.ExecuteScalar());

                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string cantidadPagas()
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT COUNT(idCompras)
                                FROM Compras
                                WHERE total <> 0 and estado = 'Pagado'";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                string retorno = Convert.ToString(cmd.ExecuteScalar());

                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string totalPagado()
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT IFNULL(SUM(total), 0)
                                FROM Compras
                                WHERE total <> 0 and estado = 'Pagado'";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                string retorno = Convert.ToString(cmd.ExecuteScalar());

                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string cantidadNoPagas()
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT COUNT(idCompras)
                                FROM Compras
                                WHERE total <> 0 and estado = 'Pendiente'";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                string retorno = Convert.ToString(cmd.ExecuteScalar());

                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string totalDeuda()
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT IFNULL(SUM(total), 0)
                                FROM Compras
                                WHERE total <> 0 and estado = 'Pendiente'";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                string retorno = Convert.ToString(cmd.ExecuteScalar());

                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
        //
    }
}