using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Datos;

namespace RamosHnos.Capas.Negocio
{
    class DomicilioB
    {
        //Metodos

        public static DomicilioEntity InsertDomicilio(DomicilioEntity domicilio)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO domicilios (rol, idPersona, provincia, localidad, calle, numero, piso, dpto, CP) 
                                 VALUES (@rol, @idPersona, @provincia, @localidad, @calle, @numero, @piso, @dpto, @CP);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@rol", domicilio.rol);
                cmd.Parameters.AddWithValue("@idPersona", domicilio.idPersona);
                cmd.Parameters.AddWithValue("@provincia", domicilio.provincia);
                cmd.Parameters.AddWithValue("@localidad", domicilio.localidad);
                cmd.Parameters.AddWithValue("@calle", domicilio.calle);
                cmd.Parameters.AddWithValue("@numero", domicilio.numero);
                cmd.Parameters.AddWithValue("@piso", domicilio.piso);
                cmd.Parameters.AddWithValue("@dpto", domicilio.dpto);
                cmd.Parameters.AddWithValue("@CP", domicilio.CP);

                //cmd.ExecuteNonQuery();
                domicilio.idDomicilio = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Domicilio Guardado!");
                MySQLDAL.DcnxDB();
                return domicilio;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }               
        
        
    }
}
