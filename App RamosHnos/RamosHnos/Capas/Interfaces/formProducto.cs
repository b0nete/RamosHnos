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
    public partial class formProducto : Form
    {
        public formProducto()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formTipoProducto frm = new formTipoProducto();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formMedida frm = new formMedida();
            frm.Show();
        }

        private void cbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoProducto_DropDown(object sender, EventArgs e)
        {
            ProductoB.MostrarTipoProducto(cbTipoProducto);
        }

        private void formProducto_Load(object sender, EventArgs e)
        {
            ProductoB.MostrarTipoProducto(cbTipoProducto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoEntity producto = new ProductoEntity()
            {
                tipoProducto = Convert.ToInt32(cbTipoProducto.SelectedValue),
                producto = txtProducto.Text,
                medida = Convert.ToInt32(cbMedida.SelectedValue),
                descripcion= txtDescripcion.Text,
                stockMin = Convert.ToInt32(txtStockMin.Text),
                fechaVencimiento = dtpFechaAct.MaxDate,
                estado = cbEstado.Checked
            };
        }
    }
}
