using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Negocio;
using RamosHnos.Libs;

namespace RamosHnos.Capas.Interfaces
{
    public partial class formProveedor : Form
    {
        public formProveedor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formRubroProveedores frm = new formRubroProveedores();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validación de Campos.   
            if (txtCUIT.MaskFull == false || txtrazonSocial.Text == string.Empty || txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Datos necesarios incompletos.");
                return;
            }
            else
            {
                ProveedorEntity proveedor = new ProveedorEntity()
                {
                    razonSocial = txtrazonSocial.Text,
                    cuit = txtCUIT.Text,
                    email = txtEmail.Text,
                    estado = cbEstado.Checked
                };

                if (ProveedorB.ExisteProveedor(proveedor) == true)
                {
                    DialogResult result = MessageBox.Show("El proveedor existe, desea actualizarlo con los datos ingresados?", "Cliente existente", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        ProveedorB.UpdateProveedor(proveedor);
                    }
                    else
                    {
                        return;
                    }
                }
                else if (ProveedorB.ExisteProveedor(proveedor) == false)
                {
                    ProveedorB.InsertProveedor(proveedor);
                }                
                txtIDproveedor.Text = Convert.ToString(proveedor.idProveedor);
            }
        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            if (txtIDproveedor.Text == "")
            {
                MessageBox.Show("Asigne el proveedor a cargar un Domicilio");
            }
            else
            {
                formDomicilio frmdom = new formDomicilio();
                frmdom.txtID.Text = txtIDproveedor.Text;
                frmdom.txtNombre.Text = txtrazonSocial.Text + ' ' + '-' + ' ' + txtIDproveedor.Text;
                frmdom.Show();

                //Cargar Cliente
                string persona = txtIDproveedor.Text;
                ProveedorB.CargarDomicilioProveedor(frmdom.dgvDomicilio, persona);

                frmdom.cbRoles.SelectedIndex = 1;

                if (frmdom.dgvDomicilio == null)
                {
                    return;
                }
                else
                {
                    frmdom.dgvDomicilio.Columns["idProvincia"].Visible = false;
                    frmdom.dgvDomicilio.Columns["idLocalidad"].Visible = false;
                }  
            }
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            if (txtIDproveedor.Text == "")
            {
                MessageBox.Show("Asigne el proveedor a cargar un Teléfono");
            }
            else
            {
                formTelefono frmtel = new formTelefono();
                frmtel.txtID.Text = txtIDproveedor.Text;
                frmtel.txtNombre.Text = txtrazonSocial.Text + ' ' + '-' + ' ' + txtIDproveedor.Text;
                frmtel.Show();

                //Seleccionar Proveedor de CB.
                frmtel.cbRoles.SelectedIndex = 1;
                int rol = Convert.ToInt32(frmtel.cbRoles.SelectedValue);
                string telefono = frmtel.txtID.Text;
                ProveedorB.MostrarTelefonoProveedor(frmtel.dgvTelefonos, rol, telefono);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txtinCUIT = "";
            txtinCUIT = txtCUIT.Text;

            if (txtCUIT.MaskFull == false)
            {
                MessageBox.Show("Ingrese el CUIT del Proveedor");
                return;
            }

            ProveedorEntity proveedor = new ProveedorEntity
            {
                cuit = txtinCUIT
            };

            ProveedorB.BuscarProveedor(proveedor);

            txtIDproveedor.Text = Convert.ToString(proveedor.idProveedor);
            txtCUIT.Text = proveedor.cuit;
            txtrazonSocial.Text = proveedor.razonSocial;
            txtEmail.Text = proveedor.email;
            cbEstado.Checked = proveedor.estado;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtCUIT.Text == string.Empty)
            {
                return;
            }
            else
            {
                ProveedorEntity proveedor = new ProveedorEntity()
                {
                    idProveedor = Convert.ToInt32(txtIDproveedor.Text),
                    cuit = txtCUIT.Text,
                    razonSocial = txtrazonSocial.Text,
                    email = txtEmail.Text
                };

                ProveedorB.UpdateProveedor(proveedor);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbCliente_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            formListado frm = new formListado();
            frm.Show();

            ProveedorB.ListarProveedores(frm.dgvListado);
        }

        private void txtCUIT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtCUIT.MaskFull == false)
            {
                MessageBox.Show("Ingrese CUIT del Proveedor a desabilitar");
                return;
            }
            else
            {
                string proveedor = txtIDproveedor.Text;
                ProveedorB.DisableProveedor(proveedor, cbEstado);
            }
        }
        }
    }

