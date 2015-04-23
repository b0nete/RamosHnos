using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Datos;



namespace RamosHnos.Capas.Negocio
{
    class ClienteB
    {
        // Conexión
        static MySqlConnection sqlcnx = new MySqlConnection();
        static string server = "Server = localhost;";
        static string db = "Database = ramosdb;";
        static string usuario = "UID = root;";
        static string pw = "Password = adminroot;";
        public string cadenaConexion = server + db + usuario + pw;


        static MySqlCommand sqlcmd = new MySqlCommand();
        static MySqlDataAdapter sqlda = new MySqlDataAdapter();
        //static MySqlDataReader sqldr = new MySqlDataReader();
        //public DataSet ds = new DataSet();

       //Métodos
        public void CnxDB() //Conectar con la DB.
        {
            try
            {
                sqlcnx.ConnectionString = cadenaConexion;
                sqlcnx.Open();
                //MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception)
            {
                //MessageBox.Show("Error en la Conexion");
                throw;
            }
        }

        public void DcnxDB() //Desconectar con la DB.
        {
            sqlcnx.Close();
        }



        public static ClienteEntity InsertCliente(ClienteEntity cliente)            
        {
            try
            {
                string query = @"INSERT INTO Clientes (tipoDoc, numDoc, nombre, apellido, cuil, email) 
                                 VALUES (@tipoDoc, @numdoc, @nombre, @apellido, @cuil, @email)";
                MySqlCommand cmd = new MySqlCommand(query, sqlcnx);
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
                cmd.Parameters.AddWithValue("@email", cliente.email); 

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Guardado!");
                return cliente;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:"+ ex);
                throw;
            }
        }        
    }
}
