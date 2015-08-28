using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;

namespace RamosHermanos.Capas.Negocio
{
    class MarcaB
    {

        public static bool ExisteMarca(MarcaEntity marca)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Marcas
                             WHERE marca = @marca";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@marca", marca.marca);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;

        }

        public static MarcaEntity UpdateMarca(MarcaEntity marca)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Marcas
                                 SET marca = @marca, estado = @estado
                                 WHERE idMarca = @idMarca";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idMarca", marca.idMarca);
                cmd.Parameters.AddWithValue("@marca", marca.marca);
                cmd.Parameters.AddWithValue("@estado", marca.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Marca Actualizada!");
                return marca;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static MarcaEntity InsertMarca(MarcaEntity marca, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO Marcas (marca, estado) 
                                 VALUES (@marca, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@marca", marca.marca);
                cmd.Parameters.AddWithValue("@estado", marca.estado);

                marca.idMarca = Convert.ToInt32(cmd.ExecuteScalar());
                txt.Text = Convert.ToString(marca.idMarca);

                MessageBox.Show("Marca Cargada!");
                MySQL.DisconnectDB();

                return marca;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarDGV(DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT * FROM Marcas";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idMarca"]),
                    Convert.ToString(dr["marca"]),
                    Convert.ToString(dr["estado"]));
                }

                dr.Close();
                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarCB(ComboBox cb)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT * FROM Marcas";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                cb.DisplayMember = "marca";
                cb.ValueMember = "idMarca";
                cb.DataSource = dt;

                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
