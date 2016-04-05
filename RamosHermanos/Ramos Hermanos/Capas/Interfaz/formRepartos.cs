﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHermanos.Capas.Interfaz.Contratos;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Entidades;

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
        }

        private void EjecDescarga()
        {
            formDescargaPedido frm = new formDescargaPedido();

            column = dgvRepartos.CurrentCell.ColumnIndex;
            row = dgvRepartos.CurrentCell.RowIndex;
            frm.comprobante = Convert.ToString(dgvRepartos.CurrentRow.Cells["colComprobante"].Value);

            frm.Show(this);
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

                DomicilioB.CargarCB(frmP.cbDomicilio, frmP.txtIDcliente, "1");
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
            formDistribuidores frm = new formDistribuidores();

            if (RepartoB.ExisteReparto(reparto) == true)
            {
                RepartoB.BuscarReparto(reparto);
                dtpFechaReparto.Value = reparto.fecha;
                cbDistribuidores.SelectedValue = reparto.distribuidor;
                txtReparto.Text = Convert.ToString(reparto.idReparto);

                itemsReparto.reparto = reparto.idReparto;
                dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto, dgvRepartos);
            }
            else
            {
                DataSet ds = frm.GenerarReparto();

                RepartoB.BuscarReparto(reparto);
                dtpFechaReparto.Value = reparto.fecha;
                cbDistribuidores.SelectedValue = reparto.distribuidor;
                txtReparto.Text = Convert.ToString(reparto.idReparto);

                itemsReparto.reparto = reparto.idReparto;
                dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto, dgvRepartos);

                //frm.setRowNumber(frm.dgvRepartos);
                //frm.dgvRepartos.DataSource = ds;
                //frm.dgvRepartos.DataMember = "dtItemsRecorrido";
            }

            setRowNumber(dgvRepartos);
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
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
                }
                else
                {
                    InsertFactura("colSCarga");
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
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
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
                }
                else
                {
                    InsertFactura("colCCarga");
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
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
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
                }
                else
                {
                    InsertFactura("colCCCarga");
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
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
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
                }
                else
                {
                    InsertFactura("colPCarga");
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
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
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
                }
                else
                {
                    InsertFactura("colDCarga");
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
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
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
                }
                else
                {
                    InsertFactura("colSDescarga");
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
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
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
                }
                else
                {
                    InsertFactura("colCDescarga");
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
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
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
                }
                else
                {
                    InsertFactura("colCCDescarga");
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
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
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
                }
                else
                {
                    InsertFactura("colPDescarga");
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
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
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
                }
                else
                {
                    InsertFactura("colDDescarga");
                    dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
                }
            }
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
                    frm.comprobante = itemFactura.factura;
                    frm.Show();

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
                    frm.Show();

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
        }

        private void dgvRepartos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRepartos.CurrentCell.Value == DBNull.Value)
            {
                dgvRepartos.CurrentCell.Value = "0";
            }
        }

        public void UpdateTotalFactura()
        {
            dgvRepartos.Rows[0].Cells["colVenta"].Value = "5";
            //dgvRepartos.CurrentRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(dgvRepartos);
        }

    }
}

