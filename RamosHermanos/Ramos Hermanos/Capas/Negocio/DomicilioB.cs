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

        public static DomicilioEntity InsertDomicilio(DomicilioEntity domicilio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO domicilios (rol, idPersona, provincia, localidad, barrio, calle, numero, piso, dpto, CP) 
                                 VALUES (@rol, @idPersona, @provincia, @localidad, @barrio, @calle, @numero, @piso, @dpto, @CP);
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

                string query = @"SELECT D.idDomicilio, D.Calle, D.Numero, D.Piso, D.Dpto, D.CP, B.Barrio, L.Localidad, P.Provincia
                                 FROM Domicilios D 
                                 INNER JOIN Provincias P ON P.idProvincia = D.Provincia
                                 INNER JOIN Localidades L ON L.idLocalidad = D.Localidad
                                 INNER JOIN Barrios B ON D.Barrio = B.idBarrio
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
                    Convert.ToString(dr["Provincia"]));
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

        public static void CargarTXT(TextBox txt, TextBox txt2, int rol)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT group_concat(' ', B.barrio,' ', calle,' ', numero,' ', piso,' ', dpto,' ', CP) 
                                 FROM Domicilios D
                                 INNER JOIN Barrios B ON D.barrio = B.idBarrio
                                 WHERE rol = @rol and idPersona = @idPersona";

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
        
    }
}
