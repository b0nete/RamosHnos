﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCliente frm = new formCliente();
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRoles frm = new formRoles();
            frm.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLogin frm = new formLogin();
            frm.Show();
              //Test frm = new Test();
              //frm.Show();
        }

        private void rubroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRubro frm = new formRubro();
            frm.Show();

        }

        private void agregarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProveedor frm = new formProveedor();
            frm.Show();

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProducto frm = new formProducto();
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formUsuario frm = new formUsuario();
            frm.Show();
        }
    }
}
