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
    public partial class formTipoTel : Form
    {
        public formTipoTel()
        {
            InitializeComponent();
        }

        private void formTipoTel_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TipoTelEntity tipotel = new TipoTelEntity()
            {
                tipoTel = txtTipoTel.Text,
                estado = cbTipoTel.Checked
            };

            TelefonoB.InsertTipoTel(tipotel);
            TelefonoB.LlenarDGV(dgvTipoTel);            
        }
    }
}
