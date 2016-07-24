using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        // Eventos

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
                return;
            else
            {

                CargarUsuario();

                if (UsuarioB.VerificarUsuario(usuario) == true)
                {
                    OpenMain();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos!");
                }                
            }                    
        }

        // Metodos

        private bool ValidarCampos()
        {
            if (txtUsuario.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Campos necesarios incompletos!");
                return true;
            }
            else
                return false;
        }

        private void OpenMain()
        {
            formMain frm = new formMain();
            frm.usr = usuario.numDoc + " - " + usuario.apellido + "," + usuario.nombre;
            frm.Show();
        }



        // Entidades

        UsuarioEntity usuario = new UsuarioEntity();
        
        private void CargarUsuario()
        {
            usuario.apellido = UsuarioB.BuscarNomUsuario(Convert.ToInt32(usuario.numDoc));
            usuario.numDoc = txtUsuario.Text;
            usuario.password = txtPassword.Text;
        }


    }
}
