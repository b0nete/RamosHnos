using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using RamosHermanos.Capas.Interfaz.Contratos;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Reportes;
using RamosHermanos.Capas.Reportes.Recorridos;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formRepartos : Form, IForm
    {
        public string hablar;

        public int row;
        public int column;
        public int comprobante;
        public int iRow;
        public int iFactura;
        //public int total;

        public formRepartos()
        {
            InitializeComponent();
        }

        #region IForm Members

        public void CompletarCelda(string total)
        {
            dgvRepartos[column, row].Value = Convert.ToString(total);
        }

        #endregion

        private void dgvRepartos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formRepartos_Load(object sender, EventArgs e)
        {
            DistribuidorB.CargarCBDistrib(cbDistribuidores);
            dgvRepartos.AutoGenerateColumns = false;

            //dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);
        }

        public void setRowNumber(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells["colOrden"].Value = (row.Index + 1).ToString();
            }
        }

        private void dgvRepartos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvRepartos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void text_KeyUp(object sender, KeyEventArgs e)
        {
            //int rowIndex = Convert.ToInt32(dgvRepartos.CurrentRow);

            //if (e.KeyCode == Keys.Enter)
            //{
            //    formCargaPedido frm = new formCargaPedido();
            //    frm.Show();
            //}
        }

        private void dgvRepartos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void dgvRepartos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 13)
            //{
            //    formCargaPedido frm = new formCargaPedido();

            //    column = dgvRepartos.CurrentCell.ColumnIndex;
            //    row = dgvRepartos.CurrentCell.RowIndex;

            //    frm.Show(this);
            //}
        }

        private void EjecCarga()
        {
            formCargaPedido frm = new formCargaPedido();

            column = dgvRepartos.CurrentCell.ColumnIndex;
            row = dgvRepartos.CurrentCell.RowIndex;
            frm.comprobante = Convert.ToString(dgvRepartos.CurrentRow.Cells["colComprobante"].Value);

            frm.Show(this);

            //Para todos, actualizar total de la Venta.
            dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dgvRepartos.CurrentRow.Cells["colComprobante"].Value));
        }

        private void EjecDescarga()
        {
            formDescargaPedido frm = new formDescargaPedido();

            column = dgvRepartos.CurrentCell.ColumnIndex;
            row = dgvRepartos.CurrentCell.RowIndex;
            frm.comprobante = Convert.ToString(dgvRepartos.CurrentRow.Cells["colComprobante"].Value);

            frm.Show(this);

            //Para todos, actualizar total de la Venta.
            dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dgvRepartos.CurrentRow.Cells["colComprobante"].Value));
        }

        private void Ejec2(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        // Entidades
        FacturaEntity factura = new FacturaEntity();

        RepartoEntity reparto = new RepartoEntity();

        itemsRepartoEntity itemsReparto = new itemsRepartoEntity();

        itemFacturaEntity itemFactura = new itemFacturaEntity();

        PedidoEntity pedido = new PedidoEntity();

        itemPedidoEntity itemPedido = new itemPedidoEntity();


        private void InsertFactura(string nombreColumna)
        {
            if (dgvRepartos.CurrentCell.Value.ToString() != string.Empty)
            {
                itemFactura.factura = dgvRepartos.CurrentRow.Cells["colComprobante"].Value.ToString();
                itemFactura.cantidad = Convert.ToInt32(dgvRepartos.CurrentRow.Cells[nombreColumna].Value.ToString());
                itemFactura.precioUnitario = PrecioProductosB.UltimoPrecio(itemFactura.producto);
                itemFactura.subTotal = itemFactura.precioUnitario * itemFactura.cantidad;

                itemsFacturaB.InsertItemFactura(itemFactura);
            }
        }

        private void UpdateFactura(string nombreColumna)
        {
            if (dgvRepartos.CurrentCell.Value.ToString() != string.Empty)
            {
                itemFactura.factura = dgvRepartos.CurrentRow.Cells["colComprobante"].Value.ToString();
                itemFactura.cantidad = Convert.ToInt32(dgvRepartos.CurrentRow.Cells[nombreColumna].Value.ToString());
                itemFactura.precioUnitario = PrecioProductosB.UltimoPrecio(itemFactura.producto);
                itemFactura.subTotal = itemFactura.precioUnitario * itemFactura.cantidad;

                itemsFacturaB.UpdateItemFactura(itemFactura);
            }
        }

        private void dgvRepartos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void SeleccionarDgv()
        {
            formVentas frmP = new formVentas();

            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvRepartos.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el pedido para cargarlo.
                factura.idFactura = Convert.ToInt32(row.Cells["colComprobante"].Value.ToString());
                FacturaB.BuscarFacturaID(factura);
                frmP.txtIDFactura.Text = Convert.ToString(factura.idFactura);
                frmP.txtIDcliente.Text = Convert.ToString(factura.cliente);
                frmP.dtpfechaFactura.Value = factura.fechaFactura;
                frmP.dtpEntrega.Value = factura.fechaEntrega;
                frmP.cbEstado.SelectedItem = factura.estado;
                frmP.txtObservaciones.Text = Convert.ToString(pedido.observaciones);
                frmP.txtNombre.Text = Convert.ToString(factura.nombreCompleto);
                frmP.txtTotal.Text = Convert.ToString(factura.total);

                itemFactura.factura = dgvRepartos.CurrentRow.Cells["colComprobante"].Value.ToString();
                itemsFacturaB.BuscarItemFacturaDGV(itemFactura, frmP.dgvFactura, frmP.txtTotal);

                DomicilioB.CargarTXTID(factura.domicilio, frmP.txtDomicilio);

                ClienteEntity cliente = ClienteB.BuscarClienteCIVAyCP(factura.cliente);
                frmP.txtIVA.Text = cliente.condicionIVA;
                frmP.cbformaPago.Text = "Contado";
                frmP.Show();
            }
        }

        private void TextboxNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            Boolean nonNumberEntered;

            nonNumberEntered = true;

            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                nonNumberEntered = false;
            }

            if (nonNumberEntered == true)
            {
                // Stop the character from being entered into the control since it is non-numerical.
                e.Handled = true;
                MessageBox.Show("Solo se aceptan Numeros!");
            }
            else
            {
                e.Handled = false;
            }

            
        }

        private void cbDistribuidores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDistribuidores_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //formDistribuidores frm = new formDistribuidores();

            //if (RepartoB.ExisteReparto(reparto) == true)
            //{
            //    RepartoB.BuscarReparto(reparto);
            //    dtpFechaReparto.Value = reparto.fecha;
            //    cbDistribuidores.SelectedValue = reparto.distribuidor;
            //    txtReparto.Text = Convert.ToString(reparto.idReparto);

            //    itemsReparto.reparto = reparto.idReparto;
            //    dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto, dgvRepartos);
            //}
            //else
            //{
            //    DataSet ds = frm.GenerarReparto();

            //    RepartoB.BuscarReparto(reparto);
            //    dtpFechaReparto.Value = reparto.fecha;
            //    cbDistribuidores.SelectedValue = reparto.distribuidor;
            //    txtReparto.Text = Convert.ToString(reparto.idReparto);

            //    itemsReparto.reparto = reparto.idReparto;
            //    dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto, dgvRepartos);

            //    //frm.setRowNumber(frm.dgvRepartos);
            //    //frm.dgvRepartos.DataSource = ds;
            //    //frm.dgvRepartos.DataMember = "dtItemsRecorrido";
            //}

            //setRowNumber(dgvRepartos);
        }

        private void dgvRepartos_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            itemFactura.factura = dgvRepartos.CurrentRow.Cells["colComprobante"].Value.ToString();

            //CARGAS
            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colSCarga")
            {
                //Soda
                itemFactura.producto = 7;
                itemFactura.carga = "C";
                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                {
                    UpdateFactura("colSCarga");
                }
                else
                {
                    InsertFactura("colSCarga");
                    //Actualizar Stock
                    CargaItemLogStock("colSCarga", itemFactura.producto);
                    StockProductoB.ActualizarStock(logStock);
                }

            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colCCarga")
            {
                //Cajon
                itemFactura.producto = 8;
                itemFactura.carga = "C";
                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                {
                    UpdateFactura("colCCarga");
                }
                else
                {
                    InsertFactura("colCCarga");
                }
            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colCCCarga")
            {
                //Canasta
                itemFactura.producto = 9;
                itemFactura.carga = "C";
                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                {
                    UpdateFactura("colCCCarga");
                }
                else
                {
                    InsertFactura("colCCCarga");
                }
            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colPCarga")
            {
                //Pie
                itemFactura.producto = 10;
                itemFactura.carga = "C";
                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                {
                    UpdateFactura("colPCarga");
                }
                else
                {
                    InsertFactura("colPCarga");
                }
            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colDCarga")
            {
                //Dispenser
                itemFactura.producto = 11;
                itemFactura.carga = "C";
                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                {
                    UpdateFactura("colDCarga");
                }
                else
                {
                    InsertFactura("colDCarga");
                }
            }


            //DESCARGAS
            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colSDescarga")
            {
                //Soda
                itemFactura.producto = 7;
                itemFactura.carga = "D";
                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                {
                    UpdateFactura("colSDescarga");
                }
                else
                {
                    InsertFactura("colSDescarga");
                }
            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colCDescarga")
            {
                //Cajon
                itemFactura.producto = 8;
                itemFactura.carga = "D";
                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                {
                    UpdateFactura("colCDescarga");
                }
                else
                {
                    InsertFactura("colCDescarga");
                }
            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colCCDescarga")
            {
                //Canasta
                itemFactura.producto = 9;
                itemFactura.carga = "D";
                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                {
                    UpdateFactura("colCCDescarga");
                }
                else
                {
                    InsertFactura("colCCDescarga");
                }
            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colPDescarga")
            {
                //Pie
                itemFactura.producto = 10;
                itemFactura.carga = "D";
                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                {
                    UpdateFactura("colPDescarga");
                }
                else
                {
                    InsertFactura("colPDescarga");
                }
            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colDDescarga")
            {
                //Dispenser
                itemFactura.producto = 11;
                itemFactura.carga = "D";
                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                {
                    UpdateFactura("colDDescarga");
                }
                else
                {
                    InsertFactura("colDDescarga");
                }
            }

            //if (dgvRepartos.Columns[e.ColumnIndex].Name == "colCobro")
            //{
            //    int factura = Convert.ToInt32(dgvRepartos.CurrentRow.Cells["colComprobante"].Value);
            //    string estado;

            //    //Convert.ToDecimal(drDatos["total"] is DBNull ? 0:drDatos["total"])

            //    if (dgvRepartos.CurrentRow.Cells["colCobro"].Value is DBNull ? false : Convert.ToBoolean(dgvRepartos.CurrentRow.Cells["colCobro"].Value))
            //    {
            //        estado = "Pagado";
            //        FacturaB.UpdateFromDGV(estado, factura);
            //    }
            //    else if (dgvRepartos.CurrentRow.Cells["colCobro"].Value is DBNull ? true : Convert.ToBoolean(dgvRepartos.CurrentRow.Cells["colCobro"].Value))
            //    {
            //        estado = "Pendiente";
            //        FacturaB.UpdateFromDGV(estado, factura);
            //    }
            //}

            //Para todos, actualizar total de la Venta.
            dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dgvRepartos.CurrentRow.Cells["colComprobante"].Value));

        }

        private void dgvRepartos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextboxNumeric_KeyPress);

            //DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;
            //dText.KeyUp -= new KeyEventHandler(text_KeyUp);
            //dText.KeyUp += new KeyEventHandler(text_KeyUp);
        }

        private void dgvRepartos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvRepartos.CurrentRow.Cells["colASaldo"].Selected)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");

                itemFactura.factura = dgvRepartos.CurrentRow.Cells["colComprobante"].Value.ToString();
                itemFactura.carga = "C";

                formSaldoPedido frm = new formSaldoPedido();
                frm.Show();

                //DataTable dtAgua = itemsFacturaB.BuscarAguas(itemFactura);
                //foreach (DataRow dr in dtAgua.Rows)
                //{
                //    if (Convert.ToInt32(dr["producto"]) == 6)
                //        frm.txt25.Text = Convert.ToString(dr["cantidad"]);

                //    if (Convert.ToInt32(dr["producto"]) == 5)
                //        frm.txt20.Text = Convert.ToString(dr["cantidad"]);

                //    if (Convert.ToInt32(dr["producto"]) == 4)
                //        frm.txt12.Text = Convert.ToString(dr["cantidad"]);

                //    if (Convert.ToInt32(dr["producto"]) == 3)
                //        frm.txt10.Text = Convert.ToString(dr["cantidad"]);

                //    if (Convert.ToInt32(dr["producto"]) == 1)
                //        frm.txt4.Text = Convert.ToString(dr["cantidad"]);
                //}
            }

            if (e.KeyCode == Keys.Enter && dgvRepartos.CurrentRow.Cells["colACarga"].Selected)
            {
                iRow = dgvRepartos.CurrentRow.Index;
                iFactura = Convert.ToInt32(dgvRepartos.CurrentRow.Cells["colComprobante"].Value);

                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");

                itemFactura.factura = dgvRepartos.CurrentRow.Cells["colComprobante"].Value.ToString();
                itemFactura.carga = "C";

                if (itemsFacturaB.ExisteAguaItemFactura(itemFactura) == true)
                {
                    formCargaPedido frm = new formCargaPedido();
                    column = dgvRepartos.CurrentCell.ColumnIndex;
                    row = dgvRepartos.CurrentCell.RowIndex;
                    frm.comprobante = itemFactura.factura;
                    frm.Show(this);

                    DataTable dtAgua = itemsFacturaB.BuscarAguas(itemFactura);
                    foreach (DataRow dr in dtAgua.Rows)
                    {
                        if (Convert.ToInt32(dr["producto"]) == 6)
                            frm.txt25.Text = Convert.ToString(dr["cantidad"]);

                        if (Convert.ToInt32(dr["producto"]) == 5)
                            frm.txt20.Text = Convert.ToString(dr["cantidad"]);

                        if (Convert.ToInt32(dr["producto"]) == 4)
                            frm.txt12.Text = Convert.ToString(dr["cantidad"]);

                        if (Convert.ToInt32(dr["producto"]) == 3)
                            frm.txt10.Text = Convert.ToString(dr["cantidad"]);

                        if (Convert.ToInt32(dr["producto"]) == 1)
                            frm.txt4.Text = Convert.ToString(dr["cantidad"]);
                    }
                }
                else
                {
                    EjecCarga();
                }
            }

            if (e.KeyCode == Keys.Enter && dgvRepartos.CurrentRow.Cells["colADescarga"].Selected)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");

                itemFactura.factura = dgvRepartos.CurrentRow.Cells["colComprobante"].Value.ToString();
                itemFactura.carga = "D";

                if (itemsFacturaB.ExisteAguaItemFactura(itemFactura) == true)
                {
                    formCargaPedido frm = new formCargaPedido();
                    column = dgvRepartos.CurrentCell.ColumnIndex;
                    row = dgvRepartos.CurrentCell.RowIndex;
                    frm.comprobante = itemFactura.factura;
                    frm.Show(this);

                    DataTable dtAgua = itemsFacturaB.BuscarAguas(itemFactura);
                    foreach (DataRow dr in dtAgua.Rows)
                    {
                        if (Convert.ToInt32(dr["producto"]) == 6)
                            frm.txt25.Text = Convert.ToString(dr["cantidad"]);

                        if (Convert.ToInt32(dr["producto"]) == 5)
                            frm.txt20.Text = Convert.ToString(dr["cantidad"]);

                        if (Convert.ToInt32(dr["producto"]) == 4)
                            frm.txt12.Text = Convert.ToString(dr["cantidad"]);

                        if (Convert.ToInt32(dr["producto"]) == 3)
                            frm.txt10.Text = Convert.ToString(dr["cantidad"]);

                        if (Convert.ToInt32(dr["producto"]) == 1)
                            frm.txt4.Text = Convert.ToString(dr["cantidad"]);
                    }
                }
                else
                {
                    EjecDescarga();
                }
            }

            if (e.KeyCode == Keys.Enter && dgvRepartos.CurrentRow.Cells["colComprobante"].Selected)
            {
                SeleccionarDgv();
            }

            //Para todos, actualizar total de la Venta.
            dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dgvRepartos.CurrentRow.Cells["colComprobante"].Value));

        }

        private void dgvRepartos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (dgvRepartos.Columns[e.ColumnIndex].Name == "colCobro")
            //{
            //    MessageBox.Show("ASD2");
            //}
        }

        public void UpdateTotalFactura()
        {
            dgvRepartos.Rows[0].Cells["colVenta"].Value = "5";
            //dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
        }

        private void dgvRepartos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void dgvRepartos_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            //if (dgvRepartos.CurrentCell.OwningColumn.Name == "colCobro")
            //{
            //    MessageBox.Show("ASD");
            //}
        }

        private void dgvRepartos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                //int factura = Convert.ToInt32(dgvRepartos.CurrentRow.Cells["colComprobante"].Value);
                //string estado;

                ////Convert.ToDecimal(drDatos["total"] is DBNull ? 0:drDatos["total"])

                //if (dgvRepartos.CurrentRow.Cells["colCobro"].Value is DBNull ? false : Convert.ToBoolean(dgvRepartos.CurrentRow.Cells["colCobro"].Value))
                //{
                //    estado = "Pagado";
                //    FacturaB.UpdateFromDGV(estado, factura);
                //}
                //else if (dgvRepartos.CurrentRow.Cells["colCobro"].Value is DBNull ? true : Convert.ToBoolean(dgvRepartos.CurrentRow.Cells["colCobro"].Value))
                //{
                //    estado = "Pendiente";
                //    FacturaB.UpdateFromDGV(estado, factura);
                //}  
        }

        private void dgvRepartos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvRepartos.CurrentCell.OwningColumn.Name == "colCobro")
            {
                dgvRepartos.CommitEdit(DataGridViewDataErrorContexts.Commit);

                int factura = Convert.ToInt32(dgvRepartos.CurrentRow.Cells["colComprobante"].Value);
                string estado;

                //Convert.ToDecimal(drDatos["total"] is DBNull ? 0:drDatos["total"])

                if (dgvRepartos.CurrentRow.Cells["colCobro"].Value is DBNull ? false : Convert.ToBoolean(dgvRepartos.CurrentRow.Cells["colCobro"].Value))
                {
                    estado = "Pagado";
                    FacturaB.UpdateFromDGV(estado, factura);
                }
                else if (dgvRepartos.CurrentRow.Cells["colCobro"].Value is DBNull ? true : Convert.ToBoolean(dgvRepartos.CurrentRow.Cells["colCobro"].Value))
                {
                    estado = "Pendiente";
                    FacturaB.UpdateFromDGV(estado, factura);
                }  
            }

        }

        private void dgvRepartos_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        LogStockProductoEntity logStock = new LogStockProductoEntity();
        public void CargaItemLogStock(string nombreColumna, int producto)
        {
            logStock.operacion = "V";
            logStock.comprobante = Convert.ToInt32(dgvRepartos.CurrentRow.Cells["colComprobante"].Value);
            logStock.idProducto = producto;
            logStock.cantidad = Convert.ToInt32(dgvRepartos.CurrentRow.Cells[nombreColumna].Value.ToString());

            //Buscamos el stockActual
            StockProductoEntity stockProducto = StockProductoB.BuscarStock(logStock.idProducto);
            logStock.stockNuevo = stockProducto.stockNuevo;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}

