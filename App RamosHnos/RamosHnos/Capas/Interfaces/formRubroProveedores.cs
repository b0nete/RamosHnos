using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHnos.Capas.Negocio;

namespace RamosHnos.Capas.Interfaces
{
    public partial class formRubroProveedores : Form
    {
        public formRubroProveedores()
        {
            InitializeComponent();
        }

        private void formRubroProveedores_Load(object sender, EventArgs e)
        {
            dgvRubroProveedor.AutoGenerateColumns = false; 
            dgvRubroProveedor.DataSource = RubroB.ObtenerRubros(dgvRubroProveedor);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            formRubro frm = new formRubro();
            frm.Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvRubroProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
