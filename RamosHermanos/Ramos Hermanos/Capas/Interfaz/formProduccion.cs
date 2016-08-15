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
        public int cantidadPreEdit;
        public int cantidadAfterEdit;

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
            dtpFechaProduccion.Value = DateTime.Today;
            dtpFechaProduccion.MaxDate = DateTime.Today;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            produccion.fechaProduccion = Convert.ToDateTime(dtpFechaProduccion.Value);
            produccion.descripcion = txtDescripcion.Text;
            ProduccionB.InsertProduccion(produccion, txtIDProduccion);
            
            foreach (DataGridViewRow rowA in dgvProduccion.Rows)
            {
                CargaItemProduccion(rowA);
                itemProduccionB.InsertItemProduccion(itemProduccion);

                DataTable DTitemsProducto = itemsProductoB.BuscarItemsProducto(Convert.ToInt32(rowA.Cells["colIDProducto"].Value));

                //Insumos
                foreach (DataRow dr in DTitemsProducto.Rows)
                {
                    stockInsumo.idInsumo = Convert.ToInt32(dr["insumo"].ToString());
                    stockInsumo.tipoStock = Convert.ToString(dr["tipoStock"].ToString());
                    stockInsumo.valorAnterior = cantidadPreEdit * Convert.ToInt32(dr["cantidad"].ToString());
                    stockInsumo.valorNuevo = cantidadAfterEdit * Convert.ToInt32(dr["cantidad"].ToString());
                    DateTime fechaActual = DateTime.Now;
                    stockInsumo.mesAño = Convert.ToDateTime(fechaActual.ToString("MM-yyyy"));

                    StockInsumoB.UpdateStockInsert(stockInsumo, "D");
                }
            }

            //Productos
            foreach (DataGridViewRow dRow in dgvProduccion.Rows)
            {
                stockProducto.idProducto = Convert.ToInt32(dRow.Cells["colIDProducto"].Value);
                stockProducto.valorAnterior = Convert.ToInt32(dRow.Cells["colCantidad"].Value);
                StockProductoB.UpdateStockInsert(stockProducto, "C");
            }

            MessageBox.Show("Produccion guardada");
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

        StockInsumoEntity stockInsumo = new StockInsumoEntity();
        
        LogStockProductoEntity logStock = new LogStockProductoEntity();
        public void CargaItemLogStock(DataGridViewRow row)
        {
            logStock.operacion = "P";
            logStock.comprobante = Convert.ToInt32(txtIDProduccion.Text);
            logStock.idProducto = Convert.ToInt32(row.Cells["colIDProducto"].Value);
            logStock.cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);

            //Buscamos el stockActual
            StockProductoEntity stockP = StockProductoB.BuscarStock(logStock.idProducto);
            logStock.stockNuevo = stockP.stockNuevo;
        }

        StockProductoEntity stockProducto = new StockProductoEntity();

        private void dgvProduccion_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvProduccion.CurrentCell.OwningColumn.Name == "colCantidad")
            {
                cantidadPreEdit = Convert.ToInt32(dgvProduccion.CurrentCell.Value);
            }            
        }

        private void dgvProduccion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduccion.CurrentCell.OwningColumn.Name == "colCantidad")
            {
                cantidadAfterEdit = Convert.ToInt32(dgvProduccion.CurrentCell.Value);
            }     
        }

    }
}
