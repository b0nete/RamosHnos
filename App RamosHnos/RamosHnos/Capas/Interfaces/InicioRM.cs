using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamosHnos
{
    public partial class InicioRM : Form
    {
        public InicioRM()
        {
            InitializeComponent();
        }

        private void InicioRM_Load(object sender, EventArgs e)
        {

        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCliente frm = new formCliente();
            frm.Show();
        }

        private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
