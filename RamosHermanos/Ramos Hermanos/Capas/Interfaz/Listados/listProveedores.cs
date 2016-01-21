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

namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listProveedores : Form
    {
        public listProveedores()
        {
            InitializeComponent();
            cbParametro.SelectedIndex = 0;
        }
                
        formProveedor frmP = new formProveedor();
        ProveedorEntity proveedor = new ProveedorEntity();

        private void SeleccionarDGV()
        {
            
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvProveedores.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                frmP.Show();
                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.
                proveedor.idProveedor = Convert.ToInt32(row.Cells["colIDProveedor"].Value.ToString());
                ProveedorB.BuscarIdProv(proveedor);
                frmP.txtidprov.Text = Convert.ToString(proveedor.idProveedor);
                frmP.txtRazonSocial.Text = proveedor.razsocial;
                frmP.txtcuit.Text = proveedor.cuit;
                frmP.dtpFechaAlta.Value = proveedor.fecha;
                frmP.cbIVA.SelectedValue = proveedor.condicioniva;


                //Saldo
                //saldo.rol = 2;
                //saldo.idPersona = Convert.ToInt32(txtidprov.Text);
                //SaldoB.BuscarSaldo(saldo);
                //txtDebmax.Text = Convert.ToString(saldo.creditoMax);
                //txtSaldoActual.Text = Convert.ToString(saldo.saldoActual);


                //Contacto
                DomicilioB.CargarTXT(frmP.txtDomicilio, frmP.txtidprov, 2);
                EmailB.CargarTXT(frmP.txtEmail, frmP.txtidprov, 2);
                TelefonoB.CargarTXT(frmP.txtTel, frmP.txtidprov, 2);

                frmP.tabProveedor.SelectedTab = frmP.tabInformacion;

            }
        }

        private void listProveedores_Load(object sender, EventArgs e)
        {
            ProveedorB.cargardgv(dgvProveedores);
        }

        private void SearchParametro()
        {
            string parametro = '%' + txtParametro.Text + '%';
            ProveedorB.CargarDGVParametros(dgvProveedores, cbParametro, parametro);
        }

        private void dgvProveedores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SeleccionarDGV();
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            SearchParametro();
        }
    }
}
