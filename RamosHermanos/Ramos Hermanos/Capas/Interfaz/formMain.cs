using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Libs;


namespace RamosHermanos.Capas.Interfaz
{
    public partial class formMain : Form
    {   
        //Variables
        public string usr;
        DateTime tiempo1 = DateTime.Now;        
    
        public formMain()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRoles frm = new formRoles();
            frm.Show();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formInsumos frm = new formInsumos();
            formFactura frm = new formFactura();
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
            ;

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

        private void formMain_Load(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblUser.Text = usr;
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();

            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            string total2 = string.Format("{0:hh\\:mm\\:ss}", total);
            lblSesion.Text = total2.ToString();
        }

        //Variables
        UsuarioEntity usuario = new UsuarioEntity();

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pnlInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void distribuidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formDistribuidores frm = new formDistribuidores();
            frm.Show();
        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInsumos frm = new formInsumos();
            frm.Show();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCliente frm = new formCliente();
            frm.Show();
        }

        private void nºProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formProveedor frm = new formProveedor();
            frm.Show();
        }

       
       
       
    }
}
