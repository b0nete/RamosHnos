using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHnos;
using RamosHnos.Capas.Datos;
using RamosHnos.Capas.Entidades;



namespace RamosHnos.Capas.Negocio
{
    class TelefonoB
    {

        // Métodos

        public static TelefonoEntity InsertTelefono(TelefonoEntity telefono)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO telefonos (rol, idPersona, tipoTel, caracteristica, numTel) 
                                 VALUES (@rol, @idPersona, @tipoTel, @caracteristica, @numTel);
                                 SELECT LAST_INSERT_ID()";
                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@rol", telefono.rol);
                cmd.Parameters.AddWithValue("@idPersona", telefono.idPersona);
                cmd.Parameters.AddWithValue("@tipoTel", telefono.tipoTel);
                cmd.Parameters.AddWithValue("@caracteristica", telefono.caracteristica);
                cmd.Parameters.AddWithValue("@numTel", telefono.numTel);

                //cmd.ExecuteNonQuery();
                telefono.idTelefono = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Telefono Guardado!");
                MySQLDAL.DcnxDB();
                return telefono;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }                       
        }

        public static TipoTelEntity InsertTipoTel(TipoTelEntity tipotel)
        {
            try
            {
                MySQLDAL.CnxDB();
                string query = @"INSERT INTO TipoTelefono (tipoTel, estado)
                                 VALUES (@tipotel, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoTel", tipotel.tipoTel);
                cmd.Parameters.AddWithValue("@estado", tipotel.estado);

                tipotel.idTipoTel = Convert.ToInt32(cmd.ExecuteScalar());

                MySQLDAL.DcnxDB();
                MessageBox.Show("Tipo Telefono Guardado!");
                return tipotel;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        
        public static void CargarTipoTel(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();

                string query = "SELECT * FROM tipotelefono WHERE estado = '1'";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                cb.DisplayMember = "tipotel";
                cb.ValueMember = "idtipotel";
                cb.DataSource = dt;
                MySQLDAL.DcnxDB();                
            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex);
            }
        }

        public static void CargarTelefono(DataGridView dgv, TelefonoEntity telefono)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT C.idCliente, T.tipoTel, CONCAT (T.caracteristica, T.numtel) Telefono
                                 FROM Clientes C INNER JOIN Telefonos T ON C.idCliente = T.Cliente
                                 WHERE T.rol = '1' AND idPersona = @idPersona";

                
                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@idPersona", telefono.idPersona);

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

        public static void MostrarTelefono(DataGridView dgv, string persona)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT TT.TipoTel, CONCAT (T.caracteristica, T.numtel) Telefono
                                 FROM Telefonos T
                                 INNER JOIN TipoTelefono TT ON TT.idTipoTel = T.TipoTel
                                 INNER JOIN Clientes C ON C.idCliente = T.idPersona
                                 WHERE C.idCliente = @idPersona";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@idPersona", persona);

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

        public static DataTable ExisteTipoTel()
        {
            try
            {
                MySQLDAL.CnxDB();
                DataTable dt = new DataTable();

                string query = "SELECT * FROM tipoTelefono";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                MySQLDAL.DcnxDB();
                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void LlenarDGV(DataGridView dgv)
        {
            try
            {
                MySQLDAL.CnxDB();
                DataTable dt = new DataTable();

                string query = @"SELECT * FROM tipoTelefono";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

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
