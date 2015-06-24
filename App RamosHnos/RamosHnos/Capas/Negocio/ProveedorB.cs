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
    class ProveedorB
    {

        public static ProveedorEntity InsertProveedor(ProveedorEntity proveedor)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO Proveedores (rol ,razonSocial, cuit, email) 
                                 VALUES ('2', @razonSocial, @cuit, @email);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@razonSocial", proveedor.razonSocial);
                cmd.Parameters.AddWithValue("@CUIT", proveedor.cuit);
                cmd.Parameters.AddWithValue("@email", proveedor.email);

                //cmd.ExecuteNonQuery();
                proveedor.idProveedor = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Proveedor Guardado!");
                MySQLDAL.DcnxDB();

                return proveedor;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ProveedorEntity EditProveedor(ProveedorEntity proveedor)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"UPDATE Proveedores
                                 SET cuit = @cuit, razonSocial = @razonSocial, email = @email
                                 WHERE idProveedor = @idProveedor";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProveedor", proveedor.idProveedor);
                cmd.Parameters.AddWithValue("@razonSocial", proveedor.razonSocial);
                cmd.Parameters.AddWithValue("@cuit", proveedor.cuit);
                cmd.Parameters.AddWithValue("@email", proveedor.email);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Proveedor Actualizado");
                return proveedor;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

                
        public static ProveedorEntity DeleteProveedor(ProveedorEntity proveedor)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"DELETE FROM Proveedores
                                 WHERE idProveedor = @idProveedor";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@idProveedor", proveedor.idProveedor);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Proveedor Eliminado!");
                MySQLDAL.DcnxDB();

                return proveedor;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void MostrarTelefono(DataGridView dgv, string telefono)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT TT.TipoTel, CONCAT (T.caracteristica, T.numtel) Telefono
                                 FROM Telefonos T
                                 INNER JOIN TipoTelefono TT ON TT.idTipoTel = T.TipoTel
                                 INNER JOIN Proveedores P ON P.idProveedor = T.idPersona
                                 WHERE R.idRol = '2', P.idPersona = @idPersona";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@idPersona", telefono);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgv.DataSource = dt;

                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ProveedorEntity BuscarProveedor(ProveedorEntity proveedor)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = "SELECT * FROM PRoveedores WHERE CUIT = @CUIT";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@CUIT", proveedor.cuit);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                DataRow row = dt.Rows[0];

                proveedor.idProveedor = Convert.ToInt32(row["idProveedor"]);
                proveedor.cuit = Convert.ToString(row["CUIT"]);
                proveedor.razonSocial = Convert.ToString(row["razonSocial"]);
                proveedor.email = Convert.ToString(row["email"]);

                //string idCliente = Convert.ToInt32(dt.Rows["idCliente"]);

                MySQLDAL.DcnxDB();
                return proveedor;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarDomicilioProveedor(DataGridView dgv, string persona)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT P.Provincia, P.idProvincia, L.Localidad, L.idLocalidad, D.Calle, D.Numero, D.Piso, D.Dpto, D.CP
                                 FROM Domicilios D 
                                 INNER JOIN Provincias P ON P.idProvincia = D.Provincia
                                 INNER JOIN Localidades L ON L.idLocalidad = D.Localidad
                                 WHERE D.rol = '2' AND idPersona = @idPersona";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@idPersona", persona);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgv.DataSource = dt;

                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void MostrarProveedor(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();

                string query = "SELECT * FROM Proveedores";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                cb.DisplayMember = "razonSocial";
                cb.ValueMember = "idProveedor";
                cb.DataSource = dt;

                MySQLDAL.DcnxDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
