using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Datos;


namespace RamosHermanos.Capas.Negocio
{
    class VisitaB
    {

        public static VisitaEntity BuscarVisita(VisitaEntity visita)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT * 
                                 FROM Visitas V
                                 INNER JOIN Dias D ON V.idVisita = D.idDias
                                 INNER JOIN Orden O ON V.idVisita = O.idOrden";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@rol", visita.rol);
                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);

                DataRow row = dt.Rows[0];

                visita.horarioVisitaA = Convert.ToString(row["horarioVisitaA"]);
                visita.horarioVisitaB = Convert.ToString(row["horarioVisitaB"]);
                // Dias
                visita.dlunes = Convert.ToBoolean(row["dlunes"]);
                visita.dmartes = Convert.ToBoolean(row["dmartes"]);
                visita.dmiercoles = Convert.ToBoolean(row["dmiercoles"]);
                visita.djueves = Convert.ToBoolean(row["djueves"]);
                visita.dviernes = Convert.ToBoolean(row["dviernes"]);
                visita.dsabado = Convert.ToBoolean(row["dsabado"]);
                visita.ddomingo = Convert.ToBoolean(row["ddomingo"]);
                //Orden
                visita.olunes = Convert.ToInt32(row["olunes"]);
                visita.omartes = Convert.ToInt32(row["omartes"]);
                visita.omiercoles = Convert.ToInt32(row["omiercoles"]);
                visita.ojueves = Convert.ToInt32(row["ojueves"]);
                visita.oviernes = Convert.ToInt32(row["oviernes"]);
                visita.osabado = Convert.ToInt32(row["osabado"]);
                visita.odomingo = Convert.ToInt32(row["odomingo"]);

                MySQL.DisconnectDB();

                return visita;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static VisitaEntity InsertVisita(VisitaEntity visita)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO visitas (rol, idPersona, horarioVisitaA, horarioVisitaB) 
                                 VALUES ('1', @idPersona, @horarioVisitaA, @horarioVisitaB);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idPersona", visita.idPersona);
                cmd.Parameters.AddWithValue("@horarioVisitaA", visita.horarioVisitaA);
                cmd.Parameters.AddWithValue("@horarioVisitaB", visita.horarioVisitaB);

                visita.idVisita = Convert.ToInt32(cmd.ExecuteScalar());
               
                //MessageBox.Show("Visita Guardada!");
                MySQL.DisconnectDB();

                return visita;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static VisitaEntity InsertDias(VisitaEntity visita)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO dias (idDias, dlunes, dmartes, dmiercoles, djueves, dviernes, dsabado, ddomingo) 
                                  VALUES (@idDias, @dlunes, @dmartes, @dmiercoles, @djueves, @dviernes, @dsabado, @ddomingo);";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idDias", visita.idDias);
                cmd.Parameters.AddWithValue("@dlunes", visita.dlunes);
                cmd.Parameters.AddWithValue("@dmartes", visita.dmartes);
                cmd.Parameters.AddWithValue("@dmiercoles", visita.dmiercoles);
                cmd.Parameters.AddWithValue("@djueves", visita.djueves);
                cmd.Parameters.AddWithValue("@dviernes", visita.dviernes);
                cmd.Parameters.AddWithValue("@dsabado", visita.dsabado);
                cmd.Parameters.AddWithValue("@ddomingo", visita.ddomingo);

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Dias Guardados!");
                MySQL.DisconnectDB();

                return visita;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static VisitaEntity InsertOrden(VisitaEntity visita)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO orden (idOrden, olunes, omartes, omiercoles, ojueves, oviernes, osabado, odomingo) 
                                  VALUES (@idOrden, @olunes, @omartes, @omiercoles, @ojueves, @oviernes, @osabado, @odomingo);";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@idOrden", visita.idOrden);
                cmd.Parameters.AddWithValue("@olunes", visita.olunes);
                cmd.Parameters.AddWithValue("@omartes", visita.omartes);
                cmd.Parameters.AddWithValue("@omiercoles", visita.omiercoles);
                cmd.Parameters.AddWithValue("@ojueves", visita.ojueves);
                cmd.Parameters.AddWithValue("@oviernes", visita.oviernes);
                cmd.Parameters.AddWithValue("@osabado", visita.osabado);
                cmd.Parameters.AddWithValue("@odomingo", visita.odomingo);

                cmd.ExecuteNonQuery();

                //MessageBox.Show("Orden Guardado!");
                MySQL.DisconnectDB();

                return visita;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void CargarBOOL(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = "SELECT diasSemana FROM visitas";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                  MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                  da.Fill(dt);       

                  cb.DataSource = dt;
                  cb.DisplayMember = "diasSemana";


                  MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }
    }
}
