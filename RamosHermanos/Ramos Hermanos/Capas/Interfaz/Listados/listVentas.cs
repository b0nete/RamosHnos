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
using RamosHermanos.Capas.Graficos;

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
        itemFacturaEntity itemFactura = new itemFacturaEntity();

       
        private void SeleccionarDgv()
        {
            formVentas frmP = new formVentas();
            

            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvVentas.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                frmP.newORupdate = 2; //Update o Busqueda

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el pedido para cargarlo.
                factura.idFactura = Convert.ToInt32(row.Cells["colFactura"].Value.ToString());
                FacturaB.BuscarFacturaID(factura);
                frmP.txtIDFactura.Text = Convert.ToString(factura.idFactura);
                frmP.cbTipoFactura.SelectedItem = factura.tipoFactura;
                frmP.txtIDcliente.Text = Convert.ToString(factura.cliente);
                frmP.cbformaPago.SelectedItem = factura.formaPago;

                ClienteEntity cliente = ClienteB.BuscarClienteIDINT(factura.cliente);
                frmP.txtnumDoc.Text = cliente.numDoc;

                frmP.dtpfechaFactura.Value = factura.fechaFactura;
                frmP.dtpEntrega.Value = factura.fechaEntrega;
                frmP.cbEstado.SelectedItem = factura.estado;
                frmP.txtObservaciones.Text = Convert.ToString(factura.observaciones);
                frmP.txtNombre.Text = Convert.ToString(factura.nombreCompleto);
                frmP.txtTotal.Text = Convert.ToString(factura.total);
                DomicilioB.CargarCB(frmP.cbDomicilio, frmP.txtIDcliente, "1");
                //frmP.cbDomicilio.SelectedValue = factura.domicilio;
                TelefonoB.CargarCB(frmP.cbTelefono, frmP.txtIDcliente, 1);

                frmP.txtDescuento.Text = tipoClienteB.BuscarCategoriaClienteTXT(Convert.ToInt32(factura.cliente));
                frmP.cbEstado.SelectedIndex = 1;

                itemFactura.factura = dgvVentas.CurrentRow.Cells["colFactura"].Value.ToString();
                itemsFacturaB.BuscarItemFacturaDGV(itemFactura, frmP.dgvFactura, frmP.txtTotal);

                //DomicilioB.CargarTXTID(factura.domicilio, frmP.txtDomicilio);

                cliente = ClienteB.BuscarClienteCIVAyCP(factura.cliente);
                frmP.txtIVA.Text = cliente.condicionIVA;
                frmP.Show();

                frmP.calcularTotal();
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

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            formGVentas frm =  new formGVentas();
            frm.Show();
        }

    }
}
