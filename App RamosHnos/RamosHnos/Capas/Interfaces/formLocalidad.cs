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
using RamosHnos.Capas.Entidades;

namespace RamosHnos.Capas.Interfaces
{
    public partial class formLocalidad : Form
    {
        public formLocalidad()
        {
            InitializeComponent();
        }

        private void txtProvincia_TextChanged(object sender, EventArgs e)
        {

        }

        private void formLocalidad_Load(object sender, EventArgs e)
        {
            ProvinciaB.CargarProvincia(cbProvincia);
            LocalidadB.LlenarDGV(dgvLocalidad);
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LocalidadEntity localidad = new LocalidadEntity()
            {
                provincia = Convert.ToInt32(cbProvincia.SelectedValue),
                localidad = txtLocalidad.Text,
                estado = cbEstado.Checked
            };
            
            LocalidadB.InsertLocalidad(localidad);
            LocalidadB.LlenarDGV(dgvLocalidad);
        }
    }
}
