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
    class itemsRepartoB
    {
        public static itemsRepartoEntity InsertItemReparto(itemsRepartoEntity itemReparto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO itemsReparto (reparto, cliente, domicilio, idComprobante) 
                                 VALUES (@reparto, @cliente, @domicilio, @idComprobante);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@reparto", itemReparto.reparto);
                cmd.Parameters.AddWithValue("@cliente", itemReparto.cliente);
                cmd.Parameters.AddWithValue("@domicilio", itemReparto.domicilio);
                cmd.Parameters.AddWithValue("@idComprobante", itemReparto.idComprobante);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return itemReparto;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static int UltimoComprobante()
        {
            try
            {
                int idComprobante;

                MySQL.ConnectDB();

                string query = @"SELECT MAX(idComprobante) + 1 as idComprobante
                                 FROM itemsReparto;";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                idComprobante = Convert.ToInt32(cmd.ExecuteScalar());

                //idComprobante = idComprobante == DBNull.Value ? 0 : idComprobante;

                MySQL.DisconnectDB();

                return idComprobante;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
