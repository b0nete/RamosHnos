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
using System.Data;

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
                               SET fechaPedido = @fechaPedido, fechaEntrega= @fechaEntrega ,domicilio = @domicilio, estado = @estado,observaciones =@observaciones,total=@total
                               WHERE idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idPersona", pedido.idPersona);
                cmd.Parameters.AddWithValue("@fechaPedido", pedido.fechaPedido);
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
                            where idPedidos=@idPedido";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idPedido", pedido.idPedido);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)

                return false;

            else

                return true;


        }

//        public static PedidoEntity sumarPedido(PedidoEntity pedido, TextBox txtSum)
//        {

//            MySQL.ConnectDB();

//            string query = @"Select * from pedidos
//                            where numPedido = @numPedido";

//            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//            cmd.Parameters.AddWithValue("@numPedido", pedido.numPedido);

//            txtSum.Text = Convert.ToString(cmd.ExecuteScalar());

//            MySQL.DisconnectDB();

//            return pedido;

            

//        }
        public static void cargardgvPedido(DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                dgv.Rows.Clear();

                string query = @"Select P.idPedidos , P.fechaPedido , P.fechaEntrega ,P.total ,P.estado, P.idPersona, C.nombre, C.apellido
                               FROM pedidos P, clientes C
                               WHERE idCliente= P.idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToInt32(dr["idPedidos"]),
                    Convert.ToString(dr["idPersona"]),
                    Convert.ToString(dr["nombre"]),
                    Convert.ToString(dr["apellido"]),
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

        
        public static PedidoEntity BuscarIdPedido(PedidoEntity pedido)
        {

            try
            {
                MySQL.ConnectDB();

                string query = @"Select P.idPedidos ,P.idPersona, P.fechaPedido, P.fechaEntrega, p.Observaciones,P.rol, P.estado, P.total,
                               C.Nombre, C.Apellido, D.idDomicilio, D.calle, D.numero
                               FROM pedidos P
                               INNER JOIN clientes C on C.idCliente = P.idPersona
                               INNER JOIN domicilios D on D.idDomicilio = P.domicilio
                               WHERE idpedidos = @idPedido";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idPedido", pedido.idPedido);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Pedido NO existe!");

                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    pedido.idPedido = Convert.ToInt32(row["idPedidos"]);
                    pedido.idPersona = Convert.ToInt32(row["idPersona"]);
                    pedido.fechaPedido = Convert.ToDateTime(row["FechaPedido"]);
                    pedido.calle = Convert.ToString(row["nombre"]);
                    pedido.fechaEntrega = Convert.ToDateTime(row["FechaEntrega"]);
                    pedido.observaciones = Convert.ToString(row["observaciones"]);
                    pedido.rol = Convert.ToInt32(row["rol"]);
                    pedido.total = Convert.ToDouble(row["total"]);
                    pedido.nombre = Convert.ToString(row["Nombre"]);
                    pedido.apellido = Convert.ToString(row["Apellido"]);
                    pedido.domicilio = Convert.ToString(row["idDomicilio"]);
                    pedido.calle = Convert.ToString(row["calle"]);
                    pedido.estado = Convert.ToString(row["estado"]);
                    

                    MySQL.DisconnectDB();
                }
                return pedido;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarDGVParametros(DataGridView dgv, ComboBox cb, string parametro)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT P.idPedidos, C.idCliente, C.apellido, C.nombre, P.fechaPedido, P.estado
                                 FROM pedidos P
                                 INNER JOIN clientes C on P.idPersona = C.idCliente
                                 WHERE";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idPedidos", parametro);
                cmd.Parameters.AddWithValue("@idCliente", parametro);
                cmd.Parameters.AddWithValue("@apellido", parametro);
                cmd.Parameters.AddWithValue("@nombre", parametro);
                cmd.Parameters.AddWithValue("@fechaPedido", parametro);
                cmd.Parameters.AddWithValue("@estado", parametro);

                if(cb.SelectedIndex == 0)
                {
                    cmd.CommandText = query + " P.idPedidos LIKE @idPedidos";
                    
                }
                if (cb.SelectedIndex == 1)
                {
                    cmd.CommandText = query + " C.idCliente LIKE @idCliente";

                }
                if (cb.SelectedIndex == 2)
                {
                    cmd.CommandText = query + " P.fechaPedido LIKE @fechaPedido";

                }
                
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idPedidos"]),
                    Convert.ToString(dr["idCliente"]),
                    Convert.ToString(dr["apellido"]),
                    Convert.ToString(dr["nombre"]),
                    Convert.ToString(dr["fechaPedido"]),
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

