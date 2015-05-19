using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHnos.Capas.Negocio;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Interfaces;

namespace RamosHnos
{
    public partial class formDomicilio : Form
    {
        public formDomicilio()
        {
            InitializeComponent();
        }

        private void formDomicilio_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formProvincia frm = new formProvincia();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
