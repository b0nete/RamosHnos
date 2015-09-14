using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Datos;

namespace RamosHermanos.Capas.Negocio
{
    class CostoB
    {
        
        public static CostoEntity InsertCosto(CostoEntity costo)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO costoInsumos (insumo, fechaActualizacion, costo, estado) 
                                 VALUES (@insumo, NOW(), @costo, 1)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@insumo", costo.insumo);
                cmd.Parameters.AddWithValue("@fechaActualizacion", costo.fechaActualizacion);;
                cmd.Parameters.AddWithValue("@costo", costo.costo);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();

                return costo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static CostoEntity UpdateCosto(CostoEntity costo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE costo
                                 SET costo = @costo, fechaActualizacion = @fechaActualizacion
                                 WHERE insumo= @insumo";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@insumo", costo.insumo);
                cmd.Parameters.AddWithValue("@precio", costo.costo);
                cmd.Parameters.AddWithValue("@fechaActualizacion", costo.fechaActualizacion);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Costo Actualizado!");
                return costo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static CostoEntity BuscarCosto(CostoEntity costo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM costoInsumos WHERE insumo = @insumo and estado = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@insumo", costo.insumo);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("No hay costo!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    costo.costo = Convert.ToDouble(row["costo"]);
                    costo.fechaActualizacion = Convert.ToDateTime(row["fechaActualizacion"]);

                    MySQL.DisconnectDB();
                }
                return costo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

    }
}
