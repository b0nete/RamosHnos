using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;

namespace RamosHermanos.Capas.Negocio
{
    class StockB
    {
        public static void InsertStock(StockEntity stock)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO stockproducto (producto, idProducto, stockMinimo, stockMaximo, stockActual) 
                                 VALUES (@producto, @idProducto, @stockMinimo, @stockMaximo, 0)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@producto", stock.productoInsumo);
                cmd.Parameters.AddWithValue("@idproducto", stock.idProductoInsumo);
                cmd.Parameters.AddWithValue("@stockMinimo", stock.stockMinimo);
                cmd.Parameters.AddWithValue("@stockMaximo", stock.stockMaximo);

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
        public static void cargardgvStock(DataGridView dgv, TextBox idStock)
        {
            try
            {
                MySQL.ConnectDB();
                string query = @"SELECT P.idStock,PRO.producto,PRO.idProducto,P.stockMinimo,P.stockMaximo,P.stockActual
                            FROM stockProducto P
                            INNER JOIN productos PRO on PRO.idProducto = P.idProducto
                            where P.idStock=@idStock";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idStock", idStock.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idProducto"]),
                    Convert.ToString(dr["producto"]),
                    Convert.ToString(dr["stockMinimo"]),
                    Convert.ToString(dr["stockMaximo"]),
                    Convert.ToString(dr["stockActual"]));

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
