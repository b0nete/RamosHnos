using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Negocio
{
    class UsuarioB
    {
//        public static bool ExisteUsuario(ClienteEntity cliente)
//        {
//            MySQL.ConnectDB();

//            string query = @"SELECT COUNT(*) FROM Clientes
//                             WHERE numDoc = @numDoc";

//            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
//            cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

//            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

//            if (resultado == 0)
//                return false;
//            else
//                return true;
//        }

        public static bool VerificarUsuario(UsuarioEntity usuario)
        {
            MySQL.ConnectDB();

            string query = @"SELECT * 
                             FROM usuarios U
                             WHERE numDoc = @numDoc and password = @password";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

            cmd.Parameters.AddWithValue("@numDoc", usuario.numDoc);
            cmd.Parameters.AddWithValue("@password", usuario.password);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;

        }

        public static UsuarioEntity InsertUsuario(UsuarioEntity usuario)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Usuarios (privilegios, numDoc, apellido, nombre, fechaNacimiento, password, email, estado)
                                 VALUES (@privilegios, @numDoc, @apellido, @nombre, @fechaNacimiento, @password, @email, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@privilegios", usuario.privilegios);
                cmd.Parameters.AddWithValue("@numDoc", usuario.numDoc);
                cmd.Parameters.AddWithValue("@apellido", usuario.apellido);
                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("@fechaNacimiento", usuario.fechaNacimiento);
                cmd.Parameters.AddWithValue("@password", usuario.password);
                cmd.Parameters.AddWithValue("@email", usuario.email);
                cmd.Parameters.AddWithValue("@estado", usuario.estado);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();

                return usuario;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        
        public static string BuscarNomUsuario(int numDoc)
        {
            
            try
            {
                UsuarioEntity usuario = new UsuarioEntity();
                MySQL.ConnectDB();

                string query = @" Select CONCAT(apellido,', ' , nombre) 
                           from usuarios 
                           where numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@numDoc", numDoc);
                
                string nombre = Convert.ToString(cmd.ExecuteScalar());

                return nombre;

            }
            catch (Exception)
            {
                
                throw;
            }
        
        }
        
    }
}
