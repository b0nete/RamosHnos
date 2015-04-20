using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using connectDB;

namespace RamosHnos
{    
    class Cliente
    {
        //--
        // Atributos
        public int _idCliente { get; set; }
        public int _tipoDoc { get; set; }
        public string _numDoc { get; set; }
        public string _nombre { get; set; }
        public string _apellido { get; set; }
        public string _cuil { get; set; }
        public string _email { get; set; }
        

       
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

        public void insertCliente(string nombre, string apellido) //Guardar cliente en la DB.
        {
            string SQLtxt = "INSERT INTO Clientes as C, Domicilios as D (C.tipoDoc, C.numDoc, C.nombre, C.apellido, C.cuil, C.email, D.Provincia, D.Calle, D.Numero, D.Piso, D.Dpto, D.CP) VALUES ('" + _tipoDoc + "','" + _numDoc + "', '" + _nombre + "', '" + _apellido + "', '" + _cuil + "', '" + _email + "');";
            sqlcmd.CommandText = SQLtxt;
            sqlcmd.Connection = sqlcnx;
            sqlcmd.ExecuteNonQuery();
        }

        public void tipoDocDGV()
        {
            try
            {
                ds.Clear();
                string SQLtxt = "SELECT * FROM tipodocumento";
                sqlcmd.CommandText = SQLtxt;
                sqlcmd.Connection = sqlcnx;
                sqlda.SelectCommand = sqlcmd;
                sqlda.Fill(ds, "tipodocumento");
                //sqlcnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void cargarTipoDoc(ComboBox cb)
        {
            try
            {
                MySqlDataReader sqldr;
                //MySqlCommand sqlcmd2;
                //MySqlConnection sqlcnx2 = new MySqlConnection();
                //MySqlDataReader sqldr = new MySqlDataReader();
                sqlcnx = new MySqlConnection(cadenaConexion);
                sqlcnx.Open();
                sqlcmd = new MySqlCommand("SELECT * FROM tipoDocumento", sqlcnx);
                sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                {
                    cb.Items.Add(sqldr["tipoDoc"].ToString());                 
                }
                sqldr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }    

        //--
    }    
}
