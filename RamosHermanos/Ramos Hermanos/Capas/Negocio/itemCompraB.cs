using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace RamosHermanos.Capas.Negocio
{
    class itemCompraB
    {
        public static itemComprasEntity InsertItemCompras(itemComprasEntity itemcompra, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO itemscompras (idInsumo,idRubro,marca,precio,cantidad,subTotal)
                                    VALUES (@idInsumo,@idRubro,@marca,@precio,@cantidad,@subTotal)
                                    SELECT LAST_INSERT_ID;";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idInsumo", itemcompra.idInsumo);
                cmd.Parameters.AddWithValue("@idRubro", itemcompra.idRubro);
                cmd.Parameters.AddWithValue("@marca", itemcompra.marca);
                cmd.Parameters.AddWithValue("@precio", itemcompra.precioUnitario);
                cmd.Parameters.AddWithValue("@cantidad", itemcompra.cantidad);
                cmd.Parameters.AddWithValue("subTotal", itemcompra.subTotal);

                MySQL.DisconnectDB();

                return itemcompra;
            }


            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
                throw;
            }
        }
    }
}
