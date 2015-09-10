using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Datos;

namespace RamosHermanos.Capas.Negocio
{
    class itemsFacturaB
    {
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
    }
}
