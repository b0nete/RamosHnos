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

namespace RamosHnos.Capas.Interfaces
{
    public partial class formUsuario : Form
    {
        public formUsuario()
        {
            InitializeComponent();
        }

        private void formRegistrarCargo_Load(object sender, EventArgs e)
        {
            TipoDocB.CargarTipoDoc(cbTipoDoc);
            RolB.MostrarRolesCB(cbRol);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            formDoc frm= new formDoc();
            frm.Show();
                       
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formRol frm = new formRol();
            frm.Show();
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UsuarioEntity usuario = new UsuarioEntity()
            {
                numDoc = txtnumDoc.Text,
                cuil = txtcuil.Text,
                apellido = txtApellido.Text,
                nombre = txtNombre.Text,
                email = txtEmail.Text,
                tipoDoc = Convert.ToInt32(cbTipoDoc.SelectedValue),
                rol = Convert.ToInt32(cbRol.SelectedValue)
            };
            
            UsuarioB.InsertUsuario(usuario);
            txtIdUsuario.Text = Convert.ToString(usuario.idUsuario);
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioEntity usuario = new UsuarioEntity
            {
                numDoc = txtnumDoc.Text
            };

            string pedro = txtnumDoc.Text;

            UsuarioB.SearchUsuario(usuario);

            txtNombre.Text = usuario.nombre;
            txtApellido.Text = usuario.apellido;
            txtcuil.Text = usuario.cuil;
            txtEmail.Text = usuario.email;
        }
    }
}
