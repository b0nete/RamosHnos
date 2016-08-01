using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; //CultureInfo
using System.Threading;
using CrystalDecisions.CrystalReports.Engine;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Interfaz.Listados;
using RamosHermanos.Capas.Interfaz.Contratos;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formCompras : Form, IAddItem
    {
        public int caseSwitch = 1;
        public int switchCase = 1;
        //Case para saber si la factura es a generar o se está buscando de una ya generada.
        public int caseNueva = 1;
        public int newORupdate = 1;

        public formCompras()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void formCompras_Load(object sender, EventArgs e)
        {
            if (caseNueva == 1)
            {
                cbTipoFactura.SelectedIndex = 0;
                cbformaPago.SelectedIndex = 0;
                cbEstado.SelectedIndex = 1;
                //txtIngreso.Text = DateTime.Now.ToString("hh:mm:ss");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listInsumos frm = new listInsumos();
            //frm.caseSwitch = 1;
            //frm.Show();

            listInsumos formAdd = new listInsumos();
            formAdd.Show(this);
        }

        //public void AddNewItem(DataGridViewRow row)
        //{
        //    string item = row.Cells["item"].Value.ToString();
        //    string desc = row.Cells["Desc"].Value.ToString();

        //    this.dgvCompra.Rows.Add(new[] { item, desc });
            
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //listProveedores frm = new listProveedores();
            //frm.caseSwitch = 1;
            //frm.Show(this);

            listProveedores formADD = new listProveedores();
            formADD.Show(this);
            formADD.caseSwitch = 1;
        }

        #region IAddItem Members

        public void AddNewProveedor(TextBox txt)
        {
            string idproveedor = txtIDproveedor.Text;
                        
        }

        #endregion
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    
        private void limpiar()
        {
            txtIDproveedor.Text=null;
            txtCuil.Text=null;
            txtNameProveedor.Text = null;
            txtnumFactura.Text= null;
            txtObservaciones.Text = null;
            txtTotal.Text = null;
        }

        private void cbDomicilio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarCompras()
        {
            compras.tipoFactura = cbTipoFactura.Text;
            compras.formaPago = cbformaPago.Text;
            compras.numFactura = txtnumFactura.Text;
            compras.fecha = dtpfechaFactura.Value;
            compras.fechaEntrega = dtpEntrega.Value;
            compras.fechaVencimiento = dtpVencimiento.Value;
            compras.observaciones = txtObservaciones.Text;
            compras.proveedor = Convert.ToInt32(txtIDproveedor.Text);
            compras.total = Convert.ToDouble(txtTotal.Text);
            compras.estado = cbEstado.Text;            
        }

        private bool DataCheck()
        {
            if(txtTotal.Text == null || txtIDproveedor.Text == null || txtnumFactura.Text == null)
            {
                MessageBox.Show("Datos Incompletos");
                return false;
            }
            return true;
        }
             
        itemComprasEntity itemcompra = new itemComprasEntity();
       
        private void cargarItemCompra(DataGridViewRow row)
        {
            itemcompra.compra = Convert.ToInt32(txtidCompras.Text);
            itemcompra.idInsumo = Convert.ToInt32(row.Cells["colIDInsumo"].Value);
            itemcompra.marca = Convert.ToString(row.Cells["colMarca"].Value);
            itemcompra.precioUnitario = Convert.ToDouble(row.Cells["colPrecioUnitario"].Value);
            itemcompra.subTotal = Convert.ToDouble(row.Cells["colSubTotal"].Value);
            itemcompra.cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);            
        }
        
        ComprasEntity compras = new ComprasEntity();
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (DataCheck() == false)
            {
                return;
            }
            else
            {
                if (txtnumFactura.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese el número de factura!");
                    return;
                }

                //Encabezado
                CargarCompras();
                ComprasB.InsertCompras(compras, txtidCompras);

                //ItemsFactura
                foreach (DataGridViewRow dR in dgvCompra.Rows)
                {
                    cargarItemCompra(dR);
                    itemCompraB.InsertItemCompras(itemcompra, dgvCompra);
                    stockInsumo.idInsumo = Convert.ToInt32(dR.Cells["colIDInsumo"].Value.ToString());
                    stockInsumo.valorNuevo = Convert.ToInt32(dR.Cells["colCantidad"].Value);
                    //string carga = dR.Cells["colCarga"].Value.ToString();

                    StockInsumoB.SumarStock(stockInsumo);

                    //cargarItemsFactura(dgvFactura, dR);
                    //itemsFacturaB.InsertItemFactura(itemFactura);
                    //stockProducto.idProducto = Convert.ToInt32(dR.Cells["colCodigo"].Value.ToString());
                    //stockProducto.valorNuevo = Convert.ToInt32(dR.Cells["colCantidad"].Value);
                    //string carga = dR.Cells["colCarga"].Value.ToString();
                    //StockProductoB.UpdateStockInsert(stockProducto, carga);
                    
                }
                MessageBox.Show("Factura Guardada");
            }
        }

        StockInsumoEntity stockInsumo = new StockInsumoEntity();
        public void cargarStockInsumo()
        {
        }
        public void CargaItemStock(DataGridViewRow row)
        {
            logStock.operacion = "P";
            logStock.comprobante = Convert.ToInt32(txtidCompras.Text);
            logStock.idInsumo = Convert.ToInt32(row.Cells["colIDInsumo"].Value);
            logStock.cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);

            //Buscamos el stockActual
            StockInsumoEntity stockP = StockInsumoB.BuscarStock(logStock.idInsumo);
            logStock.stockNuevo = stockP.stockNuevo;
        }

        LogStockInsumoEntity logStock = new LogStockInsumoEntity();
        public void CargaItemLogStock(DataGridViewRow row)
        {
            logStock.operacion = "P";
            logStock.comprobante = Convert.ToInt32(txtidCompras.Text);
            logStock.idInsumo = Convert.ToInt32(row.Cells["colIDInsumo"].Value);
            logStock.cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);

            //Buscamos el stockActual
            StockInsumoEntity stockP = StockInsumoB.BuscarStock(logStock.idInsumo);
            logStock.stockNuevo = stockP.stockNuevo;
        }

        private void txtIngreso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            listInsumos form = new listInsumos();
            form.Show(this);
 
        }

        
        private void dgvCompra_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (caseNueva == 1)
            {
                DataRow dr = PrecioInsumosB.UltimoPrecio(Convert.ToInt32(dgvCompra.CurrentRow.Cells["colIDInsumo"].Value.ToString()));

                dgvCompra.CurrentRow.Cells["colIDPrecio"].Value = Convert.ToInt32(dr["idPrecioInsumo"]);
                dgvCompra.CurrentRow.Cells["colPrecioUnitario"].Value = Convert.ToString(dr["precio"]);

                // Se genera la variable para acumular los SubTotales.
                double total = 0;

                // Se recorre cada fila del DGV.
                foreach (DataGridViewRow row in dgvCompra.Rows)
                {
                    if (row.Cells["colCantidad"].ToString() != string.Empty && row.Cells["colPrecioUnitario"].ToString() != string.Empty)
                    {
                        row.Cells["colSubTotal"].Value = Convert.ToInt32(row.Cells["colCantidad"].Value) * Convert.ToDouble(row.Cells["colPrecioUnitario"].Value);

                        total += Convert.ToDouble(row.Cells["colSubTotal"].Value);
                    }

                    txtTotal.Text = Convert.ToString(total);
                }
            }
        }


        public void AddNewItem(DataGridViewRow row)
        {
            string idinsumo = row.Cells["colIDinsumo"].Value.ToString();
            string insumo = row.Cells["colInsumo"].Value.ToString();
            string rubro = row.Cells["colRubro"].Value.ToString();
            string marca = row.Cells["colMarca"].Value.ToString();

            this.dgvCompra.Rows.Add(new[] { idinsumo, insumo, rubro, marca });

        }

        public void AddNewItemProveedor(DataGridViewRow rowA)
        {
            string idproveedor = txtIDproveedor.Text;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvCompra.Rows.RemoveAt(dgvCompra.CurrentRow.Index);
        }

        public void pasarDatos(TextBox text)
        {
            string idProveedor = txtIDproveedor.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listInsumos frm = new listInsumos();
            frm.caseSwitch = 1;
            frm.Show(this);
        }
        
        private void dgvCompra_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        public bool comprobarItemRepetido()
        {
            bool bul = false;

            int ultimaFila = dgvCompra.Rows.Count - 1;
            int c = 0;
            //if (dgvCompra.Rows.Count > 1)
            //{
            //    if (Convert.ToString(dgvCompra.Rows[ultimaFila - 2].Cells["colIDInsumo"].Value) == Convert.ToString(dgvCompra.Rows[ultimaFila - 1].Cells["colIDInsumo"].Value))
            //    {
            //        dgvCompra.Rows.Remove(dgvCompra.Rows[ultimaFila - 1]);
            //        MessageBox.Show("Ya existe este insumo en la factura!");
            //        bul = true;                        
            //    }
            //}

            foreach (DataGridViewRow dr in dgvCompra.Rows)
            {
                if (Convert.ToString(dgvCompra.Rows[ultimaFila].Cells["colIDInsumo"].Value) == Convert.ToString(dr.Cells["colIDInsumo"].Value))
                {
                    //Si ya existen dos insumos iguales, evitamos agregar.
                    c = c + 1;
                    if (c == 3)
                    {
                        if (Convert.ToString(dgvCompra.Rows[ultimaFila - 1].Cells["colIDInsumo"].Value) == Convert.ToString(dr.Cells["colIDInsumo"].Value))
                        {
                            dgvCompra.Rows.Remove(dgvCompra.Rows[ultimaFila - 1]);
                            MessageBox.Show("Ya existe este insumo en la factura!");
                            bul = true;
                        }
                        else
                        {
                            dgvCompra.Rows.Remove(dgvCompra.Rows[ultimaFila ]);
                            MessageBox.Show("Ya existe este insumo en la factura!");
                            bul = true;
                        }
                    }
                }
            }

            return bul;
        }

        private void dgvCompra_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvCompra_KeyDown(object sender, KeyEventArgs e)
        {
            // Capture F5 KeyPress
            if (e.KeyCode == Keys.F5)
            {
                StockInsumoEntity stockIns = new StockInsumoEntity();
                formInsumos frmI = new formInsumos();
                InsumoEntity insumo = new InsumoEntity();
                frmI.tabVar = 1;
                frmI.Show();

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                insumo.idInsumo = Convert.ToInt32(dgvCompra.CurrentRow.Cells["colIDInsumo"].Value);

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
                if (insumo.tipoStock == "NR")
                    frmI.rbNR.Checked = true;
                else if (insumo.tipoStock == "R")
                    frmI.rbR.Checked = true;
                else if (insumo.tipoStock == "C")
                {
                    frmI.rbC.Checked = true;
                    frmI.lblConsumo.Visible = true;
                    frmI.txtConsumoMensual.Visible = true;
                    frmI.txtConsumoMensual.Text = Convert.ToString(InsumoB.BuscarConsumoMesActual(insumo.idInsumo));
                }


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
                    frmI.txtStockA.Text = Convert.ToString(stockInsumo.stockActual);

                    //Cargar Operaciones Stock      

                    StockInsumoB.ListarStock(insumo.idInsumo, frmI.dgvStock);
                    frmI.dgvStock.AutoGenerateColumns = false;
                }

                
            }
        }

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (newORupdate != 1)
            {
                compras.estado = cbEstado.Text;
                compras.idCompras = Convert.ToInt32(txtidCompras.Text);
                ComprasB.UpdateCompraEstado(compras);
            }
        }
              
    }
}

