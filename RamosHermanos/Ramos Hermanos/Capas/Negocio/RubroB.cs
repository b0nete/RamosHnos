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

        public static void CargarDGVRubro (DataGridView DGV)
        {
            DGV.Rows.Clear();
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

        public static void CargarDGVproveedor(DataGridView DGV)
        {
            DGV.Rows.Clear();
            MySQL.ConnectDB();

            string query = @"Select * from rubros";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            MySqlDataReader DR = cmd.ExecuteReader();

            while (DR.Read())
            {
                DGV.Rows.Add(
                Convert.ToString(DR["idrubro"]),
                Convert.ToString(DR["rubro"]));
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

        public static void CargarSubRubro1(ComboBox cbRubro, Label lblSubRubro1, Label lblSubRubro2, ComboBox cbSubRubro1, ComboBox cbSubRubro2)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = @"SELECT *
                                 FROM SubRubro1Productos
                                 WHERE rubro = @rubro";  
                
                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                  cmd.Parameters.AddWithValue("@rubro", cbRubro.SelectedValue);

                  int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                  if (resultado == 0)
                  {
                      lblSubRubro1.Visible = false;
                      cbSubRubro1.Visible = false;

                      lblSubRubro2.Visible = false;
                      cbSubRubro2.Visible = false;
                  }
                  else
                  {
                      MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                      da.Fill(dt);

                      lblSubRubro1.Visible = true;
                      cbSubRubro1.Visible = true;

                      cbSubRubro1.DataSource = dt;
                      cbSubRubro1.DisplayMember = "SubRubro1";
                      cbSubRubro1.ValueMember = "idSubRubro1";
                  }

                  MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        public static void CargarSubRubro2(ComboBox cbSubRubro1, Label lblSubRubro2, ComboBox cbSubRubro2)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = @"SELECT *
                                 FROM SubRubro2Productos
                                 WHERE rubro = @rubro";  
                
                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                  cmd.Parameters.AddWithValue("@rubro", cbSubRubro1.SelectedValue);

                  int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                  if (resultado == 0)
                  {
                      lblSubRubro2.Visible = false;
                      cbSubRubro2.Visible = false;
                  }
                  else
                  {
                      MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                      da.Fill(dt);

                      lblSubRubro2.Visible = true;
                      cbSubRubro2.Visible = true;

                      cbSubRubro2.DataSource = dt;
                      cbSubRubro2.DisplayMember = "SubRubro2";
                      cbSubRubro2.ValueMember = "idSubRubro2";
                  }

                  MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        


    }
}
