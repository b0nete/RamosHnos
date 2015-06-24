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
    public partial class formTipoProducto : Form
    {
        public formTipoProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            TipoProductoEntity tipoProducto = new TipoProductoEntity()
            {
                //tipoProducto = txtTipoProd.Text,
                //estado = cbEstado.Checked,               
            };

            TipoProductoB.InsertTipoProducto(tipoProducto);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TipoProductoEntity tproducto = new TipoProductoEntity()
            {
                tipoProducto = txtTipoProducto.Text,
                estado = cbEstado.Checked
            };

            ProductoB.InsertTipoProducto(tproducto);
            ProductoB.MostrarTipoProducto(dgvTipoProducto);
        }
    }
}
