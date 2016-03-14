using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Negocio
{
    class FacturaB
    {
        public static FacturaEntity InsertFactura(FacturaEntity factura)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Facturas (tipoFactura, numFactura, fechaFactura, fechaVencimiento, fechaEntrega, formaPago, cliente, observaciones, total, estado) 
                                 VALUES (@tipoFactura, @numFactura, @fechaFactura, @fechaVencimiento, @fechaEntrega, @formaPago, @cliente, @observaciones, @total, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoFactura", factura.tipoFactura);
                cmd.Parameters.AddWithValue("@numFactura", factura.numFactura);
                cmd.Parameters.AddWithValue("@fechaFactura", factura.fechaFactura);
                cmd.Parameters.AddWithValue("@fechaVencimiento", factura.fechaVencimiento);
                cmd.Parameters.AddWithValue("@fechaEntrega", factura.fechaEntrega);
                cmd.Parameters.AddWithValue("@formaPago", factura.formaPago);
                cmd.Parameters.AddWithValue("@cliente", factura.cliente);
                cmd.Parameters.AddWithValue("@observaciones", factura.observaciones);
                cmd.Parameters.AddWithValue("@total", factura.total);
                cmd.Parameters.AddWithValue("@estado", factura.estado);

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return factura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static int UltimaFactura()
        {
            try
            {
                int idFactura;

                MySQL.ConnectDB();

                string query = @"SELECT ISNULL(MAX(idFactura)) + 1 as idFactura
                                 FROM facturas;";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                                
                idFactura = Convert.ToInt32(cmd.ExecuteScalar());

                if (idFactura == 1)
                    idFactura = 0;

                MySQL.DisconnectDB();

                return idFactura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static FacturaEntity InsertIDFactura(FacturaEntity factura, DataGridView dgv)
        {
            try
            {                
                MySQL.ConnectDB();

                string query = @"INSERT INTO Facturas (tipoFactura, numFactura, fechaFactura, fechaVencimiento, fechaEntrega, formaPago, cliente, observaciones, total, estado) 
                                 VALUES (@tipoFactura, @numFactura, @fechaFactura, @fechaVencimiento, @fechaEntrega, @formaPago, @cliente, @observaciones, @total, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);


                foreach (DataGridView row in dgv.Rows)
                {
                    cmd.Parameters.AddWithValue("@numFactura", factura.numFactura);
                    cmd.Parameters.AddWithValue("@cliente", factura.cliente);

                    cmd.ExecuteNonQuery();
                }

                MySQL.DisconnectDB();

                return factura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

//        public static FacturaEntity BuscarFacturaID(FacturaEntity Factura)
//        {

//            try
//            {
//                MySQL.ConnectDB();

//                string query = @"SELECT P.idFactura, P.idPersona, P.fechaPedido, P.fechaEntrega, p.Observaciones,P.rol, P.estado, P.total,
//                               C.Nombre, C.Apellido, D.idDomicilio, D.calle, D.numero
//                               FROM pedidos P
//                               INNER JOIN clientes C on C.idCliente = P.idPersona
//                               INNER JOIN domicilios D on D.idDomicilio = P.domicilio
//                               WHERE P.idpedidos = @idPedido";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@idPedido", pedido.idPedido);

//                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
//                if (resultado == 0)
//                {
//                    MessageBox.Show("El Pedido NO existe!");

//                }
//                else
//                {
//                    DataTable dt = new DataTable();
//                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

//                    da.Fill(dt);

//                    DataRow row = dt.Rows[0];

//                    pedido.idPedido = Convert.ToInt32(row["idPedidos"]);
//                    pedido.idPersona = Convert.ToInt32(row["idPersona"]);
//                    pedido.fechaPedido = Convert.ToDateTime(row["FechaPedido"]);
//                    pedido.calle = Convert.ToString(row["nombre"]);
//                    pedido.fechaEntrega = Convert.ToDateTime(row["FechaEntrega"]);
//                    pedido.observaciones = Convert.ToString(row["observaciones"]);
//                    pedido.rol = Convert.ToInt32(row["rol"]);
//                    pedido.total = Convert.ToDouble(row["total"]);
//                    pedido.nombre = Convert.ToString(row["Nombre"]);
//                    pedido.apellido = Convert.ToString(row["Apellido"]);
//                    pedido.domicilio = Convert.ToString(row["idDomicilio"]);
//                    pedido.calle = Convert.ToString(row["calle"]);
//                    pedido.estado = Convert.ToString(row["estado"]);


//                    MySQL.DisconnectDB();
//                }
//                return pedido;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }

        
    }
}
