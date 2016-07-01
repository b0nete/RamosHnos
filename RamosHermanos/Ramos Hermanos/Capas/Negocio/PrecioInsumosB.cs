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
    class PrecioInsumosB
    {
        public static void DisablePrecio(int idInsumo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE precioInsumos
                                 SET estado = 0
                                 WHERE idInsumo = @idInsumo";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", idInsumo);
                
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static PrecioInsumoEntity InsertPrecio(PrecioInsumoEntity precio)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO precioInsumos (idInsumo, fechaActualizacion, precio, estado) 
                                 VALUES (@idInsumo, NOW(), @precio, 1)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", precio.insumo);
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

        public static PrecioInsumoEntity UpdatePrecio(PrecioInsumoEntity precio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Precios
                                 SET precio = @precio, fechaActualizacion = @fechaActualizacion
                                 WHERE Insumo = @Insumo";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@Insumo", precio.insumo);
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

        public static DataRow UltimoPrecio(int Insumo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT idPrecioInsumo, precio
                                 FROM precioInsumos
                                 WHERE idInsumo = @idInsumo
                                 ORDER BY fechaActualizacion DESC LIMIT 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", Insumo);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                DataRow row = dt.Rows[0];

                return row;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static PrecioInsumoEntity BuscarPrecio(PrecioInsumoEntity precio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM precioInsumos WHERE Insumo = @Insumo and estado = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@Insumo", precio.insumo);

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

        public static void UltimoPrecioDGV(DataGridView dgv, TextBox idInsumo)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT precio, fechaActualizacion
                                    FROM precioInsumos
                                    WHERE idInsumo = @idInsumo
                                    ORDER BY fechaActualizacion DESC";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("idInsumo", idInsumo.Text);

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
