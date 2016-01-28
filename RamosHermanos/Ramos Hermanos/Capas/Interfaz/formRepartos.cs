using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formRepartos : Form
    {
        public formRepartos()
        {
            InitializeComponent();
        }

        private void dgvRepartos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formRepartos_Load(object sender, EventArgs e)
        {
            dgvRepartos.AutoGenerateColumns = false;
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
            //dgvRepartos.BeginEdit(false); 
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
    }
}
