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
    public partial class listProductos : Form
    {
        public listProductos()
        {
            InitializeComponent();
        }

        ProductoEntity producto = new ProductoEntity();
        formPedidos frmP = new formPedidos();

        private void listProductos_Load(object sender, EventArgs e)
        {
            cbParametro.SelectedIndex = 0;
            ProductoB.CargarDGV(dgvProducto);
        }

        private void dgvProducto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvProducto.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                formProducto frmPro = new formProducto();
                frmPro.Show();

                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                producto.idProducto = Convert.ToInt32(row.Cells["colIDProducto"].Value.ToString());

                ProductoB.BuscarIdProducto(producto);
                frmPro.txtIDProd.Text = Convert.ToString(producto.idProducto);
                frmPro.dtpFechaAlta.Value = Convert.ToDateTime(producto.fechaAlta);
                //frmPro.cbTipoProducto.SelectedValue = producto.tipoProducto;
                frmPro.cbMarca.SelectedValue = producto.marca;
                frmPro.txtProducto.Text = producto.producto;
                frmPro.txtDescripcion.Text = producto.descripcion;
                frmPro.txtCantidad.Text = Convert.ToString(producto.cantidad);
                frmPro.cbMedida.SelectedValue = producto.medida;

                PrecioProductosB.UltimoPrecioDGV(frmPro.dgvPrecios, frmPro.txtIDProd);
                StockB.cargardgvStock(frmPro.dgvStock, frmPro.txtIDProd);
                
            }
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void SearchParametro()
        {
            string parametro = '%' + txtParametro.Text + '%';
            ProductoB.CargarDGVParametros(dgvProducto, cbParametro, parametro);
        }

        private void txtParametro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            SearchParametro();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}                     
                       