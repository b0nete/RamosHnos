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

                string query = @"INSERT INTO itemsReparto (reparto, cliente, domicilio, idComprobante) 
                                 VALUES (@reparto, @cliente, @domicilio, @idComprobante);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@reparto", itemReparto.reparto);
                cmd.Parameters.AddWithValue("@cliente", itemReparto.cliente);
                cmd.Parameters.AddWithValue("@domicilio", itemReparto.domicilio);
                cmd.Parameters.AddWithValue("@idComprobante", itemReparto.idComprobante);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Guardado!");
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

        public static DataTable BuscarItemsReparto(itemsRepartoEntity itemsReparto)
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
                DataTable dtCargas = new DataTable();

                //Encabezado
                string query = @"SELECT IR.cliente as idCliente, CONCAT(C.nombre, ' ', C.apellido) as clienteCompleto, IR.domicilio as idDomicilio, CONCAT(CC.Calle,' ',D.Numero,' PISO: ',D.Piso,', DPTO: ',D.Dpto) as domicilioCompleto, idComprobante
                                 FROM itemsReparto IR
                                 INNER JOIN Clientes C ON C.idCliente = IR.cliente
                                 INNER JOIN Domicilios D ON D.idDomicilio = IR.domicilio
                                 INNER JOIN Calles CC ON D.Calle = CC.idCalle
                                 WHERE reparto = @reparto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@reparto", itemsReparto.reparto);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dtEncabezado);

                //Cargas
                string queryCargas = @"SELECT SUM(cantidad) as colACarga
                                       FROM itemsFactura
                                       WHERE factura = 1 and carga = 'D'";

                MySqlCommand cmd2 = new MySqlCommand(queryCargas, MySQL.sqlcnx);

                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
                da2.Fill(dtCargas);

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

                for (int i = 0; i <= dtCargas.Rows.Count - 1; i++)
                {
                    DataRow rowMerge = dtMerge.Rows[i];
                    DataRow roworigen = dtCargas.Rows[i];

                    rowMerge["colACarga"] = roworigen["colACarga"];
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
    }
}
