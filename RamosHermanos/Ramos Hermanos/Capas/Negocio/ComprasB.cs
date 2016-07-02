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
    class ComprasB
    {
        public static DataRow BuscarCompraID(int idCompra)
        {
            try
            {
                MySQL.ConnectDB();

                DataTable dt = new DataTable();

                string query = @"SELECT idCompras, C.proveedor, P.cuit, P.condicionIVA, P.razonSocial, fecha, observaciones, total, C.estado, tipofactura
                                FROM Compras C
                                INNER JOIN Proveedores P ON C.proveedor = P.idProveedor
                                WHERE idCompras = @idCompra";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCompra", idCompra);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("La Compra NO existe!");
                }
                else
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);
                }

                DataRow dr = dt.Rows[0];

                MySQL.DisconnectDB();

                return dr;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ComprasEntity InsertCompras(ComprasEntity compras, TextBox txtid)
        {
             try 
	            {
                    MySQL.ConnectDB();
                    string query = @"INSERT INTO compras (tipoFactura, numFactura, fecha, fechaEntrega, fechaVencimiento, proveedor, observaciones, total, estado)
                                 VALUES (@tipoFactura, @numFactura, @fecha, @fechaEntrega, @fechaVencimiento, @proveedor, @observaciones, @total, @estado);
                                 SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);



                    cmd.Parameters.AddWithValue("@tipoFactura", compras.tipoFactura);
                    cmd.Parameters.AddWithValue("@numFactura", compras.numFactura);
                    cmd.Parameters.AddWithValue("@fecha", compras.fecha);
                    cmd.Parameters.AddWithValue("@fechaEntrega", compras.fechaEntrega);
                    cmd.Parameters.AddWithValue("@fechaVencimiento", compras.fechaVencimiento);
                    cmd.Parameters.AddWithValue("@proveedor", compras.proveedor);                 
                    cmd.Parameters.AddWithValue("@observaciones", compras.observaciones);
                    cmd.Parameters.AddWithValue("@total", compras.total);
                    cmd.Parameters.AddWithValue("@estado", compras.estado);
                                       
                    txtid.Text = Convert.ToString(cmd.ExecuteScalar());

                    MySQL.DisconnectDB();

                    return compras;

                }
	catch (Exception ex)
	{
        MessageBox.Show(ex + "ERROR");
		throw;
	}
        }

        public static void ListCompras(DataGridView dgvList)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT idcompras as colCompra, fecha as colFecha, total as colTotal, razonSocial as colProveedor, total as colTotal
                                FROM Compras C
                                INNER JOIN Proveedores P ON P.idProveedor = C.proveedor";

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(query, MySQL.sqlcnx);

                da.Fill(dt);

                dgvList.DataSource = dt;
                dgvList.AutoGenerateColumns = false;

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