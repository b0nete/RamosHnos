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
    class SaldoB
    {

        public static SaldoEntity BuscarSaldo(SaldoEntity saldo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM saldos WHERE rol = @rol and idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", saldo.rol);
                cmd.Parameters.AddWithValue("@idPersona", saldo.idPersona);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    //MessageBox.Show("No hay saldo");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    saldo.creditoMax = Convert.ToDouble(row["creditoMax"]);
                    saldo.saldoActual = Convert.ToDouble(row["saldoActual"]);


                    MySQL.DisconnectDB();
                }
                return saldo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }

        
        }

        public static SaldoEntity InsertSaldo(SaldoEntity saldo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO saldos(rol, idPersona, creditoMax, saldoActual)
                                 VALUES (@rol, @idPersona, @creditoMax, @saldoActual);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", saldo.rol);
                cmd.Parameters.AddWithValue("@idPersona", saldo.idPersona);
                cmd.Parameters.AddWithValue("@creditoMax", saldo.creditoMax);
                cmd.Parameters.AddWithValue("@saldoActual", saldo.saldoActual);

                cmd.ExecuteNonQuery();
                          
                return saldo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }   
        }

        public static SaldoEntity UpdateSaldo(SaldoEntity saldo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE saldos
                                 SET creditoMax = @creditoMax, saldoActual = @saldoActual
                                 WHERE rol = @rol and idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", saldo.rol);
                cmd.Parameters.AddWithValue("@idPersona", saldo.idPersona);
                cmd.Parameters.AddWithValue("@creditoMax", saldo.creditoMax);
                cmd.Parameters.AddWithValue("@saldoActual", saldo.saldoActual);

                cmd.ExecuteNonQuery();

                return saldo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static String GenerarSaldo(int cliente)
        {
            try
            {
                MySQL.ConnectDB();

                //                string query = @"SELECT totalPagado.total1-totalPendiente.total2
                //                                FROM
                //                                (
                //                                SELECT SUM(total) as total1
                //                                FROM Facturas
                //                                WHERE estado = 'Pagado' and cliente = @cliente 
                //                                ) as TotalPagado,
                //                                (
                //                                SELECT SUM(total) as total2
                //                                FROM Facturas
                //                                WHERE estado = 'Pendiente' and cliente = @cliente
                //                                ) as TotalPendiente";

                string queryPagado = @"SELECT IFNULL((SELECT SUM(total) as total1
                                    FROM Facturas
                                    WHERE estado = 'Pagado' and cliente = @cliente), 0)";

                MySqlCommand cmdPagado = new MySqlCommand(queryPagado, MySQL.sqlcnx);
                cmdPagado.Parameters.AddWithValue("@cliente", cliente);
                double totalPagado = Convert.ToDouble(cmdPagado.ExecuteScalar());

                string queryPendiente = @"SELECT IFNULL((SELECT SUM(-total) as total2
                                        FROM Facturas
                                        WHERE estado = 'Pendiente' and cliente = @cliente), 0)";

                MySqlCommand cmdPendiente = new MySqlCommand(queryPendiente, MySQL.sqlcnx);
                cmdPendiente.Parameters.AddWithValue("@cliente", cliente);
                double totalPendiente = Convert.ToDouble(cmdPendiente.ExecuteScalar());

                double porcDescuento = tipoClienteB.BuscarCategoriaClientePorc1(cliente);

                string casiTotal = Convert.ToString(((totalPendiente) * porcDescuento) / 100);
                string total = Convert.ToString((totalPendiente) - Convert.ToDouble(casiTotal));

                //MySQL.DisconnectDB();

                //return total;

                //string totalDeuda = Convert.ToString(totalPendiente);

                return total;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

            public static String GenerarSaldodesdeTotalFinal(int cliente)
        {
            try
            {
                MySQL.ConnectDB();

//                string query = @"SELECT totalPagado.total1-totalPendiente.total2
//                                FROM
//                                (
//                                SELECT SUM(total) as total1
//                                FROM Facturas
//                                WHERE estado = 'Pagado' and cliente = @cliente 
//                                ) as TotalPagado,
//                                (
//                                SELECT SUM(total) as total2
//                                FROM Facturas
//                                WHERE estado = 'Pendiente' and cliente = @cliente
//                                ) as TotalPendiente";

                string queryPagado = @"SELECT IFNULL((SELECT SUM(totalDescuento) as total1
                                    FROM Facturas
                                    WHERE estado = 'Pagado' and cliente = @cliente), 0)";

                MySqlCommand cmdPagado = new MySqlCommand(queryPagado, MySQL.sqlcnx);
                cmdPagado.Parameters.AddWithValue("@cliente", cliente);
                double totalPagado = Convert.ToDouble(cmdPagado.ExecuteScalar());

                string queryPendiente = @"SELECT IFNULL((SELECT SUM(totalDescuento) as total2
                                        FROM Facturas
                                        WHERE estado = 'Pendiente' and cliente = @cliente), 0)";

                MySqlCommand cmdPendiente = new MySqlCommand(queryPendiente, MySQL.sqlcnx);
                cmdPendiente.Parameters.AddWithValue("@cliente", cliente);
                double totalPendiente = Convert.ToDouble(cmdPendiente.ExecuteScalar());
                
                string total = Convert.ToString((totalPendiente));

                //MySQL.DisconnectDB();

                //return total;

                //string totalDeuda = Convert.ToString(totalPendiente);

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

