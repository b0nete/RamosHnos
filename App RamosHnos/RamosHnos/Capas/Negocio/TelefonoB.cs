using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHnos;
using RamosHnos.Capas.Datos;
using RamosHnos.Capas.Entidades;



namespace RamosHnos.Capas.Negocio
{
    class TelefonoB
    {

        // Métodos

        public static TelefonoEntity InsertTelefono(TelefonoEntity telefono)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO telefonos (idTelefono, cliente, tipoTel, caracteristica, numTel) 
                                 VALUES (@idTelefono, @cliente, @tipoTel, @caracteristica, @numTel);
                                 SELECT LAST_INSERT_ID()";
                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@idTelefono", telefono.idTelefono);
                cmd.Parameters.AddWithValue("@cliente", telefono.cliente);
                cmd.Parameters.AddWithValue("@tipoTel", telefono.tipoTel);
                cmd.Parameters.AddWithValue("@caracteristica", telefono.caracteristica);
                cmd.Parameters.AddWithValue("@numTel", telefono.numTel);

                cmd.ExecuteNonQuery();
                telefono.idTelefono = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Telefono Guardado!");
                MySQLDAL.DcnxDB();
                return telefono;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }                       
        }

        
    }
}
