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
    class MedidaB
    {
        public static MedidaEntity InsertMedida(MedidaEntity medida)
        {
            try
            {
                MySQLDAL.CnxDB();
                string query = "INSERT INTO medidas(medida, estado) VALUES (@medida,@estado); SELECT LAST_INSERT_ID()";
                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@medida", medida.medida);
                cmd.Parameters.AddWithValue("@estado", medida.estado);

                //cmd.ExecuteNonQuery();
                medida.idMedida = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("CARGADO");
                MySQLDAL.DcnxDB();
                return medida;

            }

            catch (Exception ex)
            {
                MessageBox.Show("error:" + ex);
                throw;
            }
        }

  
        public static void MostrarMedidaDGV(DataGridView dgv)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT *
                                 FROM Medidas ";


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

        public static void MostrarMedidasCB(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT *
                                 FROM Medidas ";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "Medida";
                cb.ValueMember = "idMedida";


                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static List<MedidaEntity> ObtenerMedidas(DataGridView dgv)
        {
            List<MedidaEntity> lista = new List<MedidaEntity>();
            {
                MySQLDAL.CnxDB();

                string query = @"SELECT *
                                 FROM Medida
                                 WHERE Estado = '1'";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                MySqlDataReader reader = cmd.ExecuteReader();

                DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                dgv.Columns.Add(column);
                DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
                dgv.Columns.Add(column2);

                
            }
            return lista;
        }

        

    }
}