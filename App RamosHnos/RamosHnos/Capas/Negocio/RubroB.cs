using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Datos;

namespace RamosHnos.Capas.Negocio
{
    class RubroB
    {

        public static RubroEntity InsertRubro(RubroEntity rubro)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO Rubros (rubro, estado) 
                                 VALUES (@rubro, @estado);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@rubro", rubro.rubro);
                cmd.Parameters.AddWithValue("@estado", rubro.estado);

                cmd.ExecuteNonQuery();
                //rubro.idRubro = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Rubro Guardado!");
                MySQLDAL.DcnxDB();

                return rubro;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void MostrarRubroDGV(DataGridView dgv)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT *
                                 FROM Rubros ";


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

        public static void MostrarRubroCB(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT *
                                 FROM Rubros ";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "Rubro";
                cb.ValueMember = "idRubro";


                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static List<RubroEntity> ObtenerRubros(DataGridView dgv)
        {
            List<RubroEntity> lista = new List<RubroEntity>();
            {
                MySQLDAL.CnxDB();

                string query = @"SELECT *
                                 FROM Rubros
                                 WHERE Estado = '1'";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                MySqlDataReader reader = cmd.ExecuteReader();

                DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                dgv.Columns.Add(column);
                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                dgv.Columns.Add(column2);

                while (reader.Read())
                {                    
                    lista.Add(ConvertirRubro(reader));
                }
            }
            return lista;
        }

        private static RubroEntity ConvertirRubro(IDataReader reader)
        {
            RubroEntity rubro = new RubroEntity();

            rubro.idRubro = Convert.ToInt32(reader["idRubro"]);
            rubro.rubro = Convert.ToString(reader["Rubro"]);
            rubro.estado = Convert.ToInt32(reader["Estado"]);

            return rubro;
        }


    }
}
