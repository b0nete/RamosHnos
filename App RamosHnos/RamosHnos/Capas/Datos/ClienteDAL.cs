using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace RamosHnos.Capas.Datos
{
    public class ClienteDAL
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
        public DataSet ds = new DataSet();



        //Métodos
        public void CnxDB() //Conectar con la DB.
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

        public void DcnxDB() //Desconectar con la DB.
        {
            sqlcnx.Close();
        }
    }
}
