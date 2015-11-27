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

namespace RamosHermanos.Capas.Interfaz.ABMs
{
    public partial class formBuscarProducto : Form
    {
        public formBuscarProducto()
        {
            InitializeComponent();
        }

        formProducto frm = new formProducto();
        ProductoEntity producto = new ProductoEntity(); 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarIDproducto();
        }

        private void BuscarIDproducto()
        {

            if (txtIDproducto.Text == "")
            {
                frm.tabProducto.Controls.Remove(frm.tabInformacion);
                frm.Show();
                frm.tabProducto.SelectedTab = frm.tabListado;
                
                return;
            }

            producto.idProducto = Convert.ToInt32(txtIDproducto.Text);

            if (ProductoB.ExisteProductoID(producto) == false)
            {
                MessageBox.Show("El producto no existe");
                return;
            }
            else
            {
                ProductoB.BuscarIdProducto(producto);
                frm.txtIDProd.Text = Convert.ToString(producto.idProducto);
                frm.dtpFechaAlta.Value = producto.fechaAlta;
                frm.txtProducto.Text = producto.producto;
                frm.cbTipoProducto.SelectedValue = producto.tipoProducto;
                frm.cbMarca.SelectedValue = producto.marca;
                frm.cbMedida.SelectedValue = producto.medida;
                frm.txtDescripcion.Text = producto.descripcion;
                frm.txtCantidad.Text = Convert.ToString(producto.cantidad);

                frm.Show();
            }
        }
        
    }

    
   
        
}
