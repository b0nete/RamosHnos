using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listVentas : Form
    {
        public listVentas()
        {
            InitializeComponent();
        }

        private void listVentas_Load(object sender, EventArgs e)
        {
            this.dgvVentas.Columns["colTotal"].DefaultCellStyle.Format = "c";
            this.dgvVentas.Columns["colTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            cbParametro.SelectedIndex = 0;
            FacturaB.ListFacturas(dgvVentas, "Pagado");
            dgvVentas.AutoGenerateColumns = false;
        }

        private void dgvVentas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SeleccionarDgv();
        }
        itemFacturaEntity itemfactura = new itemFacturaEntity();
        public void CargarItemFactura(DataGridViewRow row)
        {
            itemfactura.idItemFactura = Convert.ToInt32((row.Cells["colFactura"].Value));
            //itemPedido.iditemsPedido = Convert.ToInt32(row.Cells["colIdClient"].Value);
            //itemPedido.preciounitario = Convert.ToDouble(row.Cells["colPrecio"].Value);
            //itemPedido.subtotal = Convert.ToDouble(row.Cells["colSubTotal"].Value);

        }

        formVentas frmV = new formVentas();
        FacturaEntity factura = new FacturaEntity();
        itemFacturaEntity item = new itemFacturaEntity();

       
        private void SeleccionarDgv()
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvVentas.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos la venta para cargarlo.
                factura.idFactura =  Convert.ToInt32(row.Cells["colFactura"].Value.ToString());
                FacturaB.BuscarFacturaID(factura);
                frmV.txtIDFactura.Text = Convert.ToString(factura.idFactura);
                frmV.txtNombre.Text = Convert.ToString(factura.nombreCompleto);
                //frmV.txtDomicilio.Text = Convert.ToString(factura.domicilioCompleto);
                
                CargarItemFactura(row);

                itemsFacturaB.CargarDgvVentas(item, frmV.dgvFactura);

                //DomicilioB.CargarCB(frmV.cbDomicilio, frmV.txtidCliente, "1");
                frmV.Show();
                //frmP.tabMain.SelectedTab = frmP.tabPedido;
            }
        }

        private void SearchParametro()
        {
            string parametro = '%' + txtParametro.Text + '%';
            FacturaB.CargarDGVParametros(dgvVentas, cbParametro, parametro);
           
        }
        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            SearchParametro();
        }

        private void rbPagas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPagas.Checked == true)
            FacturaB.ListFacturas(dgvVentas, "Pagado");
        }

        private void rbNoPagas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoPagas.Checked == true)
            FacturaB.ListFacturas(dgvVentas, "Pendiente");
        }

    }
}
