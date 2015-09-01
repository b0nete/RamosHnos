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
            ProductoB.CargarDGV(dgvProducto);
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
            if (ValidarCampos() == true)
            {
                return;
            }
            else
            {
                CargarProducto(); // Cargamos la Entidad.

                if (ProductoB.ExisteProductoID(producto) == true) // Verificamos si el ID del producto Existe.
                {
                    return;
                }
                else if (ProductoB.ExisteProducto(producto) == true) // Verificamos si los datos coinciden con los de otro producto.
                {
                    return;
                }
                else
                {
                    ProductoB.InsertProducto(producto, txtIDProd);

                    CargarPrecio(txtIDProd);
                    PrecioB.InsertPrecio(precio);

                    ProductoB.CargarDGV(dgvProducto);
                }
            }
        }

        private void cbMarca_DropDown(object sender, EventArgs e)
        {
            MarcaB.CargarCB(cbMarca);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CargarProducto();
            ProductoB.UpdateProducto(producto);

            precio.producto = Convert.ToInt32(txtIDProd.Text); //Asignamos el ID del producto para desabilitar los precios anteriores.
            PrecioB.DisablePrecio(precio);//Método para desabilitar los precios.
            CargarPrecio(txtIDProd); //Cargamos los atributos de la entidad para pasarlos al método que realiza la carga en la DB.
            PrecioB.InsertPrecio(precio); //Método para cargar pasar los datos de la entidad a la DB.

            ProductoB.CargarDGV(dgvProducto);
        }

        private void dgvProducto_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducto_DoubleClick_1(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvProducto.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                producto.idProducto = Convert.ToInt32(row.Cells["colIDProducto"].Value.ToString());

                ProductoB.BuscarProducto(producto);
                txtIDProd.Text = Convert.ToString(producto.idProducto);
                dtpFechaAlta.Value = Convert.ToDateTime(producto.fechaAlta);
                cbTipoProducto.SelectedValue = producto.tipoProducto;
                cbMarca.SelectedValue = producto.marca;
                txtProducto.Text = producto.producto;
                txtDescripcion.Text = producto.descripcion;
                txtCantidad.Text = Convert.ToString(producto.cantidad);
                cbMedida.SelectedValue = producto.medida;
                txtStockMin.Text = Convert.ToString(producto.stockMin);
                txtStockActual.Text = Convert.ToString(producto.stockActual);

                precio.producto = producto.idProducto;
                PrecioB.BuscarPrecio(precio);
                txtPrecioActual.Text = Convert.ToString(precio.precio);
                txtFechaActualizacion.Text = Convert.ToString(precio.fechaActualizacion);

                tabProducto.SelectedTab = tabInformacion;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clean();
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

        private bool ValidarCampos()
        {
            if (cbTipoProducto.SelectedValue == null || cbMarca.SelectedValue == null || txtProducto.Text == string.Empty || txtCantidad.Text == string.Empty || cbMedida.SelectedValue == null || txtStockMin.Text == string.Empty || txtPrecioActual.Text == string.Empty)
            {
                MessageBox.Show("Campos necesarios incompletos!");
                return true;
            }
            else
                return false;
        }

        private void Clean()
        {
            txtIDProd.Text = "";
            cbTipoProducto.SelectedIndex = 0;
            cbMarca.SelectedIndex = 0;
            txtProducto.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            cbMedida.SelectedIndex = 0;
            txtStockMin.Text = "";
            txtPrecioActual.Text = "";
            txtFechaActualizacion.Text = "";
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
            precio.precio = Convert.ToDouble(txtPrecioActual.Text);
        }

        


        
    }
}


