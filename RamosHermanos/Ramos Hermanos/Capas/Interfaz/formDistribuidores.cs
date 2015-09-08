using System;
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

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formDistribuidores : Form
    {
        public formDistribuidores()
        {
            InitializeComponent();
        }

        // Eventos

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void formDistribuidores_Load(object sender, EventArgs e)
        {
            //tabInformacion
            VehiculoB.CargarCB(cbVehiculo);
            CheckColor(cbEstado, lblEstado);
            dtpNacimiento.MaxDate = DateTime.Today;
            tipoDocB.CargarTipoDoc(cbTipoDoc);
            cbSexo.SelectedIndex = 0;
            cbEstadoCivil.SelectedIndex = 0;
            CheckColor(cbEstado, lblEstado);
            DistribuidorB.CargarDGV(dgvDistribuidores);
            
            //tabVehiculos
            VehiculoB.CargarDGV(dgvVehiculos);
            CheckColor(cbEstadoVeh, lblEstadoVeh);
        }

        private void btnSaveVehi_Click(object sender, EventArgs e)
        {
            CargarVehiculo();
            VehiculoB.InsertVehiculo(vehiculo, txtIDvehiculo);
            VehiculoB.CargarDGV(dgvVehiculos);
        }

        private void btnUpdVeh_Click(object sender, EventArgs e)
        {
            CargarVehiculo();
            VehiculoB.UpdateVehiculo(vehiculo);
            VehiculoB.CargarDGV(dgvVehiculos);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
            {
                return;
            }
            else
            {
                distribuidor.numDoc = txtnumDoc.Text;
                if (DistribuidorB.ExisteDistribuidor(distribuidor) == true)
                {
                    DialogResult result = MessageBox.Show("El distribuidor existe, desea actualizarlo con los datos ingresados?", "distribuidor existente", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        CargarDistribuidor();
                        DistribuidorB.UpdateDistribuidor(distribuidor);
                        DistribuidorB.CargarDGV(dgvDistribuidores);

                        BuscarDistribuidor();
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
                else if (DistribuidorB.ExisteDistribuidor(distribuidor) == false)
                {
                    CargarDistribuidor();
                    DistribuidorB.InsertDistribuidores(distribuidor, txtIDdistribuidor);

                    DistribuidorB.CargarDGV(dgvDistribuidores);
                }
            }
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string clr = cbColor.Text;
            Color colour = Color.FromName(clr);

            btnColor.BackColor = colour;
        }

        private void cbEstadoVeh_CheckedChanged(object sender, EventArgs e)
        {
            CheckColor(cbEstadoVeh, lblEstadoVeh);
        }

        private void dgvVehiculos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvVehiculos.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el distribuidor para cargarlo en tabInformación.

                vehiculo.patente = row.Cells["colPatente"].Value.ToString();

                VehiculoB.BuscarVehiculoPatente(vehiculo);
                txtIDvehiculo.Text = Convert.ToString(vehiculo.idVehiculo);
                cbMarca.Text = vehiculo.marca;
                nudModelo.Value = Convert.ToDecimal(vehiculo.modelo);
                txtPatente.Text = vehiculo.patente;
                cbColor.Text = vehiculo.color;
                cbEstadoVeh.Checked = vehiculo.estado;
            }
        }

        private void dgvDistribuidores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvDistribuidores.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el distribuidor para cargarlo en tabInformación.

                distribuidor.numDoc = row.Cells["colnumDoc"].Value.ToString();

                DistribuidorB.BuscarDistribuidorDOC(distribuidor);
                txtIDdistribuidor.Text = Convert.ToString(distribuidor.idDistribuidor);
                dtpFechaAlta.Value = distribuidor.fechaAlta;
                cbTipoDoc.SelectedValue = distribuidor.tipoDoc;
                txtnumDoc.Text = distribuidor.numDoc;
                cbSexo.Text = distribuidor.sexo;
                txtCUIL.Text = distribuidor.cuil;
                txtApellido.Text = distribuidor.apellido;
                txtNombre.Text = distribuidor.nombre;
                cbEstadoCivil.Text = distribuidor.estadoCivil;
                cbVehiculo.SelectedValue = distribuidor.vehiculo;
                cbEstado.Checked = distribuidor.estado;

                DomicilioB.CargarTXT(txtDomic, txtIDdistribuidor, 3);
                EmailB.CargarTXT(txtEmail, txtIDdistribuidor, 3);
                TelefonoB.CargarTXT(txtTel, txtIDdistribuidor, 3);

                tabDistribuidor.SelectedTab = tabInformacion;
            }
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {
            CheckColor(cbEstado, lblEstado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == false)
            {
                return;
            }
            else
            {
                if (txtIDdistribuidor.Text == string.Empty)
                {
                    DialogResult result1 = MessageBox.Show("Seleccione un distribuidor", "Advertencia!", MessageBoxButtons.OK);
                    if (result1 == DialogResult.OK)
                    {
                        tabDistribuidor.SelectedTab = tabListado;
                        return;
                    }
                    return;
                }
                DialogResult result = MessageBox.Show("Desea actualizar los datos del distribuidor?", "Actualizar", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    CargarDistribuidor();
                    DistribuidorB.UpdateDistribuidor(distribuidor);
                    DistribuidorB.CargarDGV(dgvDistribuidores);
                }
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarDistribuidor();
        }   

        // Metodos

        private void CheckColor(CheckBox cb, Label lbl)
        {
            if (cb.Checked == true)
            {
                lbl.BackColor = Color.Green;
                lbl.Text = "Habilitado";
            }
            else
            {
                lbl.BackColor = Color.Red;
                lbl.Text = "Desabilitado";
            }
        }

        private bool ValidarCampos() //Verificar valores necesarios cargados.
        {
            if (txtnumDoc.Text == string.Empty || txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtCUIL.MaskFull == false)
            {
                MessageBox.Show("Datos necesarios incompletos.");
                return false;
            }
            return true;
        }

        private void BuscarDistribuidor()
        {
            if (txtnumDoc.Text == "")
            {
                tabDistribuidor.SelectedTab = tabListado;
                return;
            }

            CargarDistribuidor();

            if (DistribuidorB.ExisteDistribuidor(distribuidor) == false)
            {
                MessageBox.Show("El distribuidor no existe!");
                return;
            }
            else
            {
                DistribuidorB.BuscarDistribuidorDOC(distribuidor);                          
                txtIDdistribuidor.Text = Convert.ToString(distribuidor.idDistribuidor);
                dtpFechaAlta.Value = distribuidor.fechaAlta;
                cbTipoDoc.SelectedValue = distribuidor.tipoDoc;
                txtnumDoc.Text = distribuidor.numDoc;
                dtpNacimiento.Value = distribuidor.fechaNacimiento;
                cbSexo.Text = distribuidor.sexo;
                txtCUIL.Text = distribuidor.cuil;
                txtApellido.Text = distribuidor.apellido;
                txtNombre.Text = distribuidor.nombre;
                cbEstadoCivil.Text = distribuidor.estadoCivil;
                cbVehiculo.SelectedValue = distribuidor.vehiculo;
                cbEstado.Checked = distribuidor.estado;

                //Contacto
                DomicilioB.CargarTXT(txtDomic, txtIDdistribuidor, 3);
                EmailB.CargarTXT(txtEmail, txtIDdistribuidor, 3);
                TelefonoB.CargarTXT(txtTel, txtIDdistribuidor, 3);
            }

            CheckColor(cbEstado, lblEstado);
            
        }

        // Entidades

        DistribuidorEntity distribuidor = new DistribuidorEntity();
        private void CargarDistribuidor()
        {
            distribuidor.rol = 3;
            distribuidor.fechaAlta = dtpFechaAlta.Value;
            distribuidor.tipoDoc = Convert.ToInt32(cbTipoDoc.SelectedValue);
            distribuidor.numDoc = txtnumDoc.Text;
            distribuidor.fechaNacimiento = dtpNacimiento.Value;
            distribuidor.sexo = cbSexo.Text;
            distribuidor.cuil = txtCUIL.Text;
            distribuidor.apellido = txtApellido.Text;
            distribuidor.nombre = txtNombre.Text;
            distribuidor.estadoCivil = cbEstadoCivil.Text;
            distribuidor.vehiculo = Convert.ToInt32(cbVehiculo.SelectedValue);
            distribuidor.estado = cbEstado.Checked;         
        }

        VehiculoEntity vehiculo = new VehiculoEntity();
        private void CargarVehiculo()
        {
            vehiculo.marca = cbMarca.Text;
            vehiculo.modelo = Convert.ToString(nudModelo.Value);
            vehiculo.patente = txtPatente.Text;
            vehiculo.color = cbColor.Text;
            vehiculo.estado = cbEstado.Checked;
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (txtIDdistribuidor.Text == string.Empty)
            {
                MessageBox.Show("Por favor, ingrese un distribuidor");
            }
            else
            {
                formContacto frm = new formContacto();
                frm.txtIDALL.Text = txtIDdistribuidor.Text;
                frm.tabVar = 2;
                frm.Show();
                frm.cbRolALL.SelectedValue = 3;
                frm.txtNombreEmail.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreDom.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreTel.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.CargarDGVs();
            }
        }

        private void btnDomicilio_Click(object sender, EventArgs e)
        {
            if (txtIDdistribuidor.Text == string.Empty)
            {
                MessageBox.Show("Por favor, ingrese un distribuidor");
            }
            else
            {
                formContacto frm = new formContacto();
                frm.txtIDALL.Text = txtIDdistribuidor.Text;
                frm.tabVar = 3;
                frm.Show();
                frm.cbRolALL.SelectedValue = 3;
                frm.txtNombreEmail.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreDom.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreTel.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.CargarDGVs();
            }
        }

        private void btnTelefono_Click(object sender, EventArgs e)
        {
            if (txtIDdistribuidor.Text == string.Empty)
            {
                MessageBox.Show("Por favor, ingrese un distribuidor");
            }
            else
            {
                formContacto frm = new formContacto();
                frm.txtIDALL.Text = txtIDdistribuidor.Text;
                frm.tabVar = 1;
                frm.Show();
                frm.cbRolALL.SelectedValue = 3;
                frm.txtNombreEmail.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreDom.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.txtNombreTel.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.CargarDGVs();
            }
        }

        
 
    }
}
