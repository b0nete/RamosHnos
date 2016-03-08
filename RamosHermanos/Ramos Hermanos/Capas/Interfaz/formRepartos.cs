using System;
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
        //public int total;

        public formRepartos()
        {
            InitializeComponent();
        }

        #region IForm Members

        public void CompletarCelda(string total)
        {
            dgvRepartos[column, row].Value = Convert.ToString(Convert.ToString(total));
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

        private void dgvRepartos_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;
            //dText.KeyUp -= new KeyEventHandler(text_KeyUp);
            //dText.KeyUp += new KeyEventHandler(text_KeyUp);
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

        private void dgvRepartos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvRepartos.CurrentRow.Cells["colACarga"].Selected)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");

                EjecCarga();
            }

            if (e.KeyCode == Keys.Enter && dgvRepartos.CurrentRow.Cells["colADescarga"].Selected)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");

                EjecDescarga();
            }          
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

        private void dgvRepartos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colSCarga")
            {
                //Soda
                itemFactura.producto = 7;
                itemFactura.carga = "C";
                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                    UpdateFactura("colSCarga");                    
                else
                    InsertFactura("colSCarga");
                    
            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colCCarga")
            {
                //Cajon
                itemFactura.producto = 8;
                itemFactura.carga = "C";
                InsertFactura("colCCarga");
            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colCCCarga")
            {
                //Canasta
                itemFactura.producto = 9;
                itemFactura.carga = "C";
                InsertFactura("colCCCarga");
            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colPCarga")
            {
                //Pie
                itemFactura.producto = 10;
                itemFactura.carga = "C";
                InsertFactura("colPCarga");
            }

            if (dgvRepartos.Columns[e.ColumnIndex].Name == "colDCarga")
            {
                //Dispenser
                itemFactura.producto = 11;
                itemFactura.carga = "C";
                InsertFactura("colDCarga");
            } 
               
        }

        // Entidades
        FacturaEntity factura = new FacturaEntity();

        RepartoEntity reparto = new RepartoEntity();

        itemsRepartoEntity itemsReparto = new itemsRepartoEntity();

        itemFacturaEntity itemFactura = new itemFacturaEntity(); 

        private void dgvRepartos_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRepartos.CurrentCell.Value == DBNull.Value)
            {
                dgvRepartos.CurrentCell.Value = "0";
            }
        }

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

    }
}
