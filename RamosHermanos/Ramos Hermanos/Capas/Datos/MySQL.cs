using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace RamosHermanos.Capas.Datos
{
    public class MySQL
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
        public static void ConnectDB() //Conectar con la DB.
        {
            try
            {
                DisconnectDB();
                sqlcnx.ConnectionString = cadenaConexion;
                sqlcnx.Open();
                //MessageBox.Show("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Conexíon: " + ex);
                throw;
            }
        }

        public static void DisconnectDB() //Desconectar con la DB.
        {
            sqlcnx.Close();
        }

        public static void GoExport()
        {
            string ruta = Application.StartupPath.Replace(@"\bin\Debug", "");   
            string rep = @"\Backup\";
            string constring = cadenaConexion;

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(ruta + rep + "backup.sql");
                        conn.Close();
                    }
                }
            }
            MessageBox.Show("Backup creado!");
        }

        public static void GoImport()
        {
            string ruta = Application.StartupPath.Replace(@"\bin\Debug", "");
            string rep = @"\Backup\";
            string constring = cadenaConexion;

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(ruta + rep + "backup.sql");
                        conn.Close();
                    }
                }
            }
            MessageBox.Show("Backup restaurado!");
        }
    }

