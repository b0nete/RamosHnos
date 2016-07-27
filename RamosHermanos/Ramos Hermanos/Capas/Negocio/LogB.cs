using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Datos;


namespace RamosHermanos.Capas.Negocio
{
    class LogB
    {
        public static void InsertLog(logEntity log)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Logs (usuario, accion, detalle, hora)
                                 VALUES (@usuario, @accion, @detalle, @hora);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@usuario", log.usuario);
                cmd.Parameters.AddWithValue("@accion", log.accion);
                cmd.Parameters.AddWithValue("@detalle", log.detalle);
                cmd.Parameters.AddWithValue("@hora", System.DateTime.Now);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarDGV(DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT *, CONCAT(U.apellido, ' ', U.nombre) as nombreC
                                 FROM ramosdb.logs L
                                 INNER JOIN Usuarios U ON U.idusuario = L.usuario";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgv.DataSource = dt;

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
