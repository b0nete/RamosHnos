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
    public class MySQLDAL
    {
        // Conexión
        public static MySqlConnection sqlcnx = new MySqlConnection();
        public static MySqlCommand sqlcmd = new MySqlCommand();
        public static MySqlDataAdapter sqlda = new MySqlDataAdapter();
        //public static MySqlDataReader sqldr = new MySqlDataReader();
        public static DataSet ds = new DataSet();
        public static DataTable dt = new DataTable();

        static string server = "Server = localhost;";
        static string db = "Database = ramosdb;";
        static string usuario = "UID = root;";
        static string pw = "Password = adminroot;";
        static string cadenaConexion = server + db + usuario + pw;


        
        // Métodos
        public static void CnxDB() //Conectar con la DB.
        {
            try
            {                
                sqlcnx.ConnectionString = cadenaConexion;
                sqlcnx.Open();
                //MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Conexíon: "+ ex);
                throw;
            }
        }

        public static void DcnxDB() //Desconectar con la DB.
        {
            sqlcnx.Close();
        }
    }
}
