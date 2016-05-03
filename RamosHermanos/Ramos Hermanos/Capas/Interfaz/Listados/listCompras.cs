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

namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listCompras : Form
    {
        public listCompras()
        {
            InitializeComponent();
        }

        private void listCompras_Load(object sender, EventArgs e)
        {
            ComprasB.ListCompras(dgvCompras);
            dgvCompras.AutoGenerateColumns = false;
            
        }
    }
}
