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
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formUsuario : Form
    {
        public formUsuario()
        {
            InitializeComponent();
        }

        // Eventos

        private void formUsuario_Load(object sender, EventArgs e)
        {
            PrivilegiosB.CargarCB(cbPrivilegios);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CargarUsuario();
            UsuarioB.InsertUsuario(usuario);
        }

        // Metodos

        // Entidades

        UsuarioEntity usuario = new UsuarioEntity();
        public void CargarUsuario()
        {
            usuario.privilegios = Convert.ToInt32(cbPrivilegios.SelectedValue);
            usuario.numDoc = txtDNI.Text;
            usuario.apellido = txtApellido.Text;
            usuario.nombre = txtNombre.Text;
            usuario.fechaNacimiento = dtpNacimiento.Value;
            usuario.password = txtPassword.Text;
            usuario.email = txtEmail.Text;
            usuario.estado = cbEstado.Checked;
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            txtIDusuario.Text = txtDNI.Text;
        }
    }
}
