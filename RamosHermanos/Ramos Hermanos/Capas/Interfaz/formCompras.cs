﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; //CultureInfo
using System.Threading;
using CrystalDecisions.CrystalReports.Engine;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Interfaz.Listados;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formCompras : Form
    {
        public int caseSwitch = 1;

        public formCompras()
        {
            InitializeComponent();
        }
        
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void formCompras_Load(object sender, EventArgs e)
        {
            txtIngreso.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listInsumos frm = new listInsumos();
            frm.caseSwitch = 1;
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listProveedores frm = new listProveedores();
            frm.caseSwitch = 1;
            frm.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    
        private void limpiar()
        {
            txtIDproveedor.Text=null;
            txtCuil.Text=null;
            txtIngreso.Text = null;
            txtNameProveedor.Text = null;
            txtnumFactura.Text= null;
            txtObservaciones.Text = null;
            txtTotal.Text = null;
        }

        private void cbDomicilio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarCompras()
        {
            compras.fecha = dtpfechaFactura.Value;
            compras.observaciones = txtObservaciones.Text;
            compras.proveedor = Convert.ToInt32(txtIDproveedor.Text);
            compras.total = Convert.ToDouble(txtTotal.Text);
            compras.estado = cbEstado.Text;
            compras.numfactura = Convert.ToInt32(txtnumFactura.Text);
            compras.tipofactura = Convert.ToString(cbTipoFactura.SelectedValue);
            
        }


        
        itemComprasEntity itemcompra = new itemComprasEntity();
       
        private void cargarItemCompra(DataGridViewRow row)
        {

            itemcompra.idInsumo = Convert.ToInt32(row.Cells["colIDInsumo"].Value);
            itemcompra.idRubro = Convert.ToInt32(row.Cells["colIDRubro"].Value);
            itemcompra.marca = Convert.ToString(row.Cells["colMarca"].Value);
            itemcompra.precioUnitario = Convert.ToDouble(row.Cells["colPrecioCompra"].Value);
            itemcompra.subTotal = Convert.ToDouble(row.Cells["colSubTotal"].Value);
            itemcompra.cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);


        }
        
        ComprasEntity compras = new ComprasEntity();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //CargarCompras();
            //ComprasB.InsertCompras(compras, txtidCompras);
            
            foreach (DataGridViewRow row in dgvCompra.Rows)
            {
                cargarItemCompra(row);
                itemCompraB.InsertItemCompras(itemcompra, dgvCompra);
            }

            MessageBox.Show("guardado");

        }

        private void txtIngreso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
            
       
    }
}

