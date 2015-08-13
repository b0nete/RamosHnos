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

        private void formCliente_Load(object sender, EventArgs e)
        {
            CargaInicial();            
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GuardarCliente();
        }

        // -------------------------------------//

        // Metodos del FORM.

        public void CargaInicial()
        {
            tipoDocB.CargarTipoDoc(cbTipoDoc);
            tipoClienteB.CargarTipoCliente(cbTipoCliente);

            //Valores Iniciales
            cbSexo.SelectedIndex = 0;
            cbEstadoCivil.SelectedIndex = 0;
            cbIVA.SelectedIndex = 4;
        }

  
        
            

        private bool VerificarCampos() //Verificar valores necesarios cargados.
        {
            if (txtnumDoc.Text == string.Empty || txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtCUIL.MaskFull == false)
            {
                MessageBox.Show("Datos necesarios incompletos.");
                return false;
            }
            return true;
        }

        private void GuardarCliente()
        {
            if (VerificarCampos() == false)
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

                        //CargarVisita(txtIDcliente);
                        //VisitaB.UpdateVisita(visita);

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
                }                
            }
        }

        private void BuscarCliente()
        {
            if (txtnumDoc.Text == "")
            {
                MessageBox.Show("Ingrese el Nº de documento del cliente a Buscar");
                return;
            }

            CargarCliente();    
            ClienteB.BuscarCliente(cliente);
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
            //cbTipoCliente.SelectedValue = cliente.tipoCliente;
            cbEstado.Checked = cliente.estado;


            CargarSaldo(txtIDcliente);
            SaldoB.BuscarSaldo(saldo);
            txtCreditoMax.Text = Convert.ToString(saldo.creditoMax);
            txtSaldo.Text = Convert.ToString(saldo.saldoActual);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

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
            visita.olunes = Convert.ToInt32(txtLun.Text);
            visita.omartes = Convert.ToInt32(txtMar.Text);
            visita.omiercoles = Convert.ToInt32(txtMie.Text);
            visita.ojueves = Convert.ToInt32(txtJue.Text);
            visita.oviernes = Convert.ToInt32(txtVie.Text);
            visita.osabado = Convert.ToInt32(txtSab.Text);
            visita.odomingo = Convert.ToInt32(txtDom.Text);   
        }

        private void txtCreditoMax_TextChanged(object sender, EventArgs e)
        {

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

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            formContacto frm = new formContacto();
            frm.tabVar = 0;
            frm.Show();
        }

        private void btnTelefono_Click_1(object sender, EventArgs e)
        {
            formContacto frm = new formContacto();
            frm.tabVar = 1;
            frm.Show();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            formContacto frm = new formContacto();
            frm.tabVar = 2;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formtipoCliente frm = new formtipoCliente();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //int[] array = new int[7];
            //array[0] = Convert.ToInt32(txtLun.Text);
            //array[1] = Convert.ToInt32(txtMar.Text);
            //array[2] = Convert.ToInt32(txtMie.Text);
            //array[3] = Convert.ToInt32(txtJue.Text);
            //array[4] = Convert.ToInt32(txtVie.Text);
            //array[5] = Convert.ToInt32(txtSab.Text);
            //array[6] = Convert.ToInt32(txtDom.Text);

            //visita.diasSemana[0] = Convert.ToBoolean(cbLunes.Checked);
            //visita.diasSemana[1] = Convert.ToBoolean(cbMartes.Checked);
            //visita.diasSemana[2] = Convert.ToBoolean(cbMiercoles.Checked);
            //visita.diasSemana[3] = Convert.ToBoolean(cbJueves.Checked);
            //visita.diasSemana[4] = Convert.ToBoolean(cbViernes.Checked);
            //visita.diasSemana[5] = Convert.ToBoolean(cbSabado.Checked);
            //visita.diasSemana[6] = Convert.ToBoolean(cbDomingo.Checked);

            //MessageBox.Show(Convert.ToString(visita.diasSemana[1]));
 


            //VisitaB.CargarBOOL(comboBox1);
            //bool[] diaSemana = new bool[3];
            //diaSemana[0] = cbLunes.Checked;
            //diaSemana[1] = cbMartes.Checked;
            //diaSemana[2] = cbMiercoles.Checked;

            //MessageBox.Show(Convert.ToString(diaSemana[0]) + " " + Convert.ToString(diaSemana[1]) + " " + Convert.ToString(diaSemana[2]));

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



    }
}




        


