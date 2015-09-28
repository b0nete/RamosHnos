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
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabProducto;
            tabMain.Controls.Remove(tabClientes);
            tabMain.Controls.Remove(tabRemito);
            return;
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

        
       

        
        

        
    }
}
