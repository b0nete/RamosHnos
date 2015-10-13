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

namespace RamosHermanos.Capas.Negocio
{
    class itemsPedidoB
    {
        public static itemPedidoEntity InsertItemPedido(itemPedidoEntity itemPedido, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO itemsPedido (pedido, producto, cantidad, precioUnitario, subTotal) 
                                 VALUES (@pedido, @producto, @cantidad, @precioUnitario, @subTotal)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@pedido", itemPedido.pedido);
                cmd.Parameters.AddWithValue("@producto", itemPedido.codProducto);
                cmd.Parameters.AddWithValue("@cantidad", itemPedido.cantidad);
                cmd.Parameters.AddWithValue("@precioUnitario", itemPedido.preciounitario);
                cmd.Parameters.AddWithValue("@subTotal", itemPedido.subtotal);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();

                return itemPedido;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
 }

