﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RamosHnos.Capas.Interfaces
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCliente frm = new formCliente();
            frm.Show();

        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProveedor frm = new formProveedor();
            frm.Show();
        }

        private void agregarInsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInsumo frm = new formInsumo();
            frm.Show();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsuario frm = new formUsuario();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void verClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListado frm = new formListado();
            frm.Show();
        }

        private void verProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListado frm = new formListado();
            frm.Show();
        }

        private void verInsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListado frm = new formListado();
            frm.Show();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListado frm = new formListado();
            frm.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio frm = new Inicio();
            frm.Show();
        }

        private void ingresarGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGenerarComprobante frm = new formGenerarComprobante();

            frm.Show();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProducto frm = new formProducto();
            frm.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRol frm = new formRol();
            frm.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Test frm = new Test();
            frm.Show();
        }
    }
}
