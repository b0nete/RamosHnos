using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace RamosHermanos.Capas.Negocio
{
    class ProveedorB
    {
        public static ProveedorEntity InsertProveedor(ProveedorEntity prov, TextBox txtid)
        
        { 
            MySQL.ConnectDB();

            string query = @"Insert into proveedores (rol,razonSocial,cuit,estado,condicionIVA,tipoProveedor)
                          VALUES (@rol,@razonSocial,@cuit,@estado,@condicionIVA,@tipoProveedor);
                          Select last_insert_id();";

            MySqlCommand cmd = new MySqlCommand (query, MySQL.sqlcnx);

            cmd.Parameters.AddWithValue("@rol", prov.rol);
            cmd.Parameters.AddWithValue("@razonSocial", prov.razsocial);
            cmd.Parameters.AddWithValue("@cuit", prov.cuit);
            cmd.Parameters.AddWithValue("@estado", prov.estado);
            cmd.Parameters.AddWithValue("@condicionIVA", prov.condicioniva);
            cmd.Parameters.AddWithValue("@tipoProveedor", prov.tipoProveedor);
                   
            txtid.Text= Convert.ToString(cmd.ExecuteScalar());

            MessageBox.Show("Guardado");
            
            return prov;

        }
    }
}
