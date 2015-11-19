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
using RamosHermanos.Capas.Interfaz.ABMs;
using RamosHermanos.Libs;
using RamosHermanos.Capas.Interfaz.Listados;


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

        }

        private void insumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formInsumos frm = new formInsumos();
            frm.Show();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCliente frm = new formCliente();
            frm.caseSwitch = 3;
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

        private void dNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCliente frm = new formCliente();
            frm.caseSwitch = 1;
            frm.Show();
        }

        private void personaJurídicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCliente frm = new formCliente();
            frm.caseSwitch = 2;
            frm.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formBuscarProv frm = new formBuscarProv();
            frm.Show();
        }

        private void testToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void ingresarGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            formDistribuidores frm = new formDistribuidores();
            frm.Show();
            frm.CaseListado();
            
        }

        private void registrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            formDistribuidores frm = new formDistribuidores();
            frm.Show();
            frm.CaseNuevo();
        }

        private void nºInsumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBuscarInsumo frm = new formBuscarInsumo();
            frm.Show();
        }

        private void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formPedidos frm = new formPedidos();
            frm.Show();
        }

        private void testFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFactura frm = new formFactura();
            frm.Show();
        }

        private void testDGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formTestDGV frm = new formTestDGV();
            frm.Show();
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formParametros frm1 = new formParametros();
            frm1.Show();
            frm1.Location = new Point(100, 100);

            listCaja frm2 = new listCaja();
            frm2.Show();
            frm2.Location = new Point(Convert.ToInt32(90 + frm1.Width), 100);
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formBuscarCliente frm1 = new formBuscarCliente();
            frm1.Show();
            frm1.Location = new Point(100, 100);

            listClientes frm2 = new listClientes();
            frm2.Show();
            int w = frm1.Width;
            frm2.Location = new Point(Convert.ToInt32(90 + w) , 100);
        }

       
       
       
    }
}
