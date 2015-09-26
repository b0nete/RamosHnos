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
    class CalleB
    {
        public static bool ExisteCalle(TextBox txt)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Calles
                             WHERE calle = @calle";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@calle", txt.Text);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;

        }

        public static CalleEntity UpdateCalle(CalleEntity calle)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Calles
                                 SET idBarrio = @idBarrio, calle = @calle, estado = @estado
                                 WHERE idCalle = @idCalle";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCalle", calle.idCalle);
                cmd.Parameters.AddWithValue("@idBarrio", calle.idBarrio);
                cmd.Parameters.AddWithValue("@calle", calle.calle);
                cmd.Parameters.AddWithValue("@estado", calle.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Calle Actualizada!");
                return calle;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static CalleEntity InsertCalle(CalleEntity calle)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Calles (idCalle, idBarrio, calle, estado)
                                 VALUES (@idCalle, @idBarrio, @calle, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCalle", calle.idCalle);
                cmd.Parameters.AddWithValue("@idBarrio", calle.idBarrio);
                cmd.Parameters.AddWithValue("@calle", calle.calle);
                cmd.Parameters.AddWithValue("@estado", calle.estado);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();

                return calle;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static CalleEntity BuscarCalleID(CalleEntity calle)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT C.idCalle, C.Calle, B.Barrio, L.Localidad, P.Provincia
                                 FROM Calles C
                                 INNER JOIN Barrios B ON C.idBarrio = B.idBarrio
                                 INNER JOIN Localidades L ON B.idLocalidad = L.idLocalidad
                                 INNER JOIN Provincias P ON L.idProvincia = P.idProvincia
                                 WHERE C.idCalle = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCalle", calle.idCalle);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("La calle no existe!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    calle.idBarrio = Convert.ToInt32(row["idBarrio"]);
                    calle.calle = Convert.ToString(row["calle"]);
                    calle.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return calle;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarCB(ComboBox cb, ComboBox cb2)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = "SELECT * FROM Calles WHERE idBarrio = @idBarrio";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idBarrio", cb2.SelectedValue);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                cb.DisplayMember = "Calle";
                cb.ValueMember = "idCalle";
                cb.DataSource = dt;

                MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void CargarDGV(BarrioEntity barrio, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT P.idProvincia, P.Provincia, L.idLocalidad, L.Localidad, B.idBarrio, B.Barrio, C.idCalle, C.Calle, C.Estado
                                 FROM Calles C
                                 INNER JOIN Barrios B ON C.idBarrio = B.idBarrio
                                 INNER JOIN Localidades L ON B.idLocalidad = L.idLocalidad
                                 INNER JOIN Provincias P ON L.idProvincia = P.idProvincia
                                 WHERE B.idBarrio = @idBarrio";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idBarrio", barrio.idBarrio);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idProvincia"]),
                    Convert.ToString(dr["provincia"]),
                    Convert.ToString(dr["idLocalidad"]),
                    Convert.ToString(dr["localidad"]),
                    Convert.ToString(dr["idBarrio"]),
                    Convert.ToString(dr["barrio"]),
                    Convert.ToString(dr["idCalle"]),
                    Convert.ToString(dr["calle"]),
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
    }
}
