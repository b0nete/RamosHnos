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
    class PrecioB
    {
        public static PrecioEntity InsertPrecio(PrecioEntity precio)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO precioProductos (producto, fechaActualizacion, precio) 
                                 VALUES (@producto, @fechaActualizacion, @precio)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@producto", precio.producto);
                cmd.Parameters.AddWithValue("@fechaActualizacion", precio.fechaActualizacion);
                cmd.Parameters.AddWithValue("@precio", precio.precio);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();

                return precio;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
