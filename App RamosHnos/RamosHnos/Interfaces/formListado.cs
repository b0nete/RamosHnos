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
    public partial class formListado : Form
    {
        public formListado()
        {
            InitializeComponent();
        }

        private void formListado_Load(object sender, EventArgs e)
        {
            connectDB db = new connectDB();
            db.Conectar();
            dgvListado.DataSource = null;
            db.LlenarDGVDoc();
            dgvListado.DataSource = db.ds.Tables["tipodocumento"].DefaultView;
        }

        
    }
}
