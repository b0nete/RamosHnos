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

        formCliente frm = new formCliente();
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frm.caseSwitch = 3;
            frm.Show();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PedidoB.InsertPedido(pedido);
        }

        formProducto frm1 = new formProducto();
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frm1.caseSwitch = 2;
            frm1.Show();
        }

        private void formPedidos_Load(object sender, EventArgs e)
        {
            ProductoB.CargarDGV(dgvPedido);
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        formContacto frm2 = new formContacto();
        private void BtnAgregarDomicilio_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        

        

        
    }
}
