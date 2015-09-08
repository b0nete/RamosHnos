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
    class VehiculoB
    {
        public static bool ExisteVehiculo(VehiculoEntity vehiculo)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Vehiculos
                             WHERE patente = @patente";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@patente", vehiculo.patente);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static VehiculoEntity UpdateVehiculo(VehiculoEntity vehiculo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SET @@sql_safe_updates = 0; 
                                 UPDATE Vehiculos
                                 SET marca = @marca, modelo = @modelo, color = @color, estado = @estado
                                 WHERE idVehiculo = @idVehiculo;
                                 SET @@sql_safe_updates = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@marca", vehiculo.marca);
                cmd.Parameters.AddWithValue("@modelo", vehiculo.modelo);
                cmd.Parameters.AddWithValue("@color", vehiculo.color);
                cmd.Parameters.AddWithValue("@estado", vehiculo.estado);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Vehiculo Actualizado!");
                return vehiculo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static VehiculoEntity InsertVehiculo(VehiculoEntity Vehiculo, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO Vehiculos (marca, modelo, patente, color, estado) 
                                 VALUES (@marca, @modelo, @patente, @color, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@marca", Vehiculo.marca);
                cmd.Parameters.AddWithValue("@modelo", Vehiculo.modelo);
                cmd.Parameters.AddWithValue("@patente", Vehiculo.patente);
                cmd.Parameters.AddWithValue("@color", Vehiculo.color);
                cmd.Parameters.AddWithValue("@estado", Vehiculo.estado);

                Vehiculo.idVehiculo = Convert.ToInt32(cmd.ExecuteScalar());
                txt.Text = Convert.ToString(Vehiculo.idVehiculo);

                MessageBox.Show("Vehiculo Guardado!");
                MySQL.DisconnectDB();

                return Vehiculo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static VehiculoEntity BuscarVehiculoPatente(VehiculoEntity Vehiculo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Vehiculos WHERE patente = @patente";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@patente", Vehiculo.patente);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Vehiculo no existe!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    Vehiculo.idVehiculo = Convert.ToInt32(row["idVehiculo"]);
                    Vehiculo.marca = Convert.ToString(row["marca"]);
                    Vehiculo.modelo = Convert.ToString(row["modelo"]);
                    Vehiculo.patente = Convert.ToString(row["patente"]);
                    Vehiculo.color = Convert.ToString(row["color"]);
                    Vehiculo.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return Vehiculo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
