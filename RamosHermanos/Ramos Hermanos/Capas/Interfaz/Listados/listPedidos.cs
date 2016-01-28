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
using RamosHermanos.Capas.Interfaz;

namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listPedidos : Form
    {
        public listPedidos()
        {
            InitializeComponent();
        }

        private void listPedidos_Load(object sender, EventArgs e)
        {
            cbParametro.SelectedIndex = 0;
            PedidoB.cargardgvPedido(dgvListadoPedidos);
        }

        private void SearchParametro()
        {
            string parametro = '%' + txtParametro.Text + '%';
            PedidoB.CargarDGVParametros(dgvListadoPedidos, cbParametro, parametro);
            
        }


        private void dgvListadoPedidos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        //    private void SeleccionarDgv()
        //{
        //    DataGridViewCell cell = null;
        //    foreach (DataGridViewCell selectedCell in dgvListadoPedidos.SelectedCells)
        //    {
        //        cell = selectedCell;
        //        break;
        //    }
        //    if (cell != null)
        //    {
        //        DataGridViewRow row = cell.OwningRow;

        //        //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el pedido para cargarlo.
        //        pedido.idPedido = Convert.ToInt32(row.Cells["colIDpedido"].Value.ToString());
        //        PedidoB.BuscarIdPedido(pedido);
        //        txtidpedido.Text = Convert.ToString(pedido.idPedido);
        //        txtidCliente.Text = Convert.ToString(pedido.idPersona);
        //        dtpFecha.Value = pedido.fechaPedido;
        //        dtpEntrega.Value = pedido.fechaEntrega;
        //        cbEstado.SelectedItem = pedido.estado;
        //        txtObservaciones.Text = Convert.ToString(pedido.observaciones);
        //        txtNombre.Text = Convert.ToString(pedido.nombre) + " " + Convert.ToString(pedido.apellido);
        //        txtTotal.Text = Convert.ToString(pedido.total);                
        //        tabMain.SelectedTab = tabPedido;
        //        //itemsPedidoB.CargarDgvPedido(item, dgvPedido);
        //        DomicilioB.CargarCB(cbDomicilio, txtidCliente);
                
            }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            SearchParametro();
        }
        }
}
