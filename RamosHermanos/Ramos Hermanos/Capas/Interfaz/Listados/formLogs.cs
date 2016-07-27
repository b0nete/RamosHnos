using System;
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
    public partial class formLogs : Form
    {
        public formLogs()
        {
            InitializeComponent();
        }

        private void formLogs_Load(object sender, EventArgs e)
        {
            dgvLogs.AutoGenerateColumns = false;
            LogB.CargarDGV(dgvLogs);
            
        }
    }
}
