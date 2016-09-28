using System;
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
    class PagoB
    {
        public static void InsertPago(PagoEntity pago)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO Pagos (cliente, monto, fechaPago) 
                                 VALUES (@cliente, @monto, @fechaPago);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@cliente", pago.cliente);
                cmd.Parameters.AddWithValue("@monto", pago.monto);
                cmd.Parameters.AddWithValue("@fechaPago", pago.fechaPago);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Pago Guardado!");
                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void UpdateDGV(int cliente, DataGridView dgvPagos)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Pagos";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvPagos.AutoGenerateColumns = false;
                dgvPagos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string totalPagado(int cliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT SUM(monto)
                                 FROM pagos
                                 WHERE cliente = @cliente";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@cliente", cliente);

                string retornar = Convert.ToString(cmd.ExecuteScalar());

                return retornar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
