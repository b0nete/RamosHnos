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
    class TelefonoB
    {
        public static bool ExisteTelefono(TelefonoEntity telefono)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*)
                             FROM Telefonos
                             WHERE rol = @rol and idPersona = @idPersona and caracteristica = @caracteristica and numTel = @numTel";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@rol", telefono.rol);
            cmd.Parameters.AddWithValue("@idPersona", telefono.idPersona);
            cmd.Parameters.AddWithValue("@caracteristica", telefono.caracteristica);
            cmd.Parameters.AddWithValue("@numTel", telefono.numTel);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static TelefonoEntity UpdateTelefono(TelefonoEntity telefono)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Telefonos
                                 SET tipoTel = @tipoTel, caracteristica = @caracteristica, numTel = @numTel, estado = @estado
                                 WHERE idTelefono = @idTelefono";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idTelefono", telefono.idTelefono);
                cmd.Parameters.AddWithValue("@tipoTel", telefono.tipoTel);
                cmd.Parameters.AddWithValue("@caracteristica", telefono.caracteristica);
                cmd.Parameters.AddWithValue("@numTel", telefono.numTel);
                cmd.Parameters.AddWithValue("@estado", telefono.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Telefono Actualizado!");
                return telefono;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static TelefonoEntity InsertTelefono(TelefonoEntity telefono)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Telefonos (rol, idPersona, tipoTel, caracteristica, numtel, estado)
                                 VALUES (@rol, @idPersona, @tipoTel, @caracteristica, @numTel, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", telefono.rol);
                cmd.Parameters.AddWithValue("@idPersona", telefono.idPersona);
                cmd.Parameters.AddWithValue("@tipoTel", telefono.tipoTel);
                cmd.Parameters.AddWithValue("@caracteristica", telefono.caracteristica);
                cmd.Parameters.AddWithValue("@numTel", telefono.numTel);
                cmd.Parameters.AddWithValue("@estado", telefono.estado);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();

                return telefono;
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
                dgv.Rows.Clear();

                string query = @"SELECT T.idTelefono, TT.idTipoTel, TT.tipoTel, T.caracteristica, T.numTel, T.estado
                                 FROM Telefonos T
                                 INNER JOIN TipoTelefono TT ON T.TipoTel = TT.idTipoTel 
                                 WHERE rol = @rol and idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", cbROL.SelectedValue);
                cmd.Parameters.AddWithValue("@idPersona", txtID.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idTelefono"]),
                    Convert.ToString(dr["idTipoTel"]),
                    Convert.ToString(dr["tipoTel"]),
                    Convert.ToString(dr["caracteristica"]),
                    Convert.ToString(dr["numTel"]),
                    Convert.ToString(dr["caracteristica"]) +"-"+ Convert.ToString(dr["numTel"]),
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

                string query = "SELECT group_concat(' ', caracteristica,'-', numTel) FROM Telefonos T WHERE rol = @rol and idPersona = @idPersona";

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

        public static string CargarTXTString(TextBox txtID, int rol)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT group_concat(' ', caracteristica,'-', numTel) FROM Telefonos T WHERE rol = @rol and idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@idPersona", txtID.Text);

                string retornado = Convert.ToString(cmd.ExecuteScalar());

                MySQL.DisconnectDB();

                return retornado;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarCB(ComboBox cb, TextBox txt, int rol)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT idTelefono, CONCAT(caracteristica, '-', numTel) as telCompleto
                                FROM Telefonos
                                WHERE rol = @rol and idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@idPersona", txt.Text);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                cb.DataSource = dt;
                cb.ValueMember = "idTelefono";
                cb.DisplayMember = "telCompleto";


                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static int CantidadTelefonos(int rol, int idPersona)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT COUNT(T.idTelefono)
                                FROM Telefonos T
                                WHERE T.rol = @rol and T.idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@idPersona", idPersona);

                int cantTelefonos = Convert.ToInt32(cmd.ExecuteScalar());

                return cantTelefonos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
