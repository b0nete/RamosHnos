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

        private void txtCreditoMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            formContacto frm = new formContacto();
            frm.tabVar = 3;
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formContacto frm = new formContacto();
            frm.tabVar = 1;
            frm.Show();

        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            formContacto frm = new formContacto();
            frm.tabVar = 2;
            frm.Show();
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Validación de Campos.           

            if (VerificarCampos() == false)
            {
                return;
            }
            else
            {
                 ClienteEntity cliente = new ClienteEntity()
                 {
                     //idCliente = Convert.ToInt32(txtIDcliente.Text),
                     //rol = 1,
                     fechaAlta = dtpFechaAlta.Value,
                     tipoDoc = Convert.ToInt32(cbTipoDoc.SelectedValue),
                     numDoc = txtnumDoc.Text,
                     sexo = cbSexo.Text,
                     cuil = txtCUIL.Text,
                     apellido = txtApellido.Text,
                     nombre = txtNombre.Text,
                     estadoCivil = cbEstadoCivil.Text,
                     condicionIVA = cbIVA.Text,
                     tipoCliente = Convert.ToInt32(cbTipoCliente.SelectedValue),
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
            }
        }

        // -------------------------------------//

        // Metodos del FORM.

        public void CargaInicial()
        {
            TipoDocB.CargarTipoDoc(cbTipoDoc);

            //Valores Iniciales
            cbSexo.SelectedIndex = 0;
            cbEstadoCivil.SelectedIndex = 0;
            cbIVA.SelectedIndex = 4;
        }

        //public ClienteEntity cliente = new ClienteEntity()
        //{
        //    idCliente = Convert.ToInt32(txtIDcliente.Text),
        //    rol = '1',
        //    fechaAlta = dtpFechaAlta.Value,
        //    tipoDoc = Convert.ToInt32(cbTipoDoc.SelectedValue),
        //    numDoc = txtnumDoc.Text,
        //    sexo = cbSexo.SelectedText,
        //    cuil = txtCUIL.Text,
        //    apellido = txtApellido.Text,
        //    nombre = txtNombre.Text,
        //    estadoCivil = cbEstadoCivil.SelectedText,
        //    tipoCliente = Convert.ToInt32(cbTipoCliente.SelectedValue),
        //    estado = cbEstado.Checked
        //};
        
            

        public bool VerificarCampos()
        {
            if (txtnumDoc.Text == string.Empty || txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtCUIL.MaskFull == false)
            {
                MessageBox.Show("Datos necesarios incompletos.");
                return false;
            }
            return true;
        }



    }
}




        


