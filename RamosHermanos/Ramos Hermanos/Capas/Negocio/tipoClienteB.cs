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
        public static tipoClienteEntity UpdatetCliente(tipoClienteEntity tcliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Clientes
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

        public static tipoClienteEntity BuscartCliente(tipoClienteEntity tcliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Clientes WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                //cmd.Parameters.AddWithValue("@numDoc", tcliente.numDoc);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Cliente no existe!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    //cliente.idCliente = Convert.ToInt32(row["idCliente"]);
                    //cliente.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    //cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                    //cliente.sexo = Convert.ToString(row["sexo"]);
                    //cliente.cuil = Convert.ToString(row["cuil"]);
                    //cliente.apellido = Convert.ToString(row["apellido"]);
                    //cliente.nombre = Convert.ToString(row["nombre"]);
                    //cliente.estadoCivil = Convert.ToString(row["estadoCivil"]);
                    //cliente.condicionIVA = Convert.ToString(row["condicionIVA"]);
                    //cliente.tipoCliente = Convert.ToInt32(row["tipoCliente"]);
                    //cliente.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return tcliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void ListadoDGV(DataGridView dgv)
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
