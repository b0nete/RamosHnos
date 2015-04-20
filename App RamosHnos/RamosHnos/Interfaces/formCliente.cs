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
using connectDB;


namespace RamosHnos
{
    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();

            Cliente cli = new Cliente();
            cli.cargarTipoDoc(cbTipoDoc);
            //Cliente cli = new Cliente();
            //cli.cargarTipoDoc(cbTipoDoc);


            //connectDB db = new connectDB();
            //db.Conectar();
            //dgvListado.DataSource = null;
            //db.LlenarDGVDoc();
            //dgvListado.DataSource = db.ds.Tables["tipodocumento"].DefaultView;



        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente newcliente = new Cliente();
                newcliente._tipoDoc = Convert.ToInt32(cbTipoDoc.SelectedValue);
                newcliente._numDoc = txtnumDoc.Text;
                newcliente._nombre = txtNombre.Text;
                newcliente._apellido = txtApellido.Text;
                newcliente._cuil = txtcuil.Text;
                newcliente._email = txtEmail.Text;
               
                newcliente.CnxDB();
                newcliente.insertCliente(newcliente._tipoDoc, newcliente._numDoc, newcliente._nombre, newcliente._apellido, newcliente._cuil, newcliente._email);
                newcliente.DcnxDB();
                this.Close();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
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
    }
}
