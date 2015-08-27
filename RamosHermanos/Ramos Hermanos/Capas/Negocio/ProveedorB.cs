using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace RamosHermanos.Capas.Negocio
{
    class ProveedorB
    {
        public static ProveedorEntity InsertProveedor(ProveedorEntity prov, TextBox txtid)
        
        { 
            MySQL.ConnectDB();

            string query = @"Insert into proveedores (rol,razonSocial,cuit,estado,condicionIVA,tipoProveedor,fechaAlta)
                          VALUES (@rol,@razonSocial,@cuit,@estado,@condicionIVA,@tipoProveedor,@fechaAlta);
                          Select last_insert_id();";

            MySqlCommand cmd = new MySqlCommand (query, MySQL.sqlcnx);

            cmd.Parameters.AddWithValue("@rol", prov.rol);
            cmd.Parameters.AddWithValue("@razonSocial", prov.razsocial);
            cmd.Parameters.AddWithValue("@cuit", prov.cuit);
            cmd.Parameters.AddWithValue("@estado", prov.estado);
            cmd.Parameters.AddWithValue("@condicionIVA", prov.condicioniva);
            cmd.Parameters.AddWithValue("@tipoProveedor", prov.tipoProveedor);
            cmd.Parameters.AddWithValue("@fechaAlta", prov.fecha);
                               
            txtid.Text= Convert.ToString(cmd.ExecuteScalar());

            MessageBox.Show("Guardado");
            
            return prov;

        }

        public static bool ExisteProveedor(ProveedorEntity prov)
        {

            MySQL.ConnectDB();
           
            string query = @"Select COUNT * from proveedor
                            where cuit == @cuit" ;
            
            MySqlCommand cmd = new MySqlCommand (query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@cuit", prov.cuit);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
           
                return false;

            else
          
                return true;
            
            
            }

        public static ProveedorEntity BuscarProvCuit(ProveedorEntity proveedor)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM proveedores WHERE cuil = @cuil";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@cuil", proveedor.cuit);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Proveedor NO existe!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    proveedor.idProveedor = Convert.ToInt32(row["idProveedor"]);
                    proveedor.fecha = Convert.ToDateTime(row["fechaAlta"]);
                    proveedor.cuit = Convert.ToString(row["cuit"]);
                    proveedor.razsocial = Convert.ToString(row["razonSocial"]);
                    proveedor.condicioniva = Convert.ToString(row["condicionIVA"]);
                    proveedor.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return proveedor;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static void cargardgv (DataGridView dgv)
        {
            MySQL.ConnectDB();
            MySqlCommand cmd = new MySqlCommand (@"Select idProveedor as NumeroProveedor, rol as Rol, razonSocial as 'Razon Social',
            cuit as Cuit, email as Email, estado as Estado, tipoProveedor as 'Tipo de Proveedor', condicionIva as 'Condicion Iva',
            fechaAlta as 'Fecha de Alta' from proveedores", MySQL.sqlcnx);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
            MySQL.DisconnectDB();
        }




        }
 }

