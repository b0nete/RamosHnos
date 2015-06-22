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
using RamosHnos.Capas.Interfaces;



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
            //Mostrar Roles
            RolB.MostrarRolesCB(cbRoles);

            //Mostrar Tipos de Telefonos
            TelefonoB.CargarTipoTel(cbTipoTel);

            string tel = txtID.Text;
            TelefonoB.MostrarTelefono(dgvTelefonos, tel);

            //Cargar Tipos de Telefonos si no existen            
            DataTable dt = TelefonoB.ExisteTipoTel();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Cargue los Tipos de Telefono a utilizar");
                formTipoTel frm = new formTipoTel();
                frm.Show();
            }        
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            TelefonoEntity telefono = new TelefonoEntity()
            {
                idPersona = Convert.ToInt32(txtID.Text),
                tipoTel = Convert.ToInt32(cbTipoTel.SelectedValue),
                caracteristica = txtCaracteristica.Text,
                numTel = txtNumTel.Text
            };


            TelefonoB.InsertTelefono(telefono);
            string tel = txtID.Text;
            TelefonoB.MostrarTelefono(dgvTelefonos, tel);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            TelefonoEntity telefono = new TelefonoEntity()
            {
                rol = Convert.ToInt32(cbRoles.SelectedValue),
                idPersona = Convert.ToInt32(txtID.Text),
                tipoTel = Convert.ToInt32(cbTipoTel.SelectedValue),
                caracteristica = txtCaracteristica.Text,
                numTel = txtNumTel.Text
            };


            TelefonoB.InsertTelefono(telefono);

            string tel = txtID.Text;
            TelefonoB.MostrarTelefono(dgvTelefonos, tel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formTipoTel frm = new formTipoTel();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
