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
    class RubroB
    {
        public static RubroEntity InsertRubro(RubroEntity rubro, TextBox txtid)
        {
            MySQL.ConnectDB();

            string query=@"Insert into rubros (rubro,estado)
                                 VALUES (@rubro,@estado); 
                                 Select last_insert_id();";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

            cmd.Parameters.AddWithValue("@rubro",rubro.rubro);
            cmd.Parameters.AddWithValue("@estado", rubro.estado);

            txtid.Text = Convert.ToString(cmd.ExecuteScalar());



            MessageBox.Show("Guardado");

            return rubro;

             
        }

        public static bool ExisteRubro(RubroEntity rubro)
        {

            MySQL.ConnectDB();

            string query = @"Select COUNT(*) from rubros
                            where rubro = @rubro";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@rubro", rubro.rubro);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)

                return false;

            else

                return true;


        }

        public static RubroEntity UpdateRubro(RubroEntity rubro)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE rubro
                               SET rubro = @rubro , estado = @estado
                               WHERE rubro = @rubro";
                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rubro", rubro.rubro);
                cmd.Parameters.AddWithValue("@estado", rubro.estado);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Rubro Actualizado");

                return rubro;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR  " + ex);
                throw;
            }
        }
        public static void CargarDGV (DataGridView DGV)
        {
            MySQL.ConnectDB();

            string query = @"Select * from rubros";
            
            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                DGV.Rows.Add(
                Convert.ToString(DR["idrubro"]),
                Convert.ToString(DR["rubro"]),
                Convert.ToString(DR["estado"]));
            }
              DR.Close();
 
        }
        public static void CargarRubro(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = "SELECT * FROM rubros";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                  da.Fill(dt);

                  cb.DataSource = dt;
                  cb.DisplayMember = "rubro";
                  cb.ValueMember = "idrubro";


                  MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }


    }
}
