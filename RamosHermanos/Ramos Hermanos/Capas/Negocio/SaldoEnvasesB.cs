using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Datos;

namespace RamosHermanos.Capas.Negocio
{
    class SaldoEnvasesB
    {
        public static int GenerarSaldoEnvases(int cliente, int idSoda)
        {
            try
            {
                int total = 0;
                DataTable dtFacturas = new DataTable();

                //Buscar facturas de cliente
                string query = @"SELECT idfactura
                                FROM Facturas
                                WHERE cliente = @cliente";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                cmd.Parameters.AddWithValue("@cliente", cliente);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dtFacturas);


                foreach (DataRow dr in dtFacturas.Rows)
                {
                    //                    string queryPrueba = @"SELECT totalCarga.cantidadCarga - totalDescarga.cantidadDescarga as total
                    //                                        FROM
                    //
                    //                                        (SELECT IFNULL((SELECT cantidad as cantidadCarga
                    //                                        FROM itemsFactura
                    //                                        WHERE factura = 1 and producto = 1 and carga = 'C'), 0) as totalCarga),
                    //
                    //                                        (SELECT IFNULL((SELECT cantidad as cantidadDescarga
                    //                                        FROM itemsFactura
                    //                                        WHERE factura = 1 and producto = 1 and carga = 'D'), 0) as totalDescarga)";

                    string queryCarga = @"SELECT IFNULL((SELECT cantidad as cantidadCarga
                                        FROM itemsFactura
                                        WHERE factura = @factura and producto = @producto and carga = 'C'), 0) as totalCarga";

                    MySqlCommand cmdCarga = new MySqlCommand(queryCarga, MySQL.sqlcnx);
                    cmdCarga.Parameters.AddWithValue("@factura", dr["idFactura"]);
                    cmdCarga.Parameters.AddWithValue("@producto", idSoda);
                    int cantCarga = Convert.ToInt32(cmdCarga.ExecuteScalar());


                    string queryDescarga = @"SELECT IFNULL((SELECT cantidad as cantidadDescarga
                                            FROM itemsFactura
                                            WHERE factura = @factura and producto = @producto and carga = 'D'), 0) as totalDescarga";

                    MySqlCommand cmdDescarga = new MySqlCommand(queryDescarga, MySQL.sqlcnx);
                    cmdDescarga.Parameters.AddWithValue("@factura", dr["idFactura"]);
                    cmdDescarga.Parameters.AddWithValue("@producto", idSoda);
                    int cantDescarga = Convert.ToInt32(cmdDescarga.ExecuteScalar());

                    total += cantCarga - cantDescarga;
                }

                return total;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

    }
}
