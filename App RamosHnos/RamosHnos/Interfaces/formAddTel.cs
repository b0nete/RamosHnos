using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace RamosHnos
{
    public partial class formAddTel : Form
    {
        public formAddTel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente db = new Cliente();
            db.CnxDB();            
        }
    }
}
