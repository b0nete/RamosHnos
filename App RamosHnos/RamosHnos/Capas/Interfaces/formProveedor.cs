using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Negocio;

namespace RamosHnos.Capas.Interfaces
{
    public partial class formProveedor : Form
    {
        public formProveedor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formRubroProveedores frm = new formRubroProveedores();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProveedorEntity proveedor = new ProveedorEntity()
            {
                razonSocial = txtrazonSocial.Text,
                cuit = txtCUIT.Text,
                email = txtEmail.Text
            };

            ProveedorB.InsertProveedor(proveedor);
            txtIDproveedor.Text = Convert.ToString(proveedor.idProveedor);
        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            if (txtIDproveedor.Text == "")
            {
                MessageBox.Show("Asigne el proveedor a cargar un Domicilio");
            }
            else
            {
                formDomicilio frmdom = new formDomicilio();
                frmdom.txtID.Text = txtIDproveedor.Text;
                frmdom.txtNombre.Text = txtrazonSocial.Text + ' ' + '-' + ' ' + txtIDproveedor.Text;
                frmdom.Show();

                //Cargar Cliente
                string cliente = txtIDproveedor.Text;
                ClienteB.CargarDomicilioCliente(frmdom.dgvDomicilio, cliente);
            }
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            if (txtIDproveedor.Text == "")
            {
                MessageBox.Show("Asigne el proveedor a cargar un Teléfono");
            }
            else
            {
                formTelefono frmtel = new formTelefono();
                frmtel.txtID.Text = txtIDproveedor.Text;
                frmtel.txtNombre.Text = txtrazonSocial.Text + ' ' + '-' + ' ' + txtIDproveedor.Text;
                frmtel.Show();

                //Seleccionar Cliente de CB.
                frmtel.cbRoles.SelectedIndex = 1;
            }
        }
    }
}
