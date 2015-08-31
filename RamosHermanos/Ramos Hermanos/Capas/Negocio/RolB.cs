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
    class RolB
    {
        public static RolEntity InsertRol(RolEntity rol, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO roles (rol, estado)
                                 VALUES (@rol, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", rol.rol);
                cmd.Parameters.AddWithValue("@estado", rol.estado);

                rol.idRol = Convert.ToInt32(cmd.ExecuteScalar());
                //txt.Text = Convert.ToString(cliente.idCliente);

                MySQL.DisconnectDB();

                return rol;
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

                string query = "SELECT * FROM roles";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idRol"]),
                    Convert.ToString(dr["Rol"]),
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

        public static void CargarCB(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = "SELECT * FROM Roles";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                cb.ValueMember = "idRol";
                cb.DisplayMember = "rol";                
                cb.DataSource = dt;

                MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


    }
}
