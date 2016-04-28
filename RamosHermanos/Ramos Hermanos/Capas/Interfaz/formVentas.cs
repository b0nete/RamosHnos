using System;
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

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formVentas : Form
    {
        public formVentas()
        {
            InitializeComponent();
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
            string ruta = Application.StartupPath.Replace(@"\bin\Debug", "");
            string rep = @"\Capas\Reportes\Comprobante\crComprobante.rpt";

            dsComprobante ds = new dsComprobante();

            ////Factura
            ds.Tables["factura"].Rows.Add
            (
                new object[]
                {
                    txtIDFactura.Text,
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
    }
}
