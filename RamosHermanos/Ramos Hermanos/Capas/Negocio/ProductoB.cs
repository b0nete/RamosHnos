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
    class ProductoB
    {

        public static bool ExisteProducto(ProductoEntity producto)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Productos
                             WHERE rubro = @rubro and marca = @marca and cantidad = @cantidad and medida = @medida";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@rubro", producto.tipoProducto);
            cmd.Parameters.AddWithValue("@marca", producto.marca);
            cmd.Parameters.AddWithValue("@cantidad", producto.cantidad);
            cmd.Parameters.AddWithValue("@medida", producto.medida);

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

        public static bool ExisteProductoID(ProductoEntity producto)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Productos
                             WHERE idProducto = @idProducto";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);

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

        public static ProductoEntity UpdateProducto(ProductoEntity prod)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE productos
                                 SET tipoProducto = @tipoProducto, marca = @marca, producto = @producto, descripcion = @descripcion, cantidad = @cantidad, medida = @medida, estado = @estado
                                 WHERE idProducto = @idProducto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", prod.idProducto);
                cmd.Parameters.AddWithValue("@tipoProducto", prod.tipoProducto);
                cmd.Parameters.AddWithValue("@marca", prod.marca);
                cmd.Parameters.AddWithValue("@producto", prod.producto);
                cmd.Parameters.AddWithValue("@descripcion", prod.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", prod.cantidad);
                cmd.Parameters.AddWithValue("@medida", prod.medida);
                cmd.Parameters.AddWithValue("@estado", prod.estado);
                
                cmd.ExecuteNonQuery();
                                
                MessageBox.Show("Producto Actualizado!");
                return prod;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static ProductoEntity InsertProducto(ProductoEntity producto, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO Productos(fechaAlta, rubro, marca, producto, descripcion, cantidad, medida, estado)
                                 VALUES (@fechaAlta, @rubro, @marca, @producto, @descripcion, @cantidad, @medida, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fechaAlta", producto.fechaAlta);
                cmd.Parameters.AddWithValue("@rubro", producto.tipoProducto);
                cmd.Parameters.AddWithValue("@marca", producto.marca);
                cmd.Parameters.AddWithValue("@producto", producto.producto);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", producto.cantidad);
                cmd.Parameters.AddWithValue("@medida", producto.medida);
                cmd.Parameters.AddWithValue("@estado", producto.estado);

                producto.idProducto = Convert.ToInt32(cmd.ExecuteScalar());
                txt.Text = Convert.ToString(producto.idProducto);

                MessageBox.Show("Producto Guardado!");
                MySQL.DisconnectDB();

                return producto;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ProductoEntity BuscarIdProducto(ProductoEntity producto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM productos WHERE idProducto = @idProducto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Producto Existe");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];
                    producto.idProducto = Convert.ToInt32(row["idProducto"]);
                    producto.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    producto.tipoProducto = Convert.ToInt32(row["rubro"]);
                    producto.marca = Convert.ToInt32(row["marca"]); 
                    producto.producto = Convert.ToString(row["producto"]);
                    producto.descripcion = Convert.ToString(row["descripcion"]);
                    producto.cantidad = Convert.ToDouble(row["cantidad"]);
                    producto.medida = Convert.ToInt32(row["medida"]);
                   

                    MySQL.DisconnectDB();
                }
                return producto;
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

                string query = @"SELECT idProducto, M.marca, P.producto, cantidad, MM.medida
                                 FROM Productos P
                                 INNER JOIN Marcas M ON M.idMarca = P.Marca
                                 INNER JOIN Medidas MM ON MM.idMedida = P.Medida
                                 WHERE P.estado = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idProducto"]),
                    Convert.ToString(dr["marca"]),
                    Convert.ToString(dr["producto"]),
                    Convert.ToString(dr["cantidad"]),
                    Convert.ToString(dr["medida"]));
                                        
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

        public static void CargarRubros(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = @"SELECT * FROM rubrosProductos 
                                 WHERE idRubroFK IS NULL";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                  da.Fill(dt);

                  cb.DataSource = dt;
                  cb.DisplayMember = "rubro";
                  cb.ValueMember = "idRubro";

                  MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        public static void CargarSubRubros(ComboBox cb, ComboBox cb2)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = @"SELECT * FROM rubrosProductos 
                                 WHERE idRubroFK = @rubro";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                  cmd.Parameters.AddWithValue("@rubro", cb2.SelectedValue);

                  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                  da.Fill(dt);

                  int rows = dt.Rows.Count;

                  if (rows > 0)
                  {
                      cb.DataSource = dt;
                      cb.DisplayMember = "rubro";
                      cb.ValueMember = "idRubro";
                      cb.Visible = true;
                  }

                  else
                  {
                      cb.Visible = false;
                  }


                  MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        public static ProductoEntity AddProductoDGV(DataGridView dgv, ProductoEntity producto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT P.idProducto, P.producto
                                 FROM Productos P
                                 WHERE P.idProducto = @idProducto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idProducto"]),
                    Convert.ToString(dr["producto"]),
                    Convert.ToString(null),
                    //Convert.ToString(dr["precio"]),
                    Convert.ToString(null));
                }

                dr.Close();
                MySQL.DisconnectDB();

                return producto;
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

                string query = @"SELECT P.idProducto, P.producto, T.tipoproducto, MA.marca, M.medida
                                 FROM productos P
                                 INNER JOIN tipoproductos T ON P.tipoProducto = T.idTipoProducto
                                 INNER JOIN marcas MA ON P.marca = MA.idmarca
                                 INNER JOIN medidas M ON P.medida = M.idMedida
                                 WHERE";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", parametro);
                cmd.Parameters.AddWithValue("@tipoProductos", parametro);
                cmd.Parameters.AddWithValue("@marcas", parametro);
                cmd.Parameters.AddWithValue("@producto", parametro);
                cmd.Parameters.AddWithValue("@medida", parametro);

                if (cb.SelectedIndex == 0)
                {
                    cmd.CommandText = query + " idProducto LIKE @idProducto";
                }
                if (cb.SelectedIndex == 1)
                {
                    cmd.CommandText = query + " tipoproductos LIKE @tipoproductos";
                }
                if (cb.SelectedIndex == 2)
                {
                    cmd.CommandText = query + " marca LIKE @marcas";
                }
                if (cb.SelectedIndex == 3)
                {
                    cmd.CommandText = query + " producto LIKE @producto";
                }
                if (cb.SelectedIndex == 4)
                {
                    cmd.CommandText = query + " medida LIKE @medida";
                }

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {                    
                    dgv.Rows.Add(
                    Convert.ToString(dr["idProducto"]),
                    Convert.ToString(dr["tipoproductos"]),
                    Convert.ToString(dr["marca"]),
                    Convert.ToString(dr["Producto"]),
                    Convert.ToString(dr["Medida"]));
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
        
    }
}
