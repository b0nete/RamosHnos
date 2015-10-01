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

        public static VisitaEntity BuscarVisita(VisitaEntity visita)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT * 
                                 FROM Visitas V
                                 INNER JOIN Dias D ON V.idVisita = D.idDias
                                 INNER JOIN Orden O ON V.idVisita = O.idOrden
                                 WHERE rol = @rol and idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", visita.rol);
                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                DataRow row = dt.Rows[0];

                //visita.idVisita = Convert.ToInt32(row["idVisita"]);
                //visita.horarioVisitaA = Convert.ToString(row["horarioVisitaA"]);
                //visita.horarioVisitaB = Convert.ToString(row["horarioVisitaB"]);
                //// Dias
                //visita.dlunes = Convert.ToBoolean(row["dlunes"]);
                //visita.dmartes = Convert.ToBoolean(row["dmartes"]);
                //visita.dmiercoles = Convert.ToBoolean(row["dmiercoles"]);
                //visita.djueves = Convert.ToBoolean(row["djueves"]);
                //visita.dviernes = Convert.ToBoolean(row["dviernes"]);
                //visita.dsabado = Convert.ToBoolean(row["dsabado"]);
                //visita.ddomingo = Convert.ToBoolean(row["ddomingo"]);
                ////Orden
                //visita.olunes = Convert.ToInt32(row["olunes"]);
                //visita.omartes = Convert.ToInt32(row["omartes"]);
                //visita.omiercoles = Convert.ToInt32(row["omiercoles"]);
                //visita.ojueves = Convert.ToInt32(row["ojueves"]);
                //visita.oviernes = Convert.ToInt32(row["oviernes"]);
                //visita.osabado = Convert.ToInt32(row["osabado"]);
                //visita.odomingo = Convert.ToInt32(row["odomingo"]);

                MySQL.DisconnectDB();

                return visita;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

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


        public static VisitaEntity InsertVisita(VisitaEntity visita, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO visitas (rol, idPersona, dia, domicilio, distribuidor, estado) 
                                 VALUES (@rol, @idPersona, @dia, @domicilio, @distribuidor, @estado)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                    cmd.Parameters.AddWithValue("@rol", visita.rol);
                    cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);
                    cmd.Parameters.AddWithValue("@dia", visita.dia);
                    cmd.Parameters.AddWithValue("@domicilio", visita.domicilio);
                    cmd.Parameters.AddWithValue("@distribuidor", visita.distribuidor);
                    cmd.Parameters.AddWithValue("@estado", visita.estado);

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

                string query = @"UPDATE visitas 
                                 SET horarioVisitaA = @horarioVisitaA, horarioVisitaB = @horarioVisitaB
                                 WHERE rol = @rol and idPersona = @idPersona;";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", visita.rol);
                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);

                visita.idVisita = Convert.ToInt32(cmd.ExecuteScalar());

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

        public static void DeleteVisita(VisitaEntity visita)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"DELETE FROM Visitas
                                 WHERE rol = @rol and idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", visita.rol);
                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static VisitaEntity GetListado(VisitaEntity visita)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT V.idPersona, V.domicilio
FROM Visitas V
INNER JOIN Domicilios D ON D.idDomicilio = V.domicilio
INNER JOIN Calles C ON D.calle = C.idCalle
INNER JOIN itemsRecorrido IR ON IR.calle = C.idCalle
WHERE V.dia = 'LU' and V.distribuidor = '1' and D.numero >= IR.desde and D.numero <= IR.hasta";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", visita.rol);
                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);

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

    }
}
