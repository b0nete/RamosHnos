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
    class DistribuidoresB
    {
        public static bool ExisteDistribuidores(DistribuidoresEntity Distribuidores)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Distribuidoress
                             WHERE numDoc = @numDoc";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@numDoc", Distribuidores.numDoc);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static DistribuidoresEntity UpdateDistribuidores(DistribuidoresEntity Distribuidores)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SET @@sql_safe_updates = 0; 
                                 UPDATE Distribuidoress
                                 SET tipodoc = @tipoDoc, numdoc = @numDoc, fechaNacimiento = @fechaNacimiento, sexo = @sexo, cuil =  @cuil, nombre = @nombre, apellido = @apellido, estadoCivil = @estadoCivil, vehiculo = @vehiculo, estado = @estado
                                 WHERE numDoc = @numDoc;
                                 SET @@sql_safe_updates = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoDoc", Distribuidores.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", Distribuidores.numDoc);
                cmd.Parameters.AddWithValue("@fechaNacimiento", Distribuidores.fechaNacimiento);
                cmd.Parameters.AddWithValue("@sexo", Distribuidores.sexo);
                cmd.Parameters.AddWithValue("@cuil", Distribuidores.cuil);
                cmd.Parameters.AddWithValue("@apellido", Distribuidores.apellido);
                cmd.Parameters.AddWithValue("@nombre", Distribuidores.nombre);
                cmd.Parameters.AddWithValue("@estadoCivil", Distribuidores.estadoCivil);
                cmd.Parameters.AddWithValue("@vehiculo", Distribuidores.vehiculo);
                cmd.Parameters.AddWithValue("@estado", Distribuidores.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Distribuidor Actualizado!");
                return Distribuidores;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static DistribuidoresEntity InsertDistribuidores(DistribuidoresEntity Distribuidores, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO Distribuidoress (rol, fechaAlta, tipoDoc, numDoc, sexo, cuil, apellido, nombre, estadoCivil, condicionIVA, tipoDistribuidores, estado) 
                                 VALUES ('3', @fechaAlta, @tipoDoc, @numdoc, @fechaNacimiento, @sexo, @cuil, @apellido, @nombre, @estadoCivil, @vehiculo, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fechaAlta", Distribuidores.fechaAlta);
                cmd.Parameters.AddWithValue("@tipoDoc", Distribuidores.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", Distribuidores.numDoc);
                cmd.Parameters.AddWithValue("@numDoc", Distribuidores.fechaNacimiento);
                cmd.Parameters.AddWithValue("@sexo", Distribuidores.sexo);
                cmd.Parameters.AddWithValue("@cuil", Distribuidores.cuil);
                cmd.Parameters.AddWithValue("@apellido", Distribuidores.apellido);
                cmd.Parameters.AddWithValue("@nombre", Distribuidores.nombre);
                cmd.Parameters.AddWithValue("@estadoCivil", Distribuidores.estadoCivil);
                cmd.Parameters.AddWithValue("@tipoDistribuidores", Distribuidores.vehiculo);
                cmd.Parameters.AddWithValue("@estado", Distribuidores.estado);

                Distribuidores.idDistribuidor = Convert.ToInt32(cmd.ExecuteScalar());
                txt.Text = Convert.ToString(Distribuidores.idDistribuidor);

                MessageBox.Show("Distribuidor Guardado!");
                MySQL.DisconnectDB();

                return Distribuidores;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static DistribuidoresEntity BuscarDistribuidorDOC(DistribuidoresEntity Distribuidores)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Distribuidores WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@numDoc", Distribuidores.numDoc);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Distribuidor no existe!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    Distribuidores.idDistribuidor = Convert.ToInt32(row["idDistribuidores"]);
                    Distribuidores.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    Distribuidores.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                    Distribuidores.fechaNacimiento = Convert.ToDateTime(row["fechaNacimiento"]);
                    Distribuidores.sexo = Convert.ToString(row["sexo"]);
                    Distribuidores.cuil = Convert.ToString(row["cuil"]);
                    Distribuidores.apellido = Convert.ToString(row["apellido"]);
                    Distribuidores.nombre = Convert.ToString(row["nombre"]);
                    Distribuidores.estadoCivil = Convert.ToString(row["estadoCivil"]);
                    Distribuidores.vehiculo = Convert.ToInt32(row["vehiculo"]);
                    Distribuidores.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return Distribuidores;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
