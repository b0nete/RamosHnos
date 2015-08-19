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
    class EmailB
    {
        public static EmailEntity InsertEmail(EmailEntity email)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Emails (rol, idPersona, email, estado)
                                 VALUES (@rol, @idPersona, @email, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", email.rol);
                cmd.Parameters.AddWithValue("@idPersona", email.idPersona);
                cmd.Parameters.AddWithValue("@email", email.email);
                cmd.Parameters.AddWithValue("@estado", email.estado);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();

                return email;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarDGV(DataGridView dgv, ComboBox cbROL, TextBox txtID)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Emails WHERE rol = @rol and idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", cbROL.SelectedValue);
                cmd.Parameters.AddWithValue("@idPersona", txtID.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idEmail"]),
                    Convert.ToString(dr["email"]),
                    Convert.ToBoolean(dr["estado"]));
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

        public static void CargarTXT(TextBox txt, TextBox txt2, int rol)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT group_concat(' ',email) as email FROM Emails WHERE rol = @rol and idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@idPersona", txt2.Text);

                txt.Text = Convert.ToString(cmd.ExecuteScalar());
                
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
