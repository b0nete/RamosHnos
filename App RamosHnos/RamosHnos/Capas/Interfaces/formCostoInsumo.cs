using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Negocio;

namespace RamosHnos.Capas.Interfaces
{
    public partial class formCostoInsumo : Form
    {
        public formCostoInsumo()
        {
            InitializeComponent();
        }

        private void formCostoInsumo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCostoNuevo_TextChanged(object sender, EventArgs e)
        {
            double temp = 0;

            if (double.TryParse(txtCostoNuevo.Text, out temp))
            {
                txtCostoNuevo.Text = temp.ToString("N2");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CostoInsumoEntity cinsumo = new CostoInsumoEntity()
            {
                insumo = Convert.ToInt32(txtIDInsumo.Text),
                costo = Convert.ToDouble(txtCostoNuevo.Text),
                fechaActualizacion = dtpFechaAct.Value,
            };

            InsumoB.InsertCosto(cinsumo);

            string insumo = txtIDInsumo.Text;
            InsumoB.MostrarCostoInsumo(dgvCostoInsumo, insumo);
        }
    }
}
