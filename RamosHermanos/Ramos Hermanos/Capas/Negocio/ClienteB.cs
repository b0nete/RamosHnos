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
                                 SET tipodoc = @tipoDoc, numdoc = @numDoc, sexo = @sexo, nombre = @nombre, apellido = @apellido, cuil =  @cuil, email = @email, estado = @estado
                                 WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
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


        public static ClienteEntity InsertCliente(ClienteEntity cliente)
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

                MessageBox.Show("Cliente Guardado!");
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
                    cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                    cliente.sexo = Convert.ToString(row["sexo"]);
                    cliente.nombre = Convert.ToString(row["nombre"]);
                    cliente.apellido = Convert.ToString(row["apellido"]);
                    cliente.cuil = Convert.ToString(row["cuil"]);
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
    }
}
