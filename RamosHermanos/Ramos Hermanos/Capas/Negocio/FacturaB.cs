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

namespace RamosHermanos.Capas.Negocio
{
    class FacturaB
    {
        public static FacturaEntity UpdateFactura(FacturaEntity factura)
        {
            try
            {
                MySQL.ConnectDB();

                //Buscamos valores originales, para que en el caso de no tener algún valor para actualizar se actualize con los valores originales para no obtener 0 o NULL.

                string query = "SELECT * FROM Facturas WHERE idFactura = @idFactura";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idFactura", factura.idFactura);

                int idFacturaORIG = 0;
                string tipoFactura;
                int numFactura = 0;
                DateTime fechaFactura;
                DateTime fechaVencimiento;
                DateTime fechaEntrega;
                string formaPago;
                int cliente = 0;
                int domicilio = 0;
                string observaciones;
                double total;
                string estado;

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    idFacturaORIG = Convert.ToInt32(row["idFactura"]);
                    tipoFactura = Convert.ToString(row["tipoFactura"]);
                    numFactura = Convert.ToInt32(row["numfactura"]);
                    fechaFactura = Convert.ToDateTime(row["fechaFactura"]);
                    fechaVencimiento = Convert.ToDateTime(row["fechaVencimiento"]);
                    fechaEntrega = Convert.ToDateTime(row["fechaEntrega"]);
                    formaPago = Convert.ToString(row["formaPago"]);
                    cliente = Convert.ToInt32(row["cliente"]);
                    domicilio = Convert.ToInt32(row["domicilio"]);
                    observaciones = Convert.ToString(row["observaciones"]);
                    total = Convert.ToDouble(row["total"]);
                    estado = Convert.ToString(row["estado"]);
                }

                // ----------------------------------------------------------//

                //Hacemos el update, si hay valores nuevos se actualiza, de lo contrario se vuelven a cargar los valores originales.

                string query1 = @"UPDATE Facturas 
                                 SET tipoFactura = @tipoFactura, numFactura = @numFactura, fechaFactura = @fechaFactura, fechaVencimiento = @fechaVencimiento, fechaEntrega = @fechaEntrega, formaPago = @formaPago, cliente = @cliente, domicilio = @domicilio, observaciones = @observaciones, total = @total, estado = @estado
                                 WHERE idFactura = @idFactura";

                MySqlCommand cmd1 = new MySqlCommand(query1, MySQL.sqlcnx);

                if (factura.idFactura == 0 || factura.idFactura == null)
                {
                    factura.idFactura = idFacturaORIG;
                }
                else
                {
                    factura.idFactura = factura.idFactura;
                }
                    



                
                cmd1.Parameters.AddWithValue("@tipoFactura", factura.tipoFactura);
                cmd1.Parameters.AddWithValue("@numFactura", factura.numFactura);
                cmd1.Parameters.AddWithValue("@fechaFactura", factura.fechaFactura);
                cmd1.Parameters.AddWithValue("@fechaVencimiento", factura.fechaVencimiento);
                cmd1.Parameters.AddWithValue("@fechaEntrega", factura.fechaEntrega);
                cmd1.Parameters.AddWithValue("@formaPago", factura.formaPago);
                cmd1.Parameters.AddWithValue("@cliente", factura.cliente);
                cmd1.Parameters.AddWithValue("@domicilio", factura.domicilio);
                cmd1.Parameters.AddWithValue("@observaciones", factura.observaciones);
                cmd1.Parameters.AddWithValue("@total", factura.total);
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

                string query = @"SELECT P.idFactura, P.cliente, P.domicilio, P.fechaFactura, P.fechaEntrega, p.Observaciones, P.estado, P.total,
                               C.Nombre, C.Apellido, D.idDomicilio, D.calle, D.numero
                               FROM Facturas P
                               INNER JOIN clientes C on C.idCliente = P.cliente
                               INNER JOIN domicilios D on D.idDomicilio = P.domicilio
                               WHERE P.idFactura = @idFactura";

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
                    factura.cliente = Convert.ToInt32(row["cliente"]);
                    factura.domicilio = Convert.ToInt32(row["domicilio"]);
                    factura.fechaFactura = Convert.ToDateTime(row["FechaFactura"]);
                    factura.fechaEntrega = Convert.ToDateTime(row["FechaEntrega"]);
                    factura.observaciones = Convert.ToString(row["observaciones"]);
                    factura.total = Convert.ToDouble(row["total"]);
                    factura.nombreCompleto = Convert.ToString(row["Nombre"]) + ' ' + Convert.ToString(row["Apellido"]);
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
                                 WHERE estado = 'Pagado' and cliente = @cliente";

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
                                 WHERE estado = 'Pendiente' and cliente = @cliente";

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
                                 WHERE estado = 'Anulado' and cliente = @cliente";

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

        public static void ListFacturas(DataGridView dgvList)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT idFactura as colFactura, fechaFactura as colFecha, CONCAT(C.nombre, '' ,C.apellido) as colNombre, total as colTotal, F.estado as colEstado
                                FROM Facturas F
                                INNER JOIN Clientes C ON C.idCliente = F.cliente";

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

        
    }
}
