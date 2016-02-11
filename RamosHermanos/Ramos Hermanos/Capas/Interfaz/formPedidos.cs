using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization; //CultureInfo
using System.Threading;
using CrystalDecisions.CrystalReports.Engine;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Interfaz.Contratos;
using RamosHermanos.Capas.Interfaz.ABMs;
using RamosHermanos.Capas.Reportes;
using RamosHermanos.Capas.Reportes.Comprobante;
using RamosHermanos.Capas.Interfaz.Listados;


namespace RamosHermanos.Capas.Interfaz
{
    public partial class formPedidos : Form
    {
      
        public formPedidos()
        {
            InitializeComponent();
        }

        PedidoEntity pedido = new PedidoEntity();
        public void cargarPedido()
        {
            pedido.rol = 1;
            pedido.idPersona = Convert.ToInt32(txtdniCliente.Text);
            pedido.domicilio = Convert.ToString(cbDomicilio.SelectedValue);
            pedido.observaciones = txtObservaciones.Text;
            pedido.total = Convert.ToDouble(txtTotal.Text);
            pedido.estado = cbEstado.Text;
            pedido.fechaPedido = dtpFecha.Value;
            pedido.fechaEntrega = dtpEntrega.Value;

        }

        private void formPedidos_Load(object sender, EventArgs e)
        {
            ProductoB.CargarDGV(dgvProducto);
            ClienteB.CargarDGV(dgvCliente);
            PedidoB.cargardgvPedido(dgvListadoPedidos);
            this.reportViewer1.RefreshReport();
            
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtdniCliente.Text == "") 
            {
                MessageBox.Show("Por favor, ingrese un cliente");
            }
            else
            {
                tabMain.SelectedTab = tabProducto;
            }
            
        }

        ProductoEntity producto = new ProductoEntity();
        private void CargarProducto()
        {
            //producto.idProducto;
        }

        private void SavePedido()
        {
            if (VerificarCampos() == false)
            {
                return;

            }
            else
            {
                //pedido.idPedido = Convert.ToInt32(txtidpedido.Text); 
                
                if ((txtidpedido.Text !=null && PedidoB.ExistePedido(pedido) == true))
                {
                    DialogResult result = MessageBox.Show("El pedido existe, desea actualizarlo con los datos ingresados?", "Pedido Existente", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        cargarPedido();
                        PedidoB.UpdatePedido(pedido);
                        clean();
                        //CargarItemPedido(row);
                        //itemsPedidoB.UpdateItemPedido(itemPedido, dgv);
                        
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                else if (PedidoB.ExistePedido(pedido) == false)
                {
                    cargarPedido();
                    PedidoB.InsertPedido(pedido, txtidpedido);

                    foreach (DataGridViewRow row in dgvPedido.Rows)
                    {
                        CargarItemPedido(row);
                        itemsPedidoB.InsertItemPedido(itemPedido, dgvPedido);
                    }
                    MessageBox.Show("Pedido Guardado");
                    clean();

                                        
                }
            }
        }

        private bool VerificarCampos()
        {
            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Campos Obligatorios Incompletos");
                return false;


            }
            return true;

        }


        ClienteEntity cliente = new ClienteEntity();
        private void CargarCliente()
        {

        }

        private void dgvProducto_MouseDoubleClick(object sender, MouseEventArgs e)
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

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el producto para cargarlo en tabInformación.

                producto.idProducto = Convert.ToInt32(row.Cells["colIDProducto"].Value.ToString());

                ProductoB.AddProductoDGV(dgvPedido, producto);

                tabMain.SelectedTab = tabPedido;
            }
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            
            listClientes frm = new listClientes();
            frm.Show();
            frm.caseSwitch = 1;
            this.Close();
        }

        private void dgvCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            dgvPedido.Rows.RemoveAt(dgvPedido.CurrentRow.Index);
        }

        private void dgvPedido_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            {
                // Se genera la variable para acumular los SubTotales.
                double total = 0;

                // Se recorre cada fila del DGV.
                foreach (DataGridViewRow row in dgvPedido.Rows)
                {

                    // Se ejecutan las operaciones solo si la columna cantidad y precio tienen algún valor, ya que de lo contrario nos dará un error.
                    if (row.Cells["colCantidad"].ToString() != string.Empty && row.Cells["colPrecio"].ToString() != string.Empty)
                    {
                        row.Cells["colSubTotal"].Value = Convert.ToInt32(row.Cells["colCantidad"].Value) * Convert.ToDouble(row.Cells["colPrecio"].Value);

                        total += Convert.ToDouble(row.Cells["colSubTotal"].Value);
                    }

                    txtTotal.Text = Convert.ToString(total);
                }
            }
        }

        itemPedidoEntity itemPedido = new itemPedidoEntity();
        
        public void CargarItemPedido(DataGridViewRow row)
        {
            itemPedido.codProducto = Convert.ToInt32((row.Cells["colCodigo"].Value));
            itemPedido.pedido = Convert.ToInt32(txtidpedido.Text);
            itemPedido.cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);
            itemPedido.preciounitario = Convert.ToDouble(row.Cells["colPrecio"].Value);
            itemPedido.subtotal = Convert.ToDouble(row.Cells["colSubTotal"].Value);

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SavePedido();
            //cargarPedido();
            //PedidoB.InsertPedido(pedido, txtidpedido);

            //foreach (DataGridViewRow row in dgvPedido.Rows)
            //{
            //    CargarItemPedido(row);
            //    itemsPedidoB.InsertItemPedido(itemPedido, dgvPedido);
            //}
            //MessageBox.Show("Pedido Guardado");


        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //itemsPedidoB.InsertIntoItemPedido(itemPedido, dgvPedido);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            cargarPedido();
            PedidoB.UpdatePedido(pedido);
        }

        private void dgvListadoPedidos_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dgvListadoPedidos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //SeleccionarDgv();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void clean()
        {
            txtdniCliente.Text = "";
            txtidpedido.Text = "";
            txtNombre.Text = "";
            txtObservaciones.Text = "";
            txtTotal.Text = "";
            cbDomicilio.DataSource = null;
            cbEstado.SelectedIndex = -1;
            dgvPedido.Rows.Clear();          


        }

        private void iditem(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath.Replace(@"\bin\Debug", "");

            string rep = @"\Capas\Reportes\Comprobante\crComprobante.rpt";

            dsComprobante ds = new dsComprobante();

            //DataTable dtItemsPedido = PedidoB....

            int filas = dgvPedido.Rows.Count;

            for (int i = 0; i <= filas - 2; i++ )
            {

                ds.Tables[0].Rows.Add

                    (
                    new object[] {
                        dgvPedido[0,i].Value.ToString(),
                        dgvPedido[1,i].Value.ToString(),
                        dgvPedido[2,i].Value.ToString(),
                        dgvPedido[3,i].Value.ToString(),
                        dgvPedido[4,i].Value.ToString(),
                        dgvPedido[5,i].Value.ToString()                 

                 });
            }

            formReports frm = new formReports();
            frm.Show();
            ReportDocument oRep = new ReportDocument();
            oRep.Load(ruta + rep);
            oRep.SetDataSource(ds);
            frm.crvReporte.ReportSource = oRep;
         
        }
    }
}
