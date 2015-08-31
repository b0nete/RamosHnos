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
            MedidaB.CargarCB(cbMedida);

            CheckColor();
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            CheckColor();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formMarca frm = new formMarca();
            frm.Show();
        }

        private void txtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && ch == 46 && txtCantidad.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && ch == 46 && txtPrecioActual.Text.IndexOf(',') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 46)
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CargarProducto();
            ProductoB.InsertProducto(producto, txtIDProd);

            CargarPrecio(txtIDProd);
            PrecioB.InsertPrecio(precio);
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

        // Entidades

        ProductoEntity producto = new ProductoEntity();
        private void CargarProducto()
        {
            producto.fechaAlta = dtpFechaAlta.Value;
            producto.tipoProducto = Convert.ToInt32(cbTipoProducto.SelectedValue);
            producto.marca = Convert.ToInt32(cbMarca.SelectedValue);
            producto.producto = txtProducto.Text;
            producto.descripcion = txtDescripcion.Text;
            producto.cantidad = Convert.ToDouble(txtCantidad.Text);
            producto.medida = Convert.ToInt32(cbMedida.SelectedValue);
            producto.stockMin = Convert.ToInt32(txtStockMin.Text);
            producto.estado = cbEstado.Checked;
        }

        PrecioEntity precio = new PrecioEntity();
        private void CargarPrecio(TextBox txt)
        {
            precio.producto = Convert.ToInt32(txt.Text);
            precio.fechaActualizacion = dtpFechaAct.Value;
            precio.precio = Convert.ToDouble(txtPrecioActual.Text);
        }

        private void cbMarca_DropDown(object sender, EventArgs e)
        {
            MarcaB.CargarCB(cbMarca);
        }
    }    
}


