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
    class tipoProductoB
    {

        public static void CargarCB(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = "SELECT * FROM tipoProducto";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                  da.Fill(dt);

                  cb.DisplayMember = "tipoProducto";
                  cb.ValueMember = "idtipoProducto";
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
