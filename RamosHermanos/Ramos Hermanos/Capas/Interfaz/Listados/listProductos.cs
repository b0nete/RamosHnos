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
using RamosHermanos.Capas.Interfaz.Contratos;


namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listProductos : Form
    {
        public listProductos()
        {
            InitializeComponent();
        }

        public int caseSwitch = 0;
        ProductoEntity producto = new ProductoEntity();
        formPedidos frmP = new formPedidos();

        private void listProductos_Load(object sender, EventArgs e)
        {
            cbParametro.SelectedIndex = 0;
            ProductoB.CargarDGV(dgvProducto);
            //caseSwitch = 1;
        }

        private void dgvProducto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (caseSwitch)
            {
                case 1:
                    SeleccionarDGV();
                    break;
                case 2:
                    DataGridViewRow rowA = this.dgvProducto.CurrentRow as DataGridViewRow;

                    formProduccion formInterface = this.Owner as formProduccion;
                    formInterface.pasarDatos(rowA);
                    break;
                case 3:
                    DataGridViewRow rowB = this.dgvProducto.CurrentRow as DataGridViewRow;

                    formVentas formInter = this.Owner as formVentas;
                    formInter.pasarDatos(rowB);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
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

        private void SeleccionarDGV()
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvProducto.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                StockProductoEntity stockPo = new StockProductoEntity();
                formProducto frmPro = new formProducto();
                frmPro.Show();

                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                producto.idProducto = Convert.ToInt32(row.Cells["colIDProducto"].Value.ToString());

                //Actualizar Label
                frmPro.lblTitle.Text = ProductoB.BuscarNombreProducto(producto.idProducto);
                    
                ProductoB.BuscarIdProducto(producto);
                frmPro.txtIDProd.Text = Convert.ToString(producto.idProducto);
                frmPro.dtpFechaAlta.Value = Convert.ToDateTime(producto.fechaAlta);
                //frmPro.cbTipoProducto.SelectedValue = producto.tipoProducto;
                frmPro.cbMarca.SelectedValue = producto.marca;
                frmPro.txtProducto.Text = producto.producto;
                //frmPro.txtProductoP.Text = producto.producto;
                //frmPro.txtProductoStock.Text = producto.producto;
                //frmPro.txtProdutoC.Text = producto.producto;
                frmPro.txtDescripcion.Text = producto.descripcion;
                frmPro.txtCantidad.Text = Convert.ToString(producto.cantidad);
                frmPro.cbMedida.SelectedValue = producto.medida;

                PrecioProductosB.UltimoPrecioDGV(frmPro.dgvPrecios, frmPro.txtIDProd);

                //Cargar Datos Stock
                stockPo.idProducto = producto.idProducto;
                if (StockProductoB.ExisteStock(stockPo.idProducto) == false)
                    MessageBox.Show("No existe stock");
                else
                {
                    StockProductoEntity stockP = StockProductoB.BuscarStock(Convert.ToInt32(frmPro.txtIDProd.Text));
                    frmPro.txtStockMin.Text = Convert.ToString(stockP.stockMinimo);
                    frmPro.txtStockMax.Text = Convert.ToString(stockP.stockMaximo);
                    frmPro.txtStockA.Text = Convert.ToString(stockP.stockNuevo);

                    //Cargar Operaciones Stock                    
                    StockProductoB.StockLogDGV(frmPro.dgvStock, frmPro.txtIDProd);
                    frmPro.dgvStock.AutoGenerateColumns = false;
                }

                //Conformacion
                itemsProductoB.CargarDGV(Convert.ToInt32(frmPro.txtIDProd.Text), frmPro.dgvConformacion);
                this.Close();
            }
        }
    }

}                     
                       