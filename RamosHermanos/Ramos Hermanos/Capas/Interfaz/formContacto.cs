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
            //Domicilio
            ProvinciaB.CargarCB(cbProvincia);
            cbProvincia.SelectedValue = 5;

            LocalidadB.CargarCB(cbLocalidad, cbProvincia);
            cbLocalidad.SelectedValue = 26;

            BarrioB.CargarCB(cbBarrio, cbLocalidad);
            DomicilioB.CargarDGV(dgvDomicilio, cbRolALL, txtIDALL);

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

        private void cbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LocalidadB.CargarCB(cbLocalidad, cbProvincia);
            BarrioB.CargarCB(cbBarrio, cbLocalidad);
        }

        private void cbLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BarrioB.CargarCB(cbBarrio, cbLocalidad);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CargarDomicilio();
            DomicilioB.InsertDomicilio(domicilio);
        }

        DomicilioEntity domicilio = new DomicilioEntity();
        private void CargarDomicilio()
        {
            domicilio.rol = Convert.ToInt32(cbRolALL.SelectedValue);
            domicilio.idPersona = Convert.ToInt32(txtIDALL.Text);
            domicilio.provincia = Convert.ToInt32(cbProvincia.SelectedValue);
            domicilio.localidad = Convert.ToInt32(cbLocalidad.SelectedValue);
            domicilio.barrio = Convert.ToInt32(cbBarrio.SelectedValue);
            domicilio.calle = txtCalle.Text;
            domicilio.numero = txtnumCalle.Text;
            domicilio.piso = txtPiso.Text;
            domicilio.dpto = txtDpto.Text;
            domicilio.CP = txtCP.Text;
        }

        private void dgvDomicilio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDomicilio_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvDomicilio.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                //txtIDRol.Text = row.Cells["colIDRol"].Value.ToString();
                cbProvincia.Text = row.Cells["colProvincia"].Value.ToString();
                cbLocalidad.Text = row.Cells["colLocalidad"].Value.ToString();
                cbBarrio.Text = row.Cells["colBarrio"].Value.ToString();
                txtCalle.Text = row.Cells["colCalle"].Value.ToString();
                txtnumCalle.Text = row.Cells["colNumero"].Value.ToString();
                txtPiso.Text = row.Cells["colPiso"].Value.ToString();
                txtDpto.Text = row.Cells["colDpto"].Value.ToString();
                txtCP.Text = row.Cells["colCP"].Value.ToString();
            }
        }



    }
}
