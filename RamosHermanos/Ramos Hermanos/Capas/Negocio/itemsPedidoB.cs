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
        public static itemPedidoEntity InsertIntoItemPedido(itemPedidoEntity itemPedido, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO itemsPedido (idpedido,cantidad,preciounitario,subtotal) 
                                 VALUES (@idpedido, @cantidad, @preciounitario, @subtotal)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                foreach (DataGridView row in dgv.Rows)
                {
                    itemPedidoEntity it = new itemPedidoEntity();
                                                            
                    cmd.ExecuteNonQuery();
                }

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

