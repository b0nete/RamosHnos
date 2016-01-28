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

namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listInsumos : Form
    {
        public listInsumos()
        {
            InitializeComponent();
        }

        private void listInsumos_Load(object sender, EventArgs e)
        {
            cbParametro.SelectedIndex = 0;
            InsumoB.cargardgvInsumo(dgvInsumos);   
        }

        private void SearchParametro()
        {
            string parametro = '%' + txtParametro.Text + '%';
            InsumoB.CargarDGVParametros(dgvInsumos, cbParametro, parametro);
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            SearchParametro();
        }
    }
}
