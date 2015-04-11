using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Windows.Forms;
using System.Data;

namespace connectDB
{
    class connectDB
    {
        // -------------------------------------------------------------

        static MySqlConnection sqlcnx = new MySqlConnection();
        static string server = "Server = localhost;";
        static string db = "Database = ramosdb;";
        static string usuario = "UID = root;";
        static string pw = "Password = adminroot;";
        string cadenaConexion = server + db + usuario + pw;


        static MySqlCommand sqlcmd = new MySqlCommand();
        static MySqlDataAdapter sqlda = new MySqlDataAdapter();
        public DataSet ds = new DataSet();

        public void CnxDB()
        {
            try
            {
                sqlcnx.ConnectionString = cadenaConexion;
                sqlcnx.Open();
                MessageBox.Show("Conexion Exitosa");                
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la Conexíon");
                throw;
            }
        }

        public void DcnxDB()
        {
            sqlcnx.Close();
        }
              
        
        // ---------------------------------------------------------------
    }
}
