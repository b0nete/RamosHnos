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
    public partial class formRubro : Form
    {
        public formRubro()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cargarRubro();
            RubroB.InsertRubro(rubro, txtidRubro);

        }

        RubroEntity rubro = new RubroEntity();

        private void cargarRubro()
        {
            rubro.rubro = txtRubro.Text;
            rubro.estado = cbEstado.Checked;
        }

        private void formRubro_Load(object sender, EventArgs e)
        {
            RubroB.CargarDGV(dataGridView1);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    
    
    }
}
