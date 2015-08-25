using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Negocio
{
    class tipoClienteB
    {
        public static bool ExistetCliente(tipoClienteEntity tcliente)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM tipoCliente
                             WHERE tipoCliente = @tipoCliente";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@tipoCliente", tcliente.tipoCliente);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;

        }

        public static tipoClienteEntity UpdatetCliente(tipoClienteEntity tcliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE tipoCliente
                                 SET tipoCliente = @tipoCliente, descripcion = @descripcion, porcDescuento = @porcDescuento, color = @color, estado = @estado
                                 WHERE idtipoCliente = @idtipoCliente";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idtipoCliente", tcliente.idtipoCliente);
                cmd.Parameters.AddWithValue("@tipoCliente", tcliente.tipoCliente);
                cmd.Parameters.AddWithValue("@descripcion", tcliente.descripcion);
                cmd.Parameters.AddWithValue("@porcDescuento", tcliente.porcDescuento);
                cmd.Parameters.AddWithValue("@color", tcliente.color);
                cmd.Parameters.AddWithValue("@estado", tcliente.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Tipo Cliente Actualizado!");
                return tcliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static tipoClienteEntity InserttCliente(tipoClienteEntity tcliente)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO tipoCliente (tipoCliente, descripcion, porcDescuento, color, estado) 
                                 VALUES (@tipoCliente, @descripcion, @porcDescuento, @color, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoCliente", tcliente.tipoCliente);
                cmd.Parameters.AddWithValue("@descripcion", tcliente.descripcion);
                cmd.Parameters.AddWithValue("@porcDescuento", tcliente.porcDescuento);
                cmd.Parameters.AddWithValue("@color", tcliente.color);
                cmd.Parameters.AddWithValue("@estado", tcliente.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Tipo Cliente Guardado!");
                MySQL.DisconnectDB();

                return tcliente;
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

                string query = @"SELECT * FROM tipoCliente";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int index = dgv.Rows.Add(
                        Convert.ToString(dr["idtipoCliente"]),
                        Convert.ToString(dr["tipoCliente"]),
                        Convert.ToString(dr["descripcion"]),
                        Convert.ToInt32(dr["porcDescuento"]),
                        Convert.ToString(dr["color"]),
                        Convert.ToBoolean(dr["estado"]));

                    dgv.Rows[index].DefaultCellStyle.BackColor = Color.FromName(Convert.ToString(dr["color"]));
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

        public static void CargarTipoCliente(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = "SELECT * FROM tipoCliente";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                  da.Fill(dt);

                  cb.DataSource = dt;
                  cb.DisplayMember = "tipoCliente";
                  cb.ValueMember = "idTipoCliente";

                  MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        
    }
}
