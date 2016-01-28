﻿using System;
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
    class itemsRecorridoB
    {
        public static itemRecorridoEntity InsertItemRecorrido(itemRecorridoEntity itemRecorrido)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO itemsRecorrido (recorrido, calle, desde, hasta, sentido, estado) 
                                 VALUES (@recorrido, @calle, @desde, @hasta, @sentido, @estado)";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@recorrido", itemRecorrido.recorrido);
                cmd.Parameters.AddWithValue("@calle", itemRecorrido.calle);
                cmd.Parameters.AddWithValue("@desde", itemRecorrido.desde);
                cmd.Parameters.AddWithValue("@hasta", itemRecorrido.hasta);
                cmd.Parameters.AddWithValue("@sentido", itemRecorrido.sentido);
                cmd.Parameters.AddWithValue("@estado", itemRecorrido.estado);

                cmd.ExecuteNonQuery();             

                MySQL.DisconnectDB();

                return itemRecorrido;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        
        public static itemRecorridoEntity BuscarItemRecorrido(itemRecorridoEntity itemRecorrido, DataGridView dgv)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT  IR.idcallesRecorrido, IR.recorrido, IR.calle IDcalle, C.calle, IR.desde, IR.hasta, IR.sentido, IR.estado
                                 FROM itemsRecorrido IR
                                 INNER JOIN Calles C ON IR.calle = C.idCalle
                                 WHERE recorrido = @recorrido";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@recorrido", itemRecorrido.recorrido);

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dgv.Rows.Add(
                    Convert.ToString(dr["IDcalle"]),
                    Convert.ToString(dr["calle"]),
                    Convert.ToString(dr["desde"]),
                    Convert.ToString(dr["hasta"]),
                    Convert.ToString(dr["sentido"]),
                    Convert.ToString(dr["estado"]));
                }

                dr.Close();

                MySQL.DisconnectDB();

                return itemRecorrido;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static void DeleteItemRecorrido(itemRecorridoEntity itemRecorrido)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"DELETE FROM itemsRecorrido
                                 WHERE recorrido = @recorrido";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@recorrido", itemRecorrido.recorrido);

                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static DataTable GetItemsRecorrido(DataGridView dgv, TextBox txt)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"SELECT CONCAT(C.nombre, ' ', C.apellido) as nombreCompleto, D.idDomicilio, CONCAT(CC.Calle,' ',D.Numero,' PISO: ',D.Piso,', DPTO: ',D.Dpto) domicilioCompleto
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
                    if(row.Cells["colLuSentido"].Value.ToString() == "C")
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
