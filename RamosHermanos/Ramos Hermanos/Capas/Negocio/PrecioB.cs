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

        public static PrecioEntity UpdatePrecio(PrecioEntity precio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Precios
                                 SET precio = @precio, fechaActualizacion = @fechaActualizacion
                                 WHERE producto = @producto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@producto", precio.producto);
                cmd.Parameters.AddWithValue("@precio", precio.precio);
                cmd.Parameters.AddWithValue("@fechaActualizacion", precio.fechaActualizacion);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Precio Actualizado!");
                return precio;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static PrecioEntity BuscarPrecio(PrecioEntity precio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM precioProductos WHERE producto = @producto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@producto", precio.producto);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("No hay precio!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    precio.precio = Convert.ToDouble(row["precio"]);

                    MySQL.DisconnectDB();
                }
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
