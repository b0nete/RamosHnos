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
    class RolB
    {
        public static RolEntity InsertRol(RolEntity rol)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO Roles (rol, estado) 
                                 VALUES (@rol, @estado);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@rol", rol.rol);
                cmd.Parameters.AddWithValue("@estado", rol.estado);
                
                //cmd.ExecuteNonQuery();
                rol.idRol = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Rol Guardado!");
                MySQLDAL.DcnxDB();

                return rol;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void MostrarRolesDGV(DataGridView dgv)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();

                string query = @"SELECT rol, estado
                                 FROM Roles ";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgv.DataSource = dt;

                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void MostrarRolesCB(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();

                string query = @"SELECT idRol, rol
                                 FROM Roles
                                 WHERE estado = '1'";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                cb.DisplayMember = "rol";
                cb.ValueMember = "idRol";
                cb.DataSource = dt;

                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
