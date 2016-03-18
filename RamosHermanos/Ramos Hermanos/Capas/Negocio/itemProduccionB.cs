using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Negocio
{
    class itemProduccionB
    {
        //public static bool ExisteCliente(ClienteEntity cliente)
//        {
//            MySQL.ConnectDB();

//            string query = @"SELECT COUNT(*) FROM Clientes
//                             WHERE numDoc = @numDoc";

//            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
//            cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

//            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

//            if (resultado == 0)
//                return false;
//            else
//                return true;
//        }

//        public static ClienteEntity UpdateCliente(ClienteEntity cliente)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = @"SET @@sql_safe_updates = 0; 
//                                 UPDATE Clientes
//                                 SET fechaalta = @fechaAlta, tipodoc = @tipoDoc, numdoc = @numDoc, sexo = @sexo, cuil =  @cuil, nombre = @nombre, apellido = @apellido, estadoCivil = @estadoCivil, condicionIVA = @condicionIVA, tipoCliente = @tipoCliente, estado = @estado
//                                 WHERE numDoc = @numDoc;
//                                 SET @@sql_safe_updates = 1";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@fechaAlta", cliente.fechaAlta);
//                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
//                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
//                cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
//                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
//                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
//                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
//                cmd.Parameters.AddWithValue("@estadoCivil", cliente.estadoCivil);
//                cmd.Parameters.AddWithValue("@condicionIVA", cliente.condicionIVA);
//                cmd.Parameters.AddWithValue("@tipoCliente", cliente.tipoCliente);
//                cmd.Parameters.AddWithValue("@estado", cliente.estado);

//                cmd.ExecuteNonQuery();

//                MessageBox.Show("Cliente Actualizado!");
//                return cliente;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }


        public static void InsertItemProduccion(ItemProduccionEntity itemProduccion)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO itemsProduccion (produccion, producto, cantidad) 
                                 VALUES (@produccion, @producto, @cantidad);";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@produccion", itemProduccion.produccion);
                cmd.Parameters.AddWithValue("@producto", itemProduccion.produccion);
                cmd.Parameters.AddWithValue("@cantidad", itemProduccion.cantidad);

                cmd.ExecuteScalar();

                MessageBox.Show("Produccion Guardada!");
                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

//        public static ClienteEntity BuscarClienteDOC(ClienteEntity cliente)
//        {
//            try
//            {
//                MySQL.ConnectDB();

//                string query = "SELECT * FROM Clientes WHERE numDoc = @numDoc";

//                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

//                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

//                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
//                if (resultado != 0)
//                {
//                    DataTable dt = new DataTable();
//                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

//                    da.Fill(dt);

//                    DataRow row = dt.Rows[0];

//                    cliente.idCliente = Convert.ToInt32(row["idCliente"]);
//                    cliente.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
//                    cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
//                    cliente.sexo = Convert.ToString(row["sexo"]);
//                    cliente.cuil = Convert.ToString(row["cuil"]);
//                    cliente.apellido = Convert.ToString(row["apellido"]);
//                    cliente.nombre = Convert.ToString(row["nombre"]);
//                    cliente.estadoCivil = Convert.ToString(row["estadoCivil"]);
//                    cliente.condicionIVA = Convert.ToString(row["condicionIVA"]);
//                    cliente.tipoCliente = Convert.ToInt32(row["tipoCliente"]);
//                    cliente.estado = Convert.ToBoolean(row["estado"]);

//                    MySQL.DisconnectDB();
//                }

//                return cliente;
//            }

//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex);
//                throw;
//            }
//        }
    }
}
