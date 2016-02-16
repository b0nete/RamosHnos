﻿using System;
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
using RamosHermanos.Capas.Entidades;

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


        formPedidos frmP = new formPedidos();
        PedidoEntity pedido = new PedidoEntity();

        private void SeleccionarDgv()
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvListadoPedidos.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el pedido para cargarlo.
                pedido.idPedido = Convert.ToInt32(row.Cells["colIDpedido"].Value.ToString());
                PedidoB.BuscarIdPedido(pedido);
                frmP.txtidpedido.Text = Convert.ToString(pedido.idPedido);
                frmP.txtidCliente.Text = Convert.ToString(pedido.idPersona);
                frmP.dtpFecha.Value = pedido.fechaPedido;
                frmP.dtpEntrega.Value = pedido.fechaEntrega;
                frmP.cbEstado.SelectedItem = pedido.estado;
                frmP.txtObservaciones.Text = Convert.ToString(pedido.observaciones);
                frmP.txtNombre.Text = Convert.ToString(pedido.nombre) + " " + Convert.ToString(pedido.apellido);
                frmP.txtTotal.Text = Convert.ToString(pedido.total);
                frmP.tabMain.SelectedTab = frmP.tabPedido;
                //itemsPedidoB.CargarDgvPedido(item, dgvPedido);
                DomicilioB.CargarCB(frmP.cbDomicilio, frmP.txtidCliente);

            }
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            SearchParametro();
        }

        private void dgvListadoPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvListadoPedidos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SeleccionarDgv();
        }
        }
}
