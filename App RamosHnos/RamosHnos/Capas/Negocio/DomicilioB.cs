using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Datos;

namespace RamosHnos.Capas.Negocio
{
    class DomicilioB
    {
        //Metodos

        public static DomicilioEntity InsertDomicilio(DomicilioEntity domicilio)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO domicilios (cliente, provincia, localidad, calle, numero, piso, dpto, CP) 
                                 VALUES (@cliente, @provincia, @localidad, @calle, @numero, @piso, @dpto, @CP);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@cliente", domicilio.cliente);
                cmd.Parameters.AddWithValue("@provincia", domicilio.provincia);
                cmd.Parameters.AddWithValue("@localidad", domicilio.localidad);
                cmd.Parameters.AddWithValue("@calle", domicilio.calle);
                cmd.Parameters.AddWithValue("@numero", domicilio.numero);
                cmd.Parameters.AddWithValue("@piso", domicilio.piso);
                cmd.Parameters.AddWithValue("@dpto", domicilio.dpto);
                cmd.Parameters.AddWithValue("@CP", domicilio.CP);

                //cmd.ExecuteNonQuery();
                domicilio.idDomicilio = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Domicilio Guardado!");
                MySQLDAL.DcnxDB();
                return domicilio;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarDomicilio(DataGridView dgv, DomicilioEntity domicilio)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT P.Provincia, L.Localidad, D.Calle, D.Numero, D.Piso, D.Dpto, D.CP
                                 FROM Domicilios D 
                                 INNER JOIN Provincias P ON P.idProvincia = D.Provincia
                                 INNER JOIN Localidades L ON L.idLocalidad = D.Localidad
                                 WHERE Cliente = @cliente";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@cliente", domicilio.cliente);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgv.DataSource = dt;

                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarDomicilio2(DataGridView dgv, string cliente)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT P.Provincia, L.Localidad, D.Calle, D.Numero, D.Piso, D.Dpto, D.CP
                                 FROM Domicilios D 
                                 INNER JOIN Provincias P ON P.idProvincia = D.Provincia
                                 INNER JOIN Localidades L ON L.idLocalidad = D.Localidad
                                 WHERE Cliente = @cliente";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@cliente", cliente);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgv.DataSource = dt;

                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
        
    }
}
