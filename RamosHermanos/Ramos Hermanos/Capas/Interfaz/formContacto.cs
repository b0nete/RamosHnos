using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formContacto : Form
    {
        public int tabVar;

        public formContacto()
        {
            InitializeComponent();
        }

        private void formContacto_Load(object sender, EventArgs e)
        {
            switch (tabVar)
            {
                case 0:
                    tabContacto.SelectedTab = tabDomicilios;
                    break;
                case 1:
                    tabContacto.SelectedTab = tabTelefonos;
                    break;
                case 2:
                    tabContacto.SelectedTab = tabEmails;
                    break;
            }
            
        }
    }
}
