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

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formFactura : Form
    {
        public formFactura()
        {
            InitializeComponent();
        }

        private void tabFactura_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabProductos;
        }

        private void formFactura_Load(object sender, EventArgs e)
        {
            // Clientes
            ClienteB.CargarDGV(dgvCliente);

            // Productos
            ProductoB.CargarDGV(dgvProducto);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void dgvCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvCliente.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                cliente.idCliente = Convert.ToInt32(row.Cells["colIDCliente"].Value.ToString());

                //ClienteB.BuscarClienteID(cliente);
                //txtIDcliente.Text = Convert.ToString(cliente.idCliente);
                //dtpFechaAlta.Value = cliente.fechaAlta;
                //cbTipoDoc.SelectedValue = cliente.tipoDoc;
                //txtnumDoc.Text = cliente.numDoc;
                //cbSexo.Text = cliente.sexo;
                //txtCUIL.Text = cliente.cuil;
                //txtApellido.Text = cliente.apellido;
                //txtNombre.Text = cliente.nombre;
                //cbEstadoCivil.Text = cliente.estadoCivil;
                //cbIVA.Text = cliente.condicionIVA;
                //cbTipoCliente.SelectedValue = cliente.tipoCliente;
                //cbEstado.Checked = cliente.estado;

                tabMain.SelectedTab = tabFactura;
            }
        }

        // Metodos

        // Entidades

        ClienteEntity cliente = new ClienteEntity();
        private void CargarCliente()
        {
        }

        ProductoEntity producto = new ProductoEntity();
        private void CargarProducto()
        {
        }
       

    }
}
