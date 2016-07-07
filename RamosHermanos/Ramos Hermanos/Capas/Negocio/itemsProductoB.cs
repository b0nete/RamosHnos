using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Datos;

namespace RamosHermanos.Capas.Negocio
{
    class itemsProductoB
    {

        public static void CargarDGV(int idProducto, DataGridView dgvItemProducto)
        {
            try
            {
                MySQL.ConnectDB();
                dgvItemProducto.Rows.Clear();

                string query = @"SELECT IP.insumo as IDinsumo, I.insumo, IP.cantidad, PI.precio
                               FROM itemsProducto IP
                               INNER JOIN Insumos I ON I.idInsumo = IP.insumo
                               INNER JOIN Medidas M ON M.idMedida = IP.medida
                               INNER JOIN precioInsumos PI ON PI.idInsumo = IP.insumo
                               WHERE IP.producto = @producto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@producto", idProducto);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                dgvItemProducto.DataSource = dt;                

                MySQL.DisconnectDB();
            }


            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }


        public static void InsertItemProducto(itemsProductoEntity itemProducto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO itemsProducto (producto, insumo, medida, cantidad)
                                    VALUES (@producto, @insumo, @medida, @cantidad)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@producto", itemProducto.producto);
                cmd.Parameters.AddWithValue("@insumo", itemProducto.idInsumo);
                cmd.Parameters.AddWithValue("@medida", itemProducto.medida);
                cmd.Parameters.AddWithValue("@cantidad", itemProducto.cantidad);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();
            }


            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }
    }
}
