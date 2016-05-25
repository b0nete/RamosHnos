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
//                MySQL.ConnectDB();

//                DataTable dt = new DataTable();                

//                string query = @"SELECT idItemProducto as idItemProducto, IP.Insumo as idInsumo, I.Insumo as Insumo, IP.Medida as idMedida, M.Medida as Medida, IP.cantidad
//                                FROM itemsProducto IP
//                                INNER JOIN Insumos I ON I.idInsumo = IP.insumo
//                                INNER JOIN Medidas M ON M.idMedida = IP.medida
//                                WHERE IP.producto = @producto";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@producto", idProducto);

//                MySqlDataAdapter da = new MySqlDataAdapter(query, MySQL.sqlcnx);

//                cmd.ExecuteNonQuery();
                
//                da.Fill(dt);

//                dgvItemProducto.DataSource = dt;

//                MySQL.DisconnectDB();

                MySQL.ConnectDB();
                dgvItemProducto.Rows.Clear();

                string query = @"SELECT idItemProducto as idItemProducto, IP.Insumo as idInsumo, I.Insumo as Insumo, IP.Medida as idMedida, M.Medida as Medida, IP.cantidad
                               FROM itemsProducto IP
                               INNER JOIN Insumos I ON I.idInsumo = IP.insumo
                               INNER JOIN Medidas M ON M.idMedida = IP.medida
                               WHERE IP.producto = @producto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@producto", idProducto);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgvItemProducto.Rows.Add(
                    Convert.ToString(dr["idItemProducto"]),
                    Convert.ToString(dr["idInsumo"]),
                    Convert.ToString(dr["Insumo"]),
                    Convert.ToString(dr["idMedida"]),
                    Convert.ToString(dr["Medida"]),
                    Convert.ToString(dr["cantidad"]));
                }

                dr.Close();
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
