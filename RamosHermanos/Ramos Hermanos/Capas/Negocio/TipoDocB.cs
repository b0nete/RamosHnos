using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Datos;


namespace RamosHermanos.Capas.Negocio
{
    class TipoDocB
    {
        public static TipoDocEntity InsertTipoDoc(TipoDocEntity tipodoc)
        {
            try
            {
                MySQL.ConnectDB();
                string query = @"INSERT INTO TipoDocumento (tipoDoc, estado)
                                 VALUES (@tipoDoc, @estado);
                                 SELECT LAST_INSERT_ID();";
                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoDoc", tipodoc.tipoDoc);
                cmd.Parameters.AddWithValue("@estado", tipodoc.estado);

                tipodoc.idtipoDoc=Convert.ToInt32(cmd.ExecuteScalar());                
                MySQL.DisconnectDB();
                MessageBox.Show("Tipo Documento Guardado!");
                return tipodoc;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex);
                throw;
            }
        }

        
        public static void LlenarDGV (DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();
                DataTable dt = new DataTable();
                
                string query = @"SELECT tipoDoc 'Tipo Documento', Estado FROM tipoDocumento";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);   
 
                da.Fill(dt);

                dgv.DataSource = dt;                
                
                MySQL.DisconnectDB();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }


        public static void CargarTipoDoc(ComboBox cb)
        {
            try
            {
                DataTable dt = new DataTable();
                MySQL.ConnectDB();

                string query = "SELECT * FROM tipoDocumento";  

                ﻿﻿MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                cb.DataSource = dt;
                cb.DisplayMember = "TipoDoc";
                cb.ValueMember = "idTipoDoc";
                
           
                MySQL.DisconnectDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        public static DataTable ExisteTipoDoc()
        {
            try
            {
                MySQL.ConnectDB();
                DataTable dt = new DataTable();

                string query = "SELECT * FROM tipoDocumento";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                
                MySQL.DisconnectDB();
                return dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }            
        }



        
    }
}
