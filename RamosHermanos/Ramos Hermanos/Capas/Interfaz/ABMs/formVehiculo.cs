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

namespace RamosHermanos.Capas.Interfaz.ABMs
{
    public partial class formVehiculo : Form
    {
        public formVehiculo()
        {
            InitializeComponent();
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdVeh_Click(object sender, EventArgs e)
        {

        }

        private void cbEstadoVeh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveVehi_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveVehi_Click_1(object sender, EventArgs e)
        {
            if (ValidarVehiculo() == false)
            {
                return;
            }
            else
            {
                CargarVehiculo();
                VehiculoB.InsertVehiculo(vehiculo, txtIDvehiculo);
                VehiculoB.CargarDGV(dgvVehiculos);

                // Actualizamos CBVehiculo del formDistribuidor.
                formDistribuidores frm = new formDistribuidores();
                VehiculoB.CargarCB(frm.cbVehiculo);
            }           
        }

        private bool ValidarVehiculo() //Verificar valores necesarios cargados.
        {
            if (cbMarca.SelectedText == "" || cbColor.SelectedValue == null || txtPatente.MaskFull == false)
            {
                MessageBox.Show("Datos necesarios incompletos.");
                return false;
            }
            return true;
        }

        VehiculoEntity vehiculo = new VehiculoEntity();
        private void CargarVehiculo()
        {
            vehiculo.marca = cbMarca.Text;
            vehiculo.modelo = Convert.ToString(nudModelo.Value);
            vehiculo.patente = txtPatente.Text;
            vehiculo.color = cbColor.Text;
            vehiculo.estado = cbEstadoVeh.Checked;
        }

        private void cbColor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string clr = cbColor.Text;
            Color colour = Color.FromName(clr);

            btnColor.BackColor = colour;
        }

    }
}
