using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Datos;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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


    }
}
