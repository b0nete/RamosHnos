﻿using System;
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
          insumo.proveedor = Convert.ToInt32(cbProv.SelectedValue);
          insumo.rubro = Convert.ToString(cbRubro.SelectedValue);
          insumo.stockMin = Convert.ToString(txtStockMin.Text);
                
        }

        
        //Chequear que esten completos los campos obligatorios

        private bool VerificarCampos()
        {
            if (cbProv.SelectedValue == null || cbRubro.SelectedValue == null || cbMarca.SelectedValue == null || labelInsumo.Text == string.Empty || txtCantidad.Text == string.Empty || cbMedida.SelectedValue == null || txtStockMin.Text == string.Empty || txtCostoAct.Text == string.Empty )
            {
                MessageBox.Show("Complete los campos Obligatorios");

                return true;
            }
            return false;
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
                insumo.insumo = labelInsumo.Text;
                insumo.marca = cbMarca.Text;
                insumo.proveedor = Convert.ToInt32(cbProv.SelectedValue);
                insumo.rubro = Convert.ToString(txtRubro.Text);
                insumo.stockMin = txtStockMin.Text;

               }
                
            }
       
        
        private void formInsumos_Load(object sender, EventArgs e)
        {

            ProveedorB.CargarProv(cbProv);
            RubroB.CargarRubro(cbRubro);
            MarcaB.CargarCB(cbMarca);
            MedidaB.CargarCB(cbMedida);
            checkcolor();

            
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
            if (VerificarCampos() == true)
            {
                return;
            }
            else
            {
                cargarInsumo(); //cargamos la entidad
                if (InsumoB.ExisteInsumoID(insumo) == true) //verificamos si existe el ID
                {
                   return;                
                }
                else if (InsumoB.ExisteInsumo(insumo) == false) // Verificamos si los datos coinciden con los de otro insumo.
                {
                    return;
                }
                else
                {
                    InsumoB.InsertInsumo(insumo,txtidInsumo);                                       
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

        private void txtCostoAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }
            bool IsDec = false;
            int nroDec = 0;

            for (int i = 0; i < txtCostoAct.Text.Length; i++)
            {
                if (txtCostoAct.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true; 
        }

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

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    
          
    }
  
}
