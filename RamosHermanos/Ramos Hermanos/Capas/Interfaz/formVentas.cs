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
    public partial class formVentas : Form
    {
        public formVentas()
        {
            InitializeComponent();
        }

        private void formFactura_Load(object sender, EventArgs e)
        {
            dgvFactura.AutoGenerateColumns = false;
        }
    }
}
