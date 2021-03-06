﻿using System;
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
using RamosHermanos.Capas.Interfaz.Listados;
using RamosHermanos.Capas.Interfaz.Contratos;

namespace RamosHermanos.Capas.Interfaz.ABMs
{
    public partial class formBuscarCliente : Form
    {
        public formBuscarCliente()
        {
            InitializeComponent();
        }

        private void formBuscarCliente_Load(object sender, EventArgs e)
        {

        }

        public void CheckRB()
        {
            if (rbApellido.Checked == true)
            {
                txtApellido.Enabled = true;
                txtNombre.Enabled = false;
                txtCUIL.Enabled = false;
                txtIDCliente.Enabled = false;
            }
            else if (rbNombre.Checked == true)
            {
                txtApellido.Enabled = false;
                txtNombre.Enabled = true;
                txtCUIL.Enabled = false;
                txtIDCliente.Enabled = false;
            }
            else if (rbCUIL.Checked == true)
            {
                txtApellido.Enabled = false;
                txtNombre.Enabled = false;
                txtCUIL.Enabled = true;
                txtIDCliente.Enabled = false;
            }
            else if (rbIDCliente.Checked == true)
            {
                txtApellido.Enabled = false;
                txtNombre.Enabled = false;
                txtCUIL.Enabled = false;
                txtIDCliente.Enabled = true;
            }     
        }

        private void rbApellido_CheckedChanged(object sender, EventArgs e)
        {
            CheckRB();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            CheckRB();
        }

        private void rbCUIL_CheckedChanged(object sender, EventArgs e)
        {
            CheckRB();
        }

        private void rbIDCliente_CheckedChanged(object sender, EventArgs e)
        {
            CheckRB();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            listClientes frm = new listClientes();

            if (rbNombre.Checked == true)
            {
                
            }
            else if (rbNombre.Checked == true)
            {
                txtApellido.Enabled = false;
                txtNombre.Enabled = true;
                txtCUIL.Enabled = false;
                txtIDCliente.Enabled = false;
            }
            else if (rbCUIL.Checked == true)
            {
                txtApellido.Enabled = false;
                txtNombre.Enabled = false;
                txtCUIL.Enabled = true;
                txtIDCliente.Enabled = false;
            }
            else if (rbIDCliente.Checked == true)
            {
                //frm.Show();
                //ClienteB.CargarDGVParametros(frm.dgvCliente, txtApellido);
                //TextBox txt = txtIDCliente as TextBox;

                //GetParametro parameter = this.Owner as GetParametro;
                //parameter.AddParametro(txt);

                //DataGridViewRow rowA = this.dgvCalle.CurrentRow as DataGridViewRow;

                //IAddItem parent = this.Owner as IAddItem;
                //parent.AddNewItem(rowA);
            }     
        }

        // Entidades 
        ClienteEntity cliente = new ClienteEntity();


    }
}
