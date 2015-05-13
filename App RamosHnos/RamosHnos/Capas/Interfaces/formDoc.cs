using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Negocio;

namespace RamosHnos.Capas.Interfaces
{
    public partial class formDoc : Form
    {
        public formDoc()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipoDocEntity tipodoc = new TipoDocEntity()
            {
                tipoDoc = txtTipoDoc.Text
            };

            TipoDocB.InsertTipoDoc(tipodoc);
            TipoDocB.LlenarDGV(dgvTipoDoc);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTipoDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void formDoc_Load(object sender, EventArgs e)
        {
            TipoDocB.LlenarDGV(dgvTipoDoc);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            formCliente frm = new formCliente();
            frm.Show();

            this.Close();
        }


    }
}
