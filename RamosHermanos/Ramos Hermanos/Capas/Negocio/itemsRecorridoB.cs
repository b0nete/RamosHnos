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

        
        public static itemRecorridoEntity BuscarItemRecorrido(itemRecorridoEntity itemRecorrido, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT  IR.idcallesRecorrido, IR.recorrido, IR.calle IDcalle, C.calle, IR.desde, IR.hasta, IR.estado
                                 FROM itemsRecorrido IR
                                 INNER JOIN Calles C ON IR.calle = C.idCalle
                                 WHERE recorrido = @recorrido";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@recorrido", itemRecorrido.recorrido);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["IDcalle"]),
                    Convert.ToString(dr["calle"]),
                    Convert.ToString(dr["desde"]),
                    Convert.ToString(dr["hasta"]),
                    Convert.ToString(dr["estado"]));
                }

                dr.Close();

                MySQL.DisconnectDB();

                return itemRecorrido;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void DeleteItemRecorrido(itemRecorridoEntity itemRecorrido)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"DELETE FROM itemsRecorrido
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
