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

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formProducto : Form
    {
        public formProducto()
        {
            InitializeComponent();
        }

        //Eventos

        private void formProducto_Load(object sender, EventArgs e)
        {
            //Cargas iniciales de CB
            tipoProductoB.CargarCB(cbTipoProducto);
            MarcaB.CargarCB(cbMarca);
            
            CheckColor();
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            CheckColor(); 
        }

        // Metodos

        private void CheckColor() //Cambia Label y Color de acuerdo a el estado Checked.
        {
            if (cbEstado.Checked == true)
            {
                lblEstado.BackColor = Color.Green;
                lblEstado.Text = "Habilitado";
            }
            else
            {
                lblEstado.BackColor = Color.Red;
                lblEstado.Text = "Desabilitado";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formMarca frm = new formMarca();
            frm.Show();
        }

        

    }
}
