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
        public static PedidoEntity InsertPedido(PedidoEntity pedido, TextBox txtid)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT into Pedidos (rol,idPersona,domicilio,fechaPedido,fechaEntrega,observaciones, total, estado)
                             VALUES (@rol,@idPersona,@domicilio,@fechaPedido,@fechaEntrega,@observaciones,@total,@estado);
                             SELECT LAST_INSERT_ID();";


                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", pedido.rol);
                cmd.Parameters.AddWithValue("@idPersona", pedido.idPersona);
                cmd.Parameters.AddWithValue("@domicilio", pedido.domicilio);
                cmd.Parameters.AddWithValue("@fechaPedido", pedido.fechaPedido);
                cmd.Parameters.AddWithValue("@fechaEntrega", pedido.fechaEntrega);
                cmd.Parameters.AddWithValue("@observaciones", pedido.observaciones);
                cmd.Parameters.AddWithValue("@total", pedido.total);
                cmd.Parameters.AddWithValue("@estado", pedido.estado);

                txtid.Text = Convert.ToString(cmd.ExecuteScalar());

                //cmd.ExecuteNonQuery();


                MySQL.DisconnectDB();

                return pedido;


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }

        public static PedidoEntity UpdatePedido(PedidoEntity pedido)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE pedidos
                               SET fechaPedido = @fechaPedido, fechaEntrega= @fechaEntrega domicilio = @domicilio, estado = @estado,observaciones =@observaciones,total=@total
                               WHERE idPedidos = @idPedidos";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fechaPedido", pedido.fechaPedido);
                cmd.Parameters.AddWithValue("@idPedidos", pedido.idPedido);
                cmd.Parameters.AddWithValue("@fechaEntrega", pedido.fechaEntrega);
                cmd.Parameters.AddWithValue("@domicilio", pedido.domicilio);
                cmd.Parameters.AddWithValue("@estado", pedido.estado);
                cmd.Parameters.AddWithValue("@observaciones", pedido.observaciones);
                cmd.Parameters.AddWithValue("@total", pedido.total);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Pedido Actualizado");

                return pedido;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR  " + ex);
                throw;
            }


        }

        public static bool ExistePedido(PedidoEntity pedido)
        {

            MySQL.ConnectDB();

            string query = @"Select COUNT(*) from pedidos
                            where idPedidos = @idPedidos";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idPedidos", pedido.idPedido);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)

                return false;

            else

                return true;


        }
        public static void cargardgvPedido (DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                dgv.Rows.Clear();

                string query = @"Select P.idPedidos , P.fechaPedido , P.fechaEntrega ,P.total ,P.estado, p.idPersona
                               FROM pedidos P";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToInt32(dr["idPedidos"]),
                    Convert.ToString(dr["idPersona"]),
                    Convert.ToDateTime(dr["fechaPedido"]).ToString("dd/MM/yyyy"),
                    Convert.ToDateTime(dr["fechaEntrega"]).ToString("dd/MM/yyyy"),
                    Convert.ToDouble(dr["total"]),
                    Convert.ToString(dr["estado"]));
                                       
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

