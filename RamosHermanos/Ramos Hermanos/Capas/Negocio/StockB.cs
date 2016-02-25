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


                string query = @"INSERT INTO Stock (productoInsumo, idProductoInsumo, stockMinimo, stockMaximo, stockActual) 
                                 VALUES (@productoInsumo, @idProductoInsumo, @stockMinimo, @stockMaximo, 0)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@productoInsumo", stock.productoInsumo);
                cmd.Parameters.AddWithValue("@idproductoInsumo", stock.idProductoInsumo);
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
    }
}
