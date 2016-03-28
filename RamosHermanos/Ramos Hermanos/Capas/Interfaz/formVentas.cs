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
using RamosHermanos.Capas.Entidades;

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

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            factura.estado = cbEstado.Text;
            FacturaB.UpdateFactura(factura);
        }

        // Entidades
        FacturaEntity factura = new FacturaEntity();

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
