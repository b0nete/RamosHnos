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
    class VisitaB
    {

//        public static VisitaEntity BuscarDistribuidorVisita(VisitaEntity visita, DataGridView dgv, string colDistribuidor)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = @"SELECT V.distribuidor, CONCAT(D.nombre,' ', D.apellido) as nombreCom
//FROM Visitas V
//INNER JOIN Distribuidores D ON V.distribuidor = D.idDistribuidor
//WHERE V.rol = 1 and V.idPersona = 4 and dia = 'LU'";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@rol", visita.rol);
//                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);
//                cmd.Parameters.AddWithValue("@dia", visita.dia);

//                MySqlDataReader dr = cmd.ExecuteReader();

//                DataGridViewComboBoxColumn comboboxColumn = dgv.Columns[colDistribuidor] as DataGridViewComboBoxColumn;

//                //int i = 0;

                

//                while (dr.Read())
//                {
//                    string nombreCom = Convert.ToString(dr["nombreCom"]);
//                //    foreach (DataGridViewRow row in dgv.Rows)
//                //    {
//                    comboboxColumn.DataPropertyName = nombreCom;
//                //    }
//                }


//                dr.Close();

//                MySQL.DisconnectDB();

//                return visita;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }

//        public static VisitaEntity BuscarIDVisita(VisitaEntity visita)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = @"SELECT idVisita
//                                 FROM Visitas V                                 
//                                 WHERE rol = @rol and idPersona = @idPersona";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@rol", visita.rol);
//                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);

//                DataTable dt = new DataTable();
//                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

//                da.Fill(dt);

//                DataRow row = dt.Rows[0];

//                visita.idVisita = Convert.ToInt32(row["idVisita"]);

//                MySQL.DisconnectDB();

//                return visita;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }


//        public static VisitaEntity InsertVisita(VisitaEntity visita, DataGridView dgv)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = @"INSERT INTO visitas (rol, idPersona, dia, domicilio, distribuidor, estado) 
//                                 VALUES (@rol, @idPersona, @dia, @domicilio, @distribuidor, @estado)";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                    cmd.Parameters.AddWithValue("@rol", visita.rol);
//                    cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);
//                    cmd.Parameters.AddWithValue("@dia", visita.dia);
//                    cmd.Parameters.AddWithValue("@domicilio", visita.domicilio);
//                    cmd.Parameters.AddWithValue("@distribuidor", visita.distribuidor);
//                    cmd.Parameters.AddWithValue("@estado", visita.estado);

//                    cmd.ExecuteNonQuery();

//                //MessageBox.Show("Visita Guardada!");
//                MySQL.DisconnectDB();

//                return visita;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }

        public static VisitaEntity BuscarVisita(int idCliente, int domicilio)
        {
            try
            {
                MySQL.ConnectDB();

                VisitaEntity visita = new VisitaEntity();

                string query = @"SELECT * FROM Visitas WHERE cliente = @idCliente and domicilio = @domicilio";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                cmd.Parameters.AddWithValue("@domicilio", domicilio);

                cmd.ExecuteNonQuery();

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    visita.lunes = Convert.ToBoolean(row["lunes"]);
                    visita.martes = Convert.ToBoolean(row["martes"]);
                    visita.miercoles = Convert.ToBoolean(row["miercoles"]);
                    visita.jueves = Convert.ToBoolean(row["jueves"]);
                    visita.viernes = Convert.ToBoolean(row["viernes"]);
                    visita.sabado = Convert.ToBoolean(row["sabado"]);
                }

                //MessageBox.Show("Visita Guardada!");
                MySQL.DisconnectDB();

                return visita;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static VisitaEntity InsertVisita(VisitaEntity visita)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO visitas (cliente, domicilio, lunes, martes, miercoles, jueves, viernes, sabado) 
                                 VALUES (@cliente, @domicilio, @lunes, @martes, @miercoles, @jueves, @viernes, @sabado)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@cliente", visita.cliente);
                cmd.Parameters.AddWithValue("@domicilio", visita.domicilio);
                cmd.Parameters.AddWithValue("@lunes", visita.lunes);
                cmd.Parameters.AddWithValue("@martes", visita.martes);
                cmd.Parameters.AddWithValue("@miercoles", visita.miercoles);
                cmd.Parameters.AddWithValue("@jueves", visita.jueves);
                cmd.Parameters.AddWithValue("@viernes", visita.viernes);
                cmd.Parameters.AddWithValue("@sabado", visita.sabado);

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Visita Guardada!");
                MySQL.DisconnectDB();

                return visita;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static VisitaEntity UpdateVisita(VisitaEntity visita)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SET @@sql_safe_updates = 0;
                                 UPDATE visitas 
                                 SET distribuidor = @distribuidor, domicilio = @domicilio, lunes = @lunes, martes = @martes, miercoles = @miercoles, jueves = @jueves, viernes = @viernes, sabado = @sabado
                                 WHERE cliente = @cliente and domicilio = @domicilio";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@cliente", visita.cliente);
                cmd.Parameters.AddWithValue("@domicilio", visita.domicilio);
                cmd.Parameters.AddWithValue("@distribuidor", visita.distribuidor);
                cmd.Parameters.AddWithValue("@lunes", visita.lunes);
                cmd.Parameters.AddWithValue("@martes", visita.martes);
                cmd.Parameters.AddWithValue("@miercoles", visita.miercoles);
                cmd.Parameters.AddWithValue("@jueves", visita.jueves);
                cmd.Parameters.AddWithValue("@viernes", visita.viernes);
                cmd.Parameters.AddWithValue("@sabado", visita.sabado);

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Visita Guardada!");
                MySQL.DisconnectDB();

                return visita;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

//        public static VisitaEntity UpdateVisita(VisitaEntity visita)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = @"UPDATE visitas 
//                                 SET horarioVisitaA = @horarioVisitaA, horarioVisitaB = @horarioVisitaB
//                                 WHERE rol = @rol and idPersona = @idPersona;";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@rol", visita.rol);
//                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);

//                visita.idVisita = Convert.ToInt32(cmd.ExecuteScalar());

//                //MessageBox.Show("Visita Guardada!");
//                MySQL.DisconnectDB();

//                return visita;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }

//        public static void DeleteVisita(VisitaEntity visita)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = @"DELETE FROM Visitas
//                                 WHERE idPersona = @idPersona";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);
                
//                cmd.ExecuteNonQuery();
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }

//        public static VisitaEntity GetListado(VisitaEntity visita)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = @"SELECT V.idPersona, V.domicilio
//                                 FROM Visitas V
//                                 INNER JOIN Domicilios D ON D.idDomicilio = V.domicilio
//                                 INNER JOIN Calles C ON D.calle = C.idCalle
//                                 INNER JOIN itemsRecorrido IR ON IR.calle = C.idCalle
//                                 WHERE V.dia = 'LU' and V.distribuidor = '1' and D.numero >= IR.desde and D.numero <= IR.hasta";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@rol", visita.rol);
//                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);

//                cmd.ExecuteNonQuery();

//                //MessageBox.Show("Visita Guardada!");
//                MySQL.DisconnectDB();

//                return visita;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }

//        public static VisitaEntity InsertVisitaCliente(VisitaEntity visitas)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = @"INSERT INTO visitas (idVisita, idPersona, dia, domicilio, distribuidor, estado) 
//                                 VALUES (@idVisita, @idPersona, @dia, @domicilio, @distribuidor, @estado)";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@idVisita", visitas.idVisita);
//                //cmd.Parameters.AddWithValue("@rol", visita.rol);
//                cmd.Parameters.AddWithValue("@idPersona", visitas.idPersona);
//                cmd.Parameters.AddWithValue("@dia", visitas.dia);
//                cmd.Parameters.AddWithValue("@domicilio", visitas.domicilio);
//                cmd.Parameters.AddWithValue("@distribuidor", visitas.distribuidor);
//                cmd.Parameters.AddWithValue("@estado", visitas.estado);

//                cmd.ExecuteNonQuery();

//                MessageBox.Show("Visita Guardada!");
//                MySQL.DisconnectDB();

//                return visitas;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }

//        public static VisitaEntity DeleteAllVisitaCliente(VisitaEntity visitas)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = @"DELETE from visitas (idVisita, idPersona, dia, domicilio, distribuidor, estado) 
//                                 VALUES (@idVisita, @idPersona, @dia, @domicilio, @distribuidor, @estado)";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@idVisita", visitas.idVisita);
//                //cmd.Parameters.AddWithValue("@rol", visita.rol);
//                cmd.Parameters.AddWithValue("@idPersona", visitas.idPersona);
//                cmd.Parameters.AddWithValue("@dia", visitas.dia);
//                cmd.Parameters.AddWithValue("@domicilio", visitas.domicilio);
//                cmd.Parameters.AddWithValue("@distribuidor", visitas.distribuidor);
//                cmd.Parameters.AddWithValue("@estado", visitas.estado);

//                cmd.ExecuteNonQuery();

//                MessageBox.Show("Visita Actualizada!");
//                MySQL.DisconnectDB();

//                return visitas;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }

    }
}
