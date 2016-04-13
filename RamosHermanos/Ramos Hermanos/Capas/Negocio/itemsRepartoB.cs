using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Datos;

namespace RamosHermanos.Capas.Negocio
{
    class itemsRepartoB
    {
        public static itemsRepartoEntity InsertItemReparto(itemsRepartoEntity itemReparto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO itemsReparto (reparto, cliente, domicilio, idComprobante, soda, agua4, agua10, agua12, agua20, agua25, cajon, canasta, pie, dispenser, saldo) 
                                 VALUES (@reparto, @cliente, @domicilio, @idComprobante, @soda, @agua4, @agua10, @agua12, @agua20, @agua25, @cajon, @canasta, @pie, @dispenser, saldo);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@reparto", itemReparto.reparto);
                cmd.Parameters.AddWithValue("@cliente", itemReparto.cliente);
                cmd.Parameters.AddWithValue("@domicilio", itemReparto.domicilio);
                cmd.Parameters.AddWithValue("@idComprobante", itemReparto.idComprobante);
                cmd.Parameters.AddWithValue("@soda", SaldoEnvasesB.GenerarSaldoEnvases(itemReparto.cliente, 7));
                cmd.Parameters.AddWithValue("@agua4", SaldoEnvasesB.GenerarSaldoEnvases(itemReparto.cliente, 1));
                cmd.Parameters.AddWithValue("@agua10", SaldoEnvasesB.GenerarSaldoEnvases(itemReparto.cliente, 3));
                cmd.Parameters.AddWithValue("@agua12", SaldoEnvasesB.GenerarSaldoEnvases(itemReparto.cliente, 4));
                cmd.Parameters.AddWithValue("@agua20", SaldoEnvasesB.GenerarSaldoEnvases(itemReparto.cliente, 5));
                cmd.Parameters.AddWithValue("@agua25", SaldoEnvasesB.GenerarSaldoEnvases(itemReparto.cliente, 6));
                cmd.Parameters.AddWithValue("@cajon", SaldoEnvasesB.GenerarSaldoEnvases(itemReparto.cliente, 8));
                cmd.Parameters.AddWithValue("@canasta", SaldoEnvasesB.GenerarSaldoEnvases(itemReparto.cliente, 9));
                cmd.Parameters.AddWithValue("@pie", SaldoEnvasesB.GenerarSaldoEnvases(itemReparto.cliente, 10));
                cmd.Parameters.AddWithValue("@dispenser", SaldoEnvasesB.GenerarSaldoEnvases(itemReparto.cliente, 11));
                cmd.Parameters.AddWithValue("@saldo", itemsRepartoB.CalcularVenta(itemReparto.idComprobante));


                cmd.ExecuteNonQuery();

                //MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return itemReparto;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static int UltimoComprobante()
        {
            try
            {
                int idComprobante;

                MySQL.ConnectDB();

                string query = @"SELECT MAX(idComprobante) as idComprobante
                                 FROM itemsReparto;";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                //idComprobante = Convert.ToInt32(cmd.ExecuteScalar());
                //visita.olunes = reader["olunes"] == DBNull.Value ? 0 : Convert.ToInt32(reader["olunes"]);

                idComprobante = cmd.ExecuteScalar() == DBNull.Value ? 0 : Convert.ToInt32(cmd.ExecuteScalar());

                MySQL.DisconnectDB();

                return idComprobante;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static DataTable BuscarItemsReparto(itemsRepartoEntity itemsReparto, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                DataTable dtMerge = new DataTable();

                dtMerge.Columns.Add("colOrden");
                dtMerge.Columns.Add("idCliente");
                dtMerge.Columns.Add("clienteCompleto");
                dtMerge.Columns.Add("idDomicilio");
                dtMerge.Columns.Add("domicilioCompleto");
                //Saldo
                dtMerge.Columns.Add("colSSaldo");
                dtMerge.Columns.Add("colASaldo");
                dtMerge.Columns.Add("colCSaldo");
                dtMerge.Columns.Add("colCCSaldo");
                dtMerge.Columns.Add("colPSaldo");
                dtMerge.Columns.Add("colDSaldo");
                dtMerge.Columns.Add("colSCCSaldo");
                //Carga
                dtMerge.Columns.Add("colSCarga");
                dtMerge.Columns.Add("colACarga");
                dtMerge.Columns.Add("colCCarga");
                dtMerge.Columns.Add("colCCCarga");
                dtMerge.Columns.Add("colPCarga");
                dtMerge.Columns.Add("colDCarga");
                //Descarga
                dtMerge.Columns.Add("colSDescarga");
                dtMerge.Columns.Add("colADescarga");
                dtMerge.Columns.Add("colCDescarga");
                dtMerge.Columns.Add("colCCDescarga");
                dtMerge.Columns.Add("colPDescarga");
                dtMerge.Columns.Add("colDDescarga");
                //
                dtMerge.Columns.Add("colVenta");
                dtMerge.Columns.Add("colCobro");
                dtMerge.Columns.Add("colSaldoCC");
                dtMerge.Columns.Add("idComprobante");

                DataTable dtEncabezado = new DataTable();
                DataTable dtACarga = new DataTable();
                DataTable dtSCarga = new DataTable();
                DataTable dtCCarga = new DataTable();
                DataTable dtCCCarga = new DataTable();
                DataTable dtPCarga = new DataTable();
                DataTable dtDCarga = new DataTable();
                DataTable dtADescarga = new DataTable();
                DataTable dtSDescarga = new DataTable();
                DataTable dtCDescarga = new DataTable();
                DataTable dtCCDescarga = new DataTable();
                DataTable dtPDescarga = new DataTable();
                DataTable dtDDescarga = new DataTable();
                DataTable dtVenta = new DataTable();


                //Encabezado
                string query = @"SELECT IR.cliente as idCliente, CONCAT(C.nombre, ' ', C.apellido) as clienteCompleto, IR.domicilio as idDomicilio, CONCAT(CC.Calle,' ',D.Numero,' PISO: ',D.Piso,', DPTO: ',D.Dpto) as domicilioCompleto, idComprobante, soda as colSSaldo, (SELECT SUM(agua4 + agua10 + agua12 + agua20 + agua25)
FROM itemsReparto) as colASaldo, cajon as colCSaldo, canasta as colCCSaldo, pie as colPSaldo, dispenser as colDSaldo, saldo as colSCCSaldo
                                 FROM itemsReparto IR
                                 INNER JOIN Clientes C ON C.idCliente = IR.cliente
                                 INNER JOIN Domicilios D ON D.idDomicilio = IR.domicilio
                                 INNER JOIN Calles CC ON D.Calle = CC.idCalle
                                 WHERE reparto = @reparto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@reparto", itemsReparto.reparto);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dtEncabezado);

                               
                foreach (DataRow dRow in dtEncabezado.Rows)
                {
                    ////CARGAS

                    //Aguas
                    //dtACarga.Clear();
                    itemFacturaEntity itemFactura = new itemFacturaEntity();

                    string queryACarga = @"SELECT SUM(cantidad) as colACarga
                                            FROM itemsFactura
                                            WHERE factura = @factura and carga = 'C' 
                                            and (producto = 1 
                                            or producto = 2 
                                            or producto = 3 
                                            or producto = 4
                                            or producto = 5 
                                            or producto = 6)";

                    MySqlCommand cmd2 = new MySqlCommand(queryACarga, MySQL.sqlcnx);

                    cmd2.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                    da2.Fill(dtACarga);

                    //Sodas
                    //dtSCarga.Clear();
                    string querySCarga = @"SELECT SUM(cantidad) as colSCarga
                                            FROM itemsFactura
                                            WHERE producto = 7 and factura = @factura and carga = 'C'";

                    MySqlCommand cmd3 = new MySqlCommand(querySCarga, MySQL.sqlcnx);

                    cmd3.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter da3 = new MySqlDataAdapter(cmd3);
                    da3.Fill(dtSCarga);

                    //Cajon
                    //dtSCarga.Clear();
                    string queryCCarga = @"SELECT SUM(cantidad) as colCCarga
                                            FROM itemsFactura
                                            WHERE producto = 8 and factura = @factura and carga = 'C'";

                    MySqlCommand cmd4 = new MySqlCommand(queryCCarga, MySQL.sqlcnx);

                    cmd4.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter da4 = new MySqlDataAdapter(cmd4);
                    da4.Fill(dtCCarga);

                    //Canasta
                    //dtSCarga.Clear();
                    string queryCCCarga = @"SELECT SUM(cantidad) as colCCCarga
                                            FROM itemsFactura
                                            WHERE producto = 9 and factura = @factura and carga = 'C'";

                    MySqlCommand cmdCC = new MySqlCommand(queryCCCarga, MySQL.sqlcnx);

                    cmdCC.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter daCC = new MySqlDataAdapter(cmdCC);
                    daCC.Fill(dtCCCarga);

                    //Pie
                    //dtSCarga.Clear();
                    string queryPCarga = @"SELECT SUM(cantidad) as colPCarga
                                            FROM itemsFactura
                                            WHERE producto = 10 and factura = @factura and carga = 'C'";

                    MySqlCommand cmdP = new MySqlCommand(queryPCarga, MySQL.sqlcnx);

                    cmdP.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter daP = new MySqlDataAdapter(cmdP);
                    daP.Fill(dtPCarga);

                    //Dispenser
                    //dtSCarga.Clear();
                    string queryDCarga = @"SELECT SUM(cantidad) as colDCarga
                                            FROM itemsFactura
                                            WHERE producto = 11 and factura = @factura and carga = 'C'";

                    MySqlCommand cmdD = new MySqlCommand(queryDCarga, MySQL.sqlcnx);

                    cmdD.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter daD = new MySqlDataAdapter(cmdD);
                    daD.Fill(dtDCarga);

                    ////DESCARGAS

                    //Aguas
                    //dtACarga.Clear();

                    string queryADescarga = @"SELECT SUM(cantidad) as colADescarga
                                            FROM itemsFactura
                                            WHERE factura = @factura and carga = 'D' 
                                            and (producto = 1 
                                            or producto = 2 
                                            or producto = 3 
                                            or producto = 4
                                            or producto = 5 
                                            or producto = 6)";

                    MySqlCommand cmdADescarga = new MySqlCommand(queryADescarga, MySQL.sqlcnx);

                    cmdADescarga.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter daADescarga = new MySqlDataAdapter(cmdADescarga);
                    daADescarga.Fill(dtADescarga);

                    //Sodas
                    //dtSCarga.Clear();
                    string querySDescarga = @"SELECT SUM(cantidad) as colSDescarga
                                            FROM itemsFactura
                                            WHERE producto = 7 and factura = @factura and carga = 'D'";

                    MySqlCommand cmdSDescarga = new MySqlCommand(querySDescarga, MySQL.sqlcnx);

                    cmdSDescarga.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter daSDescarga = new MySqlDataAdapter(cmdSDescarga);
                    daSDescarga.Fill(dtSDescarga);

                    //Cajon
                    //dtSCarga.Clear();
                    string queryCDescarga = @"SELECT SUM(cantidad) as colCDescarga
                                            FROM itemsFactura
                                            WHERE producto = 8 and factura = @factura and carga = 'D'";

                    MySqlCommand cmdCDescarga = new MySqlCommand(queryCDescarga, MySQL.sqlcnx);

                    cmdCDescarga.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter daCDescarga = new MySqlDataAdapter(cmdCDescarga);
                    daCDescarga.Fill(dtCDescarga);

                    //Canasta
                    //dtSCarga.Clear();
                    string queryCCDescarga = @"SELECT SUM(cantidad) as colCCDescarga
                                            FROM itemsFactura
                                            WHERE producto = 9 and factura = @factura and carga = 'D'";

                    MySqlCommand cmdCCDescarga = new MySqlCommand(queryCCDescarga, MySQL.sqlcnx);

                    cmdCCDescarga.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter daCCDescarga = new MySqlDataAdapter(cmdCCDescarga);
                    daCCDescarga.Fill(dtCCDescarga);

                    //Pie
                    //dtSCarga.Clear();
                    string queryPDescarga = @"SELECT SUM(cantidad) as colPDescarga
                                            FROM itemsFactura
                                            WHERE producto = 10 and factura = @factura and carga = 'D'";

                    MySqlCommand cmdPDescarga = new MySqlCommand(queryPDescarga, MySQL.sqlcnx);

                    cmdPDescarga.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter daPDescarga = new MySqlDataAdapter(cmdPDescarga);
                    daPDescarga.Fill(dtPDescarga);

                    //Dispenser
                    //dtSCarga.Clear();
                    string queryDDescarga = @"SELECT SUM(cantidad) as colDDescarga
                                            FROM itemsFactura
                                            WHERE producto = 11 and factura = @factura and carga = 'D'";

                    MySqlCommand cmdDDescarga = new MySqlCommand(queryDDescarga, MySQL.sqlcnx);

                    cmdDDescarga.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter daDDescarga = new MySqlDataAdapter(cmdDDescarga);
                    daDDescarga.Fill(dtDDescarga);

                    ////VENTA & COBRO

                    //Venta
                    //dtACarga.Clear();

                    string queryVenta = @"SELECT totalCarga.subTotalC - totalDescarga.subTotalD as venta
                                        FROM
                                        (SELECT SUM(subTotal) as subTotalC
                                        FROM itemsFactura
                                        WHERE factura = @factura and carga = 'C') as totalCarga,
                                        (SELECT SUM(subTotal) as subTotalD
                                        FROM itemsFactura
                                        WHERE factura = @factura and carga = 'D') as totalDescarga";

                    MySqlCommand cmdVenta = new MySqlCommand(queryVenta, MySQL.sqlcnx);

                    cmdVenta.Parameters.AddWithValue("@factura", dRow["idComprobante"]);

                    MySqlDataAdapter daVenta = new MySqlDataAdapter(cmdVenta);
                    daVenta.Fill(dtVenta);
                }

                foreach (DataRow row in dtEncabezado.Rows)
                {
                    DataRow newRow = dtMerge.NewRow();
                    newRow["idCliente"] = row["idCliente"];
                    newRow["clienteCompleto"] = row["clienteCompleto"];
                    newRow["idDomicilio"] = row["idDomicilio"];
                    newRow["domicilioCompleto"] = row["domicilioCompleto"];
                    newRow["idComprobante"] = row["idComprobante"];

                    dtMerge.ImportRow(row);
                }

                for (int i = 0; i <= dtACarga.Rows.Count - 1; i++)
                {
                    DataRow rowMerge = dtMerge.Rows[i];
                    //CARGA
                    DataRow roworigen = dtACarga.Rows[i];
                    DataRow roworigen2 = dtSCarga.Rows[i];
                    DataRow roworigenC = dtCCarga.Rows[i];
                    DataRow roworigenCC = dtCCCarga.Rows[i];
                    DataRow roworigenP= dtPCarga.Rows[i];
                    DataRow roworigenD = dtDCarga.Rows[i];
                    //DESCARGA
                    DataRow roworigenSDescarga = dtSDescarga.Rows[i];
                    DataRow roworigenADescarga = dtADescarga.Rows[i];
                    DataRow roworigenCDescarga = dtCDescarga.Rows[i];
                    DataRow roworigenCCDescarga = dtCCDescarga.Rows[i];
                    DataRow roworigenPDescarga = dtPDescarga.Rows[i];
                    DataRow roworigenDDescarga = dtDDescarga.Rows[i];
                    //Venta
                    DataRow roworigenVenta = dtVenta.Rows[i];


                    //CARGA
                    rowMerge["colACarga"] = roworigen["colACarga"];
                    rowMerge["colSCarga"] = roworigen2["colSCarga"];
                    rowMerge["colCCarga"] = roworigenC["colCCarga"];
                    rowMerge["colCCCarga"] = roworigenCC["colCCCarga"];
                    rowMerge["colPCarga"] = roworigenP["colPCarga"];
                    rowMerge["colDCarga"] = roworigenD["colDCarga"];
                    //DESCARGA
                    rowMerge["colADescarga"] = roworigenADescarga["colADescarga"];
                    rowMerge["colSDescarga"] = roworigenSDescarga["colSDescarga"];
                    rowMerge["colCDescarga"] = roworigenCDescarga["colCDescarga"];
                    rowMerge["colCCDescarga"] = roworigenCCDescarga["colCCDescarga"];
                    rowMerge["colPDescarga"] = roworigenPDescarga["colPDescarga"];
                    rowMerge["colDDescarga"] = roworigenDDescarga["colDDescarga"];
                    //Venta
                    rowMerge["colVenta"] = roworigenVenta["venta"];
                }

                MySQL.DisconnectDB();
                return dtMerge;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string CalcularVenta(int idFactura)
        {
            try
            {
                MySQL.ConnectDB();

                string queryCarga = @"SELECT IFNULL((SELECT SUM(subTotal) as STCarga
                                        FROM itemsFactura
                                        WHERE factura = @factura and carga = 'C'), 0) as totalCarga";

                MySqlCommand cmdCarga = new MySqlCommand(queryCarga, MySQL.sqlcnx);
                cmdCarga.Parameters.AddWithValue("@factura", idFactura);
                int cantCarga = Convert.ToInt32(cmdCarga.ExecuteScalar());


                string queryDescarga = @"SELECT IFNULL((SELECT SUM(subTotal) as STDescarga
                                        FROM itemsFactura
                                        WHERE factura = @factura and carga = 'D'), 0) as totalDescarga";

                MySqlCommand cmdDescarga = new MySqlCommand(queryDescarga, MySQL.sqlcnx);
                cmdDescarga.Parameters.AddWithValue("@factura", idFactura);
                int cantDescarga = Convert.ToInt32(cmdDescarga.ExecuteScalar());

                string total = Convert.ToString(cantCarga - cantDescarga);

                return total;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string CalcularVentaRow(int facturaValue)
        {
            try
            {
                MySQL.ConnectDB();

                string queryCarga = @"SELECT IFNULL((SELECT SUM(subTotal) as STCarga
                                        FROM itemsFactura
                                        WHERE factura = @factura and carga = 'C'), 0) as totalCarga";

                MySqlCommand cmdCarga = new MySqlCommand(queryCarga, MySQL.sqlcnx);
                cmdCarga.Parameters.AddWithValue("@factura", facturaValue);
                int cantCarga = Convert.ToInt32(cmdCarga.ExecuteScalar());


                string queryDescarga = @"SELECT IFNULL((SELECT SUM(subTotal) as STDescarga
                                        FROM itemsFactura
                                        WHERE factura = @factura and carga = 'D'), 0) as totalDescarga";

                MySqlCommand cmdDescarga = new MySqlCommand(queryDescarga, MySQL.sqlcnx);
                cmdDescarga.Parameters.AddWithValue("@factura", facturaValue);
                int cantDescarga = Convert.ToInt32(cmdDescarga.ExecuteScalar());

                string total = Convert.ToString(cantCarga - cantDescarga);

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
