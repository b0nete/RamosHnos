using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;

namespace RamosHermanos.Capas.Negocio
{
    class StockProductoB
    {
        public static bool ExisteStock(StockProductoEntity stockP)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM stockProducto
                             WHERE idProducto = @idProducto";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idProducto", stockP.idProducto);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static StockProductoEntity BuscarStock(StockProductoEntity stockP)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM stockProducto WHERE idProducto = @idProducto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", stockP.idProducto);

                int resultado = cmd.ExecuteNonQuery();

                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    stockP.stockMinimo = Convert.ToInt32(row["stockMinimo"]);
                    stockP.stockMaximo = Convert.ToInt32(row["stockMaximo"]);
                    stockP.stockActual = Convert.ToInt32(row["stockActual"]);
                    stockP.fechaActualizacion = Convert.ToDateTime(row["fechaActualizacion"]);

                    MySQL.DisconnectDB();
                }

                return stockP;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void InsertStock(StockProductoEntity stock)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO stockproducto (idProducto, stockMinimo, stockMaximo, stockActual,fechaActualizacion) 
                                 VALUES (@idProducto, @stockMinimo, @stockMaximo, 0,@fechaActualizacion)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idproducto", stock.idProducto);
                cmd.Parameters.AddWithValue("@stockMinimo", stock.stockMinimo);
                cmd.Parameters.AddWithValue("@stockMaximo", stock.stockMaximo);
                cmd.Parameters.AddWithValue("@fechaActualizacion", stock.fechaActualizacion);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Stock Guardado!");
                MySQL.DisconnectDB();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void cargardgvStock(DataGridView dgv, TextBox idProducto)
        {
            try
            {
                MySQL.ConnectDB();
                string query = @"SELECT P.idStock,PRO.producto,PRO.idProducto,P.stockMinimo,P.stockMaximo,P.stockActual,P.fechaActualizacion
                            FROM stockProducto P
                            INNER JOIN productos PRO on PRO.idProducto = P.idProducto
                            WHERE P.idProducto=@idProducto
                            ORDER BY fechaActualizacion DESC";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", idProducto.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idProducto"]),
                    Convert.ToString(dr["producto"]),
                    Convert.ToString(dr["stockMinimo"]),
                    Convert.ToString(dr["stockMaximo"]),
                    Convert.ToString(dr["stockActual"]),
                    Convert.ToString(dr["fechaActualizacion"]));

                }

                dr.Close();
                MySQL.ConnectDB();
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "ERROR");
                throw;
            }
        }
    }
}
