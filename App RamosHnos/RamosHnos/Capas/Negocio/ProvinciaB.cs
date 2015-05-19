using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Datos;
using RamosHnos.Capas.Entidades;

namespace RamosHnos.Capas.Negocio
{
    class ProvinciaB
    {

        public static ProvinciaEntity InsertProvincia(ProvinciaEntity provincia)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO Provincias (provincia, estado)
                                 VALUES (@provincia, @estado);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("provincia", provincia.provincia);
                cmd.Parameters.AddWithValue("estado", provincia.estado);

                provincia.idProvincia = Convert.ToInt32(cmd.ExecuteScalar());

                MySQLDAL.DcnxDB();
                return provincia;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

    }
}
