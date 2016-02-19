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
    class BarrioB
    {
        public static bool ExisteBarrio(TextBox txt)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Barrios
                             WHERE barrio = @barrio";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@barrio", txt.Text);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static BarrioEntity UpdateBarrio(BarrioEntity barrio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Barrios
                                 SET idLocalidad = @idLocalidad, barrio = @barrio, estado = @estado
                                 WHERE idBarrio = @idBarrio";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idBarrio", barrio.idBarrio);
                cmd.Parameters.AddWithValue("@idLocalidad", barrio.idLocalidad);
                cmd.Parameters.AddWithValue("@barrio", barrio.barrio);
                cmd.Parameters.AddWithValue("@estado", barrio.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Barrio Actualizado!");
                return barrio;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static BarrioEntity InsertBarrio(BarrioEntity barrio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Barrios (idBarrio, idLocalidad, barrio, estado)
                                 VALUES (@idBarrio, @idLocalidad, @barrio, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idBarrio", barrio.idBarrio);
                cmd.Parameters.AddWithValue("@idLocalidad", barrio.idLocalidad);
                cmd.Parameters.AddWithValue("@barrio", barrio.barrio);
                cmd.Parameters.AddWithValue("@estado", barrio.estado);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();

                return barrio;
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

                string query = "SELECT * FROM Barrios WHERE idLocalidad = @idLocalidad";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idLocalidad", cb2.SelectedValue);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                cb.DisplayMember = "Barrio";
                cb.ValueMember = "idBarrio";
                cb.DataSource = dt;

                MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void CargarDGV(DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();
                DataTable dt = new DataTable();

                string query = @"SELECT L.Localidad, B.Barrio, B.Estado
                                 FROM Barrios B
                                 INNER JOIN Localidades L ON B.idLocalidad = L.idLocalidad";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

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
