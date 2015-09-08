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

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formInsumos : Form
    {
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
          insumo.insumo= txtInsumo.Text;
          insumo.marca = cbMarca.Text;
          insumo.proveedor = Convert.ToInt32(cbProv.Text);
          insumo.rubro = Convert.ToInt32(txtRubro.Text);
          insumo.stockMin = txtStockMin.Text;
                
        }

        
        //Chequear que esten completos los campos obligatorios

        private bool VerificarCampos()
        {
            if (cbProv.SelectedValue == null || cbRubro.SelectedValue == null || cbMarca.SelectedValue == null || txtProducto.Text == string.Empty || txtCantidad.Text == string.Empty || cbMedida.SelectedValue == null || txtStockMin.Text == string.Empty || txtStockActual.Text == string.Empty)
            {
                MessageBox.Show("Complete los campos Obligatorios");

                return false;
            }
            return true;
        }

        private void BuscarInsumo()
        {
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

                insumo.estado = cbEstado.Checked;
                insumo.descripcion = txtDescripcion.Text;
                insumo.fecha = dtpFecha.Value;
                insumo.insumo = txtInsumo.Text;
                insumo.marca = cbMarca.Text;
                insumo.proveedor = Convert.ToInt32(cbProv.Text);
                insumo.rubro = Convert.ToInt32(txtRubro.Text);
                insumo.stockMin = txtStockMin.Text;

               }
                
            }

        private void GuardarInsumo()
        {
            if (VerificarCampos() == false)
            {
                return;
            }
            else
            {
                insumo.idInsumo = Convert.ToInt32(txtidInsumo.Text);
                if(InsumoB.ExisteInsumo(insumo) == true)
                {
                 
                    DialogResult result = MessageBox.Show("¿El Insumo ya existe, desea Actualizarlo?" , "Insumo Existente" , MessageBoxButtons.OKCancel);
                    
                    if (result == DialogResult.OK)
                    {
                        
                        cargarInsumo();
                        InsumoB.UpdateInsumo(insumo);




                        BuscarInsumo();
                        return;
                    }
                    {
                        return;
                    }
                }
                else if (InsumoB.ExisteInsumo(insumo) == false)
                {

                    cargarInsumo();
                    InsumoB.InsertInsumo(insumo, txtidInsumo);
                    
                              
                }
            
            
            }
        
        
        }
        private void formInsumos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarInsumo();
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

        
    }
}
