﻿using System;
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
    class RepartoB
    {
        public static RepartoEntity InsertReparto(RepartoEntity reparto, TextBox txtReparto)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Repartos (distribuidor, fecha, turno) 
                                 VALUES (distribuidor, fecha, turno);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@distribuidor", reparto.distribuidor);
                cmd.Parameters.AddWithValue("@fecha", reparto.fecha);
                cmd.Parameters.AddWithValue("@turno", reparto.turno);
                
                txtReparto.Text = Convert.ToString(cmd.ExecuteScalar());

                MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return reparto;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static DataTable GenerarReparto(DataGridView dgv, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT C.idCliente, CONCAT(C.nombre, ' ', C.apellido) as nombreCompleto, D.idDomicilio, CONCAT(CC.Calle,' ',D.Numero,' PISO: ',D.Piso,', DPTO: ',D.Dpto) domicilioCompleto
                                FROM itemsRecorrido IR
                                INNER JOIN Domicilios D ON D.calle = IR.calle
                                INNER JOIN Clientes C ON C.idCliente = D.idPersona
                                INNER JOIN Recorridos R ON R.idRecorrido = IR.recorrido
                                INNER JOIN Calles CC ON D.Calle = CC.idCalle
                                WHERE idRecorrido = @idRecorrido and D.calle = @calle
                                ORDER BY D.numero";

                //MySqlCommand cmd = new MySqlCommand(queryM, MySQL.sqlcnx); 
                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dtItemsRecorrido = new DataTable();
                DataTable dtItemsRecorridoFULL = new DataTable();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells["colLuSentido"].Value.ToString() == "C")
                    {
                        cmd.CommandText = query + " DESC";
                    }

                    cmd.Parameters.AddWithValue("@sentido", Convert.ToString(row.Cells["colLuSentido"].Value));
                    cmd.Parameters.AddWithValue("@idRecorrido", txt.Text);
                    cmd.Parameters.AddWithValue("@calle", Convert.ToInt32(row.Cells["colLuIDcalle"].Value));

                    // Se Llena el dtItemsRecorrido
                    da.Fill(dtItemsRecorrido);

                    // Agregamos al DataTable principal
                    dtItemsRecorridoFULL.Merge(dtItemsRecorrido);

                    cmd.Parameters.Clear();
                    dtItemsRecorrido.Clear();
                }

                return dtItemsRecorridoFULL;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }
    }
}
