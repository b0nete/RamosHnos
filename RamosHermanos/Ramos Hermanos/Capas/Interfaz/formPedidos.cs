using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Interfaz.ABMs;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formPedidos : Form
    {
      
        public formPedidos()
        {
            InitializeComponent();
        }

        PedidoEntity pedido = new PedidoEntity();
        public void cargarPedido()
        {
            pedido.rol = 1;
            pedido.idPersona = Convert.ToInt32(txtidCliente.Text);
            pedido.domicilio = Convert.ToString(cbDomicilio.SelectedValue);
            pedido.observaciones = txtObservaciones.Text;
            pedido.total = Convert.ToDouble(txtTotal.Text);
            pedido.estado = cbEstado.Text;
            pedido.fechaPedido = dtpFecha.Value;
            pedido.fechaEntrega = dtpEntrega.Value;

        }


        private void formPedidos_Load(object sender, EventArgs e)
        {
            ProductoB.CargarDGV(dgvProducto);
            ClienteB.CargarDGV(dgvCliente);
            PedidoB.cargardgvPedido(dgvListadoPedidos);
            this.reportViewer1.RefreshReport();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabProducto;
        }

        ProductoEntity producto = new ProductoEntity();
        private void CargarProducto()
        {
            //producto.idProducto;
        }

        ClienteEntity cliente = new ClienteEntity();
        private void CargarCliente()
        {

        }

        private void dgvProducto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvProducto.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el producto para cargarlo en tabInformación.

                producto.idProducto = Convert.ToInt32(row.Cells["colIDProducto"].Value.ToString());

                ProductoB.AddProductoDGV(dgvPedido, producto);

                tabMain.SelectedTab = tabPedido;
            }
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            
            formBuscarCliente frm1 = new formBuscarCliente();
            frm1.Show();
            frm1.Location = new Point(100, 100);

            formCliente frm2 = new formCliente();
            frm2.switchcase = 3;
            frm2.Show();
            frm2.caseSwitch = 1;
            int w = frm1.Width;
            frm2.Location = new Point(Convert.ToInt32(90 + w), 100);
        }

        private void dgvCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
        }

        private void dgvPedido_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            {
                // Se genera la variable para acumular los SubTotales.
                double total = 0;

                // Se recorre cada fila del DGV.
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {

                    // Se ejecutan las operaciones solo si la columna cantidad y precio tienen algún valor, ya que de lo contrario nos dará un error.
                    if (row.Cells["colCantidad"].ToString() != string.Empty && row.Cells["colPrecio"].ToString() != string.Empty)
                    {
                        row.Cells["colSubTotal"].Value = Convert.ToInt32(row.Cells["colCantidad"].Value) * Convert.ToDouble(row.Cells["colPrecio"].Value);

                        total += Convert.ToDouble(row.Cells["colSubTotal"].Value);
                    }

                    txtTotal.Text = Convert.ToString(total);
                }
            }
        }

        itemPedidoEntity itemPedido = new itemPedidoEntity();
        private void CargarItemPedido(DataGridViewRow row)
        {
            itemPedido.codProducto = Convert.ToInt32((row.Cells["colCodigo"].Value));
            itemPedido.pedido = Convert.ToInt32(txtidpedido.Text);
            itemPedido.cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);
            itemPedido.preciounitario = Convert.ToDouble(row.Cells["colPrecio"].Value);
            itemPedido.subtotal = Convert.ToDouble(row.Cells["colSubTotal"].Value);

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cargarPedido();
            PedidoB.InsertPedido(pedido, txtidpedido);

            foreach (DataGridViewRow row in dgvPedido.Rows)
            {
                CargarItemPedido(row);
                itemsPedidoB.InsertItemPedido(itemPedido, dgvPedido);
            }
            MessageBox.Show("Pedido Guardado");


        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //itemsPedidoB.InsertIntoItemPedido(itemPedido, dgvPedido);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
