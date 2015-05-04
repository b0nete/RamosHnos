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


namespace RamosHnos
{
    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();

            ClienteB.CargarTipoDoc(cbTipoDoc);

            //connectDB db = new connectDB();
            //db.Conectar();
            //dgvListado.DataSource = null;
            //db.LlenarDGVDoc();
            //dgvListado.DataSource = db.ds.Tables["tipodocumento"].DefaultView;
        }
        



        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void formCliente_Load(object sender, EventArgs e)
        {

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
            formDomicilio frmdom = new formDomicilio();
            frmdom.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            formTelefono frmtel = new formTelefono();
            frmtel.Show();

            frmtel.txtIDcliente.Text = txtIDcliente.Text;
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
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }
    }
}

