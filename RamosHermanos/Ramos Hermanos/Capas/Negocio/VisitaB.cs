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

                string query = @"INSERT INTO dias (idDias, lunes, martes, miercoles, jueves, viernes, sabado, domingo) 
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

                string query = @"INSERT INTO orden (idOrden, lunes, martes, miercoles, jueves, viernes, sabado, domingo) 
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
