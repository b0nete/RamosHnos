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
                DataTable dt = new DataTable();

                string query = @"SELECT B.Barrio, C.Calle, C.Estado
                                 FROM Calles C
                                 INNER JOIN Barrios B ON C.idBarrio = B.idBarrio
                                 WHERE B.idBarrio = @idBarrio";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idBarrio", barrio.idBarrio);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

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
