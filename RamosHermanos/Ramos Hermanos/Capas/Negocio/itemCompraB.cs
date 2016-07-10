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
    class itemCompraB
    {
        public static void BuscarItemCompra(int idCompra, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT IC.idInsumo, I.insumo, precio, IC.cantidad, subTotal
                                FROM itemscompra IC
                                INNER JOIN Insumos I ON IC.idInsumo = I.idInsumo
                                WHERE IC.compra = @idCompra";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCompra", idCompra);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);
                    dgv.AutoGenerateColumns = false;
                    dgv.DataSource = dt;
                }

                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static itemComprasEntity InsertItemCompras(itemComprasEntity itemcompra, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO itemscompra (compra,idInsumo,idRubro,marca,precio,cantidad,subTotal)
                                    VALUES (@compra,@idInsumo,@idRubro,@marca,@precio,@cantidad,@subTotal)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@compra", itemcompra.compra);
                cmd.Parameters.AddWithValue("@idInsumo", itemcompra.idInsumo);
                cmd.Parameters.AddWithValue("@idRubro", itemcompra.idRubro);
                cmd.Parameters.AddWithValue("@marca", itemcompra.marca);
                cmd.Parameters.AddWithValue("@precio", itemcompra.precioUnitario);
                cmd.Parameters.AddWithValue("@cantidad", itemcompra.cantidad);
                cmd.Parameters.AddWithValue("@subTotal", itemcompra.subTotal);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();

                return itemcompra;
            }


            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }

        public static int BuscarCantidadAnterior(int idCompra, int idInsumo, string carga)
        {
            try
            {
                //Buscamos valor anterior del itemFactura
                MySQL.ConnectDB();

                string queryConsultaValor = @"SELECT *
                                              FROM itemsCompras
                                              WHERE compra = @idCompra and insumo = @insumo and carga = @carga";

                MySqlCommand cmdConsultaValor = new MySqlCommand(queryConsultaValor, MySQL.sqlcnx);

                cmdConsultaValor.Parameters.AddWithValue("@idCompra", idCompra);
                cmdConsultaValor.Parameters.AddWithValue("@insumo", idInsumo);
                cmdConsultaValor.Parameters.AddWithValue("@carga", carga);

                DataTable dtValor = new DataTable();
                MySqlDataAdapter daValor = new MySqlDataAdapter(cmdConsultaValor);

                daValor.Fill(dtValor);
                DataRow drValor = dtValor.Rows[0];

                int cantidad = Convert.ToInt32(drValor["cantidad"].ToString());

                MySQL.DisconnectDB();
                return cantidad;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
