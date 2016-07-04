﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Reportes;
using RamosHermanos.Capas.Reportes.Comprobante;
using RamosHermanos.Capas.Interfaz.Listados;
using RamosHermanos.Capas.Interfaz.Contratos;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formVentas : Form, produccionForm
    {
        public formVentas()
        {
            InitializeComponent();
        }

        public void pasarDatos(DataGridViewRow row)
        {
            string idProducto = row.Cells["colIDProducto"].Value.ToString();
            string producto = row.Cells["colProducto"].Value.ToString();
            //string check = "true";

            this.dgvFactura.Rows.Add(new[] { idProducto, producto });
        }

        private void formFactura_Load(object sender, EventArgs e)
        {
            dgvFactura.AutoGenerateColumns = false;
        }

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            factura.estado = cbEstado.Text;
            FacturaB.UpdateFactura(factura);
        }

        // Entidades
        FacturaEntity factura = new FacturaEntity();

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            //string valor = "00000000";
            string ruta = Application.StartupPath.Replace(@"\bin\Debug", "");
            string rep = @"\Capas\Reportes\Comprobante\crComprobante.rpt";
            string change;
            dsComprobante ds = new dsComprobante();

            ////Factura
            ds.Tables["factura"].Rows.Add
            (
                new object[]
                { 
                    change = string.Format("{0,18:00000000}", Convert.ToInt32(txtIDFactura.Text)),
                    //Convert.ToString(valor + Convert.ToInt32(txtIDFactura.Text)),
                    dtpfechaFactura.Text,
                    txtNombre.Text,
                    txtDomicilio.Text,
                    txtTotal.Text,
                    txtIVA.Text,
                    cbformaPago.Text
                }
            );

            //ItemsFactura
            foreach (DataGridViewRow dRow in dgvFactura.Rows)
            {
                ds.Tables["itemsFactura"].Rows.Add
                (
                new object[]
                {
                    dRow.Cells["colCantidad"].Value,
                    dRow.Cells["colProducto"].Value,
                    dRow.Cells["colPrecio"].Value,
                    dRow.Cells["colSubTotal"].Value,   
                }
                );
            };

            //Cargar Reporte
            formReports frm = new formReports();
            frm.Show();
            ReportDocument rd = new ReportDocument();
            rd.Load(ruta + rep);
            //rd.Load("C:/Users/b0nete/Documents/GitHub/RamosHnos/RamosHermanos/Ramos Hermanos/Capas/Reportes/Recorridos/crFactura.rpt");
            rd.SetDataSource(ds);
            frm.crvReporte.ReportSource = rd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listProductos frm = new listProductos();
            frm.caseSwitch = 2;
            frm.Show(this);
        }

        private void dgvFactura_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            double precioUnitario;

            foreach (DataGridViewRow dRow in dgvFactura.Rows)
            {                
                if (dRow.Cells["colCodigo"].Value.ToString() != string.Empty)
                {
                    int codProducto = Convert.ToInt32(dRow.Cells["colCodigo"].Value.ToString());
                    precioUnitario = PrecioProductosB.UltimoPrecio(codProducto);
                    dRow.Cells["colPrecio"].Value = precioUnitario;
                }
            }
        }

        private void dgvFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFactura.CurrentRow.Cells["colCodigo"].Value.ToString() != string.Empty && dgvFactura.CurrentRow.Cells["colCantidad"].Value.ToString() != string.Empty)
            {
                int cantidad = Convert.ToInt32(dgvFactura.CurrentRow.Cells["colCantidad"].Value.ToString());
                double precioUnitario = PrecioProductosB.UltimoPrecio(Convert.ToInt32(dgvFactura.CurrentRow.Cells["colCodigo"].Value.ToString()));
                dgvFactura.CurrentRow.Cells["colSubTotal"].Value = Convert.ToString(cantidad * precioUnitario);
            }
        }
    }
}
