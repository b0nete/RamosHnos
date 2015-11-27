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

        public static itemPedidoEntity CargarDgvPedido(itemPedidoEntity item, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT I.iditemsPedido, I.pedido, I.producto, I.cantidad, I.precioUnitario, I.subTotal , P.producto
                                FROM itemspedido I
                                INNER JOIN productos P on P.idProducto = I.producto
                                WHERE iditemsPedido = @iditemsPedido";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@iditemsPedido", item.iditemsPedido);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    item.codProducto = Convert.ToInt32(row["codProducto"]);
                    item.cantidad = Convert.ToInt32(row["cantidad"]);
                    //cliente.idCliente = Convert.ToInt32(row["idCliente"]);
                    //cliente.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    //cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                    //cliente.sexo = Convert.ToString(row["sexo"]);
                    //cliente.cuil = Convert.ToString(row["cuil"]);
                    //cliente.apellido = Convert.ToString(row["apellido"]);
                    //cliente.nombre = Convert.ToString(row["nombre"]);
                    //cliente.estadoCivil = Convert.ToString(row["estadoCivil"]);
                    //cliente.condicionIVA = Convert.ToString(row["condicionIVA"]);
                    //cliente.tipoCliente = Convert.ToInt32(row["tipoCliente"]);
                    //cliente.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }

                return item;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

    }
 }

