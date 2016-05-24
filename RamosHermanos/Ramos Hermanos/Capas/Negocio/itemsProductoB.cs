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
    class itemsProductoB
    {
        public static void InsertItemProducto(itemsProductoEntity itemProducto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO itemsProducto (idInsumo, medida, cantidad)
                                    VALUES (@idInsumo, @medida, @cantidad)
                                    SELECT LAST_INSERT_ID;";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", itemProducto.idInsumo);
                cmd.Parameters.AddWithValue("@medida", itemProducto.medida);
                cmd.Parameters.AddWithValue("@cantidad", itemProducto.cantidad);

                MySQL.DisconnectDB();
            }


            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }
    }
}
