using System;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace connectTest
{
    class connectDB
    {
        static MySqlConnection conex = new MySqlConnection();
        static string server = "Server=localhost;";
        static string db = "Database=ramosdb;";
        static string usuario = "UID=root;";
        static string pw = "Password = adminroot;";

        string cadenaConexion = server + db + usuario + pw;

        static MySqlCommand comando = new MySqlCommand();
        static MySqlDataAdapter adaptador = new MySqlDataAdapter();
        public DataSet ds = new DataSet();

        public void Conectar()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                //MessageBox.Show("DB conectada");
            }
            catch (Exception)
            {
                //MessageBox.Show("Error, DB no conectada");
                throw;
            }
        }

        public void Desconectar()
        {
            conex.Close();
        }

        // INSERTAR CLIENTE EN DB.
        public void insertCliente(string numDoc)
        {
            string SQLtxt = "INSERT INTO clientes (numDoc) VALUES ('" + numDoc + "');";
            comando.CommandText = SQLtxt;
            comando.Connection = conex;
            comando.ExecuteNonQuery();
        }

        // CARGAR DGV CON TIPO DE DOCUMENTOS.
        public void LlenarDGVDoc()
        {
            try
            {
                ds.Clear();
                string SQLtxt = "SELECT * FROM tipodocumento";
                comando.CommandText = SQLtxt;
                comando.Connection = conex;
                adaptador.SelectCommand = comando;
                adaptador.Fill(ds, "tipodocumento");
                conex.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }    

        

    
        // ---------------------------------------------------------------
    }
}
