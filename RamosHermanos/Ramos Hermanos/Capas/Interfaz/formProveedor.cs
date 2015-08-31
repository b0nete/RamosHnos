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
            cargarSaldo();
            SaldoB.InsertSaldo(saldo);
            cargarEmail();
            


        }

        ProveedorEntity proveedor = new ProveedorEntity();

        private void cargarProv()

        {
            proveedor.fecha = dtpFechaAlta.Value;
            proveedor.cuit = txtcuit.Text;
            proveedor.razsocial = txtRazonSocial.Text;
            proveedor.estado = cbEstado.Checked;
            proveedor.condicioniva = cbIVA.Text;
            proveedor.rol = 2;
               
        }

        SaldoEntity saldo = new SaldoEntity();

        private void cargarSaldo()

        {

            saldo.idPersona =Convert.ToInt32(txtidprov.Text);
            saldo.rol = 2;
            saldo.creditoMax = Convert.ToDouble(txtDebmax.Text);
            //saldo.saldoActual = Convert.ToDouble(txtSaldoActual.Text);
            

                

        
        }

        EmailEntity email = new EmailEntity();

        private void cargarEmail()

        {

            email.idPersona = Convert.ToInt32(txtidprov.Text);
            email.rol = 2;
               
        }

             
           
             
        private void btnSearch_Click(object sender, EventArgs e)
        {
            proveedor.razsocial = txtRazonSocial.Text;
            ProveedorB.BuscarProvRazonsocial(proveedor);
            txtcuit.Text = proveedor.cuit;
            txtidprov.Text = Convert.ToString(proveedor.idProveedor);
            cbEstado.Checked = proveedor.estado;
            cbIVA.SelectedValue = proveedor.condicioniva;
            dtpFechaAlta.Value = proveedor.fecha;


            saldo.rol = 2;
            saldo.idPersona= Convert.ToInt32(txtidprov.Text);
            SaldoB.BuscarSaldo(saldo);
            txtDebmax.Text = Convert.ToString(saldo.creditoMax);
            //txtSaldo.Text = Convert.ToString(saldo.saldoActual);


            EmailB.CargarTXT(txtEmail , txtidprov, 2);
            DomicilioB.CargarTXT(txtDomicilio , txtidprov, 2);
            TelefonoB.CargarTXT(txtTel , txtidprov, 2);

                                           
        }



        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            if (txtidprov.Text == string.Empty)
            {

                MessageBox.Show("Por favor, ingrese un proveedor");

            }

            else
            {
                formContacto frm = new formContacto();
                frm.txtIDALL.Text = txtidprov.Text;
                frm.tabVar = 0;
                frm.cbRolALL.SelectedValue = 2;
                frm.txtNombreEmail.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreDom.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreTel.Text = txtRazonSocial.Text + " - " + txtidprov.Text;

                frm.Show();


            }
        }

        private void btnTelefono_Click_1(object sender, EventArgs e)
        {
            if (txtidprov.Text == string.Empty)
            {

                MessageBox.Show("Por favor, ingrese un proveedor");

            }

            else
            {
                formContacto frm = new formContacto();
                frm.txtIDALL.Text = txtidprov.Text;
                frm.tabVar = 1;
                frm.cbRolALL.SelectedValue = 2;
                frm.txtNombreEmail.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreDom.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreTel.Text = txtRazonSocial.Text + " - " + txtidprov.Text;

                frm.Show();


            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
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

        
              

        
    }
}
