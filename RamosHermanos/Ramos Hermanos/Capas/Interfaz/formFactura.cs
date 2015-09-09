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
    public partial class formFactura : Form
    {
        public formFactura()
        {
            InitializeComponent();
        }

        private void tabFactura_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tabProductos;
        }

        private void formFactura_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }
    }
}
