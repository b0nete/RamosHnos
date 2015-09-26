using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RamosHermanos.Capas.Negocio
{
    class PedidoB
    {
        public static PedidoEntity InsertPedido(PedidoEntity pedido)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT into Pedidos (fechaPedido,fechaEntrega,observaciones, total, estado)
                             VALUES (@fechaPedido,@fechaEntrega,@observaciones,@total,@estado);
                             SELECT LAST_INSERT_ID();";


                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fechaPedido", pedido.fechaPedido);
                cmd.Parameters.AddWithValue("@fechaEntrega", pedido.fechaEntrega);
                cmd.Parameters.AddWithValue("@observaciones", pedido.observaciones);
                cmd.Parameters.AddWithValue("@total", pedido.total);
                cmd.Parameters.AddWithValue("@estado", pedido.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return pedido;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            } 
        
        
        }
    }
}
