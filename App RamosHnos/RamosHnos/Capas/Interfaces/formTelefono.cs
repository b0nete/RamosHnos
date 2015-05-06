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



namespace RamosHnos
{
    public partial class formTelefono : Form
    {
        public formTelefono()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void formAddTel_Load(object sender, EventArgs e)
        {
            TelefonoB.CargarTipoTel(cbTipoTel);
            TelefonoB.CargarTelefono(dgvTelefonos);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            TelefonoEntity telefono = new TelefonoEntity()
            {
                cliente = Convert.ToInt32(txtIDcliente.Text),
                tipoTel = Convert.ToInt32(cbTipoTel.SelectedValue),
                caracteristica = txtCaracteristica.Text,
                numTel = txtNumTel.Text
            };


            TelefonoB.InsertTelefono(telefono);
            TelefonoB.CargarTelefono(dgvTelefonos);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
