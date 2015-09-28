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
using RamosHermanos.Capas.Interfaz.Contratos;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formDomicilio : Form
    {
        public formDomicilio()
        {
            InitializeComponent();
        }

        public int tabVar;
        public int DGVvar = 1;

        // Eventos
        private void formDomicilio_Load(object sender, EventArgs e)
        {
            // Tab Inicial
            switch (tabVar)
            {
                case 0:
                    tabDomicilios.SelectedTab = tabCalles;
                    break;
                case 1:
                    tabDomicilios.SelectedTab = tabBarrios;
                    break;
                case 2:
                    tabDomicilios.SelectedTab = tabLocalidades;
                    break;
                case 3:
                    tabDomicilios.SelectedTab = tabProvincias;
                    break;
            }

            // Combos
            //Provincia
            ProvinciaB.CargarCB(cbProvinciaBar);
            //Localidad
            LocalidadB.CargarCB(cbLocalidadBar, cbProvinciaBar);
            //Barrio
            BarrioB.CargarDGV(dgvBarrio);
            //Calles
            ProvinciaB.CargarCB(cbProvinciaCalle);

            CheckColor(cbEstadoBar, lblEstadoDom);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProvinciaBar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LocalidadB.CargarCB(cbLocalidadBar, cbProvinciaBar);
        }

        private void cbEstadoBar_CheckedChanged(object sender, EventArgs e)
        {
            CheckColor(cbEstadoBar, lblEstadoDom);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ValidarBarrios() == false)
            {
                MessageBox.Show("Campos incompletos");
                return;
            }
            else
            {
                if (BarrioB.ExisteBarrio(txtBarrio) == true)
                {
                    MessageBox.Show("El Barrio ya existe");
                    return;
                }
                else
                {
                    CargarBarrio();
                    BarrioB.InsertBarrio(barrio);
                    BarrioB.CargarDGV(dgvBarrio);
                }
            }
        }

        private void btnSaveCalle_Click(object sender, EventArgs e)
        {
            if (ValidarCalles() == false)
            {
                MessageBox.Show("Campos incompletos");
                return;
            }
            else
            {
                if (CalleB.ExisteCalle(txtCalle) == true)
                {
                    MessageBox.Show("La calle ya existe");
                    return;
                }
                else
                {
                    CargarCalle();
                    CalleB.InsertCalle(calle);
                    CargarBarrio();
                    CalleB.CargarDGV(barrio, dgvCalle);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Metodos

        private void CheckColor(CheckBox cb, Label lbl)
        {
            if (cb.Checked == true)
            {
                lbl.BackColor = Color.Green;
                lbl.Text = "Habilitado";
            }
            else
            {
                lbl.BackColor = Color.Red;
                lbl.Text = "Desabilitado";
            }
        }

        // Entidades

        BarrioEntity barrio = new BarrioEntity();
        private void CargarBarrio()
        {
            barrio.idLocalidad = Convert.ToInt32(cbLocalidadBar.SelectedValue);
            barrio.barrio = txtBarrio.Text;
            barrio.estado = Convert.ToBoolean(cbEstadoBar.Checked);
        }

        CalleEntity calle = new CalleEntity();
        private void CargarCalle()
        {
            calle.idBarrio = Convert.ToInt32(cbBarriosCalle.SelectedValue);
            calle.calle = txtCalle.Text;
            calle.estado = Convert.ToBoolean(cbEstadoCalle.Checked);
        }

        // Validaciones

        private bool ValidarBarrios()
        {
            if (cbProvinciaBar.SelectedValue == null || cbLocalidadBar.SelectedValue == null || txtBarrio.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private bool ValidarCalles()
        {
            if (cbLocalidadesCalle.SelectedValue == null || cbBarriosCalle.SelectedValue == null || txtCalle.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void cbProvinciaCalle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LocalidadB.CargarCB(cbLocalidadesCalle, cbProvinciaCalle);
        }

        private void cbLocalidadesCalle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BarrioB.CargarCB(cbBarriosCalle, cbLocalidadesCalle);
        }

        private void cbBarriosCalle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Cargamos el ID de barrio para llenar el DGV.
            barrio.idBarrio = Convert.ToInt32(cbBarriosCalle.SelectedValue);
            CalleB.CargarDGV(barrio, dgvCalle);
        }

        private void dgvCalle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            formDistribuidores frm = new formDistribuidores();

            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvCalle.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                switch (DGVvar)
                {
                    // Caso 1: Carga datos en los elementos para editarlos.
                    case 1:
                        cbProvinciaCalle.SelectedValue = row.Cells["colCIDProvincia"].Value.ToString();
                        cbLocalidadesCalle.SelectedValue = row.Cells["colCIDLocalidad"].Value.ToString();
                        cbBarriosCalle.SelectedValue = row.Cells["colCIDBarrio"].Value.ToString();
                        txtCalle.Text = row.Cells["colCCalle"].Value.ToString();
                        cbEstadoCalle.Checked = Convert.ToBoolean(row.Cells["colCEstado"].Value);
                        break;

                    // Caso 2: Envía datos al formRecorrido.
                    case 2:
                        DataGridViewRow rowA = this.dgvCalle.CurrentRow as DataGridViewRow;

                        IAddItem parent = this.Owner as IAddItem;
                        parent.AddNewItem(rowA);

                        this.Close();
                        break;
                }
            }
        }


    }
}
