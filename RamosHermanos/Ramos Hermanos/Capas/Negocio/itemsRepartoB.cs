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

                DataTable dt = new DataTable();
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

                MySQL.DisconnectDB();
                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
