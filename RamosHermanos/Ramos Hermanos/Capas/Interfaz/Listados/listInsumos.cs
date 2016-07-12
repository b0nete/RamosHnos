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
    public partial class listInsumos : Form
    {
        public int caseSwitch = 1;

        public listInsumos()
        {
            InitializeComponent();
        }

        private void listInsumos_Load(object sender, EventArgs e)
        {
            cbParametro.SelectedIndex = 0;
            InsumoB.cargardgvInsumo(dgvInsumos);             
        }

        private void SearchParametro()
        {
            string parametro = '%' + txtParametro.Text + '%';
            InsumoB.CargarDGVParametros(dgvInsumos, cbParametro, parametro);
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            SearchParametro();
        }

        formInsumos frmI = new formInsumos();
        InsumoEntity insumo = new InsumoEntity();

        private void dgvInsumos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (caseSwitch)
            {
                case 1:
                    SeleccionarDgvInsumos();
                    break;
                case 2:
                    SeleccionarDGV();
                    break;
                case 3:
                    SeleccionarDgvInsumosConformacion();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
        private void SeleccionarDGV()

        {
               
                DataGridViewCell cell = null;
                
                foreach (DataGridViewCell selectedCell in dgvInsumos.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }
                if (cell != null)
                {
                    StockInsumoEntity stockIns = new StockInsumoEntity();
                    formInsumos frmI = new formInsumos();
                    InsumoEntity insumo = new InsumoEntity();
                    frmI.Show();
                    DataGridViewRow row = cell.OwningRow;
                    
                    //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                    insumo.idInsumo = Convert.ToInt32(row.Cells["colIDinsumo"].Value.ToString());

                    //Actualizar Label
                    frmI.lblTitle.Text = InsumoB.BuscarNombreInsumo(insumo.idInsumo);

                    InsumoB.BuscarInsumosID(insumo);
                    frmI.txtidInsumo.Text = Convert.ToString(insumo.idInsumo);
                    frmI.dtpFecha.Value = Convert.ToDateTime(insumo.fecha);
                    frmI.txtInsumo.Text = Convert.ToString(insumo.insumo);
                    //frmI.txtInsumoPrecio.Text = frmI.txtInsumo.Text;
                    //frmI.txtInsumoStock.Text = frmI.txtInsumo.Text;
                    frmI.txtCantidad.Text = Convert.ToString(insumo.stockMin);
                    frmI.txtDescripcion.Text = Convert.ToString(insumo.descripcion);
                    //frmI.cbMarca.SelectedValue= insumo.marca;
                    frmI.cbProv.SelectedValue = insumo.proveedor;
                    frmI.cbRubro.SelectedValue = insumo.rubro;
                    frmI.cbMedida.SelectedValue = insumo.medida;
                    frmI.txtCantidad.Text = Convert.ToString(insumo.cantidad);

                    PrecioInsumosB.UltimoPrecioDGV(frmI.dgvPrecios, frmI.txtidInsumo);

                    //cargarDatosStock
                    stockIns.idInsumo = insumo.idInsumo;
                    if (StockInsumoB.ExisteStock(insumo.idInsumo) == false)
                        MessageBox.Show("No existe stock");
                    else
                    {
                        StockInsumoEntity stockInsumo = StockInsumoB.BuscarStock(Convert.ToInt32(frmI.txtidInsumo.Text));
                        frmI.txtStockMin.Text = Convert.ToString(stockInsumo.stockMinimo);
                        frmI.txtStockMax.Text = Convert.ToString(stockInsumo.stockMaximo);
                        frmI.txtStockA.Text = Convert.ToString(stockInsumo.stockNuevo);

                        //Cargar Operaciones Stock      

                        StockInsumoB.ListarStock(insumo.idInsumo, frmI.dgvStock);
                        frmI.dgvStock.AutoGenerateColumns = false;                        
                    }

                    

                    //StockInsumoB.cargardgvStock(frmI.dgvStock, frmI.txtidInsumo);

                    //frmPro.cbTipoProducto.SelectedValue = producto.tipoProducto;
                    //frmI.txtInsumo.Text= Convert.ToString(insumo.insumo);
                    //frmPro.cbMarca.SelectedValue = producto.marca;
                    //frmPro.txtProducto.Text = producto.producto;
                    //frmPro.txtDescripcion.Text = producto.descripcion;
                    //frmPro.txtCantidad.Text = Convert.ToString(producto.cantidad);
                    //frmPro.cbMedida.SelectedValue = producto.medida;

                    
                }
            }

        formCompras frmP = new formCompras();

        private void SeleccionarDgvInsumos()
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvInsumos.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow rowA = this.dgvInsumos.CurrentRow as DataGridViewRow;

                formCompras parent = this.Owner as formCompras;
                parent.AddNewItem(rowA);

                bool bull = parent.comprobarItemRepetido();

                if (bull == true)
                {
                    return;
                }

                //this.Close();
            }     
        }

        private void SeleccionarDgvInsumosConformacion()
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvInsumos.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow rowA = this.dgvInsumos.CurrentRow as DataGridViewRow;

                IAddItem parent = this.Owner as IAddItem;
                parent.AddNewItem(rowA);

                //bool bull = parent.comprobarItemRepetido();

                //if (bull == true)
                //{
                //    return;
                //}

                //this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvInsumos.SelectedRows[0] as DataGridViewRow;
            
            IAddItem parent = this.Owner as IAddItem;
            parent.AddNewItem(row);

            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgvInsumos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
                  
      }
       
         
 }
