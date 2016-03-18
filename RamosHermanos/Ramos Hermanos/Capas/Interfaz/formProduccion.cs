using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHermanos.Capas.Interfaz.Listados;
using RamosHermanos.Capas.Interfaz.Contratos;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formProduccion : Form, produccionForm
    {
        public formProduccion()
        {
            InitializeComponent();
        }

        //#region IAddItem Members

        public void pasarDatos(DataGridViewRow row)
        {
            string idProducto = row.Cells["colIDProducto"].Value.ToString();
            string producto = row.Cells["colProducto"].Value.ToString();
            //string check = "true";

            this.dgvProduccion.Rows.Add(new[] { idProducto, producto });
        }

        //#endregion
        private void btnAdd_Click(object sender, EventArgs e)
        {
            listProductos frm = new listProductos();
            frm.caseSwitch = 2;
            frm.Show(this);
        }

        private void formProduccion_Load(object sender, EventArgs e)
        {
            dtpFechaProduccion.MaxDate = DateTime.Today;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            produccion.fechaProduccion = Convert.ToDateTime(dtpFechaProduccion.Value);
            ProduccionB.InsertProduccion(produccion, txtIDProduccion);

            
            foreach (DataGridViewRow rowA in dgvProduccion.Rows)
            {
                CargaItemProduccion(rowA);
                itemProduccionB.InsertItemProduccion(itemProduccion);
            }


        }

        //Entidades

        ProduccionEntity produccion = new ProduccionEntity();

        ItemProduccionEntity itemProduccion = new ItemProduccionEntity();
        public void CargaItemProduccion(DataGridViewRow row)
        {
            itemProduccion.produccion = Convert.ToInt32(txtIDProduccion.Text);
            itemProduccion.producto = Convert.ToInt32(row.Cells["colIDProducto"].Value);
            itemProduccion.cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);
        }
    }
}
