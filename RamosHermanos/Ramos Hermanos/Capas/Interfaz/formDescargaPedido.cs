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
    public partial class formDescargaPedido : Form
    {
        public int cantidadPreEdit;
        public int cantidadAfterEdit;
        public string comprobante;

        public formDescargaPedido()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            formRepartos frm = new formRepartos();

            int total = Suma();

            DescargaTXT(txt25, 6);
            DescargaTXT(txt20, 5);
            DescargaTXT(txt12, 4);
            DescargaTXT(txt10, 3);
            DescargaTXT(txt4, 1);

            // Tutorial Interfaz formularios desacoplados
            // http://ltuttini.blogspot.com.ar/2009/09/c-comunicar-formularios-de-forma.html

            IForm formInterface = this.Owner as IForm;

            if (formInterface != null)
                formInterface.CompletarCelda(Convert.ToString(total));

            this.Close();
        }

        private void formCargaPedido_Load(object sender, EventArgs e)
        {

        }

        public int Suma()
        {
            int suma = Convert.ToInt32(txt25.Text) + Convert.ToInt32(txt20.Text) + Convert.ToInt32(txt12.Text) + Convert.ToInt32(txt10.Text) + Convert.ToInt32(txt4.Text);
            return suma;
        }

        private void DescargaTXT(TextBox txt, int producto)
        {
            if (txt.Text == string.Empty)
            {
                txt.Text = "0";
                return;
            }

            if (txt.Text != string.Empty)
            {
                itemFactura.factura = comprobante;
                itemFactura.producto = producto;
                itemFactura.cantidad = Convert.ToInt32(txt.Text);
                itemFactura.precioUnitario = 0;
                itemFactura.subTotal = 0;
                itemFactura.carga = "D";

                itemsFacturaB.InsertItemFactura(itemFactura);
            }
        }

        //Entidades
        itemFacturaEntity itemFactura = new itemFacturaEntity();

        StockProductoEntity stockProducto = new StockProductoEntity();

        private void button1_Click(object sender, EventArgs e)
        {
            int total = Suma();

            IForm formInterface = this.Owner as IForm;

            if (formInterface != null)
                formInterface.CompletarCelda(Convert.ToString(total));

            this.Close();
        }

        private void CargaTXT(TextBox txt, int producto)
        {
            if (txt.Text == string.Empty)
            {
                txt.Text = "0";
                return;
            }

            if (txt.Text != string.Empty && txt.Text != "0")
            {
                cantidadAfterEdit = Convert.ToInt32(txt.Text);
                cantidadPreEdit = itemsFacturaB.BuscarCantidadAnterior(Convert.ToInt32(comprobante), producto, "D");

                itemFactura.producto = producto;
                itemFactura.cantidad = Convert.ToInt32(txt.Text);
                //itemFactura.precioUnitario = PrecioProductosB.UltimoPrecio(itemFactura.producto);
                itemFactura.precioUnitario = 0;
                //itemFactura.subTotal = itemFactura.precioUnitario * itemFactura.cantidad;
                itemFactura.subTotal = 0;
                itemFactura.factura = comprobante;
                itemFactura.carga = "D";

                if (txt.Text != string.Empty)
                {
                    if (cantidadPreEdit > cantidadAfterEdit)
                    {
                        //Stock
                        stockProducto.idProducto = producto;
                        stockProducto.valorAnterior = cantidadPreEdit;
                        stockProducto.valorNuevo = cantidadAfterEdit;
                        StockProductoB.UpdateStockUpdate(stockProducto);
                    }
                    else
                    {
                        int cantidadResultante = cantidadAfterEdit - cantidadPreEdit;
                        bool dispStock = StockProductoB.DisponiblidadStock(producto, cantidadResultante);
                        if (dispStock == false)
                        {
                            txt.Text = cantidadPreEdit.ToString();
                            return;
                        }

                        //Stock
                        stockProducto.idProducto = Convert.ToInt32(producto);
                        stockProducto.valorAnterior = cantidadPreEdit;
                        stockProducto.valorNuevo = cantidadAfterEdit;
                        StockProductoB.UpdateStockUpdate(stockProducto);
                    }
                }

                if (itemsFacturaB.ExisteItemFactura(itemFactura) == true)
                {
                    itemsFacturaB.UpdateItemFactura(itemFactura);
                }
                else
                {
                    itemsFacturaB.InsertItemFactura(itemFactura);
                }
            }
        }

        private void txt25_Validated(object sender, EventArgs e)
        {
            CargaTXT(txt25, 6);
        }

        private void txt20_Validated(object sender, EventArgs e)
        {
            CargaTXT(txt20, 5);
        }

        private void txt12_Validated(object sender, EventArgs e)
        {
            CargaTXT(txt12, 4);
        }

        private void txt10_Validated(object sender, EventArgs e)
        {
            CargaTXT(txt10, 3);
        }

        private void txt4_Validated(object sender, EventArgs e)
        {
            CargaTXT(txt4, 1);
        }

        private void formDescargaPedido_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
