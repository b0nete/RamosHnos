using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; //Para validar Email.
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

            CheckColor(cbEstadoTel, lblEstadoEmail);
            CheckColor(cbEstadoEmail, lblEstadoTel);
            CheckColor(cbEstadoDom, lblEstadoDom);
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

            //Telefono
            tipoTelB.CargarCB(cbTipoTel);
            //Domicilio
            ProvinciaB.CargarCB(cbProvincia);
            cbProvincia.SelectedValue = 5;
            LocalidadB.CargarCB(cbLocalidad, cbProvincia);
            cbLocalidad.SelectedValue = 26;
            BarrioB.CargarCB(cbBarrio, cbLocalidad);
            CalleB.CargarCB(cbCalle, cbBarrio);
        }

        public void CargarDGVs()
        {
            EmailB.CargarDGV(dgvEmail, cbRolALL, txtIDALL);
            TelefonoB.CargarDGV(dgvTelefono, cbRolALL, txtIDALL);
            DomicilioB.CargarDGV(dgvDomicilio, cbRolALL, txtIDALL);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Email Invalido");
                return;
            }
            else
            {
                if (EmailB.ExisteEmail(txtEmail) == true)
                {
                    MessageBox.Show("El mail ya existe");
                    return;
                }
                else
                {
                    CargarEmail();
                    EmailB.InsertEmail(email);
                    EmailB.CargarDGV(dgvEmail, cbRolALL, txtIDALL);
                }                
            }
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
            if (ValidarTelefono() == false)
            {
                MessageBox.Show("Campos necesarios incompletos");
                return;
            }
            else
            {
                CargarTelefono();
                if (TelefonoB.ExisteTelefono(telefono) == true)
                {
                    MessageBox.Show("El telefono existe");
                    return;
                }
                else
                {
                    CargarTelefono();
                    TelefonoB.InsertTelefono(telefono);
                    TelefonoB.CargarDGV(dgvTelefono, cbRolALL, txtIDALL);
                }                
            }            
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
            if (ValidarDomicilio() == false)
            {
                MessageBox.Show("Campos incompletos");
                return;
            }
            else
            {
                CargarDomicilio();
                DomicilioB.InsertDomicilio(domicilio);
                DomicilioB.CargarDGV(dgvDomicilio, cbRolALL, txtIDALL);
            }
            
        }

        DomicilioEntity domicilio = new DomicilioEntity();
        private void CargarDomicilio()
        {
            domicilio.rol = Convert.ToInt32(cbRolALL.SelectedValue);
            domicilio.idPersona = Convert.ToInt32(txtIDALL.Text);
            domicilio.provincia = Convert.ToInt32(cbProvincia.SelectedValue);
            domicilio.localidad = Convert.ToInt32(cbLocalidad.SelectedValue);
            domicilio.barrio = Convert.ToInt32(cbBarrio.SelectedValue);
            domicilio.calle = Convert.ToInt32(cbCalle.SelectedValue);
            domicilio.numero = txtnumCalle.Text;
            domicilio.piso = txtPiso.Text;
            domicilio.dpto = txtDpto.Text;
            domicilio.CP = txtCP.Text;
            domicilio.estado = cbEstadoDom.Checked;
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
                domicilio.idDomicilio = Convert.ToInt32(row.Cells["colIDDom"].Value.ToString());
                cbProvincia.Text = row.Cells["colProvincia"].Value.ToString();
                cbLocalidad.Text = row.Cells["colLocalidad"].Value.ToString();
                cbBarrio.Text = row.Cells["colBarrio"].Value.ToString();
                cbCalle.Text = row.Cells["colCalle"].Value.ToString();
                txtnumCalle.Text = row.Cells["colNumero"].Value.ToString();
                txtPiso.Text = row.Cells["colPiso"].Value.ToString();
                txtDpto.Text = row.Cells["colDpto"].Value.ToString();
                txtCP.Text = row.Cells["colCP"].Value.ToString();
                cbEstadoDom.Checked = Convert.ToBoolean(row.Cells["colEstadoDom"].Value.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

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

        private void cbEstadoTel_CheckedChanged(object sender, EventArgs e)
        {
            CheckColor(cbEstadoTel, lblEstadoTel);
        }

        private void cbEstadoEmail_CheckedChanged(object sender, EventArgs e)
        {
            CheckColor(cbEstadoEmail, lblEstadoEmail);
        }

        private void dgvTelefono_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvTelefono.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                cbTipoTel.Text = row.Cells["colIDTelefono"].Value.ToString();
                telefono.idTelefono = Convert.ToInt32(row.Cells["colIDTelefono"].Value.ToString());
                cbTipoTel.SelectedValue = Convert.ToInt32(row.Cells["colIDTipoTel"].Value.ToString());
                telefono.tipoTel = Convert.ToInt32(row.Cells["colIDTipoTel"].Value.ToString());
                txtCaracteristica.Text = row.Cells["colCaracteristica"].Value.ToString();
                telefono.caracteristica = row.Cells["colCaracteristica"].Value.ToString();
                txtNumTel.Text = row.Cells["colnumTel"].Value.ToString();
                telefono.numTel = row.Cells["colnumTel"].Value.ToString();
                cbEstadoTel.Checked = Convert.ToBoolean(row.Cells["colEstadoTel"].Value.ToString());
            }
        }

        private void dgvEmail_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvEmail.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                email.idEmail = Convert.ToInt32(row.Cells["colIDEmail"].Value.ToString());
                //MessageBox.Show(Convert.ToString(email.idEmail));
                txtEmail.Text = row.Cells["colEmail"].Value.ToString();                
                email.email = row.Cells["colEmail"].Value.ToString();
                cbEstadoEmail.Checked = Convert.ToBoolean(row.Cells["colEstado"].Value.ToString());
                email.estado = Convert.ToBoolean(row.Cells["colEstado"].Value.ToString());
            }
        }

        private void dgvTelefono_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public static bool ValidarEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarTelefono()
        {
            if (cbTipoTel.SelectedValue == null || txtCaracteristica.Text == string.Empty || txtNumTel.Text == string.Empty)
            {
                return false;
            }
            return true;            
        }

        private bool ValidarDomicilio()
        {
            if (cbProvincia.SelectedValue == null || cbLocalidad.SelectedValue == null || cbBarrio.SelectedValue == null || cbCalle.SelectedValue == null || txtnumCalle.Text == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void btnUpdEmail_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Seleccione un Email");
                return;
            }
            else
            {
                CargarEmail();
                EmailB.UpdateEmail(email);
                EmailB.CargarDGV(dgvEmail, cbRolALL, txtIDALL);
            }
        }

        private void btnUpdTel_Click(object sender, EventArgs e)
        {
            if (ValidarTelefono() == false)
            {
                MessageBox.Show("Campos necesarios incompletos");
                return;
            }
            else
            {
                CargarTelefono();
                TelefonoB.UpdateTelefono(telefono);
                TelefonoB.CargarDGV(dgvTelefono, cbRolALL, txtIDALL);
            }
        }

        

        private void btnUpdDom_Click(object sender, EventArgs e)
        {
            if (ValidarDomicilio() == false)
            {
                MessageBox.Show("Campos incompletos.");
                return;
            }
            else
            {
                CargarDomicilio();
                DomicilioB.UpdateDomicilio(domicilio);
                DomicilioB.CargarDGV(dgvDomicilio, cbRolALL, txtIDALL);
            }
        }

        private void cbEstadoDom_CheckedChanged(object sender, EventArgs e)
        {
            CheckColor(cbEstadoDom, lblEstadoDom);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formDomicilio frm = new formDomicilio();
            frm.Show();
        }

        private void cbRolALL_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            formDomicilio frm = new formDomicilio();
            frm.Show();
        }

      

        


    }
}
