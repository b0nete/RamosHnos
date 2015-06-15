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
    public partial class formRol : Form
    {
        public formRol()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            RolEntity rol = new RolEntity()
            {
                rol = txtRol.Text,
                estado = cbEstado.Checked
            };

            RolB.InsertRol(rol);
        }

        private void formRol_Load(object sender, EventArgs e)
        {            
            RolB.MostrarRolesDGV(dgvRoles);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
