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

            string query = @"Insert into proveedores (rol,razonSocial,cuit,estado,condicionIVA,fechaAlta)
                          VALUES (@rol,@razonSocial,@cuit,@estado,@condicionIVA,@fechaAlta);
                          Select last_insert_id();";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

            cmd.Parameters.AddWithValue("@rol", prov.rol);
            cmd.Parameters.AddWithValue("@razonSocial", prov.razsocial);
            cmd.Parameters.AddWithValue("@cuit", prov.cuit);
            cmd.Parameters.AddWithValue("@estado", prov.estado);
            cmd.Parameters.AddWithValue("@condicionIVA", prov.condicioniva);
            cmd.Parameters.AddWithValue("@fechaAlta", prov.fecha);

            txtid.Text = Convert.ToString(cmd.ExecuteScalar());

            MessageBox.Show("Guardado");

            return prov;

        }

        public static bool ExisteProveedor(ProveedorEntity prov)
        {

            MySQL.ConnectDB();

            string query = @"Select COUNT(*) from proveedores
                            where razonSocial = @razonSocial OR cuit = @cuit";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@razonSocial", prov.razsocial);
            cmd.Parameters.AddWithValue("@cuit", prov.cuit);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)

                return false;

            else

                return true;


        }

        public static bool ProveedorCuit(ProveedorEntity prov)
        {

            MySQL.ConnectDB();

            string query = @"Select COUNT(*) from proveedores
                            where cuit = @cuit";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@cuit", prov.cuit);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)

                return false;

            else

                return true;


        }

        public static bool ProveedorID(ProveedorEntity prov)
        {

            MySQL.ConnectDB();

            string query = @"Select COUNT(*) from proveedores
                            where idProveedor = @idProveedor";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@idProveedor", prov.idProveedor);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)

                return false;

            else

                return true;


        }


        public static ProveedorEntity UpdateProveedor(ProveedorEntity prov)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE proveedores
                               SET fechaAlta = @fechaAlta, razonsocial = @razonSocial, cuit = @cuit, estado = @estado,condicionIVA =@condicionIVA,debMAX=@debMAX
                               WHERE idProveedor = @idProveedor";
                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProveedor", prov.idProveedor);
                cmd.Parameters.AddWithValue("@fechaAlta", prov.fecha);
                cmd.Parameters.AddWithValue("@cuit", prov.cuit);
                cmd.Parameters.AddWithValue("@razonSocial", prov.razsocial);
                cmd.Parameters.AddWithValue("@estado", prov.estado);
                cmd.Parameters.AddWithValue("@condicionIVA", prov.condicioniva);
                cmd.Parameters.AddWithValue("@debMAX", prov.debMAX);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Proveedor Actualizado");

                return prov;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR  " + ex);
                throw;
            }


        }

        public static ProveedorEntity BuscarIdProv(ProveedorEntity proveedor)
        {

            try
            {
                MySQL.ConnectDB();

                string query = @"Select * from proveedores
                                WHERE idproveedor = @idProveedor";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProveedor", proveedor.idProveedor);

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
                    proveedor.fecha = Convert.ToDateTime(row["fechaAlta"]); ;
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


        public static ProveedorEntity BuscarProvRazonsocial(ProveedorEntity proveedor)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM proveedores WHERE razonSocial = @razonSocial";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@razonSocial", proveedor.razsocial);

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
                    proveedor.fecha = Convert.ToDateTime(row["fechaAlta"]); ;
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

        public static ProveedorEntity BuscarProvCuit(ProveedorEntity proveedor)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM proveedores WHERE cuit = @cuit";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@cuit", proveedor.cuit);

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
                    proveedor.fecha = Convert.ToDateTime(row["fechaAlta"]); ;
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

        public static ProveedorEntity BuscarProvID(ProveedorEntity proveedor)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM proveedores WHERE idProveedor = @idProveedor";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProveedor", proveedor.idProveedor);

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
                    proveedor.fecha = Convert.ToDateTime(row["fechaAlta"]); ;
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

        public static void cargardgv(DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"Select P.idProveedor , P.razonSocial , P.cuit , P.estado ,P.condicionIVA ,P.fechaAlta
                                FROM proveedores P";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idProveedor"]),
                    Convert.ToString(dr["razonSocial"]),
                    Convert.ToString(dr["cuit"]),
                    Convert.ToString(dr["fechaAlta"]),
                    Convert.ToString(dr["condicionIVA"]),
                    Convert.ToString(dr["estado"]));
                }
                dr.Close();
                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarProv(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = "SELECT * FROM proveedores";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                  da.Fill(dt);

                  cb.DataSource = dt;
                  cb.DisplayMember = "razonSocial";
                  cb.ValueMember = "idProveedor";


                  MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }
        public static void CargarDGVParametros(DataGridView dgv, ComboBox cb, string parametro)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT P.idProveedor, P.razonSocial, P.cuit, P.fechaAlta, P.condicionIva, P.estado
                                 FROM proveedores P
                                 WHERE";
                
                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProveedor", parametro);
                //cmd.Parameters.AddWithValue("@tipoproductos", parametro);
                cmd.Parameters.AddWithValue("@razonSocial", parametro);
                cmd.Parameters.AddWithValue("@cuit", parametro);
                               
                if (cb.SelectedIndex == 0)
                {
                    cmd.CommandText = query + " P.idProveedor LIKE @idProveedor";
                }
                //if (cb.SelectedIndex == 1)
                //{
                //    cmd.CommandText = query + " tipoproductos LIKE @tipoproductos";
                //}
                if (cb.SelectedIndex == 1)
                {
                    cmd.CommandText = query + " P.razonSocial LIKE @razonSocial";
                }
                if (cb.SelectedIndex == 2)
                {
                    cmd.CommandText = query + " P.cuit LIKE @cuit";
                }
                

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idProveedor"]),
                        //Convert.ToString(dr["tipoproductos"]),
                    Convert.ToString(dr["razonSocial"]),
                    Convert.ToString(dr["cuit"]),
                    Convert.ToString(dr["fechaAlta"]),
                    Convert.ToString(dr["condicionIva"]),
                    Convert.ToString(dr["estado"]));
                }

                dr.Close();
                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string BuscarNombreProveedor(int idProveedor)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT CONCAT(P.idProveedor ,' - ', P.razonSocial)
                                FROM proveedores P
                                WHERE idProveedor = @idProveedor";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProveedor", idProveedor);

                string nombre = Convert.ToString(cmd.ExecuteScalar());

                return nombre;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

    }
}
 

