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

namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listVentas : Form
    {
        public listVentas()
        {
            InitializeComponent();
        }

        private void listVentas_Load(object sender, EventArgs e)
        {
            FacturaB.ListFacturas(dgvVentas);
            dgvVentas.AutoGenerateColumns = false;
        }
    }
}
