﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Datos;


namespace RamosHnos.Capas.Negocio
{
    class ClienteB
    {

       // -------------------------------------
       // Métodos

        public static ClienteEntity InsertCliente(ClienteEntity cliente)            
        {
            try
            {
                MySQLDAL.CnxDB();
                
                string query = @"INSERT INTO Clientes (tipoDoc, numDoc, nombre, apellido, cuil, email) 
                                 VALUES (@tipoDoc, @numdoc, @nombre, @apellido, @cuil, @email);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
                cmd.Parameters.AddWithValue("@email", cliente.email);

                
                //cmd.ExecuteNonQuery();
                cliente.idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                
                MessageBox.Show("Cliente Guardado!");
                MySQLDAL.DcnxDB();
                
                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex);
                throw;
            }
        }

        
        public static void ExisteDNI(ClienteEntity cliente)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"SELECT *
                                 FROM Clientes
                                 WHERE DNI = @DNI";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
                MySQLDAL.DcnxDB();
            }

            catch
            {
            }
        }

        public static ClienteEntity BuscarCliente(ClienteEntity cliente)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = "SELECT * FROM Clientes WHERE DNI = @DNI";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@DNI", cliente.numDoc);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                DataRow row = dt.Rows[0];

                cliente.idCliente = Convert.ToInt32(row["idCliente"]);


                //string idCliente = Convert.ToInt32(dt.Rows["idCliente"]);



                MySQLDAL.DcnxDB();
                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


    



        // ------------------------------------     

    }
}
