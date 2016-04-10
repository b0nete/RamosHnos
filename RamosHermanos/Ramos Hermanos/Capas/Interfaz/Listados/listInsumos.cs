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
using RamosHermanos.Capas.Interfaz.Contratos;
namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listInsumos : Form
    {
        public int caseSwitch = 1;

        public listInsumos()
        {
            InitializeComponent();
        }

        private void listInsumos_Load(object sender, EventArgs e)
        {
            cbParametro.SelectedIndex = 0;
            InsumoB.cargardgvInsumo(dgvInsumos); 
            
        }

        private void SearchParametro()
        {
            string parametro = '%' + txtParametro.Text + '%';
            InsumoB.CargarDGVParametros(dgvInsumos, cbParametro, parametro);
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            SearchParametro();
        }

        formInsumos frmI = new formInsumos();
        InsumoEntity insumo = new InsumoEntity();

        private void dgvInsumos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (caseSwitch)
            {
                case 1:
                    SeleccionarDgvInsumos();
                    break;
                case 2:
                    SeleccionarDGV();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
        private void SeleccionarDGV()

        {
               
                DataGridViewCell cell = null;
                
                foreach (DataGridViewCell selectedCell in dgvInsumos.SelectedCells)
                {
                    cell = selectedCell;
                    break;
                }
                if (cell != null)
                {

                    DataGridViewRow row = cell.OwningRow;
                    frmI.Show();
                    //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                    insumo.idInsumo = Convert.ToInt32(row.Cells["colIDinsumo"].Value.ToString());

                    InsumoB.BuscarInsumosID(insumo);
                    frmI.txtidInsumo.Text = Convert.ToString(insumo.idInsumo);
                    frmI.dtpFecha.Value = Convert.ToDateTime(insumo.fecha);
                    frmI.txtInsumo.Text = Convert.ToString(insumo.insumo);
                    frmI.txtCantidad.Text = Convert.ToString(insumo.stockMin);
                    frmI.txtDescripcion.Text = Convert.ToString(insumo.descripcion);
                    //frmI.cbMarca.SelectedValue= insumo.marca;
                    frmI.cbProv.SelectedValue = insumo.proveedor;
                    frmI.cbRubro.SelectedValue = insumo.rubro;

                    //frmPro.cbTipoProducto.SelectedValue = producto.tipoProducto;
                    //frmI.txtInsumo.Text= Convert.ToString(insumo.insumo);
                    //frmPro.cbMarca.SelectedValue = producto.marca;
                    //frmPro.txtProducto.Text = producto.producto;
                    //frmPro.txtDescripcion.Text = producto.descripcion;
                    //frmPro.txtCantidad.Text = Convert.ToString(producto.cantidad);
                    //frmPro.cbMedida.SelectedValue = producto.medida;

                    //PrecioProductosB.UltimoPrecioDGV(frmPro.dgvPrecios);
                }
            }

        formCompras frmP = new formCompras();

        private void SeleccionarDgvInsumos()
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvInsumos.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                //DataGridViewRow row = cell.OwningRow;
                
                ////Cargamos el ID de acuerdo a la celda seleccionada y buscamos el producto para cargarlo en tabInformación.
                //insumo.idInsumo = Convert.ToInt32(row.Cells["colIDInsumo"].Value.ToString());

                //InsumoB.AdddInsumoDGV(frmP.dgvCompra, insumo);

                //frmP.Show();
                DataGridViewRow rowA = this.dgvInsumos.CurrentRow as DataGridViewRow;

                IAddItem parent = this.Owner as IAddItem;
                parent.AddNewItem(rowA);

                //this.Close();
                
                
            }
        
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvInsumos.SelectedRows[0] as DataGridViewRow;
            
            IAddItem parent = this.Owner as IAddItem;
            parent.AddNewItem(row);

            this.Close();
        }
                  
      }
       
         
 }
