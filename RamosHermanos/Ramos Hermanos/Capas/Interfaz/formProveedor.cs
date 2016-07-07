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
using RamosHermanos.Capas.Interfaz.Listados;
using RamosHermanos.Capas.Interfaz.Contratos;


namespace RamosHermanos.Capas.Interfaz
{
    public partial class formProveedor : Form, IAddItemSTRING
    {
        public formProveedor()
        {
            InitializeComponent();
        }

        public void cambiarTexto(string txtMail, string txtDom, string txtTell)
        {
            txtEmail.Text = txtMail;
            txtDomicilio.Text = txtDom;
            txtTel.Text = txtTell;
        }

        private void formProveedor_Load(object sender, EventArgs e)
        {
            cbIVA.SelectedIndex = 0;
            tabProveedor.Controls.Remove(tabListado);
            tabProveedor.Controls.Remove(tabPedido);
            tabProveedor.Controls.Remove(tabAdicional);
            ProveedorB.cargardgv(dgvProveedor);
            CheckColor();

            //Movimiento
            if (txtidprov.Text != string.Empty)
            {
                int proveedor = Convert.ToInt32(txtidprov.Text);

                if (rbNoPagas.Checked == true)
                {
                    ComprasB.SearchPendientes(proveedor, dgvMovimientos);
                }
            }
        }

        ProveedorEntity proveedor = new ProveedorEntity();

         public void cargarProv()
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
            //saldo.creditoMax = Convert.ToDouble(txtDebmax.Text);
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
                frm.tabUpdateTXT = 2;
                frm.Show(this);
                frm.cbRolALL.SelectedValue = 2;
                //lblTitle.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                frm.lblTitleEmail.Text = txtidprov.Text + " - " + txtRazonSocial.Text;
                frm.lblTitleDom.Text = txtidprov.Text + " - " + txtRazonSocial.Text;
                frm.lblTitleTel.Text = txtidprov.Text + " - " + txtRazonSocial.Text;
                //ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                //frm.lblTitleDom.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                //frm.lblTitleTel.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                //frm.txtNombreEmail.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                //frm.txtNombreDom.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                //frm.txtNombreTel.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
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
                frm.tabUpdateTXT = 2;
                frm.Show(this);
                frm.cbRolALL.SelectedValue = 2;
                frm.lblTitleEmail.Text = txtidprov.Text + " - " + txtRazonSocial.Text;
                frm.lblTitleDom.Text = txtidprov.Text + " - " + txtRazonSocial.Text;
                frm.lblTitleTel.Text = txtidprov.Text + " - " + txtRazonSocial.Text;
                //frm.lblTitleEmail.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                //frm.lblTitleDom.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                //frm.lblTitleTel.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                //frm.txtNombreEmail.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                //frm.txtNombreDom.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                //frm.txtNombreTel.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                frm.CargarDGVs();
            }
        }

        private void BuscarProv()
        {

            if (txtRazonSocial.Text == "")
            {
                this.Close();
                listProveedores frm = new listProveedores();
                frm.Show();

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
                //txtDebmax.Text = Convert.ToString(proveedor.debMAX);
                dtpFechaAlta.Value = proveedor.fecha;
                cbIVA.SelectedValue = proveedor.condicioniva;

                ////Cargar Saldos

                //cargarSaldo(txtidprov);
                //SaldoB.BuscarSaldo(saldo);
                ////txtDebmax.Text = Convert.ToString(saldo.creditoMax);
                ////txtSaldoActual.Text = Convert.ToString(saldo.saldoActual);


                EmailB.CargarTXT(txtEmail, txtidprov, 2);
                DomicilioB.CargarTXT(txtDomicilio, txtidprov, 2);
                TelefonoB.CargarTXT(txtTel, txtidprov, 2);

            }
        }



        private bool VerificarCampos()
        {

            if (txtcuit.MaskFull == false || txtRazonSocial.Text == string.Empty)
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
                frm.lblTitleEmail.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                frm.lblTitleDom.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor) ;
                frm.lblTitleTel.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                //frm.txtNombreEmail.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                //frm.txtNombreDom.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                //frm.txtNombreTel.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
            }
        }

        private void btnGuardarProv_Click(object sender, EventArgs e)
        {
            GuardarProveedor();
            lblTitle.Text = txtidprov.Text + " - " + txtRazonSocial.Text;
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
                //saldo.rol = 2;
                //saldo.idPersona = Convert.ToInt32(txtidprov.Text);
                //SaldoB.BuscarSaldo(saldo);
                //txtDebmax.Text = Convert.ToString(saldo.creditoMax);
                //txtSaldoActual.Text = Convert.ToString(saldo.saldoActual);


                //Contacto
                DomicilioB.CargarTXT(txtDomicilio, txtidprov, 2);
                EmailB.CargarTXT(txtEmail, txtidprov, 2);
                TelefonoB.CargarTXT(txtTel, txtidprov, 2);

                tabProveedor.Controls.Remove(tabListado);
                tabProveedor.Controls.Add(tabInformacion);
                tabProveedor.Controls.Add(tabAdicional);
                tabProveedor.Controls.Add(tabMovimientos);
                tabProveedor.Controls.Add(tabPedido);               
                
                tabProveedor.SelectedTab = tabInformacion;

            }
        }

      
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

       

        private void clean()
        {

            txtRazonSocial.Text = "";
            txtcuit.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            txtidprov.Text = "";
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
                frm.tabUpdateTXT = 2;
                frm.Show(this);
                frm.cbRolALL.SelectedValue = 2;
                frm.lblTitleEmail.Text = txtidprov.Text + " - " + txtRazonSocial.Text;
                frm.lblTitleDom.Text = txtidprov.Text + " - " + txtRazonSocial.Text;
                frm.lblTitleTel.Text = txtidprov.Text + " - " + txtRazonSocial.Text;
                //frm.lblTitleEmail.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                //frm.lblTitleDom.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                //frm.lblTitleTel.Text = ProveedorB.BuscarNombreProveedor(proveedor.idProveedor);
                //frm.txtNombreEmail.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                //frm.txtNombreDom.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
                //frm.txtNombreTel.Text = txtRazonSocial.Text + " - " + txtidprov.Text;
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
           
        //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
        //{
        //    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    e.Handled = true;
        //    return;

        //}
        
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
        private void cbIVA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvRubro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            CheckColor();   
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            formCompras frm = new formCompras();
            frm.Show();


            //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.
            proveedor.idProveedor = Convert.ToInt32(txtidprov.Text);
            ProveedorB.BuscarIdProv(proveedor);
            frm.txtIDproveedor.Text = Convert.ToString(proveedor.idProveedor);
            frm.txtNameProveedor.Text = proveedor.razsocial;
            frm.txtCuil.Text = proveedor.cuit;
            frm.txtCondicionIva.Text = proveedor.condicioniva;

            frm.txtDomicilio.Text = DomicilioB.CargarTXTSTRING(txtidprov, 2);

            TelefonoB.CargarTXT(frm.txtTel, frm.txtIDproveedor, 2);
        }

        private void ChangeCheck()
        {
            dgvMovimientos.DataSource = "";

            if (txtidprov.Text != string.Empty)
            {
                int proveedor = Convert.ToInt32(txtidprov.Text);

                if (rbNoPagas.Checked == true)
                {
                    ComprasB.SearchPendientes(proveedor, dgvMovimientos);
                }
                else if (rbPagas.Checked == true)
                {
                    ComprasB.SearchPagas(proveedor, dgvMovimientos);
                }
                else if (rbAnuladas.Checked == true)
                {
                    //FacturaB.SearchAnuladas(proveedor, dgvMovimientos);
                }
            }
        }

        private void rbPagas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPagas.Checked == true)
                ChangeCheck(); 
        }

        private void rbNoPagas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoPagas.Checked == true)
                ChangeCheck(); 
        }

        }
 }

