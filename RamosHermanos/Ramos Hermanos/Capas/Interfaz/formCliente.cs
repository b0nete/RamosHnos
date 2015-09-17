using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formCliente : Form
    {    
        public formCliente()
        {
            InitializeComponent();
        }

        // Eventos

        private void formCliente_Load(object sender, EventArgs e)
        {
            ClienteB.CargarDGV(dgvCliente);
            tipoDocB.CargarTipoDoc(cbTipoDoc);
            tipoClienteB.CargarTipoCliente(cbTipoCliente);

            //Cargar Ultimas ordenes de entrega.
            VisitaB.BuscarOrdenMAX(visita);
            {
                txtLun.Text = Convert.ToString(visita.olunes + 1);
                txtMar.Text = Convert.ToString(visita.omartes + 1);
                txtMie.Text = Convert.ToString(visita.omiercoles + 1);
                txtJue.Text = Convert.ToString(visita.ojueves + 1);
                txtVie.Text = Convert.ToString(visita.oviernes + 1);
                txtSab.Text = Convert.ToString(visita.osabado + 1);
                txtDom.Text = Convert.ToString(visita.odomingo + 1);
            }

            //Valores Iniciales
            cbSexo.SelectedIndex = 0;
            cbEstadoCivil.SelectedIndex = 0;
            cbIVA.SelectedIndex = 4;

            CheckColor();

            //Ocultar Tabs
            tabMain.Controls.Remove(tabMovimientos);
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
            {
                return;
            }
            else
            {
                cliente.numDoc = txtnumDoc.Text;
                if (ClienteB.ExisteCliente(cliente) == true)
                {
                    DialogResult result = MessageBox.Show("El cliente existe, desea actualizarlo con los datos ingresados?", "Cliente existente", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        CargarCliente();
                        ClienteB.UpdateCliente(cliente);

                        CargarSaldo(txtIDcliente);
                        SaldoB.UpdateSaldo(saldo);

                        CargarVisita(txtIDcliente);
                        VisitaB.UpdateVisita(visita);
                        visita.idVisita = Convert.ToInt32(txtIDVisita.Text);
                        CargarDias();
                        VisitaB.UpdateDias(visita);
                        CargarOrden();
                        VisitaB.UpdateOrden(visita);

                        BuscarCliente();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                else if (ClienteB.ExisteCliente(cliente) == false)
                {
                    CargarCliente();
                    ClienteB.InsertCliente(cliente, txtIDcliente);

                    CargarSaldo(txtIDcliente);
                    SaldoB.InsertSaldo(saldo);

                    CargarVisita(txtIDcliente);
                    VisitaB.InsertVisita(visita);
                    CargarDias();
                    VisitaB.InsertDias(visita);
                    CargarOrden();
                    VisitaB.InsertOrden(visita);

                    ClienteB.CargarDGV(dgvCliente);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void txtCreditoMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            if (txtIDcliente.Text == string.Empty)
            {
                tabMain.SelectedTab = tabListado;
            }
            else
            {
                formContacto frm = new formContacto();
                frm.tabVar = 0;
                frm.txtIDALL.Text = txtIDcliente.Text;
                frm.Show();
                frm.cbRolALL.SelectedValue = 1;                
                frm.txtNombreEmail.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreTel.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreDom.Text = txtNombre.Text + " " + txtApellido.Text;
                
            }
        }

        private void btnTelefono_Click_1(object sender, EventArgs e)
        {
            if (txtIDcliente.Text == string.Empty)
            {
                tabMain.SelectedTab = tabListado;
            }
            else
            {
                formContacto frm = new formContacto();
                frm.tabVar = 1;
                frm.txtIDALL.Text = txtIDcliente.Text;
                frm.Show();
                frm.cbRolALL.SelectedValue = 1;                
                frm.txtNombreEmail.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreTel.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreDom.Text = txtNombre.Text + " " + txtApellido.Text;                
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (txtIDcliente.Text == string.Empty)
            {
                tabMain.SelectedTab = tabListado;
            }
            else
            {
                formContacto frm = new formContacto();
                //frm.tabContacto.SelectTab = tabEmails;
                frm.tabVar = 2;
                frm.txtIDALL.Text = txtIDcliente.Text;
                frm.Show();
                frm.cbRolALL.SelectedValue = 1;                
                frm.txtNombreEmail.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreTel.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreDom.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.CargarDGVs();                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            formtipoCliente frm = new formtipoCliente();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtnumDoc.Text == "")
            {
                MessageBox.Show("Ingrese el Nº de documento del cliente a Eliminar");
                return;
            }
            else
            {
                cliente.numDoc = txtnumDoc.Text;
                ClienteB.DisableCliente(cliente, cbEstado);
            }

            CheckColor();
        }

        private void cbLunes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLunes.Checked == false)
                txtLun.Enabled = false;
            else
                txtLun.Enabled = true;              
        }

        private void txtLun_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbMartes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMartes.Checked == false)
                txtMar.Enabled = false;
            else
                txtMar.Enabled = true;           
        }

        private void cbMiercoles_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMiercoles.Checked == false)
                txtMie.Enabled = false;
            else
                txtMie.Enabled = true;       
        }

        private void cbJueves_CheckedChanged(object sender, EventArgs e)
        {
            if (cbJueves.Checked == false)
                txtJue.Enabled = false;
            else
                txtJue.Enabled = true;   
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void cbViernes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViernes.Checked == false)
                txtVie.Enabled = false;
            else
                txtVie.Enabled = true;           
        }

        private void cbSabado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSabado.Checked == false)
                txtSab.Enabled = false;
            else
                txtSab.Enabled = true;
        }

        private void cbDomingo_CheckedChanged(object sender, EventArgs e)
        {            
            if (cbDomingo.Checked == false)            
                txtDom.Enabled = false;            
            else            
                txtDom.Enabled = true;           
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            CheckColor();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
            {
                return;
            }
            else 
            {
                if (txtIDcliente.Text == string.Empty)
                {
                    DialogResult result1 = MessageBox.Show("Seleccione un cliente", "Advertencia!", MessageBoxButtons.OK);
                    if (result1 == DialogResult.OK)
                    {
                        tabMain.SelectedTab = tabListado;
                        return;
                    }
                    return;                                
                }
                DialogResult result = MessageBox.Show("Desea actualizar los datos del cliente?", "Actualizar", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    CargarCliente();
                    ClienteB.UpdateCliente(cliente);

                    CargarSaldo(txtIDcliente);
                    SaldoB.UpdateSaldo(saldo);
                                        
                    CargarVisita(txtIDcliente);
                    VisitaB.UpdateVisita(visita);
                    visita.idVisita = Convert.ToInt32(txtIDVisita.Text);
                    CargarDias();
                    VisitaB.UpdateDias(visita);
                    CargarOrden();
                    VisitaB.UpdateOrden(visita);

                    BuscarCliente();
                    ClienteB.CargarDGV(dgvCliente);
                }             
            }        
        }

        private void cbTipoCliente_DropDown(object sender, EventArgs e)
        {
            tipoClienteB.CargarTipoCliente(cbTipoCliente);
        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void cbIVA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SeleccionarDGV();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

         
        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void cbLunes_Validated(object sender, EventArgs e)
        {        

        }

        private void txtIDcliente_TextChanged(object sender, EventArgs e)
        {

        }

        // Metodos

        private void BuscarCliente()
        {
            if (txtnumDoc.Text == "")
            {
                tabMain.SelectedTab = tabListado;
                return;
            }

            CargarCliente();

            if (ClienteB.ExisteCliente(cliente) == false)
            {
                MessageBox.Show("El cliente no existe!");
                return;
            }
            else
            {
                ClienteB.BuscarClienteDOC(cliente);
                txtIDcliente.Text = Convert.ToString(cliente.idCliente);
                dtpFechaAlta.Value = cliente.fechaAlta;
                cbTipoDoc.SelectedValue = cliente.tipoDoc;
                txtnumDoc.Text = cliente.numDoc;
                cbSexo.Text = cliente.sexo;
                txtCUIL.Text = cliente.cuil;
                txtApellido.Text = cliente.apellido;
                txtNombre.Text = cliente.nombre;
                cbEstadoCivil.Text = cliente.estadoCivil;
                cbIVA.Text = cliente.condicionIVA;
                cbTipoCliente.SelectedValue = cliente.tipoCliente;
                cbEstado.Checked = cliente.estado;

                CargarSaldo(txtIDcliente);
                SaldoB.BuscarSaldo(saldo);
                txtCreditoMax.Text = Convert.ToString(saldo.creditoMax);
                txtSaldo.Text = Convert.ToString(saldo.saldoActual);

                CargarVisita(txtIDcliente);
                VisitaB.BuscarVisita(visita);
                txtIDVisita.Text = Convert.ToString(visita.idVisita);
                dtpA.Text = visita.horarioVisitaA;
                dtpB.Text = visita.horarioVisitaB;
                //Dias
                cbLunes.Checked = visita.dlunes;
                cbMartes.Checked = visita.dmartes;
                cbMiercoles.Checked = visita.dmiercoles;
                cbJueves.Checked = visita.djueves;
                cbViernes.Checked = visita.dviernes;
                cbSabado.Checked = visita.dsabado;
                cbDomingo.Checked = visita.ddomingo;
                //Orden
                txtLun.Text = Convert.ToString(visita.olunes);
                txtMar.Text = Convert.ToString(visita.omartes);
                txtMie.Text = Convert.ToString(visita.omiercoles);
                txtJue.Text = Convert.ToString(visita.ojueves);
                txtVie.Text = Convert.ToString(visita.oviernes);
                txtSab.Text = Convert.ToString(visita.osabado);
                txtDom.Text = Convert.ToString(visita.odomingo);

                //Contacto
                DomicilioB.CargarTXT(txtDomic, txtIDcliente, 1);
                EmailB.CargarTXT(txtEmail, txtIDcliente, 1);
                TelefonoB.CargarTXT(txtTel, txtIDcliente, 1);
            }

            CheckColor();
        }

        private void CargarDias()
        {
            // Días Semana
            visita.idDias = visita.idVisita;
            visita.dlunes = cbLunes.Checked;
            visita.dmartes = cbMartes.Checked;
            visita.dmiercoles = cbMiercoles.Checked;
            visita.djueves = cbJueves.Checked;
            visita.dviernes = cbViernes.Checked;
            visita.dsabado = cbSabado.Checked;
            visita.ddomingo = cbDomingo.Checked;
        }

        private void CargarOrden()
        {
            // Numero de Orden
            visita.idOrden = visita.idVisita;
            if (txtLun.Text == string.Empty)
                Convert.ToInt32(txtLun.Text == null);
            else
                visita.olunes = Convert.ToInt32(txtLun.Text);

            if (txtMar.Text == string.Empty)
                Convert.ToInt32(txtMar.Text == null);
            else
                visita.omartes = Convert.ToInt32(txtMar.Text);

            if (txtMie.Text == string.Empty)
                Convert.ToInt32(txtMie.Text == null);
            else
                visita.omiercoles = Convert.ToInt32(txtMie.Text);

            if (txtJue.Text == string.Empty)
                Convert.ToInt32(txtJue.Text == null);
            else
                visita.ojueves = Convert.ToInt32(txtJue.Text);

            if (txtVie.Text == string.Empty)
                Convert.ToInt32(txtVie.Text == null);
            else
                visita.oviernes = Convert.ToInt32(txtVie.Text);

            if (txtSab.Text == string.Empty)
                Convert.ToInt32(txtSab.Text == null);
            else
                visita.osabado = Convert.ToInt32(txtSab.Text);

            if (txtDom.Text == string.Empty)
                Convert.ToInt32(txtDom.Text == null);
            else
                visita.odomingo = Convert.ToInt32(txtDom.Text);
        }

        private bool ValidarCampos() //Verificar valores necesarios cargados.
        {
            if (txtnumDoc.Text == string.Empty || txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtCUIL.MaskFull == false)
            {
                MessageBox.Show("Datos necesarios incompletos.");
                return false;
            }
            return true;
        }

        private void Clean()
        {
            txtIDcliente.Text = "";
            txtnumDoc.Text = "";
            cbTipoDoc.SelectedIndex = 0;
            cbSexo.SelectedIndex = 0;
            cbEstadoCivil.SelectedIndex = 0;
            cbIVA.SelectedIndex = 4;
            txtnumDoc.Text = "";
            txtCUIL.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            cbTipoCliente.Text = "";
            txtEmail.Text = "";
            txtDom.Text = "";
            txtTel.Text = "";
            txtCreditoMax.Text = "";
            txtSaldo.Text = "";
            txt4LT.Text = "";
            txt10LT.Text = "";
            txt12LT.Text = "";
            txt20LT.Text = "";
            txt25LT.Text = "";
            txtAGUAram.Text = "";
            cbLunes.Checked = false;
            cbMartes.Checked = false;
            cbMiercoles.Checked = false;
            cbJueves.Checked = false;
            cbViernes.Checked = false;
            cbSabado.Checked = false;
            cbDomingo.Checked = false;
            txtLun.Text = "";
            txtMar.Text = "";
            txtMie.Text = "";
            txtJue.Text = "";
            txtVie.Text = "";
            txtSab.Text = "";
            txtDom.Text = "";
            dtpA.Text = "09:00";
            dtpB.Text = "16:00";
        }

        private void SeleccionarDGV()
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvCliente.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                cliente.idCliente = Convert.ToInt32(row.Cells["colIDCliente"].Value.ToString());

                ClienteB.BuscarClienteID(cliente);
                txtIDcliente.Text = Convert.ToString(cliente.idCliente);
                dtpFechaAlta.Value = cliente.fechaAlta;
                cbTipoDoc.SelectedValue = cliente.tipoDoc;
                txtnumDoc.Text = cliente.numDoc;
                cbSexo.Text = cliente.sexo;
                txtCUIL.Text = cliente.cuil;
                txtApellido.Text = cliente.apellido;
                txtNombre.Text = cliente.nombre;
                cbEstadoCivil.Text = cliente.estadoCivil;
                cbIVA.Text = cliente.condicionIVA;
                cbTipoCliente.SelectedValue = cliente.tipoCliente;
                cbEstado.Checked = cliente.estado;

                CargarSaldo(txtIDcliente);
                SaldoB.BuscarSaldo(saldo);
                txtCreditoMax.Text = Convert.ToString(saldo.creditoMax);
                txtSaldo.Text = Convert.ToString(saldo.saldoActual);

                CargarVisita(txtIDcliente);
                VisitaB.BuscarVisita(visita);
                txtIDVisita.Text = Convert.ToString(visita.idVisita);
                dtpA.Text = visita.horarioVisitaA;
                dtpB.Text = visita.horarioVisitaB;
                //Dias
                cbLunes.Checked = visita.dlunes;
                cbMartes.Checked = visita.dmartes;
                cbMiercoles.Checked = visita.dmiercoles;
                cbJueves.Checked = visita.djueves;
                cbViernes.Checked = visita.dviernes;
                cbSabado.Checked = visita.dsabado;
                cbDomingo.Checked = visita.ddomingo;
                //Orden
                txtLun.Text = Convert.ToString(visita.olunes);
                txtMar.Text = Convert.ToString(visita.omartes);
                txtMie.Text = Convert.ToString(visita.omiercoles);
                txtJue.Text = Convert.ToString(visita.ojueves);
                txtVie.Text = Convert.ToString(visita.oviernes);
                txtSab.Text = Convert.ToString(visita.osabado);
                txtDom.Text = Convert.ToString(visita.odomingo);

                //Contacto
                DomicilioB.CargarTXT(txtDomic, txtIDcliente, 1);
                EmailB.CargarTXT(txtEmail, txtIDcliente, 1);
                TelefonoB.CargarTXT(txtTel, txtIDcliente, 1);

                tabMain.SelectedTab = tabInformacion;
            }
        }

        private void CheckColor()
        {
            if (cbEstado.Checked == true)
            {
                lblEstado.BackColor = Color.Green;
                lblEstado.Text = "Habilitado";
            }
            else
            {
                lblEstado.BackColor = Color.Red;
                lblEstado.Text = "Desabilitado";
            }
        }

        // Validaciones

        private void txtnumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }

            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}
        }

        private void txtLun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }

        private void txtMar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }

        private void txtMie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }

        private void txtJue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }

        private void txtVie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }

        private void txtSab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }

        private void txtDom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }

        private void txtCreditoMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && ch == 46 && txtCreditoMax.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            //double temp = 0;

            //if (double.TryParse(txtCreditoMax.Text, out temp))
            //{

            //    txtCreditoMax.Text = temp.ToString("N2");
            //}
        }

        // Entidades

        ClienteEntity cliente = new ClienteEntity();
        private void CargarCliente()
        {
            cliente.rol = 1;
            //cliente.idCliente = Convert.ToInt32(txtIDcliente.Text);
            cliente.fechaAlta = dtpFechaAlta.Value;
            cliente.tipoDoc = Convert.ToInt32(cbTipoDoc.SelectedValue);
            cliente.numDoc = txtnumDoc.Text;
            cliente.sexo = cbSexo.Text;
            cliente.cuil = txtCUIL.Text;
            cliente.apellido = txtApellido.Text;
            cliente.nombre = txtNombre.Text;
            cliente.estadoCivil = cbEstadoCivil.Text;
            cliente.condicionIVA = cbIVA.Text;
            cliente.tipoCliente = Convert.ToInt32(cbTipoCliente.SelectedValue);
            cliente.estado = cbEstado.Checked;
        }

        SaldoEntity saldo = new SaldoEntity();
        public void CargarSaldo(TextBox txt)
        {
            saldo.rol = 1;
            saldo.idPersona = Convert.ToInt32(txt.Text);
            saldo.creditoMax = Convert.ToDouble(txtCreditoMax.Text);
            saldo.saldoActual = Convert.ToDouble(txtSaldo.Text);
        }

        VisitaEntity visita = new VisitaEntity();
        private void CargarVisita(TextBox txt)
        {
            visita.rol = 1;
            visita.idPersona = Convert.ToInt32(txt.Text);
            visita.horarioVisitaA = Convert.ToString(dtpA.Text);
            visita.horarioVisitaB = Convert.ToString(dtpB.Text);
        }
    }
}