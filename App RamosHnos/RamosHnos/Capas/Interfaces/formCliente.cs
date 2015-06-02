using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Negocio;
using RamosHnos.Capas.Interfaces;
using RamosHnos.Libs;


namespace RamosHnos
{
    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();  
        }
        



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void formCliente_Load(object sender, EventArgs e)
        {
            TipoDocB.CargarTipoDoc(cbTipoDoc);

            DataTable dt = TipoDocB.ExisteTipoDoc();
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Cargue los Documentos a Utilizar");
                formDoc frm = new formDoc();
                frm.Show();
                this.Close();
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoDni_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtcuil_TextChanged(object sender, EventArgs e)
        {

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
                frmdom.txtIDCliente.Text = txtIDcliente.Text;
                frmdom.txtNombre.Text = txtNombre.Text + ' ' + txtApellido.Text + ' ' + '-' + ' ' + txtIDcliente.Text;   
                frmdom.Show();                                
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
                frmtel.txtIDcliente.Text = txtIDcliente.Text;
                frmtel.txtNombre.Text = txtNombre.Text + ' ' + txtApellido.Text +' '+'-'+' '+ txtIDcliente.Text;            
                frmtel.Show();               
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIDcliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteEntity cliente = new ClienteEntity()
            {
                tipoDoc = Convert.ToInt32(cbTipoDoc.SelectedValue),
                numDoc = txtnumDoc.Text,
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                cuil = txtcuil.Text,
                email = txtEmail.Text                
            };


            ClienteB.InsertCliente(cliente);

            int idCli = cliente.idCliente;
            txtIDcliente.Text = Convert.ToString(idCli);

            Libs.ClearControlsLibs.ClearAll(this, gbCliente);
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

            ClienteEntity cliente = new ClienteEntity()
            {
                idCliente = Convert.ToInt32(txtIDcliente.Text),
                tipoDoc = Convert.ToInt32(cbTipoDoc.SelectedValue),
                numDoc = txtnumDoc.Text,
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                cuil = txtcuil.Text,
                email = txtEmail.Text
            };

            ClienteB.EditCliente(cliente);
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
            txtnumDoc.Text = cliente.numDoc;
            txtNombre.Text = cliente.nombre;
            txtApellido.Text = cliente.apellido;
            txtcuil.Text = cliente.cuil;
            txtEmail.Text = cliente.email;

            //txtIDcliente.Enabled = false;
            //cbTipoDoc.Enabled = false;
            //txtnumDoc.Enabled = false;
            //txtNombre.Enabled = false;
            //txtApellido.Enabled = false;
            //txtcuil.Enabled = false;
            //txtEmail.Enabled = false;
        }        
    }
}

