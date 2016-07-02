using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Negocio
{
    class ClienteB
    {
        //Métodos

        public static bool ExisteCliente(ClienteEntity cliente)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Clientes
                             WHERE numDoc = @numDoc";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;           
        }

        public static ClienteEntity UpdateCliente(ClienteEntity cliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SET @@sql_safe_updates = 0; 
                                 UPDATE Clientes
                                 SET fechaalta = @fechaAlta, tipodoc = @tipoDoc, numdoc = @numDoc, sexo = @sexo, cuil =  @cuil, nombre = @nombre, apellido = @apellido, estadoCivil = @estadoCivil, condicionIVA = @condicionIVA, tipoCliente = @tipoCliente, estado = @estado
                                 WHERE numDoc = @numDoc;
                                 SET @@sql_safe_updates = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fechaAlta", cliente.fechaAlta);
                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@estadoCivil", cliente.estadoCivil);
                cmd.Parameters.AddWithValue("@condicionIVA", cliente.condicionIVA);
                cmd.Parameters.AddWithValue("@tipoCliente", cliente.tipoCliente);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Actualizado!");
                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static ClienteEntity InsertCliente(ClienteEntity cliente, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO Clientes (rol, tipoPersona, fechaAlta,  tipoDoc, numDoc, sexo, cuil, apellido, nombre, estadoCivil, condicionIVA, tipoCliente, estado) 
                                 VALUES ('1', @tipoPersona, @fechaAlta, @tipoDoc, @numdoc, @sexo, @cuil, @apellido, @nombre, @estadoCivil, @condicionIVA, @tipoCliente, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fechaAlta", cliente.fechaAlta);
                cmd.Parameters.AddWithValue("@tipoPersona", cliente.tipoPersona);
                cmd.Parameters.AddWithValue("@tipoDoc", cliente.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);
                cmd.Parameters.AddWithValue("@sexo", cliente.sexo);
                cmd.Parameters.AddWithValue("@cuil", cliente.cuil);
                cmd.Parameters.AddWithValue("@apellido", cliente.apellido);
                cmd.Parameters.AddWithValue("@nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("@estadoCivil", cliente.estadoCivil);
                cmd.Parameters.AddWithValue("@condicionIVA", cliente.condicionIVA);
                cmd.Parameters.AddWithValue("@tipoCliente", cliente.tipoCliente);
                cmd.Parameters.AddWithValue("@estado", cliente.estado);

                cliente.idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                txt.Text = Convert.ToString(cliente.idCliente);

                MessageBox.Show("Cliente Guardado!");
                MySQL.DisconnectDB();

                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity BuscarClienteDOC(ClienteEntity cliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Clientes WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    cliente.idCliente = Convert.ToInt32(row["idCliente"]);
                    cliente.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                    cliente.sexo = Convert.ToString(row["sexo"]);
                    cliente.cuil = Convert.ToString(row["cuil"]);
                    cliente.apellido = Convert.ToString(row["apellido"]);
                    cliente.nombre = Convert.ToString(row["nombre"]);
                    cliente.estadoCivil = Convert.ToString(row["estadoCivil"]);
                    cliente.condicionIVA = Convert.ToString(row["condicionIVA"]);
                    cliente.tipoCliente = Convert.ToInt32(row["tipoCliente"]);
                    cliente.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }

                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity BuscarClienteCUIL(ClienteEntity cliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Clientes WHERE cuil = @cuil";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@cuil", cliente.numDoc);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado != 0)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    cliente.idCliente = Convert.ToInt32(row["idCliente"]);
                    cliente.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                    cliente.cuil = Convert.ToString(row["numDoc"]);
                    cliente.sexo = Convert.ToString(row["sexo"]);
                    cliente.apellido = Convert.ToString(row["apellido"]);
                    cliente.nombre = Convert.ToString(row["nombre"]);
                    cliente.estadoCivil = Convert.ToString(row["estadoCivil"]);
                    cliente.condicionIVA = Convert.ToString(row["condicionIVA"]);
                    cliente.tipoCliente = Convert.ToInt32(row["tipoCliente"]);
                    cliente.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }

                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity BuscarClienteID(ClienteEntity cliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Clientes WHERE idCliente = @idCliente";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Cliente no existe!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    cliente.tipoPersona = Convert.ToString(row["tipoPersona"]);
                    cliente.numDoc = Convert.ToString(row["numDoc"]);
                    cliente.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                    cliente.sexo = Convert.ToString(row["sexo"]);
                    cliente.cuil = Convert.ToString(row["cuil"]);
                    cliente.apellido = Convert.ToString(row["apellido"]);
                    cliente.nombre = Convert.ToString(row["nombre"]);
                    cliente.estadoCivil = Convert.ToString(row["estadoCivil"]);
                    cliente.condicionIVA = Convert.ToString(row["condicionIVA"]);
                    cliente.tipoCliente = Convert.ToInt32(row["tipoCliente"]);
                    cliente.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity BuscarClienteCIVAyCP(int idCliente)
        {
            try
            {
                MySQL.ConnectDB();

                ClienteEntity cliente = new ClienteEntity();

                string query = "SELECT * FROM Clientes WHERE idCliente = @idCliente";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Cliente no existe!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    cliente.tipoPersona = Convert.ToString(row["tipoPersona"]);
                    cliente.numDoc = Convert.ToString(row["numDoc"]);
                    cliente.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                    cliente.sexo = Convert.ToString(row["sexo"]);
                    cliente.cuil = Convert.ToString(row["cuil"]);
                    cliente.apellido = Convert.ToString(row["apellido"]);
                    cliente.nombre = Convert.ToString(row["nombre"]);
                    cliente.estadoCivil = Convert.ToString(row["estadoCivil"]);
                    cliente.condicionIVA = Convert.ToString(row["condicionIVA"]);
                    cliente.tipoCliente = Convert.ToInt32(row["tipoCliente"]);
                    cliente.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity BuscarApellido(ClienteEntity cliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Clientes WHERE apellido = @apellido";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Cliente no existe!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    cliente.tipoPersona = Convert.ToString(row["tipoPersona"]);
                    cliente.numDoc = Convert.ToString(row["numDoc"]);
                    cliente.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    cliente.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                    cliente.sexo = Convert.ToString(row["sexo"]);
                    cliente.cuil = Convert.ToString(row["cuil"]);
                    cliente.apellido = Convert.ToString(row["apellido"]);
                    cliente.nombre = Convert.ToString(row["nombre"]);
                    cliente.estadoCivil = Convert.ToString(row["estadoCivil"]);
                    cliente.condicionIVA = Convert.ToString(row["condicionIVA"]);
                    cliente.tipoCliente = Convert.ToInt32(row["tipoCliente"]);
                    cliente.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity DisableCliente(ClienteEntity cliente, CheckBox cb)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"UPDATE Clientes
                                 SET estado = '0'
                                 WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                //cmd.CommandText = query;

                cmd.Parameters.AddWithValue("@numDoc", cliente.numDoc);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Desabilitado!");
                cb.Checked = false;
                MySQL.DisconnectDB();

                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarDGV(DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT C.idCliente, C.fechaAlta, C.tipoDoc as IDtipoDoc, TP.tipoDoc, C.numDoc, C.sexo, C.cuil, C.apellido, C.nombre, c.estadoCivil, c.condicionIVA, C.tipoCliente as IDtipoCliente, TC.tipocliente
                                 FROM Clientes C
                                 INNER JOIN tipoDocumento TP ON C.tipoDoc = TP.idTipoDoc
                                 INNER JOIN tipoCliente TC ON C.tipoDoc = TC.idTipoCliente
                                 WHERE C.tipoPersona = 'P'";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {                    
                    dgv.Rows.Add(
                    Convert.ToString(dr["idCliente"]),
                    Convert.ToString(dr["apellido"]),
                    Convert.ToString(dr["nombre"]),
                    Convert.ToString(dr["IDtipoDoc"]),
                    Convert.ToString(dr["tipoDoc"]),
                    Convert.ToString(dr["numDoc"]),
                    Convert.ToString(dr["cuil"]),
                    Convert.ToDateTime(dr["fechaAlta"]).ToString("dd/MM/yyyy"),
                    Convert.ToString(dr["sexo"]),                  
                    Convert.ToString(dr["estadoCivil"]),
                    Convert.ToString(dr["condicionIVA"]),
                    Convert.ToString(dr["IDtipoCliente"]),
                    Convert.ToString(dr["tipocliente"]));
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

        public static void CargarDGVParametros(DataGridView dgv, ComboBox cb, string parametro)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT C.idCliente, C.fechaAlta, C.tipoDoc as IDtipoDoc, TP.tipoDoc, C.numDoc, C.sexo, C.cuil, C.apellido, C.nombre, c.estadoCivil, c.condicionIVA, C.tipoCliente as IDtipoCliente, TC.tipocliente
                                 FROM Clientes C
                                 INNER JOIN tipoDocumento TP ON C.tipoDoc = TP.idTipoDoc
                                 INNER JOIN tipoCliente TC ON C.tipoDoc = TC.idTipoCliente
                                 WHERE C.tipoPersona = 'P'";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                cmd.Parameters.AddWithValue("@idCliente", parametro);
                cmd.Parameters.AddWithValue("@numDoc", parametro);
                cmd.Parameters.AddWithValue("@cuil", parametro);
                cmd.Parameters.AddWithValue("@apellido", parametro);
                cmd.Parameters.AddWithValue("@nombre", parametro);

                if (cb.SelectedIndex == 0)
                {
                    cmd.CommandText = query + " and C.idCliente LIKE @idCliente";
                }
                if (cb.SelectedIndex == 1)
                {
                    cmd.CommandText = query + " and C.numDoc LIKE @numDoc";
                }
                if (cb.SelectedIndex == 2)
                {
                    cmd.CommandText = query + " and C.cuil LIKE @cuil";
                }
                if (cb.SelectedIndex == 3)
                {
                    cmd.CommandText = query + " and C.apellido LIKE @apellido";
                }
                if (cb.SelectedIndex == 4)
                {
                    cmd.CommandText = query + " and C.nombre LIKE @nombre";
                }

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {                    
                    dgv.Rows.Add(
                    Convert.ToString(dr["idCliente"]),
                    Convert.ToString(dr["apellido"]),
                    Convert.ToString(dr["nombre"]),
                    Convert.ToString(dr["IDtipoDoc"]),
                    Convert.ToString(dr["tipoDoc"]),
                    Convert.ToString(dr["numDoc"]),
                    Convert.ToString(dr["cuil"]),
                    Convert.ToDateTime(dr["fechaAlta"]).ToString("dd/MM/yyyy"),
                    Convert.ToString(dr["sexo"]),                  
                    Convert.ToString(dr["estadoCivil"]),
                    Convert.ToString(dr["condicionIVA"]),
                    Convert.ToString(dr["IDtipoCliente"]),
                    Convert.ToString(dr["tipocliente"]));
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

        public static void CargarDGVParametrosJ(DataGridView dgv, ComboBox cb, string parametro)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT C.idCliente, C.fechaAlta, C.cuil, C.nombre, c.condicionIVA, c.tipoCliente as IDtipoCliente, TC.tipoCliente
                                 FROM Clientes C
                                 INNER JOIN tipoCliente TC ON C.tipoCliente = TC.idTipoCliente
                                 WHERE C.tipoPersona = 'PJ'";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                cmd.Parameters.AddWithValue("@idCliente", parametro);
                cmd.Parameters.AddWithValue("@cuil", parametro);
                cmd.Parameters.AddWithValue("@nombre", parametro);

                if (cb.SelectedIndex == 0)
                {
                    cmd.CommandText = query + " and C.idCliente LIKE @idCliente";
                }
                if (cb.SelectedIndex == 1)
                {
                    cmd.CommandText = query + " and C.cuil LIKE @cuil";
                }
                if (cb.SelectedIndex == 2)
                {
                    cmd.CommandText = query + " and C.nombre LIKE @nombre";
                }

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {                    
                    dgv.Rows.Add(
                    Convert.ToString(dr["idCliente"]),
                    Convert.ToString(dr["nombre"]), //Se completa con cualquier valor ya que es un campo no visible en el DGV.
                    Convert.ToString(dr["nombre"]),
                    Convert.ToString(dr["nombre"]),//Se completa con cualquier valor ya que es un campo no visible en el DGV.
                    Convert.ToString(dr["nombre"]),//Se completa con cualquier valor ya que es un campo no visible en el DGV.
                    Convert.ToString(dr["nombre"]),//Se completa con cualquier valor ya que es un campo no visible en el DGV.
                    Convert.ToString(dr["cuil"]),
                    Convert.ToDateTime(dr["fechaAlta"]).ToString("dd/MM/yyyy"),
                    Convert.ToString(dr["nombre"]),//Se completa con cualquier valor ya que es un campo no visible en el DGV.
                    Convert.ToString(dr["nombre"]),//Se completa con cualquier valor ya que es un campo no visible en el DGV.
                    Convert.ToString(dr["condicionIVA"]),
                    Convert.ToString(dr["IDtipoCliente"]),
                    Convert.ToString(dr["tipocliente"]));
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

        public static void CargarDGVPJ(DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT C.idCliente, C.fechaAlta, C.cuil, C.nombre, c.condicionIVA, c.tipoCliente as IDtipoCliente, TC.tipocliente
                                 FROM Clientes C
                                 INNER JOIN tipocliente TC ON C.tipoCliente = TC.idtipoCliente
                                 WHERE tipoPersona = 'PJ'";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idCliente"]),
                    Convert.ToString(""),
                    Convert.ToString(dr["nombre"]),
                    Convert.ToString(""),
                    Convert.ToString(""),
                    Convert.ToString(""),
                    Convert.ToString(dr["cuil"]),
                    Convert.ToDateTime(dr["fechaAlta"]).ToString("dd/MM/yyyy"),
                    Convert.ToString(""),
                    Convert.ToString(""),
                    Convert.ToString(dr["condicionIVA"]),
                    Convert.ToString(dr["IDtipoCliente"]),
                    Convert.ToString(dr["tipocliente"]));
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

        public static ClienteEntity AddClienteDGV(DataGridView dgv, ClienteEntity cliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT * from clientes";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idClienteProducto"]),
                    Convert.ToString(dr["tipoPersona"]),
                    Convert.ToString(dr["numDoc"]),
                    Convert.ToString(dr["apellido"]),
                    Convert.ToString(dr["nombre"]));
                }

                dr.Close();
                MySQL.DisconnectDB();

                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static ClienteEntity AddClienteText(ClienteEntity cliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT * FROM Clientes";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);

                cliente.idCliente = Convert.ToInt32(cmd.ExecuteScalar());
                
                MySQL.DisconnectDB();

                return cliente;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static string BuscarNombreCliente(int idCliente)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT CONCAT(c.idCliente, ' - ',C.apellido, ' ',C.nombre)
                                FROM clientes C
                                WHERE idCliente = @idCliente";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idCliente", idCliente);

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
