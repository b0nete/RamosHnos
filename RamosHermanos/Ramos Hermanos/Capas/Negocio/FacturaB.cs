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
using RamosHermanos.Capas.Interfaz;

namespace RamosHermanos.Capas.Negocio
{
    class FacturaB
    {
        public static bool ExisteFactura(int idFactura)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Facturas
                             WHERE idFactura = @idFactura";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idFactura", idFactura);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static FacturaEntity UpdateEstadoFactura(FacturaEntity factura)
        {
            try
            {
                MySQL.ConnectDB();

                //Buscamos valores originales, para que en el caso de no tener algún valor para actualizar se actualize con los valores originales para no obtener 0 o NULL.

                string query = "SELECT * FROM Facturas WHERE idFactura = @idFactura";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idFactura", factura.idFactura);

                int idFacturaORIG = 0;
                string tipoFacturaORIG = "";
                int numFacturaORIG = 0;
                DateTime fechaFacturaORIG = Convert.ToDateTime("01/01/1990");
                DateTime fechaVencimientoORIG = Convert.ToDateTime("01/01/1990");
                DateTime fechaEntregaORIG = Convert.ToDateTime("01/01/1990");
                string formaPagoORIG = "";
                int clienteORIG = 0;
                int domicilioORIG = 0;
                string observacionesORIG = "";
                double totalORIG = Convert.ToDouble(0);
                string estadoORIG = "";

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    idFacturaORIG = Convert.ToInt32(row["idFactura"]);
                    tipoFacturaORIG = Convert.ToString(row["tipoFactura"]);
                    numFacturaORIG = Convert.ToInt32(row["numfactura"]);
                    fechaFacturaORIG = Convert.ToDateTime(row["fechaFactura"]);
                    fechaVencimientoORIG = Convert.ToDateTime(row["fechaVencimiento"]);
                    fechaEntregaORIG = Convert.ToDateTime(row["fechaEntrega"]);
                    formaPagoORIG = Convert.ToString(row["formaPago"]);
                    clienteORIG = Convert.ToInt32(row["cliente"]);
                    domicilioORIG = Convert.ToInt32(row["domicilio"]);
                    observacionesORIG = Convert.ToString(row["observaciones"]);
                    totalORIG = Convert.ToDouble(row["total"]);
                    estadoORIG = Convert.ToString(row["estado"]);
                }

                // ----------------------------------------------------------//

                //Hacemos el update, si hay valores nuevos se actualiza, de lo contrario se vuelven a cargar los valores originales.

                string query1 = @"UPDATE Facturas 
                                 SET tipoFactura = @tipoFactura, numFactura = @numFactura, fechaFactura = @fechaFactura, fechaVencimiento = @fechaVencimiento, fechaEntrega = @fechaEntrega, formaPago = @formaPago, cliente = @cliente, domicilio = @domicilio, observaciones = @observaciones, total = @total, estado = @estado
                                 WHERE idFactura = @idFactura";

                MySqlCommand cmd1 = new MySqlCommand(query1, MySQL.sqlcnx);

                if (factura.idFactura == 0 || factura.idFactura.ToString() == string.Empty)
                    cmd1.Parameters.AddWithValue("@idFactura", idFacturaORIG);
                else
                    cmd1.Parameters.AddWithValue("@idFactura", factura.idFactura);

                if (factura.tipoFactura == string.Empty || factura.tipoFactura == null)
                    cmd1.Parameters.AddWithValue("@tipoFactura", tipoFacturaORIG);
                else
                    cmd1.Parameters.AddWithValue("@tipoFactura", factura.tipoFactura);

                if (Convert.ToString(factura.numFactura) == string.Empty || factura.numFactura.ToString() == null)
                    cmd1.Parameters.AddWithValue("@numFactura", numFacturaORIG);
                else
                    cmd1.Parameters.AddWithValue("@numFactura", factura.numFactura);

                if (Convert.ToString(factura.fechaFactura) == string.Empty || factura.idFactura.ToString() == null)
                    cmd1.Parameters.AddWithValue("@fechaFactura", fechaFacturaORIG);
                else
                    cmd1.Parameters.AddWithValue("@fechaFactura", factura.fechaFactura);

                if (Convert.ToString(factura.fechaVencimiento) == string.Empty || factura.idFactura.ToString() == null)
                    cmd1.Parameters.AddWithValue("@fechaVencimiento", fechaVencimientoORIG);
                else
                    cmd1.Parameters.AddWithValue("@fechaVencimiento", factura.fechaVencimiento);

                if (Convert.ToString(factura.fechaEntrega) == string.Empty || factura.fechaEntrega.ToString() == null)
                    cmd1.Parameters.AddWithValue("@fechaEntrega", fechaEntregaORIG);
                else
                    cmd1.Parameters.AddWithValue("@fechaEntrega", factura.fechaEntrega);

                if (Convert.ToString(factura.fechaEntrega) == string.Empty || factura.fechaEntrega.ToString() == null)
                    cmd1.Parameters.AddWithValue("@fechaEntrega", fechaEntregaORIG);
                else
                    cmd1.Parameters.AddWithValue("@formaPago", factura.formaPago);

                if (Convert.ToString(factura.cliente) == string.Empty || factura.cliente.ToString() == null)
                    cmd1.Parameters.AddWithValue("@cliente", clienteORIG);
                else
                    cmd1.Parameters.AddWithValue("@cliente", factura.cliente);

                if (Convert.ToString(factura.domicilio) == string.Empty || factura.domicilio.ToString() == null)
                    cmd1.Parameters.AddWithValue("@domicilio", domicilioORIG);
                else
                    cmd1.Parameters.AddWithValue("@domicilio", factura.domicilio);

                if (Convert.ToString(factura.observaciones) == string.Empty || Convert.ToString(factura.observaciones) == null)
                    cmd1.Parameters.AddWithValue("@observaciones", observacionesORIG);
                else
                    cmd1.Parameters.AddWithValue("@observaciones", factura.observaciones);

                if (Convert.ToString(factura.total) == string.Empty || factura.total.ToString() == null)
                    cmd1.Parameters.AddWithValue("@total", totalORIG);
                else
                    cmd1.Parameters.AddWithValue("@total", factura.total);

                if (Convert.ToString(factura.estado) == string.Empty || Convert.ToString(factura.estado) == null)
                    cmd1.Parameters.AddWithValue("@estado", estadoORIG);
                else
                    cmd1.Parameters.AddWithValue("@estado", factura.estado);

                cmd1.ExecuteNonQuery();

                //MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return factura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static FacturaEntity UpdateFactura(FacturaEntity factura)
        {
            try
            {
                MySQL.ConnectDB();

                string query1 = @"UPDATE Facturas 
                                 SET estado = @estado
                                 WHERE idFactura = @idFactura";

                MySqlCommand cmd1 = new MySqlCommand(query1, MySQL.sqlcnx);

                cmd1.Parameters.AddWithValue("@idFactura", factura.idFactura);
                cmd1.Parameters.AddWithValue("@estado", factura.estado);

                cmd1.ExecuteNonQuery();

                //MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return factura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }



        public static FacturaEntity InsertFacturaNEW(FacturaEntity factura, TextBox txtIDFactura)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Facturas (tipoFactura, numFactura, fechaFactura, fechaVencimiento, fechaEntrega, formaPago, cliente, domicilio, observaciones, total, estado) 
                                 VALUES (@tipoFactura, @numFactura, @fechaFactura, @fechaVencimiento, @fechaEntrega, @formaPago, @cliente, @domicilio, @observaciones, @total, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoFactura", factura.tipoFactura);
                cmd.Parameters.AddWithValue("@numFactura", factura.numFactura);
                cmd.Parameters.AddWithValue("@fechaFactura", factura.fechaFactura);
                cmd.Parameters.AddWithValue("@fechaVencimiento", factura.fechaVencimiento);
                cmd.Parameters.AddWithValue("@fechaEntrega", factura.fechaEntrega);
                cmd.Parameters.AddWithValue("@formaPago", factura.formaPago);
                cmd.Parameters.AddWithValue("@cliente", factura.cliente);
                cmd.Parameters.AddWithValue("@domicilio", factura.domicilio);
                cmd.Parameters.AddWithValue("@observaciones", factura.observaciones);
                cmd.Parameters.AddWithValue("@total", factura.total);
                cmd.Parameters.AddWithValue("@estado", factura.estado);

                txtIDFactura.Text = Convert.ToString(cmd.ExecuteScalar());

                //MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return factura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void UpdateTotalFactura(int idFactura, double subTotal)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Facturas 
                                 SET total = total + @subTotal
                                 WHERE idFactura = @idFactura";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idFactura", idFactura);
                cmd.Parameters.AddWithValue("@subTotal", subTotal);

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static FacturaEntity InsertFactura(FacturaEntity factura)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Facturas (tipoFactura, numFactura, fechaFactura, fechaVencimiento, fechaEntrega, formaPago, cliente, domicilio, observaciones, total, estado) 
                                 VALUES (@tipoFactura, @numFactura, @fechaFactura, @fechaVencimiento, @fechaEntrega, @formaPago, @cliente, @domicilio, @observaciones, @total, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoFactura", factura.tipoFactura);
                cmd.Parameters.AddWithValue("@numFactura", factura.numFactura);
                cmd.Parameters.AddWithValue("@fechaFactura", factura.fechaFactura);
                cmd.Parameters.AddWithValue("@fechaVencimiento", factura.fechaVencimiento);
                cmd.Parameters.AddWithValue("@fechaEntrega", factura.fechaEntrega);
                cmd.Parameters.AddWithValue("@formaPago", factura.formaPago);
                cmd.Parameters.AddWithValue("@cliente", factura.cliente);
                cmd.Parameters.AddWithValue("@domicilio", factura.domicilio);
                cmd.Parameters.AddWithValue("@observaciones", factura.observaciones);
                cmd.Parameters.AddWithValue("@total", factura.total);
                cmd.Parameters.AddWithValue("@estado", factura.estado);

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return factura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static int UltimaFactura()
        {
            try
            {
                int idFactura;

                MySQL.ConnectDB();

                string query = @"SELECT ISNULL(MAX(idFactura)) + 1 as idFactura
                                 FROM facturas;";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                                
                idFactura = Convert.ToInt32(cmd.ExecuteScalar());

                if (idFactura == 1)
                    idFactura = 0;

                MySQL.DisconnectDB();

                return idFactura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static FacturaEntity InsertIDFactura(FacturaEntity factura, DataGridView dgv)
        {
            try
            {                
                MySQL.ConnectDB();

                string query = @"INSERT INTO Facturas (tipoFactura, numFactura, fechaFactura, fechaVencimiento, fechaEntrega, formaPago, cliente, observaciones, total, estado) 
                                 VALUES (@tipoFactura, @numFactura, @fechaFactura, @fechaVencimiento, @fechaEntrega, @formaPago, @cliente, @observaciones, @total, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);


                foreach (DataGridView row in dgv.Rows)
                {
                    cmd.Parameters.AddWithValue("@numFactura", factura.numFactura);
                    cmd.Parameters.AddWithValue("@cliente", factura.cliente);

                    cmd.ExecuteNonQuery();
                }

                MySQL.DisconnectDB();

                return factura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static FacturaEntity BuscarFacturaID(FacturaEntity factura)
        {

            try
            {
                MySQL.ConnectDB();

//                string query = @"SELECT P.idFactura, P.cliente, P.domicilio, P.fechaFactura, P.fechaEntrega, p.Observaciones, P.estado, P.total,
//                               C.Nombre, C.Apellido, D.idDomicilio, D.calle, D.numero
//                               FROM Facturas P
//                               INNER JOIN clientes C on C.idCliente = P.cliente
//                               INNER JOIN domicilios D on D.idDomicilio = P.domicilio
//                               WHERE P.idFactura = @idFactura";

                string query = @"SELECT idFactura, tipoFactura, numFactura, fechaFactura, fechaVencimiento, fechaEntrega, formaPago, cliente, CONCAT(C.apellido, ' ', C.apellido) as nombreCompleto, domicilio, observaciones, total, F.estado
                               FROM Facturas F
                               INNER JOIN Clientes C ON F.cliente = C.idCliente
                               WHERE F.idFactura = @idFactura";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idFactura", factura.idFactura);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("La Factura NO existe!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    factura.idFactura = Convert.ToInt32(row["idFactura"]);
                    factura.tipoFactura = row["tipoFactura"].ToString();
                    factura.formaPago = row["formaPago"].ToString();
                    factura.cliente = Convert.ToInt32(row["cliente"]);
                    factura.domicilio = Convert.ToInt32(row["domicilio"]);
                    factura.fechaFactura = Convert.ToDateTime(row["FechaFactura"]);
                    factura.fechaEntrega = Convert.ToDateTime(row["FechaEntrega"]);
                    factura.fechaVencimiento = Convert.ToDateTime(row["fechaVencimiento"]);
                    factura.observaciones = Convert.ToString(row["observaciones"]);
                    factura.total = Convert.ToDouble(row["total"]);
                    factura.nombreCompleto = Convert.ToString(row["nombreCompleto"]);
                    factura.domicilioCompleto = 
                    factura.estado = Convert.ToString(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return factura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static DataTable SearchPagas(ClienteEntity cliente, DataGridView dgvMovimientos)
        {
            try
            {
                MySQL.ConnectDB();
                DataTable dt = new DataTable();

                string query = @"SELECT idFactura, fechaFactura
                                 FROM facturas
                                 WHERE estado = 'Pagado' and cliente = @cliente and total > 0";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                cmd.Parameters.AddWithValue("@cliente", cliente.idCliente);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
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

        public static DataTable SearchPendientes(ClienteEntity cliente, DataGridView dgvMovimientos)
        {
            try
            {
                MySQL.ConnectDB();
                DataTable dt = new DataTable();

                string query = @"SELECT idFactura, fechaFactura
                                 FROM facturas
                                 WHERE estado = 'Pendiente' and cliente = @cliente and total > 0";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                cmd.Parameters.AddWithValue("@cliente", cliente.idCliente);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
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

        public static DataTable SearchAnuladas(ClienteEntity cliente, DataGridView dgvMovimientos)
        {
            try
            {
                MySQL.ConnectDB();
                DataTable dt = new DataTable();

                string query = @"SELECT idFactura, fechaFactura
                                 FROM facturas
                                 WHERE estado = 'Anulado' and cliente = @cliente and total > 0";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                cmd.Parameters.AddWithValue("@cliente", cliente.idCliente);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    //MessageBox.Show("No existen facturas anuladas!");
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

        public static bool EstadoPago(int idFactura)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT estado 
                                FROM facturas
                                WHERE idFactura = @factura";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@factura", idFactura);

                string estado = Convert.ToString(cmd.ExecuteScalar());

                if (estado == "Pagado")                
                    return true;                
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void UpdateFromDGV(string estado, int factura)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Facturas
                                SET estado = @estado
                                WHERE idFactura = @factura";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@factura", factura);

                cmd.ExecuteNonQuery();

                //if (Convert.ToBoolean(dgvReparto.CurrentRow.Cells["colCobro"].Value) == true)
                //{
                //    estadoSTRING = "Pagado";
                //    cmd.Parameters.AddWithValue("@estado", estadoSTRING);
                //}
                //else if (Convert.ToBoolean(dgvReparto.CurrentRow.Cells["colCobro"].Value) == false)
                //{
                //    estadoSTRING = "Pendiente";
                //    cmd.Parameters.AddWithValue("@estado", estadoSTRING);
                //}


                MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void ListFacturas(DataGridView dgvList, string WHERE)
        {
            try
            {
                MySQL.ConnectDB();

                string addQuery = "";

                string query = @"SELECT idFactura as colFactura, fechaFactura as colFecha, CONCAT(C.nombre, ' ' ,C.apellido) as colNombre, total as colTotal, F.estado as colEstado
                                FROM Facturas F
                                INNER JOIN Clientes C ON C.idCliente = F.cliente
                                WHERE total > 0 ";

                DataTable dt = new DataTable();

                if (WHERE == "Pagado")
                {                    
                    addQuery = " and F.estado = 'Pagado'";
                }
                else if (WHERE == "Pendiente")
                {
                    
                    addQuery = " and F.estado = 'Pendiente'";
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

        public static void ListFacturasCliente(DataGridView dgvList, string WHERE, int idCliente)
        {
            try
            {
                MySQL.ConnectDB();

                string addQuery = "";

                string query = @"SELECT idFactura as colFactura, fechaFactura as colFecha, CONCAT(C.nombre, ' ' ,C.apellido) as colNombre, total as colTotal, F.estado as colEstado
                                FROM Facturas F
                                INNER JOIN Clientes C ON C.idCliente = F.cliente
                                WHERE total > 0 and idCliente = @idCliente";

                MySqlCommand cmd = new MySqlCommand();

                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                DataTable dt = new DataTable();

                if (WHERE == "Pagado")
                {
                    addQuery = " and F.estado = 'Pagado'";
                }
                else if (WHERE == "Pendiente")
                {
                    addQuery = " and F.estado = 'Pendiente'";
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

        public static void CargarDGVParametros(DataGridView dgv, ComboBox cb, string parametro)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();
                
                string query = @"SELECT F.idfactura, F.fechaFactura, F.total, C.cliente, F.estado
                                 FROM facturas F
                                 INNER JOIN clientes C on F.cliente = C.idCliente
                                 WHERE";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idfactura", parametro);
                cmd.Parameters.AddWithValue("@idCliente", parametro);
                cmd.Parameters.AddWithValue("@apellido", parametro);
                cmd.Parameters.AddWithValue("@nombre", parametro);
                cmd.Parameters.AddWithValue("@fechaFactura", parametro);
                cmd.Parameters.AddWithValue("@estado", parametro);

                if (cb.SelectedIndex == 0)
                {
                    cmd.CommandText = query + " F.idFactura LIKE @idFactura";

                }
                if (cb.SelectedIndex == 1)
                {
                    cmd.CommandText = query + " F.fecha LIKE @fechaFactura";

                }
                
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idFactura"]),
                    Convert.ToString(dr["fechaFactura"]),
                    Convert.ToString(dr["apellido"]),
                    Convert.ToString(dr["estado"]));
                                              
                }
                dr.Close();
                MySQL.DisconnectDB();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
        
    }
}
