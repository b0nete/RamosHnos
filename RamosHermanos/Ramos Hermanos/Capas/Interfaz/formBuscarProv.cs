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
        public formBuscarProv()
        {
            InitializeComponent();
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarProv();   
        }

        formProveedor frm = new formProveedor();
        ProveedorEntity proveedor = new ProveedorEntity();

        private void BuscarProv()
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
                
               
            }

            frm.cargarProv();

            if (ProveedorB.ExisteProveedor(proveedor) == false)
            {
                MessageBox.Show("El proveedor no existe");
                return;
            }

            else
            {
                ProveedorB.BuscarProvRazonsocial(proveedor);
                frm.txtidprov.Text = Convert.ToString(proveedor.idProveedor);
                frm.txtRazonSocial.Text = proveedor.razsocial;
                frm.txtcuit.Text = proveedor.cuit;
                frm.txtDebmax.Text = Convert.ToString(proveedor.debMAX);
                frm.dtpFechaAlta.Value = proveedor.fecha;
                frm.cbIVA.SelectedValue = proveedor.condicioniva;

                //Cargar Saldos

                //cargarSaldo(txtidprov);
                //SaldoB.BuscarSaldo(saldo);
                //txtDebmax.Text = Convert.ToString(saldo.creditoMax);
                //txtSaldoActual.Text = Convert.ToString(saldo.saldoActual);


                //EmailB.CargarTXT(txtEmail, txtidprov, 2);
                //DomicilioB.CargarTXT(txtDomicilio, txtidprov, 2);
                //TelefonoB.CargarTXT(txtTel, txtidprov, 2);

            }
        }

        private void formBuscarProv_Load(object sender, EventArgs e)
        {

        }
    }
}
