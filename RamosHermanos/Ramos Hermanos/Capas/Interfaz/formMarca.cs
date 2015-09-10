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
    public partial class formMarca : Form
    {
        public formMarca()
        {
            InitializeComponent();
        }

        private void formMarca_Load(object sender, EventArgs e)
        {
            MarcaB.CargarDGV(dgvMarcas);
            txtIDMarca.Text = "";
            txtMarca.Text = "";
        }

        //Eventos

        MarcaEntity marca = new MarcaEntity();
        private void CargarMarca()
        {
            marca.marca = txtMarca.Text;
            marca.estado = cbEstado.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
            {
                return;
            }
            else
            {
                marca.marca = txtMarca.Text;
                if (MarcaB.ExisteMarca(marca) == true)
                {
                    DialogResult result = MessageBox.Show("La Marca ya existe");
                    return;
                }
                else
                {
                    CargarMarca();
                    MarcaB.InsertMarca(marca, txtIDMarca);
                    MarcaB.CargarDGV(dgvMarcas);
                    txtIDMarca.Text = "";
                    txtMarca.Text = "";
                }
            }
        }

        // Metodos

        private bool ValidarCampos()
        {
            if (txtMarca.Text == string.Empty)
            {
                MessageBox.Show("Marca incompleta!");
                return false;
            }
            return true;
        }

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvMarcas.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                marca.idMarca = Convert.ToInt32(row.Cells["colIDMarca"].Value.ToString());
                txtIDMarca.Text = row.Cells["colIDMarca"].Value.ToString();

                marca.marca = row.Cells["colMarca"].Value.ToString();
                txtMarca.Text = row.Cells["colMarca"].Value.ToString();

                marca.estado = Convert.ToBoolean(row.Cells["colEstado"].Value.ToString());
                cbEstado.Checked = Convert.ToBoolean(row.Cells["colEstado"].Value.ToString());

  
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
