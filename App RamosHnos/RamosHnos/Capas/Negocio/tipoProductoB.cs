using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Datos;

namespace RamosHnos.Capas.Negocio
{
    class TipoProductoB
    {

        public static TipoProductoEntity InsertTipoProducto(TipoProductoEntity tipoproducto)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO tipoProducto (tipoProducto, estado)
                                 VALUES (@tipoProducto, @estado);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoProducto", tipoproducto.tipoProducto);
                cmd.Parameters.AddWithValue("@estado", tipoproducto.estado);

                tipoproducto.idTipoProducto = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("TipoProducto Guardado!");
                MySQLDAL.DcnxDB();

                return tipoproducto;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex);
                throw;
            }
        }       

    }
}
