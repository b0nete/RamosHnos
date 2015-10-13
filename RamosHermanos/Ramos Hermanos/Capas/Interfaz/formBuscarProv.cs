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
    public partial class formBuscarProv : Form
    {
        public int caseSwitch = 0;
        public formBuscarProv()
        {
            InitializeComponent();
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (caseSwitch)
            {                
                case 1:
                    BuscarProvRazonSocial();
                    break;
                case 2:
                    BuscarProvCuit();
                    break;
                case 3:
                    BuscarIDProveedor();
                    break;
                
            }
        }

        formProveedor frm = new formProveedor();
        ProveedorEntity proveedor = new ProveedorEntity();

        private void BuscarProvRazonSocial()
        {
            
            if (txtRazonSocial.Text == "")
            {
                frm.tabProveedor.Controls.Remove(frm.tabInformacion);
                frm.tabProveedor.Controls.Remove(frm.tabAdicional);
                frm.tabProveedor.Controls.Remove(frm.tabMovimientos);
                frm.tabProveedor.Controls.Remove(frm.tabPedido);
                frm.Show();
                frm.tabProveedor.SelectedTab = frm.tabListado;
                frm.tabProveedor.Controls.Add(frm.tabListado);

                return;
            }

            //frm.cargarProv();
            proveedor.razsocial = txtRazonSocial.Text;

            if (ProveedorB.ExisteProveedor(proveedor) == false)
            {
                MessageBox.Show("El proveedor no existe");
                return;
            }
            else
            {
                ProveedorB.BuscarProvRazonsocial(proveedor);
                txtRazonSocial.Text = "";
                frm.Show();
                frm.txtidprov.Text = Convert.ToString(proveedor.idProveedor);
                frm.txtRazonSocial.Text = proveedor.razsocial;
                frm.txtcuit.Text = proveedor.cuit;
                //frm.txtDebmax.Text = Convert.ToString(proveedor.debMAX);
                frm.dtpFechaAlta.Value = proveedor.fecha;
                frm.cbIVA.SelectedValue = proveedor.condicioniva;

                //Cargar Saldos

                //cargarSaldo(txtidprov);
                //SaldoB.BuscarSaldo(saldo);
                //txtDebmax.Text = Convert.ToString(saldo.creditoMax);
                //txtSaldoActual.Text = Convert.ToString(saldo.saldoActual);


                EmailB.CargarTXT(frm.txtEmail, frm.txtidprov, 2);
                DomicilioB.CargarTXT(frm.txtDomicilio, frm.txtidprov, 2);
                TelefonoB.CargarTXT(frm.txtTel, frm.txtidprov, 2);
                

            }
        }

        private void BuscarProvCuit()
        {

            if (txtCuit.Text == "")
            {
                frm.tabProveedor.Controls.Remove(frm.tabInformacion);
                frm.tabProveedor.Controls.Remove(frm.tabAdicional);
                frm.tabProveedor.Controls.Remove(frm.tabMovimientos);
                frm.tabProveedor.Controls.Remove(frm.tabPedido);
                frm.Show();
                frm.tabProveedor.SelectedTab = frm.tabListado;
                frm.tabProveedor.Controls.Add(frm.tabListado);
                return;
            }

            //frm.cargarProv();
            proveedor.cuit = txtCuit.Text;

            if (ProveedorB.ProveedorCuit(proveedor) == false)
            {
                MessageBox.Show("El proveedor no existe");
                return;
            }
            else
            {
                ProveedorB.BuscarProvCuit(proveedor);
                txtRazonSocial.Text = "";
                frm.Show();
                frm.txtidprov.Text = Convert.ToString(proveedor.idProveedor);
                frm.txtRazonSocial.Text = proveedor.razsocial;
                frm.txtcuit.Text = proveedor.cuit;
                //frm.txtDebmax.Text = Convert.ToString(proveedor.debMAX);
                frm.dtpFechaAlta.Value = proveedor.fecha;
                frm.cbIVA.SelectedValue = proveedor.condicioniva;

                //Cargar Saldos

                //cargarSaldo(txtidprov);
                //SaldoB.BuscarSaldo(saldo);
                //txtDebmax.Text = Convert.ToString(saldo.creditoMax);
                //txtSaldoActual.Text = Convert.ToString(saldo.saldoActual);


                EmailB.CargarTXT(frm.txtEmail, frm.txtidprov, 2);
                DomicilioB.CargarTXT(frm.txtDomicilio, frm.txtidprov, 2);
                TelefonoB.CargarTXT(frm.txtTel, frm.txtidprov, 2);


            }
        }

        private void BuscarIDProveedor()
        {

            if (txtNproveedor.Text == "")
            {
                frm.tabProveedor.Controls.Remove(frm.tabInformacion);
                frm.tabProveedor.Controls.Remove(frm.tabAdicional);
                frm.tabProveedor.Controls.Remove(frm.tabMovimientos);
                frm.tabProveedor.Controls.Remove(frm.tabPedido);
                frm.Show();
                frm.tabProveedor.SelectedTab = frm.tabListado;
                frm.tabProveedor.Controls.Add(frm.tabListado);

                return;
            }

            //frm.cargarProv();
            proveedor.idProveedor= Convert.ToInt32(txtNproveedor.Text);

            if (ProveedorB.ProveedorID(proveedor) == false)
            {
                MessageBox.Show("El proveedor no existe");
                return;
            }
            else
            {
                ProveedorB.BuscarIdProv(proveedor);
                txtRazonSocial.Text = "";
                frm.Show();
                frm.txtidprov.Text = Convert.ToString(proveedor.idProveedor);
                frm.txtRazonSocial.Text = proveedor.razsocial;
                frm.txtcuit.Text = proveedor.cuit;
                //frm.txtDebmax.Text = Convert.ToString(proveedor.debMAX);
                frm.dtpFechaAlta.Value = proveedor.fecha;
                frm.cbIVA.SelectedValue = proveedor.condicioniva;

                //Cargar Saldos

                //cargarSaldo(txtidprov);
                //SaldoB.BuscarSaldo(saldo);
                //txtDebmax.Text = Convert.ToString(saldo.creditoMax);
                //txtSaldoActual.Text = Convert.ToString(saldo.saldoActual);


                EmailB.CargarTXT(frm.txtEmail, frm.txtidprov, 2);
                DomicilioB.CargarTXT(frm.txtDomicilio, frm.txtidprov, 2);
                TelefonoB.CargarTXT(frm.txtTel, frm.txtidprov, 2);


            }
        }


        private void formBuscarProv_Load(object sender, EventArgs e)
        {
            RBrazonsocial.Checked = true;
            txtRazonSocial.Enabled = true;
            txtCuit.Enabled = false;
            txtNproveedor.Enabled = false;
                       
        }

        private void RBrazonsocial_CheckedChanged(object sender, EventArgs e)
        {
            caseSwitch = 1;
            txtRazonSocial.Enabled = true;
            txtCuit.Text = "";
            txtCuit.Enabled = false;
            txtNproveedor.Text = "";
            txtNproveedor.Enabled = false;
        }

        private void RBcuit_CheckedChanged(object sender, EventArgs e)
        {
            caseSwitch = 2;
            txtRazonSocial.Text = "";
            txtRazonSocial.Enabled = false;
            txtCuit.Enabled = true;
            txtNproveedor.Text = "";
            txtNproveedor.Enabled = false;
        }

        
        private void RBnproveedor_CheckedChanged(object sender, EventArgs e)
        {
            caseSwitch = 3;
            txtRazonSocial.Enabled = false;
            txtRazonSocial.Text = "";
            txtCuit.Enabled = false;
            txtCuit.Text = "";
            txtNproveedor.Enabled = true;

        }

        private void txtNproveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }




    }
}
