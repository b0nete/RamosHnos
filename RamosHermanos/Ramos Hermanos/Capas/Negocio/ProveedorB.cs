using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Datos;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace RamosHermanos.Capas.Negocio
{
    class ProveedorB
    {
        public static ProveedorEntity InsertProv(ProveedorEntity prov, TextBox txtid)
        {
            MySQL.ConnectDB();

            string query=@"Insert into proveedores (rol,razonSocial,cuit,estado)
                         VALUES (@rol,@razonSocial,@cuit,@estado)";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

            cmd.Parameters.AddWithValue("@rol", prov.rolprov);
            cmd.Parameters.AddWithValue("@razonSocial", prov.nombreprov);
            cmd.Parameters.AddWithValue("@cuit", prov.cuitprov);
            cmd.Parameters.AddWithValue("@estado", prov.estadoprov);

            txtid.Text = Convert.ToString(cmd.ExecuteScalar());

            MessageBox.Show("Guardado");
                
            return prov;
            
        }
    }
}
