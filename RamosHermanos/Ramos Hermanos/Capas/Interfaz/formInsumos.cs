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
using RamosHermanos.Capas.Interfaz.Listados;
using RamosHermanos.Capas.Graficos;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formInsumos : Form
    {
        public int caseSwitch = 2;
        public int tabVar = 0;

        public formInsumos()
        {
            InitializeComponent();
        }

        InsumoEntity insumo = new InsumoEntity();
        public void cargarInsumo()
        {
           
          insumo.estado = cbEstado.Checked;
          insumo.descripcion= txtDescripcion.Text;
          insumo.fecha= dtpFecha.Value;
          insumo.insumo= Convert.ToString(txtInsumo.Text);
          insumo.marca = Convert.ToInt32(cbMarca.SelectedValue);
          insumo.proveedor = Convert.ToInt32(cbProv.SelectedValue);
          insumo.rubro = Convert.ToString(cbRubro.SelectedValue);
          insumo.medida = Convert.ToInt32(cbMedida.SelectedValue);
          insumo.cantidad = Convert.ToDouble(txtCantidad.Text);

          if (rbNR.Checked == true)
              insumo.tipoStock = "NR";
          else if (rbR.Checked == true)
              insumo.tipoStock = "R";
          else if (rbC.Checked == true)
              insumo.tipoStock = "C";
        }

        
        //Chequear que esten completos los campos obligatorios

        private bool VerificarCampos()
        {
            if (txtInsumo.Text== string.Empty || cbProv.SelectedValue == null || cbRubro.SelectedValue == null || cbMarca.SelectedValue == null || labelInsumo.Text == string.Empty || txtCantidad.Text == string.Empty || cbMedida.SelectedValue == null )
            {
                MessageBox.Show("Complete los campos Obligatorios");

                return false;
            }
            return true;
        }

        private void BuscarInsumo()
        {
            if (txtInsumo.Text == string.Empty)
            {
                listInsumos frmlist = new listInsumos();
                frmlist.Show(); ;
                return;
            
            }

            cargarInsumo();

            if (InsumoB.ExisteInsumo(insumo) == false)
            {
                MessageBox.Show("El insumo no existe!");
                return;
            }
            else
            {
                InsumoB.BuscarInsumos(insumo);
                txtidInsumo.Text = Convert.ToString(insumo.idInsumo);
                cbEstado.Checked = insumo.estado;
                txtDescripcion.Text = insumo.descripcion;
                dtpFecha.Value = insumo.fecha;
                txtInsumo.Text = insumo.insumo;
                cbMarca.Text = Convert.ToString(insumo.marca);
                cbProv.SelectedValue = insumo.proveedor;
                txtRubro.Text = insumo.rubro;

               }
                
            }
       
        
        private void formInsumos_Load(object sender, EventArgs e)
        {
            //caseSwitch = 2;
            ProveedorB.CargarProv(cbProv);
            RubroB.CargarRubro(cbRubro);
            MarcaB.CargarCB(cbMarca);
            MedidaB.CargarCB(cbMedida);
            checkcolor();

            switch (tabVar)
            {
                case 0:
                    break;
                case 1:
                    tabMain.SelectedTab = tabPrecio;
                    break;
                case 2:
                    tabMain.Controls.Remove(tabStock);
                    break;
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            formRubro frm = new formRubro();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formMarca frm = new formMarca();
            frm.Show(); 

        }

        private void checkcolor()
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

        private void button4_Click(object sender, EventArgs e)
        {
            formProveedor frm = new formProveedor();
            frm.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarInsumo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (VerificarCampos() == false)
                {
                    return;
                }
                else
                {
                    cargarInsumo();
                    if (InsumoB.ExisteInsumoID(insumo) == true)
                    {
                        MessageBox.Show("El Insumo ya existe");
                        return;
                    }
                    else if ( InsumoB.ExisteInsumo(insumo) == true)
                    {
                        MessageBox.Show("El Insumo ya existe");
                        return;
                    }
                    else
                    {
                        InsumoB.InsertInsumo(insumo, txtidInsumo);
                        //InsumoB.cargardgvInsumo(dgvinsumos);
                    }
                }
            }
                    
    
                        
            
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            checkcolor();
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        //private void txtCostoAct_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 8)
        //    {
        //        e.Handled = false;
        //        return;
        //    }
        //    bool IsDec = false;
        //    int nroDec = 0;

        //    for (int i = 0; i < txtCostoAct.Text.Length; i++)
        //    {
        //        if (txtCostoAct.Text[i] == '.')
        //            IsDec = true;

        //        if (IsDec && nroDec++ >= 2)
        //        {
        //            e.Handled = true;
        //            return;
        //        }
        //    }
        //    if (e.KeyChar >= 48 && e.KeyChar <= 57)
        //        e.Handled = false;
        //    else if (e.KeyChar == 46)
        //        e.Handled = (IsDec) ? true : false;
        //    else
        //        e.Handled = true; 
        //}

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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
                    MessageBox.Show("Solo se permiten Números Enteros");
                } 
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
                    MessageBox.Show("Solo se permiten Números");
                } 
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        //private void SeleccionarDGV()
        //{
        //    DataGridViewCell cell = null;
        //    foreach (DataGridViewCell selectedCell in dgvinsumos.SelectedCells)
        //    {
        //        cell = selectedCell;
        //        break;
        //    }
        //    if (cell != null)
        //    {
        //        DataGridViewRow row = cell.OwningRow;

        //        //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.
        //        insumo.insumo =Convert.ToString(row.Cells["colInsumo"].Value);
                
        //        InsumoB.BuscarInsumos(insumo);
        //       // insumo.idInsumo = Convert.ToInt32(txtidInsumo.Text);
        //        dtpFecha.Value = insumo.fecha;
        //        cbProv.SelectedValue = insumo.proveedor;
        //        txtInsumo.Text = insumo.insumo;
        //        txtRubro.Text = insumo.rubro;
        //        cbMarca.Text = insumo.marca;

        //        tabMain.SelectedTab = tabInformacion;
             

        //    }
        //}

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvinsumos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //SeleccionarDGV();
        }

        private void cbProv_DropDown(object sender, EventArgs e)
        {
            ProveedorB.CargarProv(cbProv);
           
        }

        private void cbProv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void cbMarca_DropDown(object sender, EventArgs e)
        {
            MarcaB.CargarCB(cbMarca);
            
        }

        private void tabInformacion_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            
            listInsumos frm = new listInsumos();
            frm.Show();
            frm.caseSwitch = 2;
            //string parametro = '%' + frm.txtParametro.Text + '%';
            //InsumoB.CargarDGVParametros(frm.dgvInsumos, frm.cbParametro, parametro);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void cbRubro_DropDown(object sender, EventArgs e)
        {
            RubroB.CargarRubro(cbRubro);
        }

        private void dtpfechaFactura_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void txtnewPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
        
        StockInsumoEntity stock = new StockInsumoEntity();
        private void CargarStock()
        {
            stock.idInsumo = Convert.ToInt32(txtidInsumo.Text);
            stock.stockMinimo = Convert.ToInt32(txtStockMin.Text);
            stock.stockMaximo = Convert.ToInt32(txtStockMax.Text);
            stock.fechaActualizacion = Convert.ToDateTime(dtpfechaStock.Value);
        }

        private bool VerificarCamposStock()
        {
            if (txtStockA.Text == null)
            {
                MessageBox.Show("Por favor, complete los campos necesarios");

                return false;
            }
            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (VerificarCamposStock() == false)
            {
                return;
            }
            else
            {
                if (StockInsumoB.ExisteStock(Convert.ToInt32(txtidInsumo.Text)) == true)
                {
                    CargarStock();
                    StockInsumoB.UpdateStockInicial(stock);
                }
                else
                {
                    CargarStock();
                    StockInsumoB.InsertStock(stock);
                }
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (txtnewPrecio.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un precio");
            }
            else
            {
                //Desabilitamos todos los precios anteriores del mismo producto.
                int idInsumo = Convert.ToInt32(txtidInsumo.Text);
                PrecioInsumosB.DisablePrecio(idInsumo);

                //Insertamos el nuevo precio.
                precio.insumo = Convert.ToInt32(txtidInsumo.Text);
                precio.precio = Convert.ToDouble(txtnewPrecio.Text);
                PrecioInsumosB.InsertPrecio(precio);
                //Actualizamos DGV
                PrecioInsumosB.UltimoPrecioDGV(dgvPrecios, txtidInsumo);
            }
        }

        //Entidades
        PrecioInsumoEntity precio = new PrecioInsumoEntity();

        private void txtnewPrecio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnewPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 44 && ch == 46 && txtnewPrecio.Text.IndexOf(',') != -1)
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

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            formGInsumos frm = new formGInsumos();
            frm.Show();

            frm.txtID.Text = txtidInsumo.Text;
            frm.lblTitle.Text = txtInsumo.Text;
        }

        private void dgvPrecios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }  
          
    }
  
}
