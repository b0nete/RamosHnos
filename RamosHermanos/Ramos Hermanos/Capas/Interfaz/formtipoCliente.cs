﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows;
//using System.Windows.Media;
using System.Globalization;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formtipoCliente : Form
    {
        public formtipoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void formtCliente_Load(object sender, EventArgs e)
        {
            tipoClienteB.CargarDGV(dgvtipoCliente);
        }

        // Metodos del FORM.

        tipoClienteEntity tcliente = new tipoClienteEntity();

        private void CargartCliente()
        {
            tcliente.tipoCliente = txttCliente.Text;
            tcliente.descripcion = txtDescripcion.Text;
            tcliente.porcDescuento = Convert.ToInt32(txtDescuento.Text);
            tcliente.color = cbColor.Text;
            tcliente.estado = cbEstado.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CargartCliente();
            if (tipoClienteB.ExistetCliente(tcliente) == true)
            {
                MessageBox.Show("No se pueden usar valores repetidos: Tipo Cliente, Porcentaje de Descuento o Color repetidos.");
                return;
            }
            else
            {
                CargartCliente();
                tipoClienteB.InserttCliente(tcliente);
                tipoClienteB.CargarDGV(dgvtipoCliente);
            }            
        }

        private void cbColor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clr = cbColor.Text;
            Color colour = Color.FromName(clr);

            btnColor.BackColor = colour;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvtipoCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvtipoCliente_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtIDtipoCli.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un tipo de Cliente");
            }
            else
            {
                CargartCliente();
                tipoClienteB.UpdatetCliente(tcliente);
                tipoClienteB.CargarDGV(dgvtipoCliente);
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && ch == 46 && txtDescuento.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void dgvtipoCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvtipoCliente.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                tcliente.idtipoCliente = Convert.ToInt32(row.Cells["colIDtipoCli"].Value.ToString());
                txtIDtipoCli.Text = row.Cells["colIDtipoCli"].Value.ToString();
                tcliente.tipoCliente = row.Cells["coltCliente"].Value.ToString();
                txttCliente.Text = row.Cells["coltCliente"].Value.ToString();
                tcliente.descripcion = row.Cells["colDescripcion"].Value.ToString();
                txtDescripcion.Text = row.Cells["colDescripcion"].Value.ToString();
                tcliente.porcDescuento = Convert.ToInt32(row.Cells["colPorc"].Value.ToString());
                txtDescuento.Text = row.Cells["colPorc"].Value.ToString();
                tcliente.color = row.Cells["colColor"].Value.ToString();
                cbColor.Text = row.Cells["colColor"].Value.ToString();
                tcliente.estado = Convert.ToBoolean(row.Cells["colEstado"].Value.ToString());
                cbEstado.Checked = Convert.ToBoolean(row.Cells["colEstado"].Value.ToString());
            }
        }




    }
}
