﻿using System;
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
    class ClienteB
    {
        //Métodos

        public static bool ExisteCliente(ClienteEntity cliente)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Clientes
                             WHERE numDoc = @numDoc";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
            
        }

        public static ClienteEntity UpdateCliente(ClienteEntity cliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Clientes
                                 SET fechaalta = @fechaAlta, tipodoc = @tipoDoc, numdoc = @numDoc, sexo = @sexo, cuil =  @cuil, nombre = @nombre, apellido = @apellido, estadoCivil = @estadoCivil, condicionIVA = @condicionIVA, tipoCliente = @tipoCliente, estado = @estado
                                 WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fechaAlta", cliente.fechaAlta);
                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@estadoCivil", cliente.estadoCivil);
                cmd.Parameters.AddWithValue("@condicionIVA", cliente.condicionIVA);
                cmd.Parameters.AddWithValue("@tipoCliente", cliente.tipoCliente);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Actualizado!");
                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static ClienteEntity InsertCliente(ClienteEntity cliente, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO Clientes (rol, fechaAlta, tipoDoc, numDoc, sexo, cuil, apellido, nombre, estadoCivil, condicionIVA, tipoCliente, estado) 
                                 VALUES ('1', @fechaAlta, @tipoDoc, @numdoc, @sexo, @cuil, @apellido, @nombre, @estadoCivil, @condicionIVA, @tipoCliente, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fechaAlta", cliente.fechaAlta);
                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@estadoCivil", cliente.estadoCivil);
                cmd.Parameters.AddWithValue("@condicionIVA", cliente.condicionIVA);
                cmd.Parameters.AddWithValue("@tipoCliente", cliente.tipoCliente);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);

                cliente.idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                txt.Text = Convert.ToString(cliente.idCliente);

                MessageBox.Show(Convert.ToString(cliente.idCliente));
                MySQL.DisconnectDB();

                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity BuscarCliente(ClienteEntity cliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Clientes WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

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
                    
                    cliente.idCliente = Convert.ToInt32(row["idCliente"]);
                    cliente.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                    cliente.sexo = Convert.ToString(row["sexo"]);
                    cliente.cuil = Convert.ToString(row["cuil"]);
                    cliente.apellido = Convert.ToString(row["apellido"]);
                    cliente.nombre = Convert.ToString(row["nombre"]);
                    cliente.estadoCivil = Convert.ToString(row["estadoCivil"]);
                    cliente.condicionIVA = Convert.ToString(row["condicionIVA"]);
                    cliente.tipoCliente = Convert.ToInt32(row["tipoCliente"]);  
                    cliente.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity DisableCliente(ClienteEntity cliente, CheckBox cb)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Clientes
                                 SET estado = '0'
                                 WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Desabilitado!");
                cb.Checked = false;
                MySQL.DisconnectDB();

                return cliente;
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

                string query = @"SELECT C.idCliente, C.fechaAlta, TP.tipoDoc, C.numDoc, C.sexo, C.cuil, C.apellido, C.nombre, c.estadoCivil, c.condicionIVA, TC.tipocliente
                                 FROM Clientes C
                                 INNER JOIN tipoDocumento TP ON C.tipoDoc = TP.idTipoDoc
                                 INNER JOIN tipoCliente TC ON C.tipoDoc = TC.idTipoCliente";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idCliente"]),
                    Convert.ToString(dr["fechaAlta"]),
                    Convert.ToString(dr["tipoDoc"]),
                    Convert.ToString(dr["numDoc"]),
                    Convert.ToString(dr["sexo"]),
                    Convert.ToString(dr["cuil"]),
                    Convert.ToString(dr["apellido"]),
                    Convert.ToString(dr["nombre"]),
                    Convert.ToString(dr["estadoCivil"]),
                    Convert.ToString(dr["condicionIVA"]),
                    Convert.ToString(dr["tipoCliente"]));
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
