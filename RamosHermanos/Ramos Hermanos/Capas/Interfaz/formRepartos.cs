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
            dgvRepartos.AutoGenerateColumns = false;

            if (chkGuardado.Checked == false)
            {
                foreach (DataGridViewRow row in dgvRepartos.Rows)
                {
                    // Buscamos el ultimo ID de factura y generamos los IDs para las nuevas facturas.
                    int ultFactura = FacturaB.UltimaFactura() + 1;
                    row.Cells["colComprobante"].Value = (ultFactura).ToString();

                    factura.idFactura = ultFactura;
                    factura.cliente = Convert.ToInt32(row.Cells["colIDCliente"].Value);

                    //Guardamos en la DB los numeros de las facturas
                    FacturaB.InsertFactura(factura);
                }

                //Guardamos los datos reparto del DataGridView en la DB para guardar el Reparto generado.
                //RepartoB.InsertReparto(reparto, txtReparto);

                //Guardamos los items del reparto
               // itemsRepartoB.InsertItemReparto(itemsReparto);

            }
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
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");

                Ejec();
            }            
        }

        private void Ejec()
        {
            formCargaPedido frm = new formCargaPedido();

            column = dgvRepartos.CurrentCell.ColumnIndex;
            row = dgvRepartos.CurrentCell.RowIndex;

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
            // SendKeys.Send("{UP}");
            // SendKeys.Send("{TAB}");
        }

        // Entidades
        FacturaEntity factura = new FacturaEntity();

        RepartoEntity reparto = new RepartoEntity();

        itemsRepartoEntity itemsReparto = new itemsRepartoEntity();

    }
}
