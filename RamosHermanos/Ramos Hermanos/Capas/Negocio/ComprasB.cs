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
        public static ComprasEntity InsertCompras(ComprasEntity compras, TextBox txtid)
        {
             try 
	            {
                    MySQL.ConnectDB();
                    string query = @"INSERT INTO compras (proveedor,fecha,observaciones,total,estado)
                                 VALUES (@proveedor,@fecha,@observaciones,@total,@estado);
                                 SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                    cmd.Parameters.AddWithValue("@proveedor", compras.proveedor);
                    cmd.Parameters.AddWithValue("@fecha", compras.fecha);
                    cmd.Parameters.AddWithValue("@observaciones", compras.observaciones);
                    cmd.Parameters.AddWithValue("@total", compras.total);
                    cmd.Parameters.AddWithValue("@estado", compras.estado);
                                       
                    txtid.Text = Convert.ToString(cmd.ExecuteScalar());

                    //cmd.ExecuteNonQuery();


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