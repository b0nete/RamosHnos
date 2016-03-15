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
using RamosHermanos.Capas.Interfaz.Listados;
using RamosHermanos.Capas.Interfaz.Contratos;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formCompras : Form, IAddItem
    {
        public int caseSwitch = 1;
        public int switchCase = 1;

        public formCompras()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void formCompras_Load(object sender, EventArgs e)
        {
            txtIngreso.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //listInsumos frm = new listInsumos();
            //frm.caseSwitch = 1;
            //frm.Show();

            listInsumos formAdd = new listInsumos();
            formAdd.Show(this);
        }

        //public void AddNewItem(DataGridViewRow row)
        //{
        //    string item = row.Cells["item"].Value.ToString();
        //    string desc = row.Cells["Desc"].Value.ToString();

        //    this.dgvCompra.Rows.Add(new[] { item, desc });
            
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //listProveedores frm = new listProveedores();
            //frm.caseSwitch = 1;
            //frm.Show(this);

            listProveedores formADD = new listProveedores();
            formADD.Show(this);
            formADD.caseSwitch = 1;
        }

        #region IAddItem Members

        public void AddNewProveedor(TextBox txt)
        {
            string idproveedor = txtIDproveedor.Text;
                        
        }

        #endregion
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    
        private void limpiar()
        {
            txtIDproveedor.Text=null;
            txtCuil.Text=null;
            txtIngreso.Text = null;
            txtNameProveedor.Text = null;
            txtnumFactura.Text= null;
            txtObservaciones.Text = null;
            txtTotal.Text = null;
        }

        private void cbDomicilio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarCompras()
        {
            compras.fecha = dtpfechaFactura.Value;
            compras.observaciones = txtObservaciones.Text;
            compras.proveedor = Convert.ToInt32(txtIDproveedor.Text);
            compras.total = Convert.ToDouble(txtTotal.Text);
            compras.estado = cbEstado.Text;
            compras.numfactura = Convert.ToInt32(txtnumFactura.Text);
            compras.tipofactura = Convert.ToString(cbTipoFactura.SelectedValue);
            
        }

        private bool DataCheck()
        {
            if(txtTotal.Text == null || txtIDproveedor.Text == null || txtnumFactura.Text == null)
            {
                MessageBox.Show("Datos Incompletos");
                return false;
            }
            return true;
        }
             
        itemComprasEntity itemcompra = new itemComprasEntity();
       
        private void cargarItemCompra(DataGridViewRow row)
        {

            itemcompra.idInsumo = Convert.ToInt32(row.Cells["colIDInsumo"].Value);
            itemcompra.marca = Convert.ToString(row.Cells["colMarca"].Value);
            itemcompra.precioUnitario = Convert.ToDouble(row.Cells["colPrecioCompra"].Value);
            itemcompra.subTotal = Convert.ToDouble(row.Cells["colSubTotal"].Value);
            itemcompra.cantidad = Convert.ToInt32(row.Cells["colCantidad"].Value);
            
        }
        
        ComprasEntity compras = new ComprasEntity();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (DataCheck() == false)
            {
                return;
            }
            else
            {
                CargarCompras();
                ComprasB.InsertCompras(compras, txtidCompras);

                foreach (DataGridViewRow row in dgvCompra.Rows)
                {
                    cargarItemCompra(row);
                    itemCompraB.InsertItemCompras(itemcompra, dgvCompra);
                }

                MessageBox.Show("guardado");

            }
            
        }

        private void txtIngreso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            listInsumos form = new listInsumos();
            form.Show(this);
 
        }

        
        private void dgvCompra_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            {
                // Se genera la variable para acumular los SubTotales.
                double total = 0;

                // Se recorre cada fila del DGV.
                foreach (DataGridViewRow row in dgvCompra.Rows)
                {
                    if (row.Cells["colCantidad"].ToString() != string.Empty && row.Cells["colPrecioCompra"].ToString() != string.Empty)
                    {
                        row.Cells["colSubTotal"].Value = Convert.ToInt32(row.Cells["colCantidad"].Value) * Convert.ToDouble(row.Cells["colPrecioCompra"].Value);

                        total += Convert.ToDouble(row.Cells["colSubTotal"].Value);
                    }

                    txtTotal.Text = Convert.ToString(total);
                }
            }
        }

             
        public void AddNewItem(DataGridViewRow row)
        {
            string idinsumo = row.Cells["colIDinsumo"].Value.ToString();
            string insumo = row.Cells["colInsumo"].Value.ToString();
            string rubro = row.Cells["colRubro"].Value.ToString();
            string marca = row.Cells["colMarca"].Value.ToString();

            
            this.dgvCompra.Rows.Add(new[] { idinsumo, insumo, rubro, marca });
            
        }

        
        //public void AddNewItem(DataGridViewRow row)
        //{
        //    string idinsumo = txtIDproveedor.Text;
                       
        //}
       
              
    }
}

