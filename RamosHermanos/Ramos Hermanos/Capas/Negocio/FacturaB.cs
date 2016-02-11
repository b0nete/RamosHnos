using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Datos;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Negocio
{
    class FacturaB
    {
        public static FacturaEntity InsertFactura(FacturaEntity factura)
        {
            try
            {
                MySQL.ConnectDB();

                string query = @"INSERT INTO Facturas (tipoFactura, numFactura, fechaFactura, fechaVencimiento, fechaEntrega, formaPago, cliente, observaciones, total, estado) 
                                 VALUES (@tipoFactura, @numFactura, @fechaFactura, @fechaVencimiento, @fechaEntrega, @formaPago, @cliente, @observaciones, @total, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                cmd.Parameters.AddWithValue("@tipoFactura", factura.tipoFactura);
                cmd.Parameters.AddWithValue("@numFactura", factura.numFactura);
                cmd.Parameters.AddWithValue("@fechaFactura", factura.fechaFactura);
                cmd.Parameters.AddWithValue("@fechaVencimiento", factura.fechaVencimiento);
                cmd.Parameters.AddWithValue("@fechaEntrega", factura.fechaEntrega);
                cmd.Parameters.AddWithValue("@formaPago", factura.formaPago);
                cmd.Parameters.AddWithValue("@cliente", factura.cliente);
                cmd.Parameters.AddWithValue("@observaciones", factura.observaciones);
                cmd.Parameters.AddWithValue("@total", factura.total);
                cmd.Parameters.AddWithValue("@estado", factura.estado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Guardado!");
                MySQL.DisconnectDB();

                return factura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static int UltimaFactura()
        {
            try
            {
                int idFactura;

                MySQL.ConnectDB();

                string query = @"SELECT MAX(idFactura) as idFactura
                                 FROM facturas;";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);

                idFactura = Convert.ToInt32(cmd.ExecuteScalar());

                MySQL.DisconnectDB();

                return idFactura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        public static FacturaEntity InsertIDFactura(FacturaEntity factura, DataGridView dgv)
        {
            try
            {                
                MySQL.ConnectDB();

                string query = @"INSERT INTO Facturas (tipoFactura, numFactura, fechaFactura, fechaVencimiento, fechaEntrega, formaPago, cliente, observaciones, total, estado) 
                                 VALUES (@tipoFactura, @numFactura, @fechaFactura, @fechaVencimiento, @fechaEntrega, @formaPago, @cliente, @observaciones, @total, @estado);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, MySQL.sqlcnx);


                foreach (DataGridView row in dgv.Rows)
                {
                    cmd.Parameters.AddWithValue("@numFactura", factura.numFactura);
                    cmd.Parameters.AddWithValue("@cliente", factura.cliente);

                    cmd.ExecuteNonQuery();
                }

                MySQL.DisconnectDB();

                return factura;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                throw;
            }
        }

        
    }
}
