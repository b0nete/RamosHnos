using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHnos.Capas.Negocio;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Interfaces;

namespace RamosHnos
{
    public partial class formDomicilio : Form
    {
        public formDomicilio()
        {
            InitializeComponent();
        }

        private void formDomicilio_Load(object sender, EventArgs e)
        {
            //Cargar Provincia
            ProvinciaB.CargarProvincia(cbProvincia);

            //Cargar Localidad
            LocalidadEntity localidad = new LocalidadEntity()
            {
                provincia = Convert.ToInt32(cbProvincia.SelectedValue)
            };
            LocalidadB.CargarLocalidad(cbLocalidad, localidad);

            //Mostrar Roles
            RolB.MostrarRolesCB(cbRoles);

            dgvDomicilio.Columns["idProvincia"].Visible = false;
            dgvDomicilio.Columns["idLocalidad"].Visible = false;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formProvincia frm = new formProvincia();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formLocalidad frm = new formLocalidad();
            frm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DomicilioEntity domicilio = new DomicilioEntity()
            {
                rol = Convert.ToInt32(cbRoles.SelectedValue),
                idPersona = Convert.ToInt32(txtID.Text),
                provincia = Convert.ToInt32(cbProvincia.SelectedValue),
                localidad = Convert.ToInt32(cbLocalidad.SelectedValue),
                calle = txtCalle.Text,
                numero = txtnumCalle.Text,
                piso = txtPiso.Text,
                dpto = txtDpto.Text,
                CP = txtCP.Text
            };

            DomicilioB.InsertDomicilio(domicilio);

            //int seleccion = Convert.ToInt32(cbRoles.SelectedValue);

            int seleccion = Convert.ToInt32(cbRoles.SelectedValue);
            string persona = txtID.Text;
            switch (seleccion)
            {                
                case 1:                    
                    ClienteB.CargarDomicilioCliente(dgvDomicilio, persona);
                    break;
                case 2:                    
                    ProveedorB.CargarDomicilioProveedor(dgvDomicilio, persona);
                    break;
            }
            //if (Convert.ToInt32(cbRoles.SelectedValue) == 1)
            //{
            //    string persona = txtID.Text;
            //    ClienteB.CargarDomicilioCliente(dgvDomicilio, persona);
            //}
            //else if (Convert.ToInt32(cbRoles.SelectedValue) == 2)
            //{
            //    string persona = txtID.Text;
            //    ProveedorB.CargarDomicilioProveedor(dgvDomicilio, persona);
            //}         
        }


        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadEntity localidad = new LocalidadEntity()
            {
                provincia = Convert.ToInt32(cbProvincia.SelectedValue)
            };

            LocalidadB.CargarLocalidad(cbLocalidad, localidad);
        }
                
        private void cbProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            //LocalidadEntity localidad = new LocalidadEntity()
            //{
            //    provincia = Convert.ToInt32(cbProvincia.SelectedValue)
            //};

            //LocalidadB.CargarLocalidad(cbLocalidad, localidad);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Cargar Cliente
            string cliente = txtID.Text;
            ClienteB.CargarDomicilioCliente(dgvDomicilio, cliente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProvincia_DropDown(object sender, EventArgs e)
        {
            ProvinciaB.CargarProvincia(cbProvincia);
        }

        private void cbProvincia_SelecionChangeCommitted(object sender, EventArgs e)
        {
            LocalidadEntity localidad = new LocalidadEntity()
            {
                provincia = Convert.ToInt32(cbProvincia.SelectedValue)
            };

            LocalidadB.CargarLocalidad(cbLocalidad, localidad);
        }

        private void dgvDomicilio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0 )
            //{
            //    DataGridViewRow row = this.dgvDomicilio.Rows[e.RowIndex];

            //    cbProvincia.SelectedText = row.Cells["Provincia"].Value.ToString();
            //    cbLocalidad.SelectedText = row.Cells["Localidad"].Value.ToString();
            //    txtCalle.Text = row.Cells["Calle"].Value.ToString();
            //    txtnumCalle.Text = row.Cells["Numero"].Value.ToString();
            //    txtPiso.Text = row.Cells["Piso"].Value.ToString();
            //    txtDpto.Text = row.Cells["Dpto"].Value.ToString();
            //    txtCP.Text = row.Cells["CP"].Value.ToString();                
            //}
        }

        private void dgvDomicilio_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvDomicilio.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                cbProvincia.SelectedValue = row.Cells["idProvincia"].Value;
                cbLocalidad.SelectedValue = row.Cells["idLocalidad"].Value;
                txtCalle.Text = row.Cells["Calle"].Value.ToString();
                txtnumCalle.Text = row.Cells["Numero"].Value.ToString();
                txtPiso.Text = row.Cells["Piso"].Value.ToString();
                txtDpto.Text = row.Cells["Dpto"].Value.ToString();
                txtCP.Text = row.Cells["CP"].Value.ToString();
            }
        }

        private void cbLocalidad_DropDown(object sender, EventArgs e)
        {
            LocalidadEntity localidad = new LocalidadEntity()
            {
                provincia = Convert.ToInt32(cbProvincia.SelectedValue)
            };

            LocalidadB.CargarLocalidad(cbLocalidad, localidad);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
