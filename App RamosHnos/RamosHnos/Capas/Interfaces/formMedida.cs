using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamosHnos.Capas.Interfaces
{
    public partial class formMedida : Form
    {
        public formMedida()
        {
            InitializeComponent();
        }

        private void txtNumTel_TextChanged(object sender, EventArgs e)
        {
            double temp = 0;

            if (double.TryParse(txtMedida.Text, out temp))
            {
                txtMedida.Text = temp.ToString("N2");
            }
        }
    }
}
