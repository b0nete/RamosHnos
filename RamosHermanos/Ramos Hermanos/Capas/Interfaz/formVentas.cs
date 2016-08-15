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
using RamosHermanos.Capas.Interfaz;
using RamosHermanos.Capas.Reportes;
using RamosHermanos.Capas.Reportes.Comprobante;
using RamosHermanos.Capas.Interfaz.Listados;
using RamosHermanos.Capas.Interfaz.Contratos;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formVentas : Form, produccionForm
    {
        public int facturaNuevaoRegistrada; //1 nueva, 2 registrada.
        public int newORupdate = 1;
        public int cantidadValorAnterior;
        public int cantidadValorNuevo;
        public int abiertoformCliente;

        public formVentas()
        {
            InitializeComponent();
        }

        public void pasarDatos(DataGridViewRow row)
        {
            string idProducto = row.Cells["colIDProducto"].Value.ToString();
            string producto = row.Cells["colProducto"].Value.ToString();
            //string check = "true";

            this.dgvFactura.Rows.Add(new[] { idProducto, producto, "1"});
        }

        private void formFactura_Load(object sender, EventArgs e)
        {
             dgvFactura.AutoGenerateColumns = false;

             cbTipoFactura.Text = "X";

             if (newORupdate == 1)
             {
                 cbTipoFactura.Text = "X";
                 cbformaPago.Text = "Contado";
             }             
        }

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (newORupdate != 1)
            {
                factura.estado = cbEstado.Text;
                factura.idFactura = Convert.ToInt32(txtIDFactura.Text);
                FacturaB.UpdateFacturaEstado(factura);
            }

            
        }

        // Entidades        
        FacturaEntity factura = new FacturaEntity();
        private void cargarFactura()
        {
            factura.cliente = Convert.ToInt32(txtIDcliente.Text);
            factura.tipoFactura = cbTipoFactura.Text;
            factura.fechaFactura = dtpfechaFactura.Value;
            factura.formaPago = cbformaPago.Text;
            factura.tipoFactura = cbTipoFactura.Text;
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

                MessageBox.Show("Comprobante actualizado");
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
                    stockProducto.valorAnterior = 0;
                    stockProducto.valorNuevo = Convert.ToInt32(dR.Cells["colCantidad"].Value);
                    string carga = dR.Cells["colCarga"].Value.ToString();
                    //StockProductoB.UpdateStockInsert(stockProducto, carga);

                    if (carga == "C")
                    {
                        StockProductoB.UpdateStockInsert(stockProducto, carga);
                    }
                    else if (carga == "D")
                    {
                        DataTable DTitemsProducto = itemsProductoB.BuscarItemsProducto(stockProducto.idProducto);

                        foreach (DataRow dr in DTitemsProducto.Rows)
                        {
                            if (dr["tipoStock"].ToString() != "C")
                            {
                                stockInsumo.idInsumo = Convert.ToInt32(dr["insumo"].ToString());
                                stockInsumo.tipoStock = Convert.ToString(dr["tipoStock"].ToString());
                                stockInsumo.valorAnterior = 0;
                                stockInsumo.valorNuevo = stockProducto.valorNuevo * Convert.ToInt32(dr["cantidad"].ToString());
                                DateTime fechaActual = DateTime.Now;
                                stockInsumo.mesAño = Convert.ToDateTime(fechaActual.ToString("MM-yyyy"));
                            }

                            if (stockInsumo.tipoStock == "R")
                            {
                                stockInsumo.idInsumo = Convert.ToInt32(dr["insumo"].ToString());
                                stockInsumo.tipoStock = Convert.ToString(dr["tipoStock"].ToString());
                                stockInsumo.valorAnterior = 0;
                                stockInsumo.valorNuevo = stockProducto.valorNuevo;
                                DateTime fechaActual = DateTime.Now;
                                stockInsumo.mesAño = Convert.ToDateTime(fechaActual.ToString("MM-yyyy"));

                                StockInsumoB.UpdateStockInsertReparto(stockInsumo);
                            }
                        }
                    }
                }


                MessageBox.Show("Comprobante guardado!");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtIDFactura.Text != string.Empty)
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
                    txtTotalDescuento.Text,
                    txtIVA.Text,
                    cbformaPago.Text,
                    tipoClienteB.BuscarCategoriaClientePorc(Convert.ToInt32(txtIDcliente.Text)),
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
            else
            {
                MessageBox.Show("Guarde la venta antes de generar el comprobante");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            facturaNuevaoRegistrada = 1; //Se cambia valor a uno para poder editar la factura.

            listProductos frm = new listProductos();
            frm.caseSwitch = 3;
            frm.Show(this);
        }

        private void dgvFactura_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (facturaNuevaoRegistrada == 1)
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
            
        }

        private void dgvFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cantidadValorNuevo = Convert.ToInt32(dgvFactura.CurrentRow.Cells["colCantidad"].Value);
            int idProducto = Convert.ToInt32(dgvFactura.CurrentRow.Cells["colCodigo"].Value);
            int cantidadResultante = cantidadValorNuevo - cantidadValorAnterior;
            string carga = "";

            if (Convert.ToString(dgvFactura.CurrentRow.Cells["colCarga"].Value) == "C")
            {
                dgvFactura.CurrentRow.Cells["colSubTotal"].Value = cantidadValorNuevo * Convert.ToDouble(dgvFactura.CurrentRow.Cells["colPrecio"].Value);
                carga = "C";
            }
            else if (Convert.ToString(dgvFactura.CurrentRow.Cells["colCarga"]) == "D")
            {
                dgvFactura.CurrentRow.Cells["colSubTotal"].Value = 0;
                carga = "D";
            }
                

            if (carga == "C")
            {
                if (verificarStock(idProducto, cantidadResultante) == false)
                {
                    dgvFactura.CurrentCell.Value = cantidadValorAnterior.ToString();
                    return;
                }
            }

            if (carga == "C")
            {
                //Stock
                stockProducto.idProducto = Convert.ToInt32(idProducto);
                stockProducto.valorAnterior = cantidadValorAnterior;
                stockProducto.valorNuevo = cantidadValorNuevo;
                //StockProductoB.UpdateStockInsert(stockProducto, carga);
            }
            else if (carga == "D")
            {
                DataTable dtInsumosRetornables = InsumoB.BuscarInsumosRetornables(idProducto);
                DataRow dr = dtInsumosRetornables.Rows[0];

                stockInsumo.idInsumo = Convert.ToInt32(dr["insumo"].ToString());
                stockInsumo.valorAnterior = cantidadValorAnterior * Convert.ToInt32(dr["cantidad"].ToString());
                stockInsumo.valorNuevo = cantidadValorNuevo * Convert.ToInt32(dr["cantidad"].ToString());

                //StockInsumoB.UpdateStockInsert(stockInsumo, carga);
            }

            calcularTotal();

            if (newORupdate != 1)
            {
                UpdateFacturaEXEC();
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
                    dgvFactura.CurrentRow.Cells["colPrecio"].Value = 0;
                    dgvFactura.CurrentRow.Cells["colSubTotal"].Value = 0;
                }
            }

            if (e.KeyChar == 112 || e.KeyChar == 80)
            {
                // 112 = p
                // 80 = P
                dgvFactura.CurrentRow.Cells["colCarga"].Value = "P";

                if (Convert.ToString(dgvFactura.CurrentRow.Cells["colCarga"].Value) == "P")
                {
                    double st = Convert.ToDouble(dgvFactura.CurrentRow.Cells["colSubTotal"].Value.ToString());
                    dgvFactura.CurrentRow.Cells["colSubTotal"].Value = 0;
                }
            }

            if (newORupdate != 1)
            {
                UpdateFacturaEXEC();
            } 
        }

        private void dgvFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow dr in dgvFactura.Rows)
            {
                if (Convert.ToString(dr.Cells["colCarga"].Value) == "C")
                {
                    dr.DefaultCellStyle.BackColor = Color.LightGreen;
                    calcularTotal();
                }

                if (Convert.ToString(dr.Cells["colCarga"].Value) == "D")
                {
                    dr.DefaultCellStyle.BackColor = Color.LightCoral;
                    calcularTotal();
                }

                if (Convert.ToString(dr.Cells["colCarga"].Value) == "P")
                {
                    dr.DefaultCellStyle.BackColor = Color.Yellow;
                    calcularTotal();
                }
            }
        }

        private void dgvFactura_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (facturaNuevaoRegistrada == 1)
            {
                foreach (DataGridViewRow dR in dgvFactura.Rows)
                {
                    if (Convert.ToString(dR.Cells["colCarga"].Value) == string.Empty)
                    {
                        dR.Cells["colCarga"].Value = "C";
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow dr in dgvFactura.Rows)
                {
                    if (Convert.ToString(dr.Cells["colCarga"].Value) == "C")
                    {
                        dr.DefaultCellStyle.BackColor = Color.LightGreen;
                    }

                    if (Convert.ToString(dr.Cells["colCarga"].Value) == "D")
                    {
                        dr.DefaultCellStyle.BackColor = Color.LightCoral;
                    }

                    //if (Convert.ToString(dr.Cells["colCarga"].Value) == "P")
                    //{
                    //    dr.DefaultCellStyle.BackColor = Color.Yellow;
                    //}
                }
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        public bool comprobarItemRepetido()
        {
            bool bul = false;

            int ultimaFila = dgvFactura.Rows.Count - 1;
            int c = 0;

            foreach (DataGridViewRow dr in dgvFactura.Rows)
            {
                if (Convert.ToString(dgvFactura.Rows[ultimaFila].Cells["colCodigo"].Value) == Convert.ToString(dr.Cells["colCodigo"].Value))
                {
                    //Si ya existen dos insumos iguales, evitamos agregar.
                    c = c + 1;
                    if (c == 3)
                    {
                        if (Convert.ToString(dgvFactura.Rows[ultimaFila - 1].Cells["colCodigo"].Value) == Convert.ToString(dr.Cells["colCodigo"].Value))
                        {
                            dgvFactura.Rows.Remove(dgvFactura.Rows[ultimaFila - 1]);
                            MessageBox.Show("Ya existe este producto en la factura!");
                            bul = true;
                        }
                        else
                        {
                            dgvFactura.Rows.Remove(dgvFactura.Rows[ultimaFila]);
                            MessageBox.Show("Ya existe este producto en la factura!");
                            bul = true;
                        }
                    }
                }
            }

            return bul;
        }

        public void calcularTotal()
        {
            // Se recorre cada fila del DGV.
            double carga = 0;

                foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                if (row.Cells["colCantidad"].ToString() != string.Empty && row.Cells["colPrecio"].ToString() != string.Empty && row.Cells["colCarga"].Value.ToString() == "C")
                {
                    row.Cells["colSubTotal"].Value = Convert.ToInt32(row.Cells["colCantidad"].Value) * Convert.ToDouble(row.Cells["colPrecio"].Value);

                    carga += Convert.ToDouble(row.Cells["colSubTotal"].Value);
                }

                txtTotal.Text = Convert.ToString(carga);

                    double porcDesc = tipoClienteB.BuscarCategoriaClientePorc(Convert.ToInt32(txtIDcliente.Text));

                    double porc = (Convert.ToDouble(txtTotal.Text) * porcDesc) / 100;

                    txtTotalDescuento.Text = Convert.ToString(Convert.ToDouble(txtTotal.Text) - porc); 
            }
            
        }

        private bool verificarStock(int idProducto, int cantidadResultante)
        {
            bool dispStock = StockProductoB.DisponiblidadStock(idProducto, cantidadResultante);
            if (dispStock == false)
            {
                dgvFactura.CurrentCell.Value = cantidadValorAnterior.ToString();
            }

            return dispStock;
        }

        StockInsumoEntity stockInsumo = new StockInsumoEntity();

        private void UpdateFacturaEXEC()
        {
            if (txtIDFactura.Text == string.Empty)
            {
                txtIDFactura.Text = Convert.ToString(FacturaB.UltimaFactura() + 1);
            }

            //Factura
            factura.tipoFactura = cbTipoFactura.Text;
            factura.estado = cbEstado.Text;
            factura.fechaFactura = dtpfechaFactura.Value;
            factura.fechaVencimiento = dtpVencimiento.Value;
            factura.fechaEntrega = dtpEntrega.Value;
            factura.cliente = Convert.ToInt32(txtIDcliente.Text);
            factura.domicilio = Convert.ToInt32(cbDomicilio.SelectedValue);
            factura.formaPago = cbformaPago.Text;
            //factura.numFactura = FacturaB.UltimaFactura() + 1;
            factura.idFactura = Convert.ToInt32(txtIDFactura.Text);
            factura.total = Convert.ToDouble(txtTotal.Text);
            factura.observaciones = txtObservaciones.Text;
            factura.estado = cbEstado.Text;

            FacturaB.UpdateFactura(factura);

            //ItemsFactura
            itemsFacturaB.DeleteItemsFactura(factura.idFactura); //Borramos itemsFactura
            foreach (DataGridViewRow dr in dgvFactura.Rows)
            {
                string cantidad, precio, subtotal;
                cantidad = Convert.ToString(dr.Cells["colCantidad"].Value);
                precio = Convert.ToString(dr.Cells["colPrecio"].Value);
                subtotal = Convert.ToString(dr.Cells["colSubTotal"].Value);

                if (cantidad != string.Empty && precio != string.Empty && subtotal != string.Empty)
                {
                    itemFactura.producto = Convert.ToInt32(dr.Cells["colCodigo"].Value.ToString());
                    itemFactura.factura = factura.idFactura.ToString();
                    itemFactura.cantidad = Convert.ToInt32(dr.Cells["colCantidad"].Value.ToString());
                    itemFactura.precioUnitario = Convert.ToDouble(dr.Cells["colPrecio"].Value.ToString());
                    itemFactura.subTotal = Convert.ToInt32(dr.Cells["colSubTotal"].Value.ToString());
                    itemFactura.carga = Convert.ToString(dr.Cells["colCarga"].Value.ToString());

                    itemsFacturaB.InsertItemFactura(itemFactura);
                }
                
            }
        }

        public void columnasNegativasTotal()
        {
            foreach (DataGridViewRow dRow in dgvFactura.Rows)
            {
                if (Convert.ToString(dRow.Cells["colCarga"].Value) == "D")
                {
                    dRow.Cells["colPrecio"].Value = 0;
                    dRow.Cells["colSubTotal"].Value = 0;           
                }

                calcularTotal();
            }
        }

        private void comprobarCargaRepetida()
        {
            int ultimaFila = dgvFactura.Rows.Count - 1;

            //if (Convert.ToString(dgvFactura.CurrentRow.Cells["colCarga"].Value) != string.Empty)
            //{
            //    string currentCarga = Convert.ToString(dgvFactura.CurrentRow.Cells["colCarga"].Value);
            //}

            //if (Convert.ToString(dgvFactura.CurrentRow.Cells["colCodigo"].Value) != string.Empty)
            //{
            //    string currentInsumo = Convert.ToString(dgvFactura.CurrentRow.Cells["colCodigo"].Value);
            //}

            if (dgvFactura.Rows.Count > 0)
            {
                foreach (DataGridViewRow dr in dgvFactura.Rows)
                {
                    string currentCarga = Convert.ToString(dgvFactura.CurrentRow.Cells["colCarga"]);
                    string currentInsumo = Convert.ToString(dgvFactura.CurrentRow.Cells["colCodigo"]);

                    if (dr.Cells["colCarga"].Value.ToString() == "C")
                    {
                        dgvFactura.Rows[ultimaFila].Cells["colCarga"].Value = "D";
                    }
                    else
                    {
                        dgvFactura.Rows[ultimaFila].Cells["colCarga"].Value = "C";
                    }
                }
            }            
        }

        private void cbDomicilio_DataSourceChanged(object sender, EventArgs e)
        {

        }

        private void formVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (abiertoformCliente == 1)
            {
                formCliente frm = this.Owner as formCliente;
                frm.ActualizarSaldos();
            }            
        }

        public void cargarCBDesdeFormRepartos(string formaPago)
        {
            //No se realizaba la carga de los CBs por eso se utiliza este método

            cbformaPago.Text = formaPago;
            DomicilioB.CargarCB(cbDomicilio, txtIDcliente, "1");
            //frmP.cbDomicilio.SelectedValue = factura.domicilio;
            TelefonoB.CargarCB(cbTelefono, txtIDcliente, 1);
        }
    }
}
