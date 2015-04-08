using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using connectTest;

namespace RamosHnos
{
    public partial class formCliente : Form
    {
        public formCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connectDB db = new connectDB();
                db.Conectar();
                db.insertCliente(txtnumDoc.Text);
                db.Desconectar();
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
    }
}
