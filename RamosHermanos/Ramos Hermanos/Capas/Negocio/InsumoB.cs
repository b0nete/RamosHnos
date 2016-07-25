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
    class InsumoB
    {
        //Metodos

        public static bool ExisteInsumo(InsumoEntity insumo)
        {

            MySQL.ConnectDB();

            string query = @"select count(*) from insumos
                             where insumo=@insumo";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

            cmd.Parameters.AddWithValue("@insumo", insumo.insumo);
       

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        
        }

        public static InsumoEntity BuscarInsumosID(InsumoEntity insumo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM insumos WHERE idInsumo=@idInsumo";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", insumo.idInsumo);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El insumo NO existe!");

                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    insumo.idInsumo = Convert.ToInt32(row["idInsumo"]);
                    insumo.estado = Convert.ToBoolean(row["estado"]);
                    insumo.descripcion = Convert.ToString(row["descripcion"]);
                    insumo.fecha = Convert.ToDateTime(row["fecha"]);
                    insumo.insumo = Convert.ToString(row["insumo"]);
                    insumo.marca = Convert.ToInt32(row["marca"]);
                    insumo.proveedor = Convert.ToInt32(row["proveedor"]);
                    insumo.rubro = Convert.ToString(row["rubro"]);
                    insumo.stockMin = Convert.ToString(row["stockMin"]);
                    insumo.medida = Convert.ToInt32(row["medida"]);
                    insumo.cantidad = Convert.ToDouble(row["cantidad"]);
                    insumo.tipoStock = Convert.ToString(row["tipoStock"]);

                    MySQL.DisconnectDB();
                }
                return insumo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static double BuscarConsumoMesActual(int idInsumo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM stockInsumosConsumo WHERE insumo = @idInsumo and mesAño like @mesAño";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", idInsumo);
                DateTime mesAño = DateTime.Now;      
                string mesAñoString = mesAño.ToString("yyyy-MM");
                string parametro = mesAñoString + "%";
                cmd.Parameters.AddWithValue("@mesAño", parametro);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                DataRow dr = dt.Rows[0];

                double retorno = Convert.ToDouble(dr["cantidad"]);

                return retorno;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static InsumoEntity BuscarInsumos(InsumoEntity insumo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM insumos WHERE insumo=@insumo";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@insumo", insumo.insumo);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El insumo NO existe!");

                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    insumo.idInsumo = Convert.ToInt32(row["idInsumo"]);
                    insumo.estado = Convert.ToBoolean(row["estado"]);
                    insumo.descripcion = Convert.ToString(row["descripcion"]);
                    insumo.fecha = Convert.ToDateTime(row["fecha"]);
                    insumo.insumo = Convert.ToString(row["insumo"]);
                    insumo.marca = Convert.ToInt32(row["marca"]);
                    insumo.proveedor = Convert.ToInt32(row["proveedor"]);
                    insumo.rubro = Convert.ToString(row["rubro"]);
                    insumo.stockMin = Convert.ToString(row["stockMin"]);
                    
                    MySQL.DisconnectDB();
                }
                return insumo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static bool ExisteInsumoID(InsumoEntity insumo)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Insumos
                             WHERE idInsumo = @idInsumo";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idInsumo", insumo.idInsumo);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static InsumoEntity UpdateInsumo(InsumoEntity insumo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE from insumos
                           SET fecha=@fecha, proveedor=@proveedor, rubro=@rubro, marca=@marca, insumo=@insumo, descripcion=@descripcion
                           stockmin=@stockmin, estado=@estado
                           where idinsumo=@idinsumo";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fecha", insumo.fecha);
                cmd.Parameters.AddWithValue("@proveedor", insumo.proveedor);
                cmd.Parameters.AddWithValue("@rubro", insumo.rubro);
                cmd.Parameters.AddWithValue("@marca", insumo.marca);
                cmd.Parameters.AddWithValue("@insumo", insumo.insumo);
                cmd.Parameters.AddWithValue("@descripcion", insumo.descripcion);
                cmd.Parameters.AddWithValue("@stockmin", insumo.stockMin);
                cmd.Parameters.AddWithValue("@estado", insumo.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Insumo Actualizado");

                return insumo;

            }

            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }

        }

        public static InsumoEntity InsertInsumo(InsumoEntity insumo, TextBox txtid)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"Insert into insumos (fecha, proveedor,rubro, marca, insumo, descripcion, stockMin, estado, medida, cantidad, tipoStock)
                                VALUES (@fecha, @proveedor,@rubro, @marca, @insumo, @descripcion, @stockMin, @estado, @medida, @cantidad, @tipoStock);
                                SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

               
                cmd.Parameters.AddWithValue("@fecha", insumo.fecha);
                cmd.Parameters.AddWithValue("@proveedor", insumo.proveedor);
                cmd.Parameters.AddWithValue("@rubro", insumo.rubro);
                cmd.Parameters.AddWithValue("@marca", insumo.marca);
                cmd.Parameters.AddWithValue("@insumo", insumo.insumo);
                cmd.Parameters.AddWithValue("@descripcion", insumo.descripcion);
                cmd.Parameters.AddWithValue("@stockMin", insumo.stockMin);
                cmd.Parameters.AddWithValue("@estado", insumo.estado);
                cmd.Parameters.AddWithValue("@medida", insumo.medida);
                cmd.Parameters.AddWithValue("@cantidad", insumo.cantidad);
                cmd.Parameters.AddWithValue("@tipoStock", insumo.tipoStock);

                txtid.Text = Convert.ToString(cmd.ExecuteScalar());

                MessageBox.Show("Guardado");

                return insumo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }

        public static void cargardgvInsumo(DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"Select I.idInsumo , I.insumo , I.fecha , I.estado, P.razonSocial ,I.StockMin, R.rubro, MM.marca, I.medida as idMedida, M.medida, I.cantidad
                                FROM insumos I
                                INNER JOIN proveedores P ON I.proveedor = P.idProveedor
                                INNER JOIN medidas M ON M.idMedida = I.medida
                                INNER JOIN Marcas MM ON MM.idMarca = I.Marca
                                INNER JOIN rubros R on I.rubro = R.idRubro ";
                                
;

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idInsumo"]),
                    Convert.ToString(dr["insumo"]),
                    Convert.ToString(dr["razonSocial"]),
                    Convert.ToString(dr["rubro"]),                   
                    Convert.ToString(dr["marca"]),
                    Convert.ToString(dr["fecha"]),
                    Convert.ToString(dr["estado"]),
                    Convert.ToString(dr["idMedida"]),
                    Convert.ToString(dr["medida"]),
                    Convert.ToString(dr["cantidad"]) 
                    );
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

        public static void CargarDGVParametros(DataGridView dgv, ComboBox cb, string parametro)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT I.idInsumo, I.insumo, P.razonSocial, I.marca, I.fecha, I.estado, R.rubro
                                 FROM insumos I
                                 INNER JOIN proveedores P on I.proveedor = P.idProveedor
                                 INNER JOIN rubros R on I.rubro = R.idRubro
                                 WHERE";
                //T.tipoproducto,
                //INNER JOIN tipoProducto T ON P.tipoProducto = T.idTipoProducto

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", parametro);
                cmd.Parameters.AddWithValue("@insumo", parametro);
                cmd.Parameters.AddWithValue("@proveedor", parametro);
                cmd.Parameters.AddWithValue("@marca", parametro);
                cmd.Parameters.AddWithValue("@rubro", parametro);
                cmd.Parameters.AddWithValue("@fecha", parametro);
                cmd.Parameters.AddWithValue("@estado", parametro);

                if (cb.SelectedIndex == 0)
                {
                    cmd.CommandText = query + " I.idInsumo LIKE @idInsumo";
                }

                if (cb.SelectedIndex == 1)
                {
                    cmd.CommandText = query + " I.insumo LIKE @insumo";
                }

                if (cb.SelectedIndex == 2)
                {
                    cmd.CommandText = query + " P.razonSocial LIKE @proveedor";
                }

                if (cb.SelectedIndex == 3)
                {
                    cmd.CommandText = query + " R.rubro LIKE @rubro";
                }

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idInsumo"]),
                    Convert.ToString(dr["insumo"]),
                    Convert.ToString(dr["razonSocial"]),
                    Convert.ToString(dr["rubro"]),
                    Convert.ToString(dr["marca"]),
                    Convert.ToString(dr["fecha"]),
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

        public static InsumoEntity AdddInsumoDGV(DataGridView dgv, InsumoEntity insumo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT I.idInsumo, I.insumo, I.marca, I.stockMin, P.idProveedor, R.rubro, R.idRubro
						    FROM insumos I
							INNER JOIN proveedores P on P.idProveedor = I.proveedor
							INNER JOIN rubros R on R.idRubro = I.rubro
						    WHERE I.idInsumo = @idInsumo";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", insumo.idInsumo);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idInsumo"]),
                    Convert.ToString(dr["Insumo"]),
                    Convert.ToString(dr["Rubro"]),
                    Convert.ToString(dr["Marca"]),
                    Convert.ToInt32(dr["idRubro"]),
                    Convert.ToString(null),
                    Convert.ToString(null),
                    Convert.ToString(null));
                }

                dr.Close();
                MySQL.DisconnectDB();

                return insumo;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string BuscarNombreInsumo(int idInsumo)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT CONCAT(I.insumo, ' (', I.cantidad, ' ', M.medida, ')')
                                FROM Insumos I
                                INNER JOIN Medidas M ON I.medida = M.idMedida
                                WHERE idInsumo = @idInsumo";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", idInsumo);

                string nombre = Convert.ToString(cmd.ExecuteScalar());

                return nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static double CalcularCU(int idInsumo, double cantidad)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT cantidad
                                FROM Insumos I
                                INNER JOIN Medidas M ON M.idMedida = I.medida
                                WHERE idInsumo = @idInsumo";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", idInsumo);

                int cantProd = Convert.ToInt32(cmd.ExecuteScalar());

                double var3 = cantProd;
                DataRow dr = PrecioInsumosB.UltimoPrecio(idInsumo);
                double var2 = Convert.ToDouble(dr["precio"]);
                double var1 = cantidad;

                double total = (var1 * var2) / var3;

                return total;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static DataTable BuscarInsumosRetornables(int idProducto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT IP.insumo, IP.cantidad
                                FROM itemsProducto IP
                                INNER JOIN Insumos I ON I.idInsumo = IP.insumo
                                WHERE producto = @idProducto and I.tipoStock = 'R'";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", idProducto);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                return dt;

                // MessageBox.Show("Cliente Actualizado!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

    }
}
