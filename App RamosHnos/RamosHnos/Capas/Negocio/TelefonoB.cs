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

                string query = @"INSERT INTO telefonos (cliente, tipoTel, caracteristica, numTel) 
                                 VALUES (@cliente, @tipoTel, @caracteristica, @numTel);
                                 SELECT LAST_INSERT_ID()";
                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                cmd.CommandText = query;
                                
                cmd.Parameters.AddWithValue("@cliente", telefono.cliente);
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

        
        public static void CargarTipoTel(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();

                string query = "SELECT * FROM tipotelefono";

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
                                 WHERE idCliente = @cliente";

                
                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@cliente", telefono.cliente);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                                
                da.Fill(dt);
                               
                dgv.DataSource = dt;
                                
                MySQLDAL.DcnxDB();
            }

            catch
            {
            }
        }

        
 



        
    }
}
