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
    public partial class formInsumo : Form
    {
        public formInsumo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void formAddInsumo_Load(object sender, EventArgs e)
        {
            RubroB.MostrarRubroCB(cbRubro);

            InsumoB.MostrarInsumos(dgvInsumos);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formRubro frm= new formRubro();
            frm.Show();
        }

        private void cbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbRubro_DropDown(object sender, EventArgs e)
        {
            RubroB.MostrarRubroCB(cbRubro);
        }



        private void button5_Click(object sender, EventArgs e)
        {
            InsumoEntity insumo = new InsumoEntity()
            {
                rubro = Convert.ToInt32(cbRubro.SelectedValue),
                insumo = txtInsumo.Text,
                marca = txtMarca.Text,
                descripcion = txtDescripcion.Text,
                stockMin = txtStockMin.Text,
                estado = cbEstado.Checked
            };
            InsumoB.InsertInsumo(insumo);
            txtIDInsumo.Text = Convert.ToString(insumo.idInsumo);
            
            CostoInsumoEntity cinsumo = new CostoInsumoEntity()
            {
                insumo = Convert.ToInt32(txtIDInsumo.Text),
                fechaActualizacion = dtpFechaAct.Value,
                estado = Convert.ToBoolean(1)
            };
            InsumoB.InsertCosto(cinsumo);

            InsumoB.MostrarInsumos(dgvInsumos);
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            double temp = 0;

            if (double.TryParse(txtCosto.Text, out temp))
            {
                txtCosto.Text = temp.ToString("N2");
            }
        }
    }
}
