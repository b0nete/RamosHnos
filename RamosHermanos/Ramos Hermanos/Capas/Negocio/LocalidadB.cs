using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;


namespace RamosHermanos.Capas.Negocio
{
    class LocalidadB
    {
        public static LocalidadEntity InsertLocalidad(LocalidadEntity localidad)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Localidades (idProvincia, localidad, estado)
                                 VALUES (@idProvincia, @localidad, @estado);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("idProvincia", localidad.provincia);
                cmd.Parameters.AddWithValue("localidad", localidad.localidad);
                cmd.Parameters.AddWithValue("estado", localidad.estado);

                localidad.idLocalidad = Convert.ToInt32(cmd.ExecuteScalar());

                MySQL.DisconnectDB();
                return localidad;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarCB(ComboBox cb, LocalidadEntity localidad)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = "SELECT * FROM Localidades WHERE idProvincia = @idProvincia";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("idProvincia", localidad.provincia);

                  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                  da.Fill(dt);

                  cb.DisplayMember = "localidad";
                  cb.ValueMember = "idlocalidad";
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

                string query = @"SELECT * FROM Localidades";

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
