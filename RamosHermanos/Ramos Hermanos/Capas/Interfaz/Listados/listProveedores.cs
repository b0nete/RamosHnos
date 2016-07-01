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
using RamosHermanos.Capas.Interfaz.Contratos;

namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listProveedores : Form
    {
        public int caseSwitch = 2;
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
                formProveedor frmP = new formProveedor();
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
                this.Close();

            }
        }

        formCompras frm = new formCompras();
        
        private void SeleccionarDGVCompras()
        {
            
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvProveedores.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {

                DataGridViewRow rowA = this.dgvProveedores.CurrentRow as DataGridViewRow;

                //formCompras formInterface = this.Owner as formCompras;

                //formInterface.pasarDatos(rowA);

                //break;
                //DataGridViewRow rowA = this.dgvProveedores.CurrentRow as DataGridViewRow;

                //IAddItem parent = this.Owner as IAddItem;


                //parent.AddNewItemProveedor(rowA);

                DataGridViewRow row = cell.OwningRow;
                formCompras frm = new formCompras();
                frm.Show();
                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.
                proveedor.idProveedor = Convert.ToInt32(row.Cells["colIDProveedor"].Value.ToString());
                ProveedorB.BuscarIdProv(proveedor);
                frm.txtIDproveedor.Text = Convert.ToString(proveedor.idProveedor);
                frm.txtNameProveedor.Text = proveedor.razsocial;
                frm.txtCuil.Text = proveedor.cuit;
                frm.txtCondicionIva.Text = proveedor.condicioniva;
                //DomicilioB.CargarCB(frm.cbDomicilio, frm.txtIDproveedor, "2");
                EmailB.CargarTXT(frmP.txtEmail, frmP.txtidprov, 2);
                TelefonoB.CargarTXT(frm.txtTel, frm.txtIDproveedor, 2);

                //frmP.tabProveedor.SelectedTab = frmP.tabInformacion;
                Close();
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
            switch (caseSwitch)
            {
                case 1:
                    SeleccionarDGVCompras();
                    break;
                case 2:
                    SeleccionarDGV();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            SearchParametro();
        }
    }
}
