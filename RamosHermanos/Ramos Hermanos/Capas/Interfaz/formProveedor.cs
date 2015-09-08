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
    public partial class formProveedor : Form
    {
        public formProveedor()
        {
            InitializeComponent();
        }

        private void formProveedor_Load(object sender, EventArgs e)
        {
            cbIVA.SelectedIndex = 0;
            RubroB.CargarDGVproveedor(dgvRubro);
            ProveedorB.cargardgv(dgvProveedor);
           
            
        }

        ProveedorEntity proveedor = new ProveedorEntity();

        private void cargarProv()
        {
            proveedor.fecha = dtpFechaAlta.Value;
            proveedor.cuit = txtcuit.Text;
            proveedor.razsocial = txtRazonSocial.Text;
            proveedor.estado = cbEstado.Checked;
            proveedor.condicioniva = cbIVA.Text;
            proveedor.rol = 2;

        }

        SaldoEntity saldo = new SaldoEntity();

        private void cargarSaldo(TextBox txt)
        {

            saldo.rol = 2;
            saldo.idPersona = Convert.ToInt32(txt.Text);
            saldo.creditoMax = Convert.ToDouble(txtDebmax.Text);
            //saldo.saldoActual = Convert.ToDouble(txtSaldoActual.Text);

        }

        EmailEntity email = new EmailEntity();

        private void cargarEmail()
        {

            email.idPersona = Convert.ToInt32(txtidprov.Text);
            email.rol = 2;

        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarProv();

        }



        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            if (txtidprov.Text == string.Empty)
            {

                MessageBox.Show("Por favor, ingrese un proveedor");

            }

            else
            {
                formContacto frm = new formContacto();
                frm.txtIDALL.Text = txtidprov.Text;
                frm.tabVar = 0;
                frm.Show();
                frm.cbRolALL.SelectedValue = 2;
                frm.txtNombreEmail.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreDom.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreTel.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.CargarDGVs();
            }
        }

        private void btnTelefono_Click_1(object sender, EventArgs e)
        {
            if (txtidprov.Text == string.Empty)
            {

                MessageBox.Show("Por favor, ingrese un proveedor");

            }

            else
            {
                formContacto frm = new formContacto();
                frm.txtIDALL.Text = txtidprov.Text;
                frm.tabVar = 1;
                frm.Show();
                frm.cbRolALL.SelectedValue = 2;
                frm.txtNombreEmail.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreDom.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreTel.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.CargarDGVs();
            }
        }

        private void BuscarProv()
        {

            if (txtRazonSocial.Text == "")
            {

                tabProveedor.SelectedTab = tabListado;
                return;

            }

            cargarProv();

            if (ProveedorB.ExisteProveedor(proveedor) == false)
            {
                MessageBox.Show("El proveedor no existe");
                return;
            }

            else
            {
                ProveedorB.BuscarProvRazonsocial(proveedor);
                txtidprov.Text = Convert.ToString(proveedor.idProveedor);
                txtRazonSocial.Text = proveedor.razsocial;
                txtcuit.Text = proveedor.cuit;
                txtDebmax.Text = Convert.ToString(proveedor.debMAX);
                dtpFechaAlta.Value = proveedor.fecha;
                cbIVA.SelectedValue = proveedor.condicioniva;

                //Cargar Saldos

                cargarSaldo(txtidprov);
                SaldoB.BuscarSaldo(saldo);
                txtDebmax.Text = Convert.ToString(saldo.creditoMax);
                //txtSaldoActual.Text = Convert.ToString(saldo.saldoActual);


                EmailB.CargarTXT(txtEmail, txtidprov, 2);
                DomicilioB.CargarTXT(txtDomicilio, txtidprov, 2);
                TelefonoB.CargarTXT(txtTel, txtidprov, 2);

            }
        }

        private bool VerificarCampos()
        {

            if (txtcuit.MaskFull == false || txtRazonSocial.Text == string.Empty || txtDebmax.Text == string.Empty)
            {

                MessageBox.Show("Campos obligatorios incompletos");
                return false;

            }
            return true;

        }






        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (txtidprov.Text == string.Empty)
            {

                MessageBox.Show("Por favor, ingrese un proveedor");

            }

            else
            {
                formContacto frm = new formContacto();
                frm.txtIDALL.Text = txtidprov.Text;
                frm.tabVar = 2;
                frm.Show();
                frm.cbRolALL.SelectedValue = 2;
                frm.txtNombreEmail.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreDom.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreTel.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
            }
        }

        private void btnGuardarProv_Click(object sender, EventArgs e)
        {
            GuardarProveedor();
            ProveedorB.cargardgv(dgvProveedor);


            //cargarProv();
            //ProveedorB.InsertProveedor(proveedor, txtidprov);
            //cargarSaldo();
            //SaldoB.InsertSaldo(saldo);
            //cargarEmail();
            //EmailB.InsertEmail(email);
            //ProveedorB.cargardgv(dgvProveedor);

        }

       
        private void SeleccionarDGV()
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvProveedor.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.
                proveedor.idProveedor = Convert.ToInt32(row.Cells["colidprov"].Value.ToString());
                ProveedorB.BuscarIdProv(proveedor);
                txtidprov.Text = Convert.ToString(proveedor.idProveedor);
                txtRazonSocial.Text = proveedor.razsocial;
                txtcuit.Text = proveedor.cuit;
                dtpFechaAlta.Value = proveedor.fecha;
                cbIVA.SelectedValue = proveedor.condicioniva;


                //Saldo
                saldo.rol = 2;
                saldo.idPersona = Convert.ToInt32(txtidprov.Text);
                SaldoB.BuscarSaldo(saldo);
                txtDebmax.Text = Convert.ToString(saldo.creditoMax);
                //txtSaldoActual.Text = Convert.ToString(saldo.saldoActual);


                //Contacto
                DomicilioB.CargarTXT(txtDomicilio, txtidprov, 2);
                EmailB.CargarTXT(txtEmail, txtidprov, 2);
                TelefonoB.CargarTXT(txtTel, txtidprov, 2);



                tabProveedor.SelectedTab = tabInformacion;

            }
        }

        ////VisitaEntity visita = new VisitaEntity();
        ////private void cargarVisita(TextBox text )
        ////{
        ////     visita.rol = 2;
        ////     visita.idPersona = Convert.ToInt32(txtidprov.Text);
        ////     visita.horarioVisitaA  = Convert.ToString(dtpA.Text);
        ////     visita.horarioVisitaB  = Convert.ToString(dtpB.Text);   
                 
        
        ////}

    
        private void GuardarProveedor()
        {
            if (VerificarCampos() == false)
            {
                return;

            }
            else
            {
                proveedor.cuit = txtcuit.Text;
                if (ProveedorB.ExisteProveedor(proveedor) == true)
                {
                    DialogResult result = MessageBox.Show("El proveedor existe, desea actualizarlo con los datos ingresados?", "Proveedor Existe", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        cargarProv();
                        ProveedorB.UpdateProveedor(proveedor);

                        cargarSaldo(txtidprov);
                        SaldoB.UpdateSaldo(saldo);

                        BuscarProv();

                        return;
                    }
                    else
                    {
                        return;
                    }
                            }
                            else if (ProveedorB.ExisteProveedor(proveedor) == false)
                            {
                                cargarProv();
                                ProveedorB.InsertProveedor(proveedor,txtidprov);

                                cargarSaldo(txtidprov);
                                SaldoB.InsertSaldo(saldo);

                     //           cargarVisita(txtidprov);
                       //         VisitaB.InsertVisita(visita);
                                
                            }                
                        }
                    }

        
        private void dgvProveedor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SeleccionarDGV();
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clean()
        {

            txtRazonSocial.Text = "";
            txtcuit.Text = "";
            txtDebmax.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            txtidprov.Text = "";
            txtSaldoActual.Text = "";
            txtTel.Text = "";
            cbIVA.SelectedIndex = 0;
                   
        
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void editarProv()
        {
            if (VerificarCampos() == false)
            {
                return;
            }
            else
            {
                if (txtidprov.Text == string.Empty)
                {
                    DialogResult result1 = MessageBox.Show("Seleccione un Proveedor", "Atencion!", MessageBoxButtons.OK);
                    if (result1 == DialogResult.OK)
                    {

                        tabProveedor.SelectedTab = tabListado;
                        return;
                    
                    }
                    return;
                    }
                    DialogResult result = MessageBox.Show("¿Desea actualizar los datos del Proveedor?", "Actualizar", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        cargarProv();
                        ProveedorB.UpdateProveedor(proveedor);
                        cargarSaldo(txtidprov);
                        SaldoB.UpdateSaldo(saldo);
                        BuscarProv();
                       

                    }             
                }
            
            
            }

        private void button4_Click(object sender, EventArgs e)
        {
            editarProv();
            ProveedorB.cargardgv(dgvProveedor);
        }

        private void btnEmail_Click_1(object sender, EventArgs e)
        {
            if (txtidprov.Text == string.Empty)
            {

                MessageBox.Show("Por favor, ingrese un proveedor");

            }

            else
            {
                formContacto frm = new formContacto();
                frm.txtIDALL.Text = txtidprov.Text;
                frm.tabVar = 2;                
                frm.Show();
                frm.cbRolALL.SelectedValue = 2;                
                frm.txtNombreEmail.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreDom.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.txtNombreTel.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.CargarDGVs();
            }
        }

        private void txtcuit_KeyPress(object sender, KeyPressEventArgs e)
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
                    MessageBox.Show("Solo se permiten Números");
                } 
        }

        private void txtRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
        {
            MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;

        }
        
}

        private void txtDebmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtDebmax.Text.Length; i++)
            {
                if (txtDebmax.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true; 
        }

        private void cbIVA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvRubro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        }
 }

