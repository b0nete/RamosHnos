using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;

namespace RamosHermanos.Capas.Negocio
{
    class UsuarioB
    {
        public static BarrioEntity InsertBarrio(BarrioEntity barrio)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Barrios (idBarrio, idLocalidad, barrio, estado)
                                 VALUES (@idBarrio, @idLocalidad, @barrio, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idBarrio", barrio.idBarrio);
                cmd.Parameters.AddWithValue("@idLocalidad", barrio.idLocalidad);
                cmd.Parameters.AddWithValue("@barrio", barrio.barrio);
                cmd.Parameters.AddWithValue("@estado", barrio.estado);

                cmd.ExecuteNonQuery();

                MySQL.DisconnectDB();

                return barrio;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
