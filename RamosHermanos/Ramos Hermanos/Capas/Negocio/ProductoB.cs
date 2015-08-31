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
                             WHERE idProducto = @idProducto";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idProducto", producto.idProducto);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;

        }

        public static ProductoEntity UpdateProducto(ProductoEntity producto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Productos
                                 SET fechaalta = @fechaAlta, tipodoc = @tipoDoc, numdoc = @numDoc, sexo = @sexo, cuil =  @cuil, nombre = @nombre, apellido = @apellido, estadoCivil = @estadoCivil, condicionIVA = @condicionIVA, tipoCliente = @tipoCliente, estado = @estado
                                 WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                //cmd.Parameters.AddWithValue("@fechaAlta", cliente.fechaAlta);
                //cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                //cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                //cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
                //cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
                //cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                //cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                //cmd.Parameters.AddWithValue("@estadoCivil", cliente.estadoCivil);
                //cmd.Parameters.AddWithValue("@condicionIVA", cliente.condicionIVA);
                //cmd.Parameters.AddWithValue("@tipoCliente", cliente.tipoCliente);
                //cmd.Parameters.AddWithValue("@estado", cliente.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Actualizado!");
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
                                 INNER JOIN precioProductos PP ON PP.Producto = P.idProducto";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idCliente"]),
                    Convert.ToString(dr["fechaAlta"]),
                    Convert.ToString(dr["IDtipoDoc"]),
                    Convert.ToString(dr["tipoDoc"]),
                    Convert.ToString(dr["numDoc"]),
                    Convert.ToString(dr["sexo"]),
                    Convert.ToString(dr["cuil"]),
                    Convert.ToString(dr["apellido"]),
                    Convert.ToString(dr["nombre"]),
                    Convert.ToString(dr["estadoCivil"]),
                    Convert.ToString(dr["condicionIVA"]),
                    Convert.ToString(dr["IDtipoCliente"]),
                    Convert.ToString(dr["tipocliente"]));
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
