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
    class itemsRecorridoB
    {
        public static itemRecorridoEntity InsertItemRecorrido(itemRecorridoEntity itemRecorrido, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                DeleteItemRecorrido(itemRecorrido);

                string query = @"INSERT INTO itemsRecorrido (recorrido, calle, desde, hasta, estado) 
                                 VALUES (@recorrido, @calle, @desde, @hasta, @estado)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@recorrido", itemRecorrido.recorrido);
                cmd.Parameters.AddWithValue("@calle", itemRecorrido.calle);
                cmd.Parameters.AddWithValue("@desde", itemRecorrido.desde);
                cmd.Parameters.AddWithValue("@hasta", itemRecorrido.hasta);
                cmd.Parameters.AddWithValue("@estado", itemRecorrido.estado);

                cmd.ExecuteNonQuery();             

                MySQL.DisconnectDB();

                return itemRecorrido;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        //public static itemRecorridoEntity BuscarItemRecorrido(itemRecorridoEntity itemRecorrido)
        //{
        //    try
        //    {
        //        MySQL.ConnectDB();

        //        string query = "SELECT * FROM itemsRecorrido WHERE recorrido = @recorrido";

        //        MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

        //        cmd.Parameters.AddWithValue("@recorrido", itemRecorrido.recorrido);

        //        int resultado = Convert.ToInt32(cmd.ExecuteScalar());
        //        if (resultado != 0)
        //        {
        //            DataTable dt = new DataTable();
        //            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

        //            da.Fill(dt);

        //            DataRow row = dt.Rows[0];

        //            recorrido.idRecorrido = Convert.ToInt32(row["idRecorrido"]);
        //            recorrido.distribuidor = Convert.ToInt32(row["distribuidor"]);
        //            recorrido.dia = Convert.ToString(row["dia"]);

        //            txtIDrecorrido.Text = Convert.ToString(recorrido.idRecorrido);

        //            MySQL.DisconnectDB();
        //        }

        //        return recorrido;
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex);
        //        throw;
        //    }

        public static void DeleteItemRecorrido(itemRecorridoEntity itemRecorrido)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"DELETE *
                                 FROM itemsRecorrido
                                 WHERE recorrido = @recorrido";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@recorrido", itemRecorrido.recorrido);

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

    }
}
