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
    class DomicilioB
    {
        //Metodos

        public static bool ExisteDomicilio(DomicilioEntity domicilio)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Domicilios
                             WHERE idDomicilio = @idDomicilio";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idDomicilio", domicilio.idDomicilio);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;

        }

        public static DomicilioEntity UpdateDomicilio(DomicilioEntity domicilio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Domicilios
                                 SET provincia = @provincia, localidad = @localidad, barrio = @barrio, calle = @calle, numero = @numero, piso = @piso, dpto = @dpto, CP = @CP
                                 WHERE idDomicilio = @idDomicilio";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idDomicilio", domicilio.idDomicilio);
                cmd.Parameters.AddWithValue("@provincia", domicilio.provincia);
                cmd.Parameters.AddWithValue("@localidad", domicilio.localidad);
                cmd.Parameters.AddWithValue("@barrio", domicilio.barrio);
                cmd.Parameters.AddWithValue("@calle", domicilio.calle);
                cmd.Parameters.AddWithValue("@numero", domicilio.numero);
                cmd.Parameters.AddWithValue("@piso", domicilio.piso);
                cmd.Parameters.AddWithValue("@dpto", domicilio.dpto);
                cmd.Parameters.AddWithValue("@CP", domicilio.CP);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Domicilio Actualizado!");
                return domicilio;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static DomicilioEntity InsertDomicilio(DomicilioEntity domicilio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO domicilios (rol, idPersona, provincia, localidad, barrio, calle, numero, piso, dpto, CP, estado) 
                                 VALUES (@rol, @idPersona, @provincia, @localidad, @barrio, @calle, @numero, @piso, @dpto, @CP, @estado);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@rol", domicilio.rol);
                cmd.Parameters.AddWithValue("@idPersona", domicilio.idPersona);
                cmd.Parameters.AddWithValue("@provincia", domicilio.provincia);
                cmd.Parameters.AddWithValue("@localidad", domicilio.localidad);
                cmd.Parameters.AddWithValue("@barrio", domicilio.barrio);
                cmd.Parameters.AddWithValue("@calle", domicilio.calle);
                cmd.Parameters.AddWithValue("@numero", domicilio.numero);
                cmd.Parameters.AddWithValue("@piso", domicilio.piso);
                cmd.Parameters.AddWithValue("@dpto", domicilio.dpto);
                cmd.Parameters.AddWithValue("@CP", domicilio.CP);
                cmd.Parameters.AddWithValue("@estado", domicilio.estado);

                //cmd.ExecuteNonQuery();
                domicilio.idDomicilio = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Domicilio Guardado!");
                MySQL.DisconnectDB();
                return domicilio;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarDGV(DataGridView dgv, ComboBox cb, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT D.idDomicilio, C.Calle, D.Numero, D.Piso, D.Dpto, D.CP, B.Barrio, L.Localidad, P.Provincia, D.Estado
                                 FROM Domicilios D 
                                 INNER JOIN Provincias P ON P.idProvincia = D.Provincia
                                 INNER JOIN Localidades L ON L.idLocalidad = D.Localidad
                                 INNER JOIN Barrios B ON D.Barrio = B.idBarrio
                                 INNER JOIN Calles C ON D.Calle = C.idCalle
                                 WHERE rol = @rol and idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", cb.SelectedValue);
                cmd.Parameters.AddWithValue("@idPersona", txt.Text);

                MySqlDataReader dr = cmd.ExecuteReader();                

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idDomicilio"]),
                    Convert.ToString(dr["Calle"]),
                    Convert.ToString(dr["Numero"]),
                    Convert.ToString(dr["Piso"]),
                    Convert.ToString(dr["Dpto"]),
                    Convert.ToString(dr["CP"]),
                    Convert.ToString(dr["Barrio"]),
                    Convert.ToString(dr["Localidad"]),
                    Convert.ToString(dr["Provincia"]),
                    Convert.ToString(dr["Estado"]));
                }

                dr.Close();
                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static void CargarDGVVisita(DataGridView dgv, DomicilioEntity domicilio)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT D.idPersona, D.idDomicilio, CONCAT(C.Calle,' ',D.Numero,' ',D.Piso,' ',D.Dpto,' - ',D.CP,' - ',B.Barrio,', ',L.Localidad,', ',P.Provincia) domCompleto
                                 FROM Domicilios D
                                 INNER JOIN Provincias P ON P.idProvincia = D.Provincia
                                 INNER JOIN Localidades L ON L.idLocalidad = D.Localidad
                                 INNER JOIN Barrios B ON D.Barrio = B.idBarrio
                                 INNER JOIN Calles C ON C.idCalle = D.Calle
                                 WHERE D.rol = @rol and D.idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", domicilio.rol);
                cmd.Parameters.AddWithValue("@idPersona", domicilio.idPersona);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idPersona"]),
                    Convert.ToString(dr["idDomicilio"]),
                    Convert.ToString(dr["domCompleto"]));
                }

                dr.Close();
                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarCB(ComboBox cb, TextBox txt, string rol)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT D.idDomicilio, CONCAT(D.idDomicilio,' ',D.Calle,' ',D.Numero,' ',D.Piso,' ',D.Dpto,' - ',D.CP,' - ',B.Barrio,', ',L.Localidad,', ',P.Provincia) domCompleto
                                 FROM Domicilios D 
                                 INNER JOIN Provincias P ON P.idProvincia = D.Provincia
                                 INNER JOIN Localidades L ON L.idLocalidad = D.Localidad
                                 INNER JOIN Barrios B ON D.Barrio = B.idBarrio
                                 WHERE rol = @rol and idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@idPersona", txt.Text);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                cb.DataSource = dt;
                cb.ValueMember = "idDomicilio";
                cb.DisplayMember = "domCompleto";
                

                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarTXT(TextBox txt, TextBox txt2, int rol)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT group_concat(' ', B.barrio,' ', calle,' ', numero,' ', piso,' ', dpto,' ', CP) 
                                 FROM Domicilios D
                                 INNER JOIN Barrios B ON D.barrio = B.idBarrio
                                 WHERE rol = @rol and idPersona = @idPersona and D.estado = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@idPersona", txt2.Text);

                txt.Text = Convert.ToString(cmd.ExecuteScalar());

                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string CargarTXTSTRING(TextBox txtID, int rol)
        {
            try
            {
                MySQL.ConnectDB();
                string query = @"SELECT group_concat(' ', B.barrio,' ', calle,' ', numero,' ', piso,' ', dpto,' ', CP) 
                                 FROM Domicilios D
                                 INNER JOIN Barrios B ON D.barrio = B.idBarrio
                                 WHERE rol = @rol and idPersona = @idPersona and D.estado = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", rol);
                cmd.Parameters.AddWithValue("@idPersona", txtID.Text);

               string retornar = Convert.ToString(cmd.ExecuteScalar());

                MySQL.DisconnectDB();
                return retornar;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarTXTID(int idDomicilio, TextBox txtDomicilio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT D.idDomicilio, CONCAT(D.idDomicilio,' ',D.Calle,' ',D.Numero,' ',IFNULL(D.Piso, '-'),' ',IFNULL(D.Dpto, '-'),' - ',IFNULL(D.CP, '-'),' - ',B.Barrio,', ',L.Localidad,', ',P.Provincia) domCompleto
                                 FROM Domicilios D 
                                 INNER JOIN Provincias P ON P.idProvincia = D.Provincia
                                 INNER JOIN Localidades L ON L.idLocalidad = D.Localidad
                                 INNER JOIN Barrios B ON D.Barrio = B.idBarrio
                                 WHERE D.idDomicilio = @idDomicilio";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idDomicilio", idDomicilio);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                DataRow row = dt.Rows[0];

                txtDomicilio.Text = Convert.ToString(row["domCompleto"]);

                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static List<DomicilioEntity> ListDomicilios(DomicilioEntity domicilio)
        {
            try
            {
                MySQL.ConnectDB();

                List<DomicilioEntity> list = new List<DomicilioEntity>();

                string query = @"SELECT D.idPersona, D.idDomicilio, CONCAT(C.Calle,' ',D.Numero,' ',D.Piso,' ',D.Dpto,' - ',D.CP,' - ',B.Barrio,', ',L.Localidad,', ',P.Provincia) domCompleto
                                 FROM Domicilios D
                                 INNER JOIN Provincias P ON P.idProvincia = D.Provincia
                                 INNER JOIN Localidades L ON L.idLocalidad = D.Localidad
                                 INNER JOIN Barrios B ON D.Barrio = B.idBarrio
                                 INNER JOIN Calles C ON C.idCalle = D.Calle
                                 WHERE D.rol = @rol and D.idPersona = @idPersona";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", domicilio.rol);
                cmd.Parameters.AddWithValue("@idPersona", domicilio.idPersona);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(LoadDomicilio(dr));
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        private static DomicilioEntity LoadDomicilio(IDataReader dr)
        {
            DomicilioEntity domicilio = new DomicilioEntity();

            domicilio.idPersona = Convert.ToInt32(dr["idPersona"]);
            domicilio.idDomicilio = Convert.ToInt32(dr["idDomicilio"]);
            domicilio.domCompleto = Convert.ToString(dr["domCompleto"]);

            return domicilio;
        }
    }
}
