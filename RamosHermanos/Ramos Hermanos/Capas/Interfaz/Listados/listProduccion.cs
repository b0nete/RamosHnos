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
    public partial class listProduccion : Form
    {
        public listProduccion()
        {
            InitializeComponent();
        }

        private void listProduccion_Load(object sender, EventArgs e)
        {
            ProduccionB.ListProduccion(dgvProduccion);
            dgvProduccion.AutoGenerateColumns = false;
        }
    }
}
