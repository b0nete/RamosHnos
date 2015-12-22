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
    class PrecioProductosB
    {
        public static void DisablePrecio(int idProducto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE precioProductos
                                 SET estado = 0
                                 WHERE idProducto = @idProducto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", idProducto);
                
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static PrecioProductoEntity InsertPrecio(PrecioProductoEntity precio)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO precioProductos (idProducto, fechaActualizacion, precio, estado) 
                                 VALUES (@idProducto, NOW(), @precio, 1)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", precio.producto);
                //cmd.Parameters.AddWithValue("@fechaActualizacion", precio.fechaActualizacion);
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

        public static PrecioProductoEntity UpdatePrecio(PrecioProductoEntity precio)
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

        public static PrecioProductoEntity BuscarPrecio(PrecioProductoEntity precio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM precioProductos WHERE producto = @producto and estado = 1";

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
                    precio.fechaActualizacion = Convert.ToDateTime(row["fechaActualizacion"]);

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

        public static void UltimoPrecioDGV(DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT precio, fechaActualizacion
                                    FROM precioProductos
                                    WHERE idProducto = 1
                                    ORDER BY fechaActualizacion DESC";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["precio"]),
                    Convert.ToString(dr["fechaActualizacion"]));

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


    }
}
