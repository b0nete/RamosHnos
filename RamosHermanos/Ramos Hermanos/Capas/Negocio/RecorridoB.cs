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

namespace RamosHermanos.Capas.Negocio
{
    class RecorridoB
    {
        public static RecorridoEntity InsertRecorrido(RecorridoEntity recorrido, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Recorridos (distribuidor, dia)
                                 VALUES (@distribuidor, @dia);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("distribuidor", recorrido.distribuidor);
                cmd.Parameters.AddWithValue("@dia", recorrido.dia);

                txt.Text = Convert.ToString(cmd.ExecuteScalar());

                MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return recorrido;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static RecorridoEntity BuscarRecorrido(RecorridoEntity recorrido, TextBox txtIDrecorrido)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Recorridos WHERE distribuidor = @distribuidor and dia = @dia";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@distribuidor", recorrido.distribuidor);
                cmd.Parameters.AddWithValue("@dia", recorrido.dia);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    recorrido.idRecorrido = Convert.ToInt32(row["idRecorrido"]);
                    recorrido.distribuidor = Convert.ToInt32(row["distribuidor"]);
                    recorrido.dia = Convert.ToString(row["dia"]);

                    txtIDrecorrido.Text = Convert.ToString(recorrido.idRecorrido);

                    MySQL.DisconnectDB();
                }

                return recorrido;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
        
    }
}
