using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace RamosHnos
{
    class Producto
    {
        //--
        // Atributos
        public int _idProducto { get; set; }
        public int _nombreProducto { get; set; }
        public string _tipoProducto { get; set; }
        public string _medida { get; set; }



        // Conexión
        static MySqlConnection sqlcnx = new MySqlConnection();
        static string server = "Server = localhost;";
        static string db = "Database = ramosdb;";
        static string usuario = "UID = root;";
        static string pw = "Password = adminroot;";
        string cadenaConexion = server + db + usuario + pw;

        
        static MySqlCommand sqlcmd = new MySqlCommand();
        static MySqlDataAdapter sqlda = new MySqlDataAdapter();
        //static MySqlDataReader sqldr = new MySqlDataReader();
        public DataSet ds = new DataSet();


        
        //Métodos

        //--
    }
}
