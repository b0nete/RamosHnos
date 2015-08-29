﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;

namespace RamosHermanos.Capas.Negocio
{
    class MedidaB
    {
        public static void CargarCB(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = "SELECT * FROM Medidas";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                  da.Fill(dt);

                  cb.DisplayMember = "medida";
                  cb.ValueMember = "idMedida";
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
