using System;
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
       //Métodos

        public static ClienteEntity InsertCliente(ClienteEntity cliente)            
        {
            try
            {
                MySQLDAL.CnxDB();
                string query = @"INSERT INTO Clientes (tipoDoc, numDoc, nombre, apellido, cuil, email) 
                                 VALUES (@tipoDoc, @numdoc, @nombre, @apellido, @cuil, @email);
                                 SELECT LAST_INSERT_ID()";
                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
                cmd.Parameters.AddWithValue("@email", cliente.email);
                 
                cmd.ExecuteNonQuery();
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

        public static void CargarTipoDoc(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();               
                
                string query = "SELECT * FROM tipoDocumento";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                
                cb.DisplayMember = "TipoDoc";
                cb.ValueMember = "idTipoDoc";
                cb.DataSource = dt;
                MySQLDAL.DcnxDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }  

        //public static ClienteEntity ObtenerID(int idCliente)
        //{
        //    try
        //    {                
        //        ClienteEntity cliente = null;
        //        ClienteDAL.CnxDB();

        //        string query = "SELECT * FROM Clientes WHERE idCliente = @idCliente";

        //        MySqlCommand cmd = new MySqlCommand(query, ClienteDAL.sqlcnx);
        //        cmd.Parameters.AddWithValue("@idCliente", idCliente);

        //        MySqlDataReader dr = new MySqlDataReader();

        //        return idCliente;
        //    }
        //    catch
        //    {
        //    }
        //}



        // ------------------------------------     

    }
}
