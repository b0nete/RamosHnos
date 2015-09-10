﻿using System;
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
                             WHERE tipoProducto = @tipoProducto and marca = @marca and cantidad = @cantidad and medida = @medida";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@tipoProducto", producto.tipoProducto);
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
                MessageBox.Show("El producto ya existe!");
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
                MessageBox.Show("El ID producto ya existe!");
                return true;
            }
        }

        public static ProductoEntity UpdateProducto(ProductoEntity producto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Productos
                                 SET tipoProducto = @tipoProducto, marca = @marca, producto = @producto, descripcion = @descripcion, cantidad = @cantidad, medida = @medida, stockMin = @stockMin, estado = @estado
                                 WHERE idProducto = @idProducto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);
                cmd.Parameters.AddWithValue("@tipoProducto", producto.tipoProducto);
                cmd.Parameters.AddWithValue("@marca", producto.marca);
                cmd.Parameters.AddWithValue("@producto", producto.producto);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", producto.cantidad);
                cmd.Parameters.AddWithValue("@medida", producto.medida);
                cmd.Parameters.AddWithValue("@stockMin", producto.stockMin);
                cmd.Parameters.AddWithValue("@estado", producto.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Producto Actualizado!");
                return producto;
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


                string query = @"INSERT INTO Productos(fechaAlta, tipoProducto, marca, producto, descripcion, cantidad, medida, stockMin, estado)
                                 VALUES (@fechaAlta, @tipoProducto, @marca, @producto, @descripcion, @cantidad, @medida, @stockMin, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fechaAlta", producto.fechaAlta);
                cmd.Parameters.AddWithValue("@tipoProducto", producto.tipoProducto);
                cmd.Parameters.AddWithValue("@marca", producto.marca);
                cmd.Parameters.AddWithValue("@producto", producto.producto);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@cantidad", producto.cantidad);
                cmd.Parameters.AddWithValue("@medida", producto.medida);
                cmd.Parameters.AddWithValue("@stockMin", producto.stockMin);
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

        public static ProductoEntity BuscarProducto(ProductoEntity producto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Productos WHERE idProducto = @idProducto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Producto no existe!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    producto.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    producto.tipoProducto = Convert.ToInt32(row["tipoProducto"]);
                    producto.marca = Convert.ToInt32(row["marca"]); 
                    producto.producto = Convert.ToString(row["producto"]);
                    producto.descripcion = Convert.ToString(row["descripcion"]);
                    producto.cantidad = Convert.ToDouble(row["cantidad"]);
                    producto.medida = Convert.ToInt32(row["medida"]);
                    producto.stockMin = Convert.ToInt32(row["stockMin"]);
                    producto.stockActual = Convert.ToInt32(row["stockActual"]);

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

                string query = @"SELECT idProducto, TP.tipoProducto, M.marca, P.producto, cantidad, MM.medida, stockActual, PP.Precio
                                 FROM Productos P
                                 INNER JOIN TipoProducto TP ON TP.idTipoProducto = P.tipoProducto
                                 INNER JOIN Marcas M ON M.idMarca = P.Marca
                                 INNER JOIN Medidas MM ON MM.idMedida = P.Medida
                                 INNER JOIN precioProductos PP ON PP.Producto = P.idProducto
                                 WHERE PP.estado = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idProducto"]),
                    Convert.ToString(dr["tipoProducto"]),
                    Convert.ToString(dr["marca"]),
                    Convert.ToString(dr["producto"]),
                    Convert.ToString(dr["cantidad"]),
                    Convert.ToString(dr["medida"]),
                    Convert.ToString(dr["stockActual"]),
                    Convert.ToString(dr["precio"]));
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

        public static ProductoEntity AddProductoDGV(DataGridView dgv, ProductoEntity producto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT P.idProducto, P.producto, PP.Precio
                                 FROM Productos P
                                 INNER JOIN precioProductos PP ON PP.Producto = P.idProducto
                                 WHERE P.idProducto = @idProducto and PP.estado = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idProducto"]),
                    Convert.ToString(dr["producto"]),
                    Convert.ToString(""),
                    Convert.ToString(dr["precio"]),
                    Convert.ToString(""));
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
    }
}
