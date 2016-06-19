using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Negocio
{
    class DistribuidorB
    {
        public static bool ExisteDistribuidor(DistribuidorEntity Distribuidor)
        {
            MySQL.ConnectDB();

            string query = @"SELECT COUNT(*) FROM Distribuidores
                             WHERE numDoc = @numDoc";

            MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
            cmd.Parameters.AddWithValue("@numDoc", Distribuidor.numDoc);

            int resultado = Convert.ToInt32(cmd.ExecuteScalar());

            if (resultado == 0)
                return false;
            else
                return true;
        }

        public static DistribuidorEntity UpdateDistribuidor(DistribuidorEntity Distribuidor)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SET @@sql_safe_updates = 0; 
                                 UPDATE Distribuidores
                                 SET tipodoc = @tipoDoc, numdoc = @numDoc, fechaNacimiento = @fechaNacimiento, sexo = @sexo, cuil =  @cuil, nombre = @nombre, apellido = @apellido, estadoCivil = @estadoCivil, vehiculo = @vehiculo, estado = @estado
                                 WHERE numDoc = @numDoc;
                                 SET @@sql_safe_updates = 1";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoDoc", Distribuidor.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", Distribuidor.numDoc);
                cmd.Parameters.AddWithValue("@fechaNacimiento", Distribuidor.fechaNacimiento);
                cmd.Parameters.AddWithValue("@sexo", Distribuidor.sexo);
                cmd.Parameters.AddWithValue("@cuil", Distribuidor.cuil);
                cmd.Parameters.AddWithValue("@apellido", Distribuidor.apellido);
                cmd.Parameters.AddWithValue("@nombre", Distribuidor.nombre);
                cmd.Parameters.AddWithValue("@estadoCivil", Distribuidor.estadoCivil);
                cmd.Parameters.AddWithValue("@vehiculo", Distribuidor.vehiculo);
                cmd.Parameters.AddWithValue("@estado", Distribuidor.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Distribuidor Actualizado!");
                return Distribuidor;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static DistribuidorEntity InsertDistribuidores(DistribuidorEntity Distribuidores, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();


                string query = @"INSERT INTO Distribuidores (rol, fechaAlta, tipoDoc, numDoc, fechaNacimiento, sexo, cuil, apellido, nombre, estadoCivil, vehiculo, estado) 
                                 VALUES ('3', @fechaAlta, @tipoDoc, @numdoc, @fechaNacimiento, @sexo, @cuil, @apellido, @nombre, @estadoCivil, @vehiculo, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@fechaAlta", Distribuidores.fechaAlta);
                cmd.Parameters.AddWithValue("@tipoDoc", Distribuidores.tipoDoc);
                cmd.Parameters.AddWithValue("@numDoc", Distribuidores.numDoc);
                cmd.Parameters.AddWithValue("@fechaNacimiento", Distribuidores.fechaNacimiento);
                cmd.Parameters.AddWithValue("@sexo", Distribuidores.sexo);
                cmd.Parameters.AddWithValue("@cuil", Distribuidores.cuil);
                cmd.Parameters.AddWithValue("@apellido", Distribuidores.apellido);
                cmd.Parameters.AddWithValue("@nombre", Distribuidores.nombre);
                cmd.Parameters.AddWithValue("@estadoCivil", Distribuidores.estadoCivil);
                cmd.Parameters.AddWithValue("@vehiculo", Distribuidores.vehiculo);
                cmd.Parameters.AddWithValue("@estado", Distribuidores.estado);

                Distribuidores.idDistribuidor = Convert.ToInt32(cmd.ExecuteScalar());
                txt.Text = Convert.ToString(Distribuidores.idDistribuidor);

                MessageBox.Show("Distribuidor Guardado!");
                MySQL.DisconnectDB();

                return Distribuidores;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static DistribuidorEntity BuscarDistribuidorDOC(DistribuidorEntity Distribuidores)
        {
            try
            {
                MySQL.ConnectDB();

                string query = "SELECT * FROM Distribuidores WHERE numDoc = @numDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@numDoc", Distribuidores.numDoc);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Distribuidor no existe!");
                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    Distribuidores.idDistribuidor = Convert.ToInt32(row["idDistribuidor"]);
                    Distribuidores.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    Distribuidores.tipoDoc = Convert.ToInt32(row["tipoDoc"]);
                    Distribuidores.fechaNacimiento = Convert.ToDateTime(row["fechaNacimiento"]);
                    Distribuidores.sexo = Convert.ToString(row["sexo"]);
                    Distribuidores.cuil = Convert.ToString(row["cuil"]);
                    Distribuidores.apellido = Convert.ToString(row["apellido"]);
                    Distribuidores.nombre = Convert.ToString(row["nombre"]);
                    Distribuidores.estadoCivil = Convert.ToString(row["estadoCivil"]);
                    Distribuidores.vehiculo = Convert.ToInt32(row["vehiculo"]);
                    Distribuidores.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return Distribuidores;
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

                string query = @"SELECT D.idDistribuidor, D.fechaAlta, IDtipoDoc as IDtipoDoc, TP.tipoDoc, D.numDoc, D.fechaNacimiento, D.sexo, D.cuil, D.apellido, D.nombre, D.estado
                                 FROM Distribuidores D
                                 INNER JOIN tipoDocumento TP ON D.tipoDoc = TP.idTipoDoc";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idDistribuidor"]),
                    Convert.ToDateTime(dr["fechaAlta"]).ToString("dd/MM/yyyy"),
                    Convert.ToString(dr["numDoc"]),
                    Convert.ToString(dr["apellido"]),
                    Convert.ToString(dr["nombre"]),
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

        public static List<DistribuidorEntity> ListDistribuidores()
        {
            try
            {
                MySQL.ConnectDB();

                List<DistribuidorEntity> list = new List<DistribuidorEntity>();

                string query = @"SELECT D.idDistribuidor, CONCAT(D.nombre,' ', D.apellido) as nombreCom
                                 FROM Distribuidores D";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DistribuidorEntity distribuidor = new DistribuidorEntity();

                    distribuidor.idDistribuidor = Convert.ToInt32(dr["idDistribuidor"]);
                    distribuidor.nombreCompleto = Convert.ToString(dr["nombreCom"]);

                    list.Add(distribuidor);
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarDGVCB(ClienteEntity cliente, DataGridView dgv, string dia, string colDistribuidor)
        {
            try
            {
                MySQL.ConnectDB();
                dgv.Rows.Clear();

                string query = @"SELECT D.rol, D.idPersona, D.idDomicilio, CONCAT(C.Calle,' ',D.Numero,' ',D.Piso,' ',D.Dpto,' - ',D.CP,' - ',B.Barrio,', ',L.Localidad,', ',P.Provincia) domCompleto, V.distribuidor
                                 FROM Visitas V
                                 INNER JOIN Domicilios D ON V.Domicilio = D.idDomicilio 
                                 INNER JOIN Provincias P ON P.idProvincia = D.Provincia
                                 INNER JOIN Localidades L ON L.idLocalidad = D.Localidad
                                 INNER JOIN Barrios B ON D.Barrio = B.idBarrio
                                 INNER JOIN Calles C ON C.idCalle = D.Calle
                                 WHERE D.rol = @rol and D.idPersona = @idPersona and dia = @dia";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", cliente.rol);
                cmd.Parameters.AddWithValue("@idPersona", cliente.idCliente);
                cmd.Parameters.AddWithValue("@dia", dia);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idPersona"]),
                    Convert.ToString(""),
                    Convert.ToString(dr["idDomicilio"]),
                    Convert.ToString(dr["domCompleto"]),
                    Convert.ToString(""));
                    //Convert.ToString(dr["distribuidor"]));
                };

                dr.Close();

                //

                DataGridViewComboBoxColumn comboboxColumn = dgv.Columns[colDistribuidor] as DataGridViewComboBoxColumn;
                comboboxColumn.DataSource = DistribuidorB.ListDistribuidores();
                comboboxColumn.ValueMember = "idDistribuidor";
                comboboxColumn.DisplayMember = "nombre";

                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarCB(ComboBox cb, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT D.idDistribuidor, CONCAT(D.apellido,' ',D.nombre,' -', ' Vehículo:',' ', V.marca,', ',
                                 'Modelo: ', V.modelo,', ', 'Patente: ', V.patente) distrCompleto                                                            
                                 FROM distribuidores D
                                 INNER JOIN Vehiculos V on V.idVehiculo = D.vehiculo";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                //cmd.Parameters.AddWithValue("@rol", 1);
                cmd.Parameters.AddWithValue("@idDistribuidor", txt.Text);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                cb.DataSource = dt;
                cb.ValueMember = "idDistribuidor";
                cb.DisplayMember = "distrCompleto";


                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarCBDistrib(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = "SELECT idDistribuidor, CONCAT(apellido,' ',nombre) as nombreCompleto FROM Distribuidores";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                  da.Fill(dt);

                  cb.DataSource = dt;
                  cb.DisplayMember = "nombreCompleto";
                  cb.ValueMember = "idDistribuidor";

                  MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        public static DistribuidorEntity BuscarIdDistr(DistribuidorEntity distribuidor)
        {

            try
            {
                MySQL.ConnectDB();

                string query = @"Select * from distribuidores
                                WHERE idDistribuidor = @idDistribuidor";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idDistribuidor", distribuidor.idDistribuidor);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                if (resultado == 0)
                {
                    MessageBox.Show("El Distribuidor NO existe!");

                }
                else
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    da.Fill(dt);

                    DataRow row = dt.Rows[0];

                    distribuidor.idDistribuidor = Convert.ToInt32(row["idDistribuidor"]);
                    distribuidor.fechaAlta = Convert.ToDateTime(row["fechaAlta"]);
                    distribuidor.numDoc = Convert.ToString(row["numDoc"]);
                    distribuidor.nombreCompleto = Convert.ToString(row["Nombre"]);
                    distribuidor.estado = Convert.ToBoolean(row["estado"]);

                    MySQL.DisconnectDB();
                }
                return distribuidor;
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

                string query = @"SELECT D.idDistribuidor, D.nombre, D.apellido, D.numDoc, D.fechaAlta, D.estado
                                 FROM Distribuidores D
                                 WHERE";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idDistribuidor", parametro);
                //cmd.Parameters.AddWithValue("@tipoproductos", parametro);
                cmd.Parameters.AddWithValue("@nombre", parametro);
                cmd.Parameters.AddWithValue("@numDoc", parametro);

                if (cb.SelectedIndex == 0)
                {
                    cmd.CommandText = query + " D.idDistribuidor LIKE @idDistribuidor";
                }
                //if (cb.SelectedIndex == 1)
                //{
                //    cmd.CommandText = query + " tipoproductos LIKE @tipoproductos";
                //}
                if (cb.SelectedIndex == 1)
                {
                    cmd.CommandText = query + " D.nombre LIKE @nombre";
                }
                if (cb.SelectedIndex == 2)
                {
                    cmd.CommandText = query + " D.numDoc LIKE @numDoc";
                }


                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["idDistribuidor"]),
                    Convert.ToString(dr["fechaAlta"]),
                    //Convert.ToString(dr["numDoc"]),
                    Convert.ToString(dr["numDoc"]),
                    Convert.ToString(dr["apellido"]),
                    Convert.ToString(dr["nombre"]),
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
        
    }
}
