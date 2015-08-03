using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHnos.Capas.Negocio;
using RamosHnos.Capas.Entidades;
using RamosHnos.Libs;

namespace RamosHnos.Capas.Interfaces
{
    public partial class UCCliente : UserControl
    {
        string sexoString;

        public UCCliente()
        {
            InitializeComponent();
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void UCCliente_Load(object sender, EventArgs e)
        {
            TipoDocB.CargarTipoDoc(cbTipoDoc);

            DataTable dt = TipoDocB.ExisteTipoDoc();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Cargue los Documentos a Utilizar");
                formDoc frm = new formDoc();
                frm.Show();
            }

            // RadioButton.
            rbMas.Checked = true;

            txtcuil.Mask = @"2\0-########-#";

            if (rbMas.Checked == true)
            {
                sexoString = "M";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (txtIDcliente.Text == "")
            {
                MessageBox.Show("Asigne el cliente a cargar un Domicilio");
            }
            else
            {
                formDomicilio frmdom = new formDomicilio();
                frmdom.txtID.Text = txtIDcliente.Text;
                frmdom.txtNombre.Text = txtNombre.Text + ' ' + txtApellido.Text + ' ' + '-' + ' ' + txtIDcliente.Text;
                frmdom.Show();

                //Cargar Cliente
                string persona = txtIDcliente.Text;
                ClienteB.CargarDomicilioCliente(frmdom.dgvDomicilio, persona);

                if (frmdom.dgvDomicilio.ColumnCount == 0)
                {
                    return;
                }
                else
                {
                    frmdom.dgvDomicilio.Columns["idProvincia"].Visible = false;
                    frmdom.dgvDomicilio.Columns["idLocalidad"].Visible = false;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtIDcliente.Text == "")
            {
                MessageBox.Show("Asigne el cliente a cargar un Teléfono");
            }
            else
            {
                formTelefono frmtel = new formTelefono();
                frmtel.txtID.Text = txtIDcliente.Text;
                frmtel.txtNombre.Text = txtNombre.Text + ' ' + txtApellido.Text + ' ' + '-' + ' ' + txtIDcliente.Text;

                frmtel.Show();

                //string telefono = txtIDcliente.Text;
                //TelefonoB.MostrarTelefono(frmtel.dgvTelefonos, telefono);

                //Seleccionar Cliente de CB.
                frmtel.cbRoles.SelectedIndex = 0;
                int rol = Convert.ToInt32(frmtel.cbRoles.SelectedValue);
                string telefono = frmtel.txtID.Text;
                TelefonoB.MostrarTelefono(frmtel.dgvTelefonos, rol, telefono);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Validación de Campos.   
            if (txtnumDoc.Text == string.Empty || txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtcuil.MaskFull == false)
            {
                MessageBox.Show("Datos necesarios incompletos.");
                return;
            }
            else
            {
                ClienteEntity cliente = new ClienteEntity()
                {
                    tipoDoc = Convert.ToInt32(cbTipoDoc.SelectedValue),
                    numDoc = txtnumDoc.Text,
                    sexo = sexoString,
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    cuil = txtcuil.Text,
                    email = txtEmail.Text,
                    estado = cbEstado.Checked
                };


                if (ClienteB.ExisteCliente(cliente) == true)
                {
                    DialogResult result = MessageBox.Show("El cliente existe, desea actualizarlo con los datos ingresados?", "Cliente existente", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        ClienteB.UpdateCliente(cliente);
                    }
                    else
                    {
                        return;
                    }
                }
                else if (ClienteB.ExisteCliente(cliente) == false)
                {
                    ClienteB.InsertCliente(cliente);
                }
                txtIDcliente.Text = Convert.ToString(cliente.idCliente);

                //Libs.ClearControlsLibs.ClearAll(this, gbCliente);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            formDoc frm = new formDoc();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //cbTipoDoc.Enabled = true;
            //txtnumDoc.Enabled = true;
            //txtNombre.Enabled = true;
            //txtApellido.Enabled = true;
            //txtcuil.Enabled = true;
            //txtEmail.Enabled = true;

            if (txtnumDoc.Text == string.Empty || txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtcuil.MaskFull == false)
            {
                MessageBox.Show("Datos necesarios incompletos.");
                return;
            }
            else
            {
                ClienteEntity cliente = new ClienteEntity()
                {
                    idCliente = Convert.ToInt32(txtIDcliente.Text),
                    tipoDoc = Convert.ToInt32(cbTipoDoc.SelectedValue),
                    numDoc = txtnumDoc.Text,
                    sexo = sexoString,
                    nombre = txtNombre.Text,
                    apellido = txtApellido.Text,
                    cuil = txtcuil.Text,
                    email = txtEmail.Text,
                    estado = cbEstado.Checked
                };

                ClienteB.UpdateCliente(cliente);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txtinDNI = "";
            txtinDNI = txtnumDoc.Text;

            if (txtnumDoc.Text == "")
            {
                DialogResult result = InputBoxLib.InputBox("Ingrese DNI", "DNI", ref txtinDNI);
                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            ClienteEntity cliente = new ClienteEntity
            {
                numDoc = txtinDNI
            };

            ClienteB.BuscarCliente(cliente);

            txtIDcliente.Text = Convert.ToString(cliente.idCliente);
            cbTipoDoc.SelectedValue = cliente.tipoDoc;
            txtnumDoc.Text = cliente.numDoc;

            if (cliente.sexo == "M")
                rbMas.Checked = true;
            else
                rbFem.Checked = true;

            txtNombre.Text = cliente.nombre;
            txtApellido.Text = cliente.apellido;
            txtcuil.Text = cliente.cuil;
            txtEmail.Text = cliente.email;
            cbEstado.Checked = cliente.estado;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            formDoc frm = new formDoc();
            frm.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtnumDoc.Text == string.Empty)
            {
                MessageBox.Show("Ingrese Numero de Documento del Cliente a Eliminar");
                return;
            }
            else
            {
                ClienteEntity cliente = new ClienteEntity()
                {
                    idCliente = Convert.ToInt32(txtIDcliente.Text)
                };

                ClienteB.DisableCliente(cliente, cbEstado);
            }
        }

        private void txtcuil_MaskChanged(object sender, EventArgs e)
        {

        }

        private void txtcuil_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            //if (rbMas.Checked == true)
            //{
            //    txtcuil.Text = "20-########-#";
            //}
            //else if (rbFem.Checked == true)
            //{
            //    txtcuil.Text = "23-########-#";
            //}
        }

        private void rbMas_CheckedChanged(object sender, EventArgs e)
        {
            txtcuil.Mask = @"2\0-########-#";

            if (rbMas.Checked == true)
            {
                sexoString = "M";
            }
        }

        private void rbFem_CheckedChanged(object sender, EventArgs e)
        {
            txtcuil.Mask = @"23-########-#";

            if (rbFem.Checked == true)
            {
                sexoString = "F";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formListado frm = new formListado();
            frm.Show();

            ClienteB.ListarClientes(frm.dgvListado);
        }

        private void cbTipoDoc_DropDown(object sender, EventArgs e)
        {
            TipoDocB.CargarTipoDoc(cbTipoDoc);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {

        }
    }
}
