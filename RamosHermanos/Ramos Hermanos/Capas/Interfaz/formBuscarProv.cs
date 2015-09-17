using System;
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
    public partial class formBuscarProv : Form
    {
        public formBuscarProv()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
        private void BuscarProv()
        {
            formProveedor frm = new formProveedor();

            //if (frm.txtRazonSocial.Text == "")
            //{
            //    tabProveedor.Controls.Add(tabListado);
            //    tabProveedor.Controls.Remove(tabInformacion);
            //    tabProveedor.Controls.Remove(tabAdicional);
            //    tabProveedor.Controls.Remove(tabMovimientos);
            //    tabProveedor.Controls.Remove(tabPedido);
            //    tabProveedor.SelectedTab = tabListado;
            //    return;

            //}

            //cargarProv();

            //if (ProveedorB.ExisteProveedor(proveedor) == false)
            //{
            //    MessageBox.Show("El proveedor no existe");
            //    return;
            //}

            //else
            //{
            //    ProveedorB.BuscarProvRazonsocial(proveedor);
            //    txtidprov.Text = Convert.ToString(proveedor.idProveedor);
            //    txtRazonSocial.Text = proveedor.razsocial;
            //    txtcuit.Text = proveedor.cuit;
            //    txtDebmax.Text = Convert.ToString(proveedor.debMAX);
            //    dtpFechaAlta.Value = proveedor.fecha;
            //    cbIVA.SelectedValue = proveedor.condicioniva;

            //    //Cargar Saldos

            //    cargarSaldo(txtidprov);
            //    SaldoB.BuscarSaldo(saldo);
            //    txtDebmax.Text = Convert.ToString(saldo.creditoMax);
            //    //txtSaldoActual.Text = Convert.ToString(saldo.saldoActual);


            //    EmailB.CargarTXT(txtEmail, txtidprov, 2);
            //    DomicilioB.CargarTXT(txtDomicilio, txtidprov, 2);
            //    TelefonoB.CargarTXT(txtTel, txtidprov, 2);

            //}
        }
    }
}
