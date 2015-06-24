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

                string query = @"INSERT INTO Insumos (rubro, proveedor, marca, insumo, descripcion, stockMin, estado) 
                                 VALUES (@rubro, @proveedor, @marca, @insumo, @descripcion, @stockMin, @estado);
                                 SELECT LAST_INSERT_ID()";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@rubro", insumo.rubro);
                cmd.Parameters.AddWithValue("@proveedor", insumo.proveedor);
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

                string query = @"INSERT INTO CostoInsumos (insumo, costo, fechaActualizacion) 
                                 VALUES (@insumo, @costo, @fechaActualizacion);
                                 SELECT LAST_INSERT_ID()";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@insumo", cinsumo.insumo );
                cmd.Parameters.AddWithValue("@costo", cinsumo.costo);
                cmd.Parameters.AddWithValue("@fechaActualizacion", cinsumo.fechaActualizacion);

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

                    string query = @"SELECT I.idInsumo, P.razonSocial, R.Rubro, I.Marca, I.Insumo, I.Descripcion, I.StockMin,                                        CI.FechaActualizacion, CI.Costo
                                     FROM Insumos I
                                     INNER JOIN Proveedores P ON P.idProveedor = I.Proveedor
                                     INNER JOIN Rubros R ON R.idRubro = I.Rubro
                                     INNER JOIN CostoInsumos CI ON CI.Insumo = I.idInsumo;";

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

            public static void MostrarCostoInsumo(DataGridView dgv, string insumo)
            {
                try
                {
                    DataTable dt = new DataTable();
                    MySQLDAL.CnxDB();

                    string query = @"SELECT *
                                     FROM CostoInsumos 
                                     WHERE Insumo = @Insumo
                                     ORDER BY idCostoInsumo DESC";

                    MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                    cmd.Parameters.AddWithValue("@Insumo", insumo);

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
