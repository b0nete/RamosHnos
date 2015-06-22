using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Datos;
using RamosHnos.Capas.Interfaces;


namespace RamosHnos.Capas.Negocio
{
    class ClienteB
    {

       // -------------------------------------
       // Métodos

        public static ClienteEntity InsertCliente(ClienteEntity cliente)            
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO Clientes (rol, tipoDoc, numDoc, sexo, nombre, apellido, cuil, email, estado) 
                                 VALUES ('1', @tipoDoc, @numdoc, @sexo, @nombre, @apellido, @cuil, @email, '1');
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
                cmd.Parameters.AddWithValue("@email", cliente.email);

                
                //cmd.ExecuteNonQuery();
                cliente.idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                
                MessageBox.Show("Cliente Guardado!");
                MySQLDAL.DcnxDB();
                
                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex);
                throw;
            }
        }

        
        public static void ExisteDNI(ClienteEntity cliente)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"SELECT *
                                 FROM Clientes
                                 WHERE DNI = @DNI";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity BuscarCliente(ClienteEntity cliente)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = "SELECT * FROM Clientes WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                DataRow row = dt.Rows[0];

                cliente.idCliente = Convert.ToInt32(row["idCliente"]);
                cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                cliente.nombre = Convert.ToString(row["nombre"]);
                cliente.apellido = Convert.ToString(row["apellido"]);
                cliente.cuil = Convert.ToString(row["cuil"]);
                cliente.email = Convert.ToString(row["email"]);

                //string idCliente = Convert.ToInt32(dt.Rows["idCliente"]);

                MySQLDAL.DcnxDB();
                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }        

        public static void CargarDomicilioCliente(DataGridView dgv, string persona)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT P.Provincia, P.idProvincia, L.Localidad, L.idLocalidad, D.Calle, D.Numero, D.Piso, D.Dpto, D.CP
                                 FROM Domicilios D 
                                 INNER JOIN Provincias P ON P.idProvincia = D.Provincia
                                 INNER JOIN Localidades L ON L.idLocalidad = D.Localidad
                                 WHERE D.rol = '1' AND idPersona = @idPersona";


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

        public static void BuscarClienteID(string cliente)
        {
            try
            {
                MySQLDAL.CnxDB();
                DataTable dt = new DataTable();

                string query = @"SELECT CONCAT (nombre,' ',apellido) FROM Clientes WHERE idCliente = @cliente)";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("cliente", cliente);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                MySQLDAL.DcnxDB();                    
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity EditCliente(ClienteEntity cliente)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"UPDATE Clientes
                                 SET tipodoc = @tipoDoc, numdoc = @numDoc, nombre = @nombre, apellido = @apellido, cuil =  @cuil, email = @email
                                 WHERE idCliente = @idCliente";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Modificado!");
                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity DisableCliente(ClienteEntity cliente)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"UPDATE Clientes
                                 SET estado = '0'
                                 WHERE idCliente = @idCliente";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Cliente Desabilitado!");
                MySQLDAL.DcnxDB();

                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void ListarClientes(DataGridView dgv)
        {
            try
            {
                MySQLDAL.CnxDB();
                DataTable dt = new DataTable();
                

                string query = "SELECT * FROM Clientes";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgv.DataSource = dt;             

                cmd.ExecuteNonQuery();
                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }






    



        // ------------------------------------     

    }
}
