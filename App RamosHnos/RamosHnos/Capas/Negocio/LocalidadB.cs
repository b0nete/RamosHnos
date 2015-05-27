using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Datos;
using RamosHnos.Capas.Entidades;


namespace RamosHnos.Capas.Negocio
{
    class LocalidadB
    {
        public static LocalidadEntity InsertLocalidad(LocalidadEntity localidad)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO Localidades (idProvincia, localidad, estado)
                                 VALUES (@idProvincia, @localidad, @estado);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("idProvincia", localidad.provincia);
                cmd.Parameters.AddWithValue("localidad", localidad.localidad);
                cmd.Parameters.AddWithValue("estado", localidad.estado);

                localidad.idLocalidad = Convert.ToInt32(cmd.ExecuteScalar());

                MySQLDAL.DcnxDB();
                return localidad;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarLocalidad(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();

                string query = "SELECT * FROM Localidades";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                  da.Fill(dt);

                  cb.DisplayMember = "localidad";
                  cb.ValueMember = "idlocalidad";
                  cb.DataSource = dt;

                  MySQLDAL.DcnxDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

            public static void LlenarDGV(DataGridView dgv)
        {
            try
            {
                MySQLDAL.CnxDB();
                DataTable dt = new DataTable();

                string query = @"SELECT * FROM Localidades";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgv.DataSource = dt;

                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
        
    }
}
