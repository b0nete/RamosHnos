﻿using System;
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

        public string comprobante;

        public formDescargaPedido()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            formRepartos frm = new formRepartos();

            int total = Suma();

            if (txt25.Text != string.Empty)
            {
                itemFactura.factura = comprobante;
                itemFactura.producto = 6;
                itemFactura.cantidad = Convert.ToInt32(txt25.Text);
                itemFactura.precioUnitario = PrecioProductosB.UltimoPrecio(itemFactura.producto);
                itemFactura.subTotal = itemFactura.precioUnitario * itemFactura.cantidad;
                itemFactura.carga = "D";

                itemsFacturaB.InsertItemFactura(itemFactura);
            }

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

        //Entidades
        itemFacturaEntity itemFactura = new itemFacturaEntity();
    }
}
