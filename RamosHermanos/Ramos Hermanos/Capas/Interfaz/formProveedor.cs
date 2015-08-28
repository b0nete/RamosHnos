using System;
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


namespace RamosHermanos.Capas.Interfaz
{
    public partial class formProveedor : Form
    {
        public formProveedor()
        {
            InitializeComponent();
        }

        private void formProveedor_Load(object sender, EventArgs e)
        {
            cbIVA.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cargarProv();
            ProveedorB.InsertProveedor(proveedor, txtidprov);

        }

        ProveedorEntity proveedor = new ProveedorEntity();

        private void cargarProv()
        {
            proveedor.fecha = dtpFechaAlta.Value;
            proveedor.cuit = txtcuit.Text;
            proveedor.razsocial = txtRazonSocial.Text;
            proveedor.estado = cbEstado.Checked;
            proveedor.condicioniva = cbIVA.SelectedText;
            proveedor.rol = 2;
               


        }

        
        SaldoEntity saldo = new SaldoEntity();

        private void cargarsaldo()
        {

            saldo.idPersona = Convert.ToInt32(txtidprov.Text);
            saldo.rol = 2;
            saldo.creditoMax = Convert.ToDouble(txtDebmax.Text);


        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (txtidprov.Text == string.Empty)
            {

                MessageBox.Show("Por favor, ingrese un proveedor");

            }

            else
            {
                formContacto frm = new formContacto();
                frm.txtIDALL.Text = txtidprov.Text;
                frm.tabVar = 2;
                frm.cbRolALL.SelectedValue = 2;
                frm.txtNombreEmail.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreDom.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreTel.Text = txtRazonSocial.Text + " - " + txtidprov.Text;

                frm.Show();


            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            formContacto frm = new formContacto();
            frm.txtIDALL.Text = Convert.ToString(txtidprov.Text);
            frm.tabVar = 0;
            frm.Show();
        }

        private void BuscarProveedor()
        {

            if (txtRazonSocial.Text == "")

            {
                tabProveedor.SelectedTab = tabListado;
                return;
                
            }

            cargarProv();

            if (ProveedorB.ExisteProveedor(proveedor) == false)
            {

                MessageBox.Show("El Proveedor no Existe");
                return;
            }

            else

            {

                ProveedorB.BuscarProvRazonsocial(proveedor);
                txtidprov.Text = Convert.ToString(proveedor.idProveedor);
                txtRazonSocial.Text = proveedor.razsocial;
                txtcuit.Text = proveedor.cuit;

                CargarSaldo(txtidprov);
                SaldoB.BuscarSaldo(saldo);
                txtDebmax.Text = Convert.ToString(saldo.creditoMax);
                

                
            }
           
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {

            formContacto frm = new formContacto();
            frm.txtIDALL.Text = Convert.ToString(txtidprov.Text);
            frm.tabVar = 1;
            frm.Show();
        }

        SaldoEntity deb = new SaldoEntity();
       
        public void CargarSaldo(TextBox txt)
        {
            deb.rol = 1;
            deb.idPersona = Convert.ToInt32(txt.Text);
            saldo.creditoMax = Convert.ToDouble(txtDebmax.Text);
                        
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarProveedor();

        }
    }
}
