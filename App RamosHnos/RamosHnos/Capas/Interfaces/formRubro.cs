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
    public partial class formRubro : Form
    {
        public formRubro()
        {
            InitializeComponent();
        }

        private void formRubro_Load(object sender, EventArgs e)
        {
            RubroB.MostrarRubroDGV(dgvRubros);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RubroEntity rubro = new RubroEntity()
            {
                rubro = txtRubro.Text,
                estado = Convert.ToInt32(cbEstado.Checked),
            };

            RubroB.InsertRubro(rubro);

            RubroB.MostrarRubroDGV(dgvRubros);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
