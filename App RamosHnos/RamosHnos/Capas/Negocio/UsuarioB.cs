using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Datos;

namespace RamosHnos.Capas.Negocio

{
    class UsuarioB
    {
        public static UsuarioEntity InsertUsuario(UsuarioEntity usuario)
        {
            try
            {
                MySQLDAL.CnxDB();
                string query = "INSERT INTO usuarios(tipoDoc,numDoc,sexo,rol,nombre,apellido,cuil,email,estado)VALUES (@tipoDoc,@numDoc,@sexo,@rol,@nombre,@apellido,@cuil,@email,@estado); SELECT LAST_INSERT_ID()";
                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoDoc", usuario.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", usuario.numDoc);
                cmd.Parameters.AddWithValue("@sexo", usuario.sexo);
                cmd.Parameters.AddWithValue("@rol", usuario.rol);
                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.apellido);
                cmd.Parameters.AddWithValue("@cuil", usuario.cuil);
                cmd.Parameters.AddWithValue("@email", usuario.email);
                cmd.Parameters.AddWithValue("@estado", usuario.estado);

                //cmd.ExecuteNonQuery();
                usuario.idUsuario = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("CARGADO");
                MySQLDAL.DcnxDB();
                return usuario;
                
            }

                catch (Exception ex)                                      
            {
                MessageBox.Show("error:" + ex);
                throw;
            }                      
        }

        public static UsuarioEntity SearchUsuario(UsuarioEntity usuario)
        {
            try
            {       
                MySQLDAL.CnxDB();

                string query = "SELECT * FROM Usuarios WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@numDoc", usuario.numDoc);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                DataRow row = dt.Rows[0];

                usuario.idUsuario = Convert.ToInt32(row["idUsuario"]);
                usuario.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                usuario.nombre = Convert.ToString(row["nombre"]);
                usuario.apellido = Convert.ToString(row["apellido"]);
                usuario.cuil = Convert.ToString(row["cuil"]);
                usuario.email = Convert.ToString(row["email"]);

                //string idCliente = Convert.ToInt32(dt.Rows["idCliente"]);

                MySQLDAL.DcnxDB();
                return usuario;                                
            }

            catch (Exception ex)
            
            {
                MessageBox.Show("ERROR" + ex);
                throw;
                
            }
        }
    }
}
