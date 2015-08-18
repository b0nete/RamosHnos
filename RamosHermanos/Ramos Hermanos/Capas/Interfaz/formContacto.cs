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
    public partial class formContacto : Form
    {
        public int tabVar;

        public formContacto()
        {
            InitializeComponent();
        }

        private void formContacto_Load(object sender, EventArgs e)
        {
            CargaInicial();
            
        }

        private void CargaInicial()
        {
            switch (tabVar)
            {
                case 0:
                    tabContacto.SelectedTab = tabDomicilios;
                    break;
                case 1:
                    tabContacto.SelectedTab = tabTelefonos;
                    break;
                case 2:
                    tabContacto.SelectedTab = tabEmails;
                    break;
            }
            
            RolB.CargarCB(cbRolALL);

            //Emails
            EmailB.CargarDGV(dgvEmail, cbRolALL, txtIDALL);
            //Telefono
            tipoTelB.CargarCB(cbTipoTel);
            TelefonoB.CargarDGV(dgvTelefono, cbRolALL, txtIDALL);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CargarEmail();
            EmailB.InsertEmail(email);
            EmailB.CargarDGV(dgvEmail, cbRolALL, txtIDALL);
        }

        EmailEntity email = new EmailEntity();
        public void CargarEmail()
        {
            email.rol = Convert.ToInt32(cbRolALL.SelectedValue);
            email.idPersona = Convert.ToInt32(txtIDALL.Text);
            email.email = txtEmail.Text;
            email.estado = Convert.ToBoolean(cbEstadoEmail.Checked);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarTelefono();
            TelefonoB.InsertTelefono(telefono);
            TelefonoB.CargarDGV(dgvTelefono, cbRolALL, txtIDALL);
        }

        TelefonoEntity telefono = new TelefonoEntity();
        public void CargarTelefono()
        {
            telefono.rol = Convert.ToInt32(cbRolALL.SelectedValue);
            telefono.idPersona = Convert.ToInt32(txtIDALL.Text);
            telefono.tipoTel = Convert.ToInt32(cbTipoTel.SelectedValue);
            telefono.caracteristica = txtCaracteristica.Text;
            telefono.numTel = txtNumTel.Text;
            telefono.estado = Convert.ToBoolean(cbEstadoTel.Checked);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
