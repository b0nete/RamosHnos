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
            ProveedorB.MostrarProveedor(cbProveedor);

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
            formRubro frm = new formRubro();
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
                proveedor = Convert.ToInt32(cbProveedor.SelectedValue),
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
                costo = Convert.ToDouble(txtCosto.Text),
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIDInsumo.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un Producto");
            }

            formCostoInsumo frm = new formCostoInsumo();
            frm.txtNombre.Text = txtInsumo.Text + ' '+ '-' + ' ' + txtIDInsumo.Text;
            frm.txtCostoAnterior.Text = txtCosto.Text;
            frm.txtIDInsumo.Text = txtIDInsumo.Text;
            string insumo = txtIDInsumo.Text;
            InsumoB.MostrarCostoInsumo(frm.dgvCostoInsumo, insumo);
            frm.Show();
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvInsumos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvInsumos.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txtIDInsumo.Text = row.Cells["idInsumo"].Value.ToString();
                //cbRubro.SelectedValue = row.Cells["Rubro"].Value.ToString();
                txtInsumo.Text = row.Cells["Insumo"].Value.ToString();
                txtMarca.Text = row.Cells["Marca"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtStockMin.Text = row.Cells["StockMin"].Value.ToString();
                txtCosto.Text = row.Cells["Costo"].Value.ToString();
                //dtpFechaAct.Value = row.Cells["FechaActualizacion"].Value.ToString();
                //cbEstado.Checked = Convert.ToBoolean(row.Cells["Estado"].Value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFechaAct_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //double temp = 0;

            //if (double.TryParse(txtCosto.Text, out temp))
            //{
            //    txtCosto.Text = temp.ToString("N2");
            //}
        }

        private void cbProveedor_DropDown(object sender, EventArgs e)
        {
            ProveedorB.MostrarProveedor(cbProveedor);
        }
    }
}


