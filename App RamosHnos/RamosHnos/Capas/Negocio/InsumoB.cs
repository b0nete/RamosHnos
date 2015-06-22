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
    class InsumoB
    {
        public static InsumoEntity InsertInsumo(InsumoEntity insumo)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO Insumos (rubro, marca, insumo, descripcion, stockMin, estado) 
                                 VALUES (@rubro, @marca, @insumo, @descripcion, @stockMin, @estado);
                                 SELECT LAST_INSERT_ID()";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@rubro", insumo.rubro);
                cmd.Parameters.AddWithValue("@marca", insumo.marca);
                cmd.Parameters.AddWithValue("@insumo", insumo.insumo);
                cmd.Parameters.AddWithValue("@descripcion", insumo.descripcion);
                cmd.Parameters.AddWithValue("@stockMin", insumo.stockMin);
                cmd.Parameters.AddWithValue("@estado", insumo.estado);


                //cmd.ExecuteNonQuery();
                insumo.idInsumo = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Insumo Guardado!");
                MySQLDAL.DcnxDB();

                return insumo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


            public static CostoInsumoEntity InsertCosto(CostoInsumoEntity cinsumo)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO CostoInsumos (insumo, costo, fechaActualizacion, estado) 
                                 VALUES (@insumo, @costo, @fechaActualizacion, @estado);
                                 SELECT LAST_INSERT_ID()";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@insumo", cinsumo.insumo );
                cmd.Parameters.AddWithValue("@costo", cinsumo.costo);
                cmd.Parameters.AddWithValue("@fechaActualizacion", cinsumo.fechaActualizacion);
                cmd.Parameters.AddWithValue("@estado", cinsumo.estado);

                cmd.ExecuteNonQuery();
                //insumo.idInsumo = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Costo Insumo Guardado!");
                MySQLDAL.DcnxDB();

                return cinsumo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

            public static void MostrarInsumos(DataGridView dgv)
            {
                try
                {
                    DataTable dt = new DataTable();
                    MySQLDAL.CnxDB();
                    
                    string query = @"SELECT *
                                     FROM Insumos";

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
    }
}
