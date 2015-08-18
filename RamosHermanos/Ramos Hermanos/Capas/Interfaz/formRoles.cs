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

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formRoles : Form
    {
        public formRoles()
        {
            InitializeComponent();
        }

        private void formRoles_Load(object sender, EventArgs e)
        {
            RolB.CargarDGV(dgvRoles);
            CheckColor();
        }

        private void CheckColor()
        {
            if (cbEstado.Checked == true)
            {
                lblEstado.BackColor = Color.Green;
                lblEstado.Text = "Habilitado";
            }
            else
            {
                lblEstado.BackColor = Color.Red;
                lblEstado.Text = "Desabilitado";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            CheckColor();
        }

        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvRoles.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txtIDRol.Text = row.Cells["colIDRol"].Value.ToString();
                txtRol.Text = row.Cells["colRol"].Value.ToString();
                cbEstado.Checked = Convert.ToBoolean(row.Cells["colEstado"].Value);
            }
        }

        
    }
}
