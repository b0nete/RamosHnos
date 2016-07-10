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

        public static void CargarDGV(int idProducto, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT IP.insumo as IDinsumo, I.insumo, IP.cantidad, PI.precio
                               FROM itemsProducto IP
                               INNER JOIN Insumos I ON I.idInsumo = IP.insumo
                               INNER JOIN Medidas M ON M.idMedida = IP.medida
                               INNER JOIN precioInsumos PI ON PI.idInsumo = IP.insumo
                               WHERE IP.producto = @idProducto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", idProducto);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["IDinsumo"]),
                    Convert.ToString(dr["insumo"]),
                    Convert.ToString(""),
                    Convert.ToString(""),
                    Convert.ToString(dr["cantidad"]),
                    Convert.ToString(dr["precio"]),
                    Convert.ToString(""));
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

        public static int BuscarCantidadAnterior(int idInsumo, int cantidad)
        {
            try
            {
                //Buscamos valor anterior del itemFactura
                MySQL.ConnectDB();

                string queryConsultaValor = @"SELECT *
                                            FROM itemsProducto
                                            WHERE insumo = @insumo and cantidad = @cantidad";

                MySqlCommand cmdConsultaValor = new MySqlCommand(queryConsultaValor, MySQL.sqlcnx);

                cmdConsultaValor.Parameters.AddWithValue("@insumo", idInsumo);
                cmdConsultaValor.Parameters.AddWithValue("@cantidad", cantidad);

                DataTable dtValor = new DataTable();
                MySqlDataAdapter daValor = new MySqlDataAdapter(cmdConsultaValor);

                daValor.Fill(dtValor);
                DataRow drValor = dtValor.Rows[0];

                int retorno = Convert.ToInt32(drValor["cantidad"].ToString());

                MySQL.DisconnectDB();
                return retorno;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
