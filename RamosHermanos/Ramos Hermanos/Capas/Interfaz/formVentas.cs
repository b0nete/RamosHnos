using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Reportes;
using RamosHermanos.Capas.Reportes.Comprobante;
using RamosHermanos.Capas.Interfaz.Listados;
using RamosHermanos.Capas.Interfaz.Contratos;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formVentas : Form, produccionForm
    {
        public int newORupdate = 1;
        public int cantidadValorAnterior;
        public int cantidadValorNuevo;

        public formVentas()
        {
            InitializeComponent();
        }

        public void pasarDatos(DataGridViewRow row)
        {
            string idProducto = row.Cells["colIDProducto"].Value.ToString();
            string producto = row.Cells["colProducto"].Value.ToString();
            //string check = "true";

            this.dgvFactura.Rows.Add(new[] { idProducto, producto });
        }

        private void formFactura_Load(object sender, EventArgs e)
        {
             dgvFactura.AutoGenerateColumns = false;
        }

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (newORupdate != 1)
            {
                factura.estado = cbEstado.Text;
                FacturaB.UpdateFactura(factura);
            }
        }

        // Entidades        
        FacturaEntity factura = new FacturaEntity();
        private void cargarFactura()
        {
            factura.cliente = Convert.ToInt32(txtIDcliente.Text);
            factura.tipoFactura = cbTipoFactura.Text;
            factura.fechaFactura = dtpfechaFactura.Value;
            factura.total = Convert.ToDouble(txtTotal.Text);
            factura.formaPago = cbformaPago.Text;
            factura.fechaVencimiento = dtpVencimiento.Value;
            factura.fechaEntrega = dtpEntrega.Value;
            factura.observaciones = txtObservaciones.Text;
            factura.estado = cbEstado.Text;
        }

        itemFacturaEntity itemFactura = new itemFacturaEntity();
        StockProductoEntity stockProducto = new StockProductoEntity();

        private void cargarItemsFactura(DataGridView dgv, DataGridViewRow dRow)
        {
                itemFactura.factura = txtIDFactura.Text;
                itemFactura.producto = Convert.ToInt32(dRow.Cells["colCodigo"].Value.ToString());
                itemFactura.precioUnitario = Convert.ToDouble(dRow.Cells["colPrecio"].Value.ToString());
                itemFactura.cantidad = Convert.ToInt32(dRow.Cells["colCantidad"].Value.ToString());
                itemFactura.subTotal = Convert.ToDouble(dRow.Cells["colSubTotal"].Value.ToString());
                itemFactura.carga = Convert.ToString(dRow.Cells["colCarga"].Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIDFactura.Text != string.Empty)
            {
                cargarFactura();
                FacturaB.UpdateFactura(factura);

                foreach (DataGridViewRow dR in dgvFactura.Rows)
                {
                    // Entidad
                    cargarItemsFactura(dgvFactura, dR);
                    //Stock
                    stockProducto.idProducto = Convert.ToInt32(dR.Cells["colCodigo"].Value.ToString());
                    stockProducto.valorAnterior = itemsFacturaB.BuscarCantidadAnterior(Convert.ToInt32(txtIDFactura.Text), Convert.ToInt32(dR.Cells["colCodigo"].Value), Convert.ToString(dR.Cells["colCarga"].Value));
                    stockProducto.valorNuevo = Convert.ToInt32(dR.Cells["colCantidad"].Value);
                    StockProductoB.UpdateStockUpdate(stockProducto);
                    // DB
                    itemsFacturaB.UpdateItemFactura(itemFactura);
                }
            }
            else
            {
                //Encabezado
                cargarFactura();
                FacturaB.InsertFacturaNEW(factura, txtIDFactura);

                //ItemsFactura
                foreach (DataGridViewRow dR in dgvFactura.Rows)
                {
                    cargarItemsFactura(dgvFactura, dR);
                    itemsFacturaB.InsertItemFactura(itemFactura);
                    stockProducto.idProducto = Convert.ToInt32(dR.Cells["colCodigo"].Value.ToString());
                    stockProducto.valorNuevo = Convert.ToInt32(dR.Cells["colCantidad"].Value);
                    string carga = dR.Cells["colCarga"].Value.ToString();
                    StockProductoB.UpdateStockInsert(stockProducto, carga);
                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            //string valor = "00000000";
            string ruta = Application.StartupPath.Replace(@"\bin\Debug", "");
            string rep = @"\Capas\Reportes\Comprobante\crComprobante.rpt";
            string change;
            dsComprobante ds = new dsComprobante();

            ////Factura
            ds.Tables["factura"].Rows.Add
            (
                new object[]
                { 
                    change = string.Format("{0,18:00000000}", Convert.ToInt32(txtIDFactura.Text)),
                    //Convert.ToString(valor + Convert.ToInt32(txtIDFactura.Text)),
                    dtpfechaFactura.Text,
                    txtNombre.Text,
                    cbDomicilio.Text,
                    txtTotal.Text,
                    txtIVA.Text,
                    cbformaPago.Text
                }
            );

            //ItemsFactura
            foreach (DataGridViewRow dRow in dgvFactura.Rows)
            {
                ds.Tables["itemsFactura"].Rows.Add
                (
                new object[]
                {
                    dRow.Cells["colCantidad"].Value,
                    dRow.Cells["colProducto"].Value,
                    dRow.Cells["colPrecio"].Value,
                    dRow.Cells["colSubTotal"].Value,   
                }
                );
            };

            //Cargar Reporte
            formReports frm = new formReports();
            frm.Show();
            ReportDocument rd = new ReportDocument();
            rd.Load(ruta + rep);
            //rd.Load("C:/Users/b0nete/Documents/GitHub/RamosHnos/RamosHermanos/Ramos Hermanos/Capas/Reportes/Recorridos/crFactura.rpt");
            rd.SetDataSource(ds);
            frm.crvReporte.ReportSource = rd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listProductos frm = new listProductos();
            frm.caseSwitch = 3;
            frm.Show(this);
        }

        private void dgvFactura_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            double precioUnitario;

            foreach (DataGridViewRow dRow in dgvFactura.Rows)
            {                
                if (dRow.Cells["colCodigo"].Value.ToString() != string.Empty)
                {
                    int codProducto = Convert.ToInt32(dRow.Cells["colCodigo"].Value.ToString());
                    precioUnitario = PrecioProductosB.UltimoPrecio(codProducto);
                    dRow.Cells["colPrecio"].Value = precioUnitario;
                }
            }
        }

        private void dgvFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cantidadValorNuevo = Convert.ToInt32(dgvFactura.CurrentRow.Cells["colCantidad"].Value);

            //Verificamos stock
            int idProducto = Convert.ToInt32(dgvFactura.CurrentRow.Cells["colCodigo"].Value);
            int cantidad = Convert.ToInt32(dgvFactura.CurrentRow.Cells["colCantidad"].Value);

            if (Convert.ToString(dgvFactura.CurrentRow.Cells["colCarga"].Value) != string.Empty && txtIDFactura.Text != string.Empty)
            {
                cantidadValorAnterior = itemsFacturaB.BuscarCantidadAnterior(Convert.ToInt32(txtIDFactura.Text), idProducto, dgvFactura.CurrentRow.Cells["colCarga"].Value.ToString());
            }

            

            int cantidadResultante = Math.Abs(cantidadValorAnterior - cantidadValorNuevo);
            bool dispStock = StockProductoB.DisponiblidadStock(idProducto, cantidadResultante);
            if (dispStock == false)
            {
                dgvFactura.CurrentCell.Value = cantidadValorAnterior.ToString();
                return;
            }

            //if (StockProductoB.DisponiblidadStock(idProducto, cantidad) == false)
            //{
            //    dgvFactura.CurrentRow.Cells["colCantidad"].Value = cantidadValorAnterior; 
            //}

            //Valor Nuevo
            if (dgvFactura.CurrentRow.Cells["colCantidad"].Value.ToString() != string.Empty)
            {
                cantidadValorNuevo = Convert.ToInt32(dgvFactura.CurrentRow.Cells["colCantidad"].Value.ToString());
                //MessageBox.Show("Valor Nuevo: " + cantidadValorNuevo);
            }

            if (dgvFactura.CurrentRow.Cells["colCodigo"].Value.ToString() != string.Empty && dgvFactura.CurrentRow.Cells["colCantidad"].Value.ToString() != string.Empty)
            {
                double precioUnitario = PrecioProductosB.UltimoPrecio(Convert.ToInt32(dgvFactura.CurrentRow.Cells["colCodigo"].Value.ToString()));
                dgvFactura.CurrentRow.Cells["colSubTotal"].Value = Convert.ToString(cantidad * precioUnitario);               
            }

            // Se recorre cada fila del DGV.
            double total = 0;

            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                if (row.Cells["colCantidad"].ToString() != string.Empty && row.Cells["colPrecio"].ToString() != string.Empty)
                {
                    row.Cells["colSubTotal"].Value = Convert.ToInt32(row.Cells["colCantidad"].Value) * Convert.ToDouble(row.Cells["colPrecio"].Value);

                    total += Convert.ToDouble(row.Cells["colSubTotal"].Value);
                }

                txtTotal.Text = Convert.ToString(total);
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvFactura_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void dgvFactura_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

            string var = Convert.ToString(dgvFactura.CurrentRow.Cells["colCantidad"].Value);

            if (var != string.Empty)
            {
                cantidadValorAnterior = Convert.ToInt32(dgvFactura.CurrentRow.Cells["colCantidad"].Value.ToString());
            }
        }

        private void dgvFactura_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == 099 || e.KeyChar == 67)
            {
                // 099 = c
                // 67 = C
                dgvFactura.CurrentRow.Cells["colCarga"].Value = "C";

                if (Convert.ToString(dgvFactura.CurrentRow.Cells["colCarga"].Value) == "C")
                {
                    double st = Convert.ToDouble(dgvFactura.CurrentRow.Cells["colSubTotal"].Value.ToString());
                    dgvFactura.CurrentRow.Cells["colSubTotal"].Value = Math.Abs(st);
                }
            }

            if (e.KeyChar == 100 || e.KeyChar == 69)
            {
                // 100 = d
                // 68 = D
                dgvFactura.CurrentRow.Cells["colCarga"].Value = "D";

                if (Convert.ToString(dgvFactura.CurrentRow.Cells["colCarga"].Value) == "D")
                {
                    double st = Convert.ToDouble(dgvFactura.CurrentRow.Cells["colSubTotal"].Value.ToString());
                    dgvFactura.CurrentRow.Cells["colSubTotal"].Value = -(st);
                }
            }
        }

        private void dgvFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvFactura_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow dR in dgvFactura.Rows)
            {
                if (Convert.ToString(dR.Cells["colCarga"].Value) == string.Empty)
                {
                    dR.Cells["colCarga"].Value = "C";
                }
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
