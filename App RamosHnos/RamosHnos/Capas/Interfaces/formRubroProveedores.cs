﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamosHnos.Capas.Interfaces
{
    public partial class formRubroProveedores : Form
    {
        public formRubroProveedores()
        {
            InitializeComponent();
        }

        private void formRubroProveedores_Load(object sender, EventArgs e)
        {
            formRubro frm = new formRubro();
            frm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            formRubro frm = new formRubro();
            frm.Show();
        }
    }
}
