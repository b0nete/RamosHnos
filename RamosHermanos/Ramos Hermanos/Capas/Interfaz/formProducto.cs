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
using RamosHermanos.Capas.Interfaz.Listados;
using RamosHermanos.Capas.Interfaz.ABMs;
using RamosHermanos.Capas.Interfaz.Contratos;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formProducto : Form, IAddItem
    {
        public formProducto()
        {
            InitializeComponent();
        }

        //Eventos

        
        private void formProducto_Load(object sender, EventArgs e)
        {
            tipoProductoB.CargarCB(cbRubro);
            MarcaB.CargarCB(cbMarca);
            MedidaB.CargarCB(cbMedida);

            CheckColor();

            ProductoB.CargarRubros(cbRubro);
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
                    ProductoB.UpdateProducto(producto);
                    return;
                }
                else
                {
                    ProductoB.InsertProducto(producto, txtIDProd);
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
                       
        }

        private void dgvProducto_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            if (cbRubro.SelectedValue == null || cbMarca.SelectedValue == null || txtProducto.Text == string.Empty || txtCantidad.Text == string.Empty || cbMedida.SelectedValue == null)
            {
                MessageBox.Show("Campos necesarios incompletos!");
                return true;
            }
            else
                return false;
        }

        private void Clean()
        {
            producto.idProducto = Convert.ToInt32(null);
            cbEstado.Checked = true;
            txtIDProd.Text = "";
            cbRubro.SelectedIndex = 0;
            cbMarca.SelectedIndex = 0;
            txtProducto.Text = "";
            txtDescripcion.Text = "";
            txtCantidad.Text = "";
            cbMedida.SelectedIndex = 0;
            
        }

        // Entidades

        ProductoEntity producto = new ProductoEntity();
        private void CargarProducto()
        {
            producto.fechaAlta = dtpFechaAlta.Value;

            if (cbSubRubro2.SelectedValue != null)
                producto.tipoProducto = Convert.ToInt32(cbSubRubro2.SelectedValue);
            else if (cbSubRubro1.SelectedValue != null)
                producto.tipoProducto = Convert.ToInt32(cbSubRubro1.SelectedValue);
            else if (cbRubro.SelectedValue != null)
                producto.tipoProducto = Convert.ToInt32(cbRubro.SelectedValue);
            else
                MessageBox.Show("Rubro no asignado");           

            producto.marca = Convert.ToInt32(cbMarca.SelectedValue);
            producto.producto = txtProducto.Text;
            producto.descripcion = txtDescripcion.Text;
            producto.cantidad = Convert.ToDouble(txtCantidad.Text);
            producto.medida = Convert.ToInt32(cbMedida.SelectedValue);
            //producto.precio = Convert.ToDouble(txtPrecioActual.Text);
            producto.estado = cbEstado.Checked;
        }

       
        private void cbMedida_DropDown(object sender, EventArgs e)
        {
            MedidaB.CargarCB(cbMedida);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            formStock frm = new formStock();
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            formBuscarProducto frm = new formBuscarProducto();
            frm.Show();
            Close();
        }

        private void tabListado_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listProductos frm = new listProductos();
            frm.Show();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            listProductos frm = new listProductos();
            frm.Show();
        }

        private void cbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 
        }

        private void cbSubRubro1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RubroB.CargarSubRubro2(cbSubRubro1, lblSubRubro2, cbSubRubro2);
        }

        private void cbRubro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RubroB.CargarSubRubro1(cbRubro, lblSubRubro1, lblSubRubro2, cbSubRubro1, cbSubRubro2);
        }

        private void button9_Click(object sender, EventArgs e)
        
        {
            if (txtnewPrecio.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un precio");
            }
            else
            {
                //Desabilitamos todos los precios anteriores del mismo producto.
                int idProducto = Convert.ToInt32(txtIDProd.Text);
                PrecioProductosB.DisablePrecio(idProducto);

                //Insertamos el nuevo precio.
                precio.producto = Convert.ToInt32(txtIDProd.Text);
                precio.precio = Convert.ToDecimal(txtnewPrecio.Text);
                PrecioProductosB.InsertPrecio(precio);

                //Actualizamos DGV
                PrecioProductosB.UltimoPrecioDGV(dgvPrecios, txtIDProd);
            }
        }

       // Entidades
        PrecioProductoEntity precio = new PrecioProductoEntity();

        private void txtnewPrecio_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            // Primero verificamos si el valor se puede convertir a Decimal.
            //
            decimal numero = default(decimal);
            bool bln = decimal.TryParse(tb.Text, out numero);

            if ((!(bln)))
            {
                // No es un valor decimal válido; limpiamos el control.
                tb.Clear();
                return;
            }

            // En la propiedad Tag guardamos el valor con todos los decimales.
            //
            tb.Tag = numero;

            // Y acto seguido formateamos el valor
            // a monetario con dos decimales.
            //
            tb.Text = string.Format("{0:N}", numero);


        }

        private void txtnewPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //decimal importe = 0;
            //if (txtnewPrecio.Text.Contains(".")) // si tiene un punto la caja de texto, usa configuracion regional
            //{
            //    importe = Convert.ToDecimal(txtnewPrecio.Text, System.Globalization.CultureInfo.InvariantCulture);

            //}
            //else // aca quiere decir que puso una coma y lo reemplaza por un punto
            //{

            //    string coma = txtnewPrecio.Text;
            //    coma.Replace(',', '.');
            //    importe = Convert.ToDecimal(coma);
            //}
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CargarStock();
            StockProductoB.InsertStock(stock);
        }

        // Entidades
        StockProductoEntity stock = new StockProductoEntity();
        private void CargarStock()
        {
            stock.idProducto = Convert.ToInt32(txtIDProd.Text);
            stock.stockMinimo = Convert.ToInt32(txtStockMin.Text);
            stock.stockMaximo = Convert.ToInt32(txtStockMax.Text);
            stock.fechaActualizacion = Convert.ToDateTime(dtpfechaStock.Value);
        }

        private void txtnewPrecio_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtnewPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            {
                //char ch = e.KeyChar;

                //if (ch == 44 && ch == 46 && txtnewPrecio.Text.IndexOf('.') != -1)
                //{
                //    e.Handled = true;
                //    return;
                //}

                //if (!Char.IsDigit(ch) && ch != 8 && ch != 44 && ch != 46)
                //{
                //    e.Handled = true;
                //}

                //if (e.KeyChar == ',')
                //{
                //    e.KeyChar = '.';
                //}

                //MessageBox.Show(Convert.ToInt16(e.KeyChar).ToString());

                if (e.KeyChar == 8)
                {
                    e.Handled = false;
                    return;
                }


                bool IsDec = false;
                int nroDec = 0;

                for (int i = 0; i < txtnewPrecio.Text.Length; i++)
                {
                    if (txtnewPrecio.Text[i] == ',')
                        IsDec = true;

                    if (IsDec && nroDec++ >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                    
                }
                if (e.KeyChar >= 48 && e.KeyChar <= 57 && e.KeyChar> 2)
                    e.Handled = false;
                else if (e.KeyChar == 44)
                    e.Handled = (IsDec) ? true : false;
                else
                    e.Handled = true;

            }
            
        }

        private void formProducto_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void dtpfechaFactura_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void AddNewItem(DataGridViewRow row)
        {
            string idinsumo = row.Cells["colIDInsumo"].Value.ToString();
            string insumo = row.Cells["colInsumo"].Value.ToString();
            string idMedida = row.Cells["colIDMedida"].Value.ToString();
            string medida = row.Cells["colMedida"].Value.ToString();

            this.dgvConformacion.Rows.Add(new[] { idinsumo, insumo, idMedida, medida });

        }

        private void btnAddLu_Click(object sender, EventArgs e)
        {
            listInsumos frm = new listInsumos();
            frm.caseSwitch = 1;
            frm.Show(this);            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dgvConformacion.Rows)
            {
                cargarItemsProducto(dr);
                itemsProductoB.InsertItemProducto(itemProducto);
            }
        }

        //Entidades
        itemsProductoEntity itemProducto = new itemsProductoEntity();
        private void cargarItemsProducto(DataGridViewRow dRow)
        {
            itemProducto.producto = Convert.ToInt32(txtIDProd.Text);
            itemProducto.idInsumo = Convert.ToInt32(dRow.Cells["colIdInsumo"].Value);
            itemProducto.medida = Convert.ToString(dRow.Cells["colIDMedida"].Value);
            itemProducto.cantidad = Convert.ToDouble(dRow.Cells["colCantidadm"].Value);
        }
        
    }
}


