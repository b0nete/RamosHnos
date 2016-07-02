using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listCompras : Form
    {
        public listCompras()
        {
            InitializeComponent();
        }

        private void listCompras_Load(object sender, EventArgs e)
        {
            dgvCompras.AutoGenerateColumns = false;
            ComprasB.ListCompras(dgvCompras);
        }

        private void BuscarFactura()
        {
            formCompras frm = new formCompras();

            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvCompras.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el pedido para cargarlo.
                compras.idCompras = Convert.ToInt32(row.Cells["colCompra"].Value.ToString());

                DataRow dr = ComprasB.BuscarCompraID(compras.idCompras);

                frm.txtIDproveedor.Text = Convert.ToString(dr["proveedor"]);
                frm.txtNameProveedor.Text = Convert.ToString(dr["razonSocial"]);
                frm.txtCuil.Text = Convert.ToString(dr["cuit"]);
                frm.txtCondicionIva.Text = Convert.ToString(dr["condicionIVA"]);
                frm.dtpfechaFactura.Value = Convert.ToDateTime(dr["fecha"]);
                frm.txtObservaciones.Text = Convert.ToString(dr["observaciones"]);
                frm.txtTotal.Text = Convert.ToString(dr["total"]);
                frm.cbEstado.Text = Convert.ToString(dr["estado"]);
                frm.txtDomicilio.Text = DomicilioB.CargarTXTSTRING(frm.txtIDproveedor, 2);
                frm.txtTel.Text = TelefonoB.CargarTXTString(frm.txtIDproveedor, 2);

                //Buscamos ItemsCompra
                itemCompraB.BuscarItemCompra(compras.idCompras, frm.dgvCompra);

                

                //ClienteEntity cliente = ClienteB.BuscarClienteCIVAyCP(factura.cliente);
                //frmP.txtIVA.Text = cliente.condicionIVA;
                //frmP.cbformaPago.Text = "Contado";
                frm.caseNueva = 2;
                frm.Show();
            }
        }

        // Entidades

        ComprasEntity compras = new ComprasEntity();

        itemComprasEntity itemCompra = new itemComprasEntity();

        private void dgvCompras_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BuscarFactura();
        }
    }
}
