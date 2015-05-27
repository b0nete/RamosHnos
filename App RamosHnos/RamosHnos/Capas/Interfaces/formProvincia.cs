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
    public partial class formProvincia : Form
    {
        public formProvincia()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProvinciaEntity provincia = new ProvinciaEntity()
            {
                provincia = txtProvincia.Text,
                estado = cbEstado.Checked
            };

            ProvinciaB.InsertProvincia(provincia);
            ProvinciaB.LlenarDGV(dgvProvincias);
        }

        private void formProvincia_Load(object sender, EventArgs e)
        {
            ProvinciaB.LlenarDGV(dgvProvincias);
        }
    }
}
