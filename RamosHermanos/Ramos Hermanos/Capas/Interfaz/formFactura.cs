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
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formFactura : Form
    {
        public formFactura()
        {
            InitializeComponent();
        }

        private void tabFactura_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabProductos;
        }

        private void formFactura_Load(object sender, EventArgs e)
        {
            // Clientes
            ClienteB.CargarDGV(dgvCliente);

            // Productos
            ProductoB.CargarDGV(dgvProducto);

            // Valores Iniciales
            cbTipoFactura.SelectedIndex = 0;
            cbformaPago.SelectedIndex = 0;
            dtpVencimiento.Value = System.DateTime.Today.AddDays(30);
            cbEstado.SelectedIndex = 2;

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void dgvCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvCliente.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                cliente.idCliente = Convert.ToInt32(row.Cells["colIDCliente"].Value.ToString());

                ClienteB.BuscarClienteID(cliente);
                txtIDcliente.Text = Convert.ToString(cliente.idCliente);
                txtnumDoc.Text = cliente.numDoc;
                txtNombre.Text = cliente.apellido + ' ' + cliente.nombre;
                txtIVA.Text = cliente.condicionIVA;
                //txtDomicilio.Text

                DomicilioB.CargarCB(cbDomicilio, txtIDcliente);

                tabMain.SelectedTab = tabFactura;
            }
        }

        private void tabMain_MouseDoubleClick(object sender, MouseEventArgs e)
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

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                producto.idProducto = Convert.ToInt32(row.Cells["colIDProducto"].Value.ToString());

                ProductoB.AddProductoDGV(dgvFactura, producto);

                tabMain.SelectedTab = tabFactura;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CargarFactura();
            FacturaB.InsertFactura(factura);

            itemFactura.factura = txtnumFactura.Text;
            CargarItemFactura();
            itemsFacturaB.InsertItemFactura(itemFactura, dgvFactura);

        }

        // Metodos

        // Entidades

        ClienteEntity cliente = new ClienteEntity();
        private void CargarCliente()
        {
            cliente.idCliente = Convert.ToInt32(txtIDcliente.Text);
        }

        ProductoEntity producto = new ProductoEntity();
        private void CargarProducto()
        {
            //producto.idProducto;
        }

        FacturaEntity factura = new FacturaEntity();
        private void CargarFactura()
        {
            factura.tipoFactura = cbTipoFactura.Text;
            factura.numFactura = txtnumFactura.Text;
            factura.fechaFactura = dtpfechaFactura.Value;
            factura.fechaVencimiento = dtpVencimiento.Value;
            factura.fechaEntrega = dtpfechaEntrega.Value;
            factura.formaPago = cbformaPago.Text;
            factura.cliente = Convert.ToInt32(txtIDcliente.Text);
            factura.observaciones = txtObservaciones.Text;
            factura.total = Convert.ToDouble(txtTotal.Text);
            factura.estado = cbEstado.Text;
        }

        itemFacturaEntity itemFactura = new itemFacturaEntity();
        private void CargarItemFactura()
        {
            DataGridViewRow row = new DataGridViewRow();

            itemFactura.producto = Convert.ToInt32(row.Cells["colCodigo"].Value);
            itemFactura.cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);
            itemFactura.precioUnitario = Convert.ToDouble(row.Cells["colPrecio"].Value);
            //itemFactura.subTotal = Convert.ToDouble(row.Cells["colSubTotal"].Value);
        }

        private void dgvFactura_MouseClick(object sender, MouseEventArgs e)
        {
            
        }



        private void dgvFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvFactura.Rows.RemoveAt(dgvFactura.CurrentRow.Index);
        }

        private void dgvFactura_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            // Se genera la variable para acumular los SubTotales.
            double total = 0;

            // Se recorre cada fila del DGV.
            foreach (DataGridViewRow row in dgvFactura.Rows)
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

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabClientes;
        }





    }
}
