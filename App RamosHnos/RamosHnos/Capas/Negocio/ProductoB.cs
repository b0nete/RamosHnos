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
    class ProductoB
    {
        public static TipoProductoEntity InsertTipoProducto(TipoProductoEntity tproducto)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO TipoProducto (tipoProducto, estado) 
                                 VALUES (@tipoProducto, @estado);
                                 SELECT LAST_INSERT_ID()";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@tipoProducto", tproducto.tipoProducto);
                cmd.Parameters.AddWithValue("@estado", tproducto.estado);


                //cmd.ExecuteNonQuery();
                tproducto.idTipoProducto = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Tipo Producto Guardado!");
                MySQLDAL.DcnxDB();

                return tproducto;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ProductoEntity InsertProducto(ProductoEntity producto)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO Productos (tipoProducto, producto, medida, descripcion, stockMin, fechaVencimiento, estado) 
                                 VALUES (@tipoProducto, @producto, @medida, @descripcion, @stockMin, @fechaVencimiento, @estado);
                                 SELECT LAST_INSERT_ID()";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@tipoProducto", producto.tipoProducto);
                cmd.Parameters.AddWithValue("@producto", producto.producto);
                cmd.Parameters.AddWithValue("@medida", producto.medida);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion);
                cmd.Parameters.AddWithValue("@stockMin", producto.stockMin);
                cmd.Parameters.AddWithValue("@fechaVencimiento", producto.fechaVencimiento);
                cmd.Parameters.AddWithValue("@estado", producto.estado);


                //cmd.ExecuteNonQuery();
                producto.idProducto = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Tipo Producto Guardado!");
                MySQLDAL.DcnxDB();

                return producto;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void MostrarTipoProducto(DataGridView dgv)
        {
            try
            {
                MySQLDAL.CnxDB();
                DataTable dt = new DataTable();

                string query = "SELECT * FROM TipoProducto";

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

        public static void MostrarTipoProducto(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();

                string query = "SELECT * FROM TipoProducto";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);


                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                cb.DisplayMember = "tipoProducto";
                cb.ValueMember = "idTipoProducto";
                cb.DataSource = dt;

                MySQLDAL.DcnxDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
