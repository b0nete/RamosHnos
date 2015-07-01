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
        public static bool ExisteProveedor(ProveedorEntity proveedor)
        {
            MySQLDAL.CnxDB();

            string query = @"SELECT COUNT(*) FROM Proveedores
                             WHERE cuit = @cuit";

            MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
            cmd.Parameters.AddWithValue("@cuit", proveedor.cuit);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static ProveedorEntity UpdateProveedor(ProveedorEntity proveedor)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"UPDATE Proveedores
                                 SET cuit = @cuit, razonSocial = @razonSocial, email = @email, estado = @estado
                                 WHERE idProveedor = @idProveedor";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@idProveedor", proveedor.idProveedor);
                cmd.Parameters.AddWithValue("@razonSocial", proveedor.razonSocial);
                cmd.Parameters.AddWithValue("@cuit", proveedor.cuit);
                cmd.Parameters.AddWithValue("@email", proveedor.email);
                cmd.Parameters.AddWithValue("@estado", proveedor.estado);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Proveedor Actualizado!");
                return proveedor;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ProveedorEntity InsertProveedor(ProveedorEntity proveedor)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"INSERT INTO Proveedores (rol ,razonSocial, cuit, email, estado) 
                                 VALUES ('2', @razonSocial, @cuit, @email, @estado);
                                 SELECT LAST_INSERT_ID()";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@razonSocial", proveedor.razonSocial);
                cmd.Parameters.AddWithValue("@CUIT", proveedor.cuit);
                cmd.Parameters.AddWithValue("@email", proveedor.email);
                cmd.Parameters.AddWithValue("@estado", proveedor.estado);

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



        public static void DisableProveedor(string proveedor, CheckBox cb)
        {
            try
            {
                MySQLDAL.CnxDB();

                string query = @"UPDATE Proveedores
                                 SET estado = '0'
                                 WHERE idProveedor = @idProveedor";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@idProveedor", proveedor);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Proveedor Desabilitado!");
                cb.Checked = false;
                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void MostrarTelefonoProveedor(DataGridView dgv, int rol, string telefono)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQLDAL.CnxDB();


                string query = @"SELECT TT.TipoTel, CONCAT (T.caracteristica,'-', T.numtel) Telefono
                                 FROM Telefonos T
                                 INNER JOIN TipoTelefono TT ON TT.idTipoTel = T.TipoTel
                                 INNER JOIN Proveedores P ON P.idProveedor = T.idPersona
                                 WHERE T.rol = @rol and T.idPersona = @idPersona";


                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", rol);
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

                string query = "SELECT * FROM Proveedores WHERE CUIT = @CUIT";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);

                cmd.Parameters.AddWithValue("@CUIT", proveedor.cuit);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Proveedor no existe!");
                }
                else
                {

                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    proveedor.idProveedor = Convert.ToInt32(row["idProveedor"]);
                    proveedor.cuit = Convert.ToString(row["CUIT"]);
                    proveedor.razonSocial = Convert.ToString(row["razonSocial"]);
                    proveedor.email = Convert.ToString(row["email"]);
                    proveedor.estado = Convert.ToBoolean(row["estado"]);

                    //string idCliente = Convert.ToInt32(dt.Rows["idCliente"]);
                }

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

        public static void ListarProveedores(DataGridView dgv)
        {
            try
            {
                MySQLDAL.CnxDB();
                DataTable dt = new DataTable();


                string query = @"SELECT P.idProveedor 'ID Proveedor', P.razonSocial 'Razon Social', P.CUIT, P.Email, P.Estado
                                 FROM Proveedores P";

                MySqlCommand cmd = new MySqlCommand(query, MySQLDAL.sqlcnx);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                dgv.DataSource = dt;

                cmd.ExecuteNonQuery();
                MySQLDAL.DcnxDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


    }
}
