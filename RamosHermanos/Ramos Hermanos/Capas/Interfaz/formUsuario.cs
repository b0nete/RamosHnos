﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHermanos.Capas.Negocio;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formUsuario : Form
    {
        public formUsuario()
        {
            InitializeComponent();
        }

        private void formUsuario_Load(object sender, EventArgs e)
        {
            PrivilegiosB.CargarCB(cbPrivilegios);
        }
    }
}
