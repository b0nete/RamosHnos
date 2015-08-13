using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;
using System.Windows;
using System.Windows.Media;
using System.Globalization;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formtipoCliente : Form
    {     
        public formtipoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
        }


        private void formtCliente_Load(object sender, EventArgs e)
        {
            tipoClienteB.ListadoDGV(dgvtipoCliente);
        }

        // Metodos del FORM.

        tipoClienteEntity tcliente = new tipoClienteEntity();

        private void CargartCliente()
        {
            tcliente.tipoCliente = txttCliente.Text;
            tcliente.descripcion = txtDescripcion.Text;
            tcliente.porcDescuento = Convert.ToInt32(txtDescuento.Text);
            tcliente.color = Convert.ToString(btnColor.BackColor);
            tcliente.estado = cbEstado.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CargartCliente();
            tipoClienteB.InserttCliente(tcliente);
        }
    }
}
