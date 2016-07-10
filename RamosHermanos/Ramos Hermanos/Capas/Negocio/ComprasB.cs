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

//        public static ComprasEntity UpdateCompra(ComprasEntity compra)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                //Buscamos valores originales, para que en el caso de no tener algún valor para actualizar se actualize con los valores originales para no obtener 0 o NULL.

//                string query = "SELECT * FROM Facturas WHERE idFactura = @idFactura";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@idFactura", factura.idFactura);

//                int idFacturaORIG = 0;
//                string tipoFacturaORIG = "";
//                int numFacturaORIG = 0;
//                DateTime fechaFacturaORIG = Convert.ToDateTime("01/01/1990");
//                DateTime fechaVencimientoORIG = Convert.ToDateTime("01/01/1990");
//                DateTime fechaEntregaORIG = Convert.ToDateTime("01/01/1990");
//                string formaPagoORIG = "";
//                int clienteORIG = 0;
//                int domicilioORIG = 0;
//                string observacionesORIG = "";
//                double totalORIG = Convert.ToDouble(0);
//                string estadoORIG = "";

//                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
//                if (resultado != 0)
//                {
//                    DataTable dt = new DataTable();
//                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

//                    da.Fill(dt);

//                    DataRow row = dt.Rows[0];

//                    idFacturaORIG = Convert.ToInt32(row["idFactura"]);
//                    tipoFacturaORIG = Convert.ToString(row["tipoFactura"]);
//                    numFacturaORIG = Convert.ToInt32(row["numfactura"]);
//                    fechaFacturaORIG = Convert.ToDateTime(row["fechaFactura"]);
//                    fechaVencimientoORIG = Convert.ToDateTime(row["fechaVencimiento"]);
//                    fechaEntregaORIG = Convert.ToDateTime(row["fechaEntrega"]);
//                    formaPagoORIG = Convert.ToString(row["formaPago"]);
//                    clienteORIG = Convert.ToInt32(row["cliente"]);
//                    domicilioORIG = Convert.ToInt32(row["domicilio"]);
//                    observacionesORIG = Convert.ToString(row["observaciones"]);
//                    totalORIG = Convert.ToDouble(row["total"]);
//                    estadoORIG = Convert.ToString(row["estado"]);
//                }

//                // ----------------------------------------------------------//

//                //Hacemos el update, si hay valores nuevos se actualiza, de lo contrario se vuelven a cargar los valores originales.

//                string query1 = @"UPDATE Facturas 
//                                 SET tipoFactura = @tipoFactura, numFactura = @numFactura, fechaFactura = @fechaFactura, fechaVencimiento = @fechaVencimiento, fechaEntrega = @fechaEntrega, formaPago = @formaPago, cliente = @cliente, domicilio = @domicilio, observaciones = @observaciones, total = @total, estado = @estado
//                                 WHERE idFactura = @idFactura";

//                MySqlCommand cmd1 = new MySqlCommand(query1, MySQL.sqlcnx);

//                if (factura.idFactura == 0 || factura.idFactura.ToString() == string.Empty)
//                    cmd1.Parameters.AddWithValue("@idFactura", idFacturaORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@idFactura", factura.idFactura);

//                if (factura.tipoFactura == string.Empty || factura.tipoFactura == null)
//                    cmd1.Parameters.AddWithValue("@tipoFactura", tipoFacturaORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@tipoFactura", factura.tipoFactura);

//                if (Convert.ToString(factura.numFactura) == string.Empty || factura.numFactura.ToString() == null)
//                    cmd1.Parameters.AddWithValue("@numFactura", numFacturaORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@numFactura", factura.numFactura);

//                if (Convert.ToString(factura.fechaFactura) == string.Empty || factura.idFactura.ToString() == null)
//                    cmd1.Parameters.AddWithValue("@fechaFactura", fechaFacturaORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@fechaFactura", factura.fechaFactura);

//                if (Convert.ToString(factura.fechaVencimiento) == string.Empty || factura.idFactura.ToString() == null)
//                    cmd1.Parameters.AddWithValue("@fechaVencimiento", fechaVencimientoORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@fechaVencimiento", factura.fechaVencimiento);

//                if (Convert.ToString(factura.fechaEntrega) == string.Empty || factura.fechaEntrega.ToString() == null)
//                    cmd1.Parameters.AddWithValue("@fechaEntrega", fechaEntregaORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@fechaEntrega", factura.fechaEntrega);

//                if (Convert.ToString(factura.fechaEntrega) == string.Empty || factura.fechaEntrega.ToString() == null)
//                    cmd1.Parameters.AddWithValue("@fechaEntrega", fechaEntregaORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@formaPago", factura.formaPago);

//                if (Convert.ToString(factura.cliente) == string.Empty || factura.cliente.ToString() == null)
//                    cmd1.Parameters.AddWithValue("@cliente", clienteORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@cliente", factura.cliente);

//                if (Convert.ToString(factura.domicilio) == string.Empty || factura.domicilio.ToString() == null)
//                    cmd1.Parameters.AddWithValue("@domicilio", domicilioORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@domicilio", factura.domicilio);

//                if (Convert.ToString(factura.observaciones) == string.Empty || factura.observaciones.ToString() == null)
//                    cmd1.Parameters.AddWithValue("@observaciones", observacionesORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@observaciones", factura.observaciones);

//                if (Convert.ToString(factura.total) == string.Empty || factura.total.ToString() == null)
//                    cmd1.Parameters.AddWithValue("@total", totalORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@total", factura.total);

//                if (Convert.ToString(factura.estado) == string.Empty || factura.estado.ToString() == null)
//                    cmd1.Parameters.AddWithValue("@estado", estadoORIG);
//                else
//                    cmd1.Parameters.AddWithValue("@estado", factura.estado);

//                cmd1.ExecuteNonQuery();

//                //MessageBox.Show("Guardado!");
//                MySQL.DisconnectDB();

//                return factura;
//            }

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

        }
}