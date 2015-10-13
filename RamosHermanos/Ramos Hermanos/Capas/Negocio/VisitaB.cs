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

        public static VisitaEntity BuscarDistribuidorVisita(VisitaEntity visita, DataGridView dgv, string colDistribuidor)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT V.distribuidor, CONCAT(D.nombre,' ', D.apellido) as nombreCom
FROM Visitas V
INNER JOIN Distribuidores D ON V.distribuidor = D.idDistribuidor
WHERE V.rol = 1 and V.idPersona = 4 and dia = 'LU'";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", visita.rol);
                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);
                cmd.Parameters.AddWithValue("@dia", visita.dia);

                MySqlDataReader dr = cmd.ExecuteReader();

                DataGridViewComboBoxColumn comboboxColumn = dgv.Columns[colDistribuidor] as DataGridViewComboBoxColumn;

                //int i = 0;

                

                while (dr.Read())
                {
                    string nombreCom = Convert.ToString(dr["nombreCom"]);
                //    foreach (DataGridViewRow row in dgv.Rows)
                //    {
                    comboboxColumn.DataPropertyName = nombreCom;
                //    }
                }


                dr.Close();

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
