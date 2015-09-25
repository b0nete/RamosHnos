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
    public partial class formDomicilio : Form
    {
        public formDomicilio()
        {
            InitializeComponent();
        }

        // Eventos
        private void formDomicilio_Load(object sender, EventArgs e)
        {
            ProvinciaB.CargarCB(cbProvinciaBar);
            LocalidadB.CargarCB(cbLocalidadBar, cbProvinciaBar);
            BarrioB.CargarDGV(dgvBarrio);

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
                    CargarBarrio();
                    BarrioB.InsertBarrio(barrio);
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
            if (cbLocalidadesCalle.SelectedValue == null || cbBarriosCalle.SelectedValue == null || txtBarrio.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        

        
    }
}
