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
using RamosHermanos.Capas.Reportes.Recorridos;
using RamosHermanos.Capas.Interfaz.Listados;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formDistribuidores : Form, IAddItemDGV
    {
        public int tabVar;
        public int addItemVar;

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
            //Tab Inicial
            switch (tabVar)
            {
                case 0:
                    tabDistribuidor.SelectedTab = tabRecorrido;
                    break;
                case 1:
                    //tabDistribuidor.SelectedTab;
                    break;
                   
            }
            //Tabs Ocultos
            //tabDistribuidor.Controls.Remove(tabListado);

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
        
        //Tabs Cases
        public void CaseListado()
        {
            tabDistribuidor.Controls.Remove(tabInformacion);
            tabDistribuidor.Controls.Remove(tabVehiculos);
            tabDistribuidor.Controls.Remove(tabHojaRuta);
            tabDistribuidor.Controls.Remove(tabListado);
            tabDistribuidor.Controls.Remove(tabRecorrido);
            tabDistribuidor.Controls.Add(tabListado);
        }

        public void CaseNuevo()
        {
            tabDistribuidor.Controls.Remove(tabInformacion);
            tabDistribuidor.Controls.Remove(tabVehiculos);
            tabDistribuidor.Controls.Remove(tabHojaRuta);
            tabDistribuidor.Controls.Remove(tabListado);
            tabDistribuidor.Controls.Remove(tabRecorrido);
            tabDistribuidor.Controls.Add(tabInformacion);           
        }

        public void CaseDistribuidor()
        {
            tabDistribuidor.Controls.Remove(tabInformacion);
            tabDistribuidor.Controls.Remove(tabVehiculos);
            tabDistribuidor.Controls.Remove(tabHojaRuta);
            tabDistribuidor.Controls.Remove(tabListado);
            tabDistribuidor.Controls.Remove(tabRecorrido);
            tabDistribuidor.Controls.Add(tabInformacion);
            tabDistribuidor.Controls.Add(tabRecorrido);
        }

        public void CaseVehiculo()
        {
            tabDistribuidor.Controls.Remove(tabInformacion);
            tabDistribuidor.Controls.Remove(tabVehiculos);
            tabDistribuidor.Controls.Remove(tabHojaRuta);
            tabDistribuidor.Controls.Remove(tabListado);
            tabDistribuidor.Controls.Remove(tabRecorrido);
            tabDistribuidor.Controls.Add(tabVehiculos);
        }

        private void btnSaveVehi_Click(object sender, EventArgs e)
        {
            if (ValidarVehiculo() == false)
            {
                return;
            }
            else
            {
                CargarVehiculo();
                VehiculoB.InsertVehiculo(vehiculo, txtIDvehiculo);
                VehiculoB.CargarDGV(dgvVehiculos);
            }           
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
                    CaseDistribuidor();

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

                //Se completa el tabRecorrido
                string strDia = "LU";
                CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, txtIDRecorridoLu);

                if (txtIDRecorridoLu.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridoLu.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, dgvRecorridoLu);
                }

                strDia = "MA";
                CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, txtIDRecorridoMa);

                if (txtIDRecorridoMa.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridoMa.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, dgvRecorridoMa);
                }

                strDia = "MI";
                CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, txtIDRecorridoMi);

                if (txtIDRecorridoMi.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridoMi.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, dgvRecorridoMi);
                }

                strDia = "JU";
                CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, txtIDRecorridoJu);

                if (txtIDRecorridoJu.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridoJu.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, dgvRecorridoJu);
                }

                strDia = "VI";
                CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, txtIDRecorridoVi);

                if (txtIDRecorridoVi.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridoVi.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, dgvRecorridoVi);
                }

                strDia = "SA";
                CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, txtIDRecorridoSa);

                if (txtIDRecorridoSa.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridoSa.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, dgvRecorridoSa);
                }

                strDia = "DO";
                CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, txtIDRecorridoDo);

                if (txtIDRecorridoDo.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridoDo.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, dgvRecorridoDo);
                }

                //Case
                CaseDistribuidor();
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
            if (txtnumDoc.Text == string.Empty || txtNombre.Text == string.Empty || txtApellido.Text == string.Empty || txtCUIL.MaskFull == false || cbVehiculo.SelectedValue == null)
            {
                MessageBox.Show("Datos necesarios incompletos.");
                return false;
            }
            return true;
        }

        private bool ValidarVehiculo() //Verificar valores necesarios cargados.
        {
            if (cbMarca.SelectedText == "" || cbColor.SelectedValue == null || txtPatente.MaskFull == false)
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
                listDistribuidores frm = new listDistribuidores();
                frm.Show();
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
                lblTitle.Text = DistribuidorB.BuscarNombreDistribuidor(distribuidor.idDistribuidor);  
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
        public void CargarVehiculo()
        {
            vehiculo.marca = cbMarca.Text;
            vehiculo.modelo = Convert.ToString(nudModelo.Value);
            vehiculo.patente = txtPatente.Text;
            vehiculo.color = cbColor.Text;
            vehiculo.estado = cbEstado.Checked;
        }

        RecorridoEntity recorrido = new RecorridoEntity();
        public void CargarRecorrido(string strDia)
        {
            recorrido.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
            recorrido.dia = strDia;
        }

        itemRecorridoEntity itemRecorrido = new itemRecorridoEntity();
        private void CargarItemRecorrido(DataGridViewRow row, string dia, TextBox txtIDRecorridoDia)
       { 
            itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridoDia.Text);
            itemRecorrido.calle = Convert.ToInt32(row.Cells["col"+ dia +"IDcalle"].Value);
            itemRecorrido.desde = Convert.ToInt32(row.Cells["col"+ dia +"Desde"].Value);
            itemRecorrido.hasta = Convert.ToInt32(row.Cells["col"+ dia +"Hasta"].Value);
            itemRecorrido.sentido = Convert.ToString(row.Cells["col"+ dia +"Sentido"].Value);

            //if (itemRecorrido.desde < itemRecorrido.hasta)
            //    // "M" = Mano
            //    itemRecorrido.sentido = "M";
            //else if (itemRecorrido.desde > itemRecorrido.hasta)
            //    // "C" = ContraMano
            //    itemRecorrido.sentido = "C";

            itemRecorrido.estado = Convert.ToBoolean(row.Cells["col"+ dia +"Estado"].Value);
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
                frm.lblTitleEmail.Text = txtIDdistribuidor.Text + " - " + txtApellido.Text + " " + txtNombre.Text;
                frm.lblTitleDom.Text = txtIDdistribuidor.Text + " - " + txtApellido.Text + " " + txtNombre.Text;
                frm.lblTitleTel.Text = txtIDdistribuidor.Text + " - " + txtApellido.Text + " " + txtNombre.Text;
                //frm.lblTitleEmail.Text = DistribuidorB.BuscarNombreDistribuidor(distribuidor.idDistribuidor);
                //frm.lblTitleDom.Text = DistribuidorB.BuscarNombreDistribuidor(distribuidor.idDistribuidor);
                //frm.lblTitleTel.Text = DistribuidorB.BuscarNombreDistribuidor(distribuidor.idDistribuidor);
                //frm.txtNombreEmail.Text = txtNombre.Text + " " + txtApellido.Text;
                //frm.txtNombreDom.Text = txtNombre.Text + " " + txtApellido.Text;
                //frm.txtNombreTel.Text = txtNombre.Text + " " + txtApellido.Text;
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
                frm.lblTitleEmail.Text = txtIDdistribuidor.Text + " - " + txtApellido.Text + " " + txtNombre.Text;
                frm.lblTitleDom.Text = txtIDdistribuidor.Text + " - " + txtApellido.Text + " " + txtNombre.Text;
                frm.lblTitleTel.Text = txtIDdistribuidor.Text + " - " + txtApellido.Text + " " + txtNombre.Text;
                //frm.lblTitleEmail.Text = DistribuidorB.BuscarNombreDistribuidor(distribuidor.idDistribuidor);
                //frm.lblTitleDom.Text = DistribuidorB.BuscarNombreDistribuidor(distribuidor.idDistribuidor);
                //frm.lblTitleTel.Text = DistribuidorB.BuscarNombreDistribuidor(distribuidor.idDistribuidor);
                //frm.txtNombreEmail.Text = txtNombre.Text + " " + txtApellido.Text;
                //frm.txtNombreDom.Text = txtNombre.Text + " " + txtApellido.Text;
                //frm.txtNombreTel.Text = txtNombre.Text + " " + txtApellido.Text;
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
                frm.lblTitleEmail.Text = txtIDdistribuidor.Text + " - " + txtApellido.Text + " " + txtNombre.Text;
                frm.lblTitleDom.Text = txtIDdistribuidor.Text + " - " + txtApellido.Text + " " + txtNombre.Text;
                frm.lblTitleTel.Text = txtIDdistribuidor.Text + " - " + txtApellido.Text + " " + txtNombre.Text;
                //frm.lblTitleEmail.Text = DistribuidorB.BuscarNombreDistribuidor(distribuidor.idDistribuidor);
                //frm.lblTitleDom.Text = DistribuidorB.BuscarNombreDistribuidor(distribuidor.idDistribuidor);
                //frm.lblTitleTel.Text = DistribuidorB.BuscarNombreDistribuidor(distribuidor.idDistribuidor);
                //frm.txtNombreEmail.Text = txtNombre.Text + " " + txtApellido.Text;
                //frm.txtNombreDom.Text = txtNombre.Text + " " + txtApellido.Text;
                //frm.txtNombreTel.Text = txtNombre.Text + " " + txtApellido.Text;
                frm.CargarDGVs();
            }
        }

        private void cbVehiculo_DropDown(object sender, EventArgs e)
        {
            VehiculoB.CargarCB(cbVehiculo);
        }

        // Contratos

        //#region IAddItem Members

        public void AddNewItem(DataGridViewRow row, int VAR)
        {
            string idCalle = row.Cells["colCIDcalle"].Value.ToString();
            string calle = row.Cells["colCCalle"].Value.ToString();
            string check = "true";


            switch (VAR)
            {
                //Lu
                case 1:
                    Console.WriteLine("Lu");
                    this.dgvRecorridoLu.Rows.Add(new[] { idCalle, calle, "", "", "", check });
                    break;
                //Ma
                case 2:
                    Console.WriteLine("Ma");
                    this.dgvRecorridoMa.Rows.Add(new[] { idCalle, calle, "", "", "", check });
                    break;
                //Mi
                case 3:
                    Console.WriteLine("Mi");
                    this.dgvRecorridoMi.Rows.Add(new[] { idCalle, calle, "", "", "", check });
                    break;
                //Ju
                case 4:
                    Console.WriteLine("Ju");
                    this.dgvRecorridoJu.Rows.Add(new[] { idCalle, calle, "", "", "", check });
                    break;
                //Vi
                case 5:
                    Console.WriteLine("Vi");
                    this.dgvRecorridoVi.Rows.Add(new[] { idCalle, calle, "", "", "", check });
                    break;
                //Sa
                case 6:
                    Console.WriteLine("Sa");
                    this.dgvRecorridoSa.Rows.Add(new[] { idCalle, calle, "", "", "", check });
                    break;
                case 7:
                    Console.WriteLine("Do");
                    this.dgvRecorridoDo.Rows.Add(new[] { idCalle, calle, "", "", "", check });
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            //this.dgvRecorridoLu.Rows.Add(new[] {idCalle, calle, "", "", "", check});
        }

        //#endregion

        //interface IAddItem
        //{
        //    void AddNewItem(DataGridViewRow row);
        //}

        

        

        private void button2_Click(object sender, EventArgs e)
        {
            formVehiculo frm = new formVehiculo();
            frm.Show();
            
            //tabDistribuidor.Controls.Add(tabVehiculos);
            //tabDistribuidor.SelectedTab = tabVehiculos;
        }

        private void tabDistribuidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabDistribuidor.SelectedTab != tabVehiculos)
            {
                tabDistribuidor.Controls.Remove(tabVehiculos);     
            }                   
        }

        

        private void btnDown_Click(object sender, EventArgs e)
        {
            DataGridView grid = dgvRecorridoLu;
            try
            {
                int totalRows = grid.Rows.Count;
                int idx = grid.SelectedCells[0].OwningRow.Index;
                if (idx == totalRows - 2)
                    return;
                int col = grid.SelectedCells[0].OwningColumn.Index;
                DataGridViewRowCollection rows = grid.Rows;
                DataGridViewRow row = rows[idx];
                rows.Remove(row);
                rows.Insert(idx + 1, row);
                grid.ClearSelection();
                grid.Rows[idx + 1].Cells[col].Selected = true;
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Tutorial: https://www.youtube.com/watch?v=Ax4dLk9xPec

            string ruta = Application.StartupPath.Replace(@"\bin\Debug", "");
            string rep = @"\Capas\Reportes\Recorridos\crRecorridos.rpt";

            // dsHojaRuta contiene dtRecorrido y dtItemsRecorrido
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();

            if (dgvRecorridoLu.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningun recorrido, no se puede generar reparto!");
            }
            else
            {
                // Verificamos que ya no se haya generado un reparto para ese mismo día y el mismo distribuidor.
                reparto.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
                reparto.fecha = DateTime.Today;
                reparto.dia = "Lu";

                if (RepartoB.ExisteReparto(reparto) == true)
                {
                    RepartoB.BuscarReparto(reparto);

                    itemsReparto.reparto = reparto.idReparto;
                    dt = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    //foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    //{
                    //    dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(dRow.Cells["colIDCliente"].Value));
                    //    dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    //    dRow.Cells["colCobro"].Value = FacturaB.EstadoPago(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    //}
                }
                else
                {
                    ds = GenerarReparto(dgvRecorridoLu, "Lu", txtIDRecorridoLu, "colLuSentido", "colLuIDcalle");

                    RepartoB.BuscarReparto(reparto);

                    itemsReparto.reparto = reparto.idReparto;
                    dt = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    //foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    //{
                    //    dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(dRow.Cells["colIDCliente"].Value));
                    //    dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    //    dRow.Cells["colCobro"].Value = FacturaB.EstadoPago(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    //}
                }

                //frm.setRowNumber(frm.dgvRepartos);

                //Cargar Reporte
                formReports frm1 = new formReports();
                frm1.Show();
                ReportDocument rd = new ReportDocument();
                rd.Load(ruta + rep);
                //rd.Load("C:/Users/b0nete/Documents/GitHub/RamosHnos/RamosHermanos/Ramos Hermanos/Capas/Reportes/Recorridos/crFactura.rpt");

                //
                dt.TableName = "mydtimage";

                if (!ds.Tables.Contains(dt.TableName))
                    ds.Tables.Add(dt);
                //

                ds = GenerarReparto(dgvRecorridoLu, "Lu", txtIDRecorridoLu, "colLuSentido", "colLuIDcalle"); 

                rd.SetDataSource(ds);
                frm1.crvReporte.ReportSource = rd;
            }
        }

        private void GetFecha(out string fechaRecorrido, out string diaSemana)
        {
            // Change current culture to fr-FR
            CultureInfo originalCulture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("Es-Es");

            DateTime dateValue = new DateTime();
            dateValue = DateTime.Today;
            // Display the DayOfWeek string representation
            fechaRecorrido = Convert.ToString(dateValue);
            diaSemana = dateValue.ToString("dddd",
                              new CultureInfo("es-ES"));    
            // Restore original current culture
            Thread.CurrentThread.CurrentCulture = originalCulture;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvRecorridoLu.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningun recorrido, no se puede generar reparto!");
            }
            else
            {
                formRepartos frm = new formRepartos();
                frm.Show();

                // Verificamos que ya no se haya generado un reparto para ese mismo día y el mismo distribuidor.
                reparto.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
                reparto.fecha = DateTime.Today;
                reparto.dia = "Lu";

                if (RepartoB.ExisteReparto(reparto) == true)
                {
                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    {
                        dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(dRow.Cells["colIDCliente"].Value));
                        dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                        dRow.Cells["colCobro"].Value = FacturaB.EstadoPago(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    }
                }
                else
                {
                    DataSet ds = GenerarReparto(dgvRecorridoLu, "Lu", txtIDRecorridoLu, "colLuSentido", "colLuIDcalle");

                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    {
                        dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(dRow.Cells["colIDCliente"].Value));
                        dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                        dRow.Cells["colCobro"].Value = FacturaB.EstadoPago(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    }

                    //frm.setRowNumber(frm.dgvRepartos);
                    //frm.dgvRepartos.DataSource = ds;
                    //frm.dgvRepartos.DataMember = "dtItemsRecorrido";
                }

                frm.setRowNumber(frm.dgvRepartos);
            }
        }

        public DataSet GenerarReparto(DataGridView dgvRecorridoDia, string diaNombre, TextBox txtIDRecorridoDia, string colDiaSentidoo, string colDiaIDCallee)
        {
            dsRecorridos ds = new dsRecorridos();
            formRepartos frm = new formRepartos();

            string fecha;
            string dia;
            GetFecha(out fecha, out dia); //Llenamos los strings fecha y dia de acuerdo a lo devuelto por el método GetFecha.  
            string distribuidor = Convert.ToString(txtNombre.Text + ' ' + txtApellido.Text);

            //dtRecorrido - fechaRecorrido, dia, distribuidor, numHoja
            ds.Tables["dtRecorrido"].Rows.Add
            (
            fecha,
            dia,
            distribuidor
            );

            //Guardamos los datos como encabezado del Reparto
            //reparto.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
            reparto.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
            reparto.fecha = DateTime.Today;
            reparto.dia = diaNombre;
            reparto.generado = true;
            int numReparto = RepartoB.InsertReparto(reparto);
            
            //dtItemsRecorrido
            DataTable dtItemsRecorridoTest = itemsRecorridoB.GetItemsRecorrido(dgvRecorridoDia, txtIDRecorridoDia, colDiaSentidoo, colDiaIDCallee);

            int rows = dtItemsRecorridoTest.Rows.Count;

            for (int i = 0; i <= rows - 1; i++)
            {
                ds.Tables["dtItemsRecorrido"].Rows.Add
                (
                new object[]
                {
                    dtItemsRecorridoTest.Rows[i][0].ToString(),//idCliente
                    dtItemsRecorridoTest.Rows[i][1].ToString(),//clienteCompleto
                    dtItemsRecorridoTest.Rows[i][2].ToString(),//idDomicilio
                    dtItemsRecorridoTest.Rows[i][3].ToString() //domicilioCompleto
                }
                );

                ds.Tables["dtEnvases"].Rows.Add
                (
                new object[]
                {
                    SaldoEnvasesB.GenerarSaldoEnvases(Convert.ToInt32(dtItemsRecorridoTest.Rows[i][0].ToString()), 7).ToString(), //saldoSoda
                    Convert.ToString(Convert.ToInt32(SaldoEnvasesB.GenerarSaldoEnvases(Convert.ToInt32(dtItemsRecorridoTest.Rows[i][0].ToString()), 1).ToString()) + Convert.ToInt32(SaldoEnvasesB.GenerarSaldoEnvases(Convert.ToInt32(dtItemsRecorridoTest.Rows[i][0].ToString()), 3).ToString()) + Convert.ToInt32(SaldoEnvasesB.GenerarSaldoEnvases(Convert.ToInt32(dtItemsRecorridoTest.Rows[i][0].ToString()), 4).ToString()) + Convert.ToInt32(SaldoEnvasesB.GenerarSaldoEnvases(Convert.ToInt32(dtItemsRecorridoTest.Rows[i][0].ToString()), 5).ToString()) + Convert.ToInt32(SaldoEnvasesB.GenerarSaldoEnvases(Convert.ToInt32(dtItemsRecorridoTest.Rows[i][0].ToString()), 6).ToString())),
                    SaldoEnvasesB.GenerarSaldoEnvases(Convert.ToInt32(dtItemsRecorridoTest.Rows[i][0].ToString()), 8).ToString(), //saldoCajon
                    SaldoEnvasesB.GenerarSaldoEnvases(Convert.ToInt32(dtItemsRecorridoTest.Rows[i][0].ToString()), 9).ToString(), //saldoCanasta
                    SaldoEnvasesB.GenerarSaldoEnvases(Convert.ToInt32(dtItemsRecorridoTest.Rows[i][0].ToString()), 10).ToString(), //saldoPie
                    SaldoEnvasesB.GenerarSaldoEnvases(Convert.ToInt32(dtItemsRecorridoTest.Rows[i][0].ToString()), 11).ToString(), //saldoDispenser
                    itemsRepartoB.CalcularVenta(Convert.ToInt32(dtItemsRecorridoTest.Rows[i][0].ToString())), //saldoCC
                }
                );
            }

            //Guardamos los items del Reparto
            foreach (DataRow dr in ds.Tables["dtItemsRecorrido"].Rows)
            {
                itemsReparto.reparto = numReparto;
                itemsReparto.cliente = Convert.ToInt32(dr["idCliente"].ToString());
                itemsReparto.domicilio = Convert.ToInt32(dr["idDomicilio"].ToString());
                itemsReparto.idComprobante = itemsRepartoB.UltimoComprobante() + 1;
                itemsRepartoB.InsertItemReparto(itemsReparto);

                factura.tipoFactura = "C";
                factura.estado = "Pendiente";
                factura.fechaFactura = DateTime.Today;
                factura.fechaVencimiento = factura.fechaVencimiento.AddDays(7); //Sumamos 7 días al actual.
                factura.fechaEntrega = DateTime.Today;
                factura.cliente = itemsReparto.cliente;
                factura.domicilio = itemsReparto.domicilio;
                //factura.numFactura = FacturaB.UltimaFactura() + 1;
                FacturaB.InsertFactura(factura);
            }

            //Buscamos y guardamos los Saldos
            //foreach (DataRow dr in ds.Tables["dtItemsRecorrido"].Rows)
            //{
            //    dr["saldoCC"] = SaldoB.GenerarSaldo(Convert.ToInt32(dr["idCliente"].ToString()));
            //    //dr["colVenta"]= itemsRepartoB.CalcularVenta(Convert.ToInt32(dr["colComprobante"].ToString()));
            //}

            return ds;
        }

        

        private void dgvRecorridoLu_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            //UpdateMCM(dgvRecorridoLu, "colLuDesde", "colLuHasta", "colLuSentido");
        }

        private void UpdateMCM(DataGridView dgvRecorridoDia, string colDiaDesde, string colDiaHasta, string colDiaSentido)
        {
            foreach (DataGridViewRow row in dgvRecorridoDia.Rows)
            {
                // Se ejecutan las operaciones solo si la columna cantidad y precio tienen algún valor, ya que de lo contrario nos dará un error.
                if (Convert.ToString(row.Cells[colDiaDesde].Value) == "" || Convert.ToString(row.Cells[colDiaHasta].Value) == "")
                {
                    return;
                }

                if (Convert.ToInt32(row.Cells[colDiaDesde].Value) < Convert.ToInt32(row.Cells[colDiaHasta].Value))
                {
                    row.Cells[colDiaSentido].Value = "M";
                }
                else
                {
                    row.Cells[colDiaSentido].Value = "C";
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            RemoveRow(dgvRecorridoLu);
        }

        //Entidades
        FacturaEntity factura = new FacturaEntity();

        RepartoEntity reparto = new RepartoEntity();

        itemsRepartoEntity itemsReparto = new itemsRepartoEntity();

        SaldoEnvasesEntity saldoEnvases = new SaldoEnvasesEntity();

        private void GuardarRecorrido(TextBox txtIDRecorridodia, string dia, DataGridView dgvRecorridoDia)
        {
            //Validacion.
            if (txtIDRecorridodia.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un distribuidor!");
            }

            //Borramos Recorrido e itemsRecorrido anteriores.
            if (txtIDRecorridodia.Text != string.Empty)
            {
                itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridodia.Text);
                itemsRecorridoB.DeleteItemRecorrido(itemRecorrido);
                recorrido.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
                RecorridoB.DeleteRecorrido(recorrido);
            }

            //Cargamos encabezado del recorrido.
            string strDia = dia;
            CargarRecorrido(strDia);
            RecorridoB.InsertRecorrido(recorrido, txtIDRecorridodia);

            //Cargamos los nuevos items del recorrido
            foreach (DataGridViewRow row in dgvRecorridoDia.Rows)
            {
                CargarItemRecorrido(row, strDia, txtIDRecorridodia);
                itemsRecorridoB.InsertItemRecorrido(itemRecorrido);
            }
        }

        private void btnSaveRecLu_Click(object sender, EventArgs e)
        {
            GuardarRecorrido(txtIDRecorridoLu, "LU", dgvRecorridoLu);      
        }

        private void btnSaveRecMa_Click_1(object sender, EventArgs e)
        {
            GuardarRecorrido(txtIDRecorridoMa, "MA", dgvRecorridoMa);
        }

        private void btnSaveRecMi_Click(object sender, EventArgs e)
        {
            GuardarRecorrido(txtIDRecorridoMi, "MI", dgvRecorridoMi);
        }

        private void btnSaveRecJu_Click_1(object sender, EventArgs e)
        {
            GuardarRecorrido(txtIDRecorridoJu, "JU", dgvRecorridoJu);
        }

        private void btnSaveRecVi_Click(object sender, EventArgs e)
        {
            GuardarRecorrido(txtIDRecorridoVi, "VI", dgvRecorridoVi);  
        }

        private void btnSaveRecSa_Click(object sender, EventArgs e)
        {
            GuardarRecorrido(txtIDRecorridoSa, "SA", dgvRecorridoSa);  
        }

        private void btnSaveRecDo_Click(object sender, EventArgs e)
        {
            GuardarRecorrido(txtIDRecorridoDo, "DO", dgvRecorridoDo);  
        }

        private void addCalles(int VAR)
        {
            formDomicilio frm = new formDomicilio();
            frm.tabVar = 0;
            frm.DGVvar = 2;
            frm.VAR = VAR;
            frm.Show(this);

            //Valores Predeterminados
            frm.cbProvinciaCalle.SelectedValue = 5; // Cordoba
            frm.cbLocalidadesCalle.SelectedValue = 26; // Cordoba Capital.
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            addCalles(1);
        }

        private void btnAddMa_Click(object sender, EventArgs e)
        {
            addCalles(2);
        }

        private void btnAddMi_Click(object sender, EventArgs e)
        {
            addCalles(3);
        }

        private void btnAddJu_Click(object sender, EventArgs e)
        {
            addCalles(4);
        }

        private void btnAddVi_Click(object sender, EventArgs e)
        {
            addCalles(5);
        }

        private void btnAddSa_Click(object sender, EventArgs e)
        {
            addCalles(6);
        }

        private void btnAddDo_Click(object sender, EventArgs e)
        {
            addCalles(7);
        }

        private void UpCalles(DataGridView dgvRecorridoDia)
        {
            DataGridView grid = dgvRecorridoDia;
            try
            {
                int totalRows = grid.Rows.Count;
                int idx = grid.SelectedCells[0].OwningRow.Index;
                if (idx == 0)
                    return;
                int col = grid.SelectedCells[0].OwningColumn.Index;
                DataGridViewRowCollection rows = grid.Rows;
                DataGridViewRow row = rows[idx];
                rows.Remove(row);
                rows.Insert(idx - 1, row);
                grid.ClearSelection();
                grid.Rows[idx - 1].Cells[col].Selected = true;

            }
            catch { }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            UpCalles(dgvRecorridoLu);
        }

        private void btnUpMa_Click(object sender, EventArgs e)
        {
            UpCalles(dgvRecorridoMa);
        }

        private void btnUpMi_Click(object sender, EventArgs e)
        {
            UpCalles(dgvRecorridoMi);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            UpCalles(dgvRecorridoJu);
        }

        private void btnUpVi_Click(object sender, EventArgs e)
        {
            UpCalles(dgvRecorridoVi);
        }

        private void btnUpSa_Click(object sender, EventArgs e)
        {
            UpCalles(dgvRecorridoSa);
        }

        private void btnUpDo_Click(object sender, EventArgs e)
        {
            UpCalles(dgvRecorridoDo);
        }

        private void dgvRecorridoLu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMCM(dgvRecorridoLu, "colLuDesde", "colLuHasta", "colLuSentido");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSaveRecorridoMa_Click(object sender, EventArgs e)
        {
            if (dgvRecorridoMa.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningun recorrido, no se puede generar reparto!");
            }
            else
            {
                formRepartos frm = new formRepartos();
                frm.Show();

                // Verificamos que ya no se haya generado un reparto para ese mismo día y el mismo distribuidor.
                reparto.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
                reparto.fecha = DateTime.Today;
                reparto.dia = "Ma";

                if (RepartoB.ExisteReparto(reparto) == true)
                {
                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    {
                        dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(dRow.Cells["colIDCliente"].Value));
                        dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                        dRow.Cells["colCobro"].Value = FacturaB.EstadoPago(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    }
                }
                else
                {
                    DataSet ds = GenerarReparto(dgvRecorridoMa, "Ma", txtIDRecorridoMa, "colMaSentido", "colMaIDcalle");

                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    //foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    //{
                    //    dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(frm.dgvRepartos.CurrentRow.Cells["colIDCliente"].Value));
                    //    dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    //}

                    //frm.setRowNumber(frm.dgvRepartos);
                    //frm.dgvRepartos.DataSource = ds;
                    //frm.dgvRepartos.DataMember = "dtItemsRecorrido";
                }

                frm.setRowNumber(frm.dgvRepartos);
            }
        }

        private void btnSaveRecorridoMi_Click(object sender, EventArgs e)
        {
            if (dgvRecorridoMi.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningun recorrido, no se puede generar reparto!");
            }
            else
            {
                formRepartos frm = new formRepartos();
                frm.Show();

                // Verificamos que ya no se haya generado un reparto para ese mismo día y el mismo distribuidor.
                reparto.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
                reparto.fecha = DateTime.Today;
                reparto.dia = "Mi";

                if (RepartoB.ExisteReparto(reparto) == true)
                {
                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    {
                        dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(dRow.Cells["colIDCliente"].Value));
                        dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                        dRow.Cells["colCobro"].Value = FacturaB.EstadoPago(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    }
                }
                else
                {
                    DataSet ds = GenerarReparto(dgvRecorridoMi, "Mi", txtIDRecorridoMi, "colMiSentido", "colMiIDcalle");

                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    //foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    //{
                    //    dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(frm.dgvRepartos.CurrentRow.Cells["colIDCliente"].Value));
                    //    dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    //}

                    //frm.setRowNumber(frm.dgvRepartos);
                    //frm.dgvRepartos.DataSource = ds;
                    //frm.dgvRepartos.DataMember = "dtItemsRecorrido";
                }

                frm.setRowNumber(frm.dgvRepartos);
            }
        }

        private void btnSaveRecorridoJu_Click(object sender, EventArgs e)
        {
            if (dgvRecorridoJu.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningun recorrido, no se puede generar reparto!");
            }
            else
            {
                formRepartos frm = new formRepartos();
                frm.Show();

                // Verificamos que ya no se haya generado un reparto para ese mismo día y el mismo distribuidor.
                reparto.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
                reparto.fecha = DateTime.Today;
                reparto.dia = "Ju";

                if (RepartoB.ExisteReparto(reparto) == true)
                {
                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    {
                        dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(dRow.Cells["colIDCliente"].Value));
                        dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                        dRow.Cells["colCobro"].Value = FacturaB.EstadoPago(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    }
                }
                else
                {
                    DataSet ds = GenerarReparto(dgvRecorridoJu, "Ju", txtIDRecorridoJu, "colJuSentido", "colJuIDcalle");

                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    //foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    //{
                    //    dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(frm.dgvRepartos.CurrentRow.Cells["colIDCliente"].Value));
                    //    dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    //}

                    //frm.setRowNumber(frm.dgvRepartos);
                    //frm.dgvRepartos.DataSource = ds;
                    //frm.dgvRepartos.DataMember = "dtItemsRecorrido";
                }

                frm.setRowNumber(frm.dgvRepartos);
            }
        }

        private void clean()
        {
            txtIDdistribuidor.Text = "";
            cbTipoDoc.SelectedValue = 0;
            txtnumDoc.Text = "";
            cbSexo.SelectedValue = 0;
            txtCUIL.Text = "";
            txtApellido.Text = "";
            txtNombre.Text = "";
            cbEstadoCivil.SelectedValue = 0;
            cbEstado.Checked = true;
            txtEmail.Text = "";
            txtTel.Text = "";
            txtDomic.Text = "";

        }

        private void btnSaveRecorridoVi_Click(object sender, EventArgs e)
        {
            if (dgvRecorridoVi.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningun recorrido, no se puede generar reparto!");
            }
            else
            {
                formRepartos frm = new formRepartos();
                frm.Show();

                // Verificamos que ya no se haya generado un reparto para ese mismo día y el mismo distribuidor.
                reparto.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
                reparto.fecha = DateTime.Today;
                reparto.dia = "Vi";

                if (RepartoB.ExisteReparto(reparto) == true)
                {
                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    {
                        dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(dRow.Cells["colIDCliente"].Value));
                        dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                        dRow.Cells["colCobro"].Value = FacturaB.EstadoPago(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    }
                }
                else
                {
                    DataSet ds = GenerarReparto(dgvRecorridoVi, "Vi", txtIDRecorridoVi, "colViSentido", "colViIDcalle");

                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    //foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    //{
                    //    dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(frm.dgvRepartos.CurrentRow.Cells["colIDCliente"].Value));
                    //    dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    //}

                    //frm.setRowNumber(frm.dgvRepartos);
                    //frm.dgvRepartos.DataSource = ds;
                    //frm.dgvRepartos.DataMember = "dtItemsRecorrido";
                }

                frm.setRowNumber(frm.dgvRepartos);
            }
        }

        private void btnSaveRecorridoSa_Click(object sender, EventArgs e)
        {
            if (dgvRecorridoSa.Rows.Count == 0)
            {
                MessageBox.Show("No existe ningun recorrido, no se puede generar reparto!");
            }
            else
            {
                formRepartos frm = new formRepartos();
                frm.Show();

                // Verificamos que ya no se haya generado un reparto para ese mismo día y el mismo distribuidor.
                reparto.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
                reparto.fecha = DateTime.Today;
                reparto.dia = "Sa";

                if (RepartoB.ExisteReparto(reparto) == true)
                {
                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    {
                        dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(dRow.Cells["colIDCliente"].Value));
                        dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                        dRow.Cells["colCobro"].Value = FacturaB.EstadoPago(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    }
                }
                else
                {
                    DataSet ds = GenerarReparto(dgvRecorridoSa, "Sa", txtIDRecorridoSa, "colSaSentido", "colSaIDcalle");

                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);

                    //foreach (DataGridViewRow dRow in frm.dgvRepartos.Rows)
                    //{
                    //    dRow.Cells["colSaldo"].Value = SaldoB.GenerarSaldo(Convert.ToInt32(frm.dgvRepartos.CurrentRow.Cells["colIDCliente"].Value));
                    //    dRow.Cells["colVenta"].Value = itemsRepartoB.CalcularVenta(Convert.ToInt32(dRow.Cells["colComprobante"].Value));
                    //}

                    //frm.setRowNumber(frm.dgvRepartos);
                    //frm.dgvRepartos.DataSource = ds;
                    //frm.dgvRepartos.DataMember = "dtItemsRecorrido";
                }

                frm.setRowNumber(frm.dgvRepartos);
            }
        }

        private void dgvRecorridoMa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMCM(dgvRecorridoMa, "colMaDesde", "colMaHasta", "colMaSentido");
        }

        private void dgvRecorridoMi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMCM(dgvRecorridoMi, "colMiDesde", "colMiHasta", "colMiSentido");
        }

        private void dgvRecorridoJu_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMCM(dgvRecorridoJu, "colJuDesde", "colJuHasta", "colJuSentido");
        }

        private void dgvRecorridoVi_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMCM(dgvRecorridoVi, "colViDesde", "colViHasta", "colViSentido");
        }

        private void dgvRecorridoSa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMCM(dgvRecorridoSa, "colSaDesde", "colSaHasta", "colSaSentido");
        }

        private void dgvRecorridoDo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateMCM(dgvRecorridoDo, "colDoDesde", "colDoHasta", "colDoSentido");
        }

        private void RemoveRow(DataGridView dgvRecorrido)
        {
            dgvRecorrido.Rows.RemoveAt(dgvRecorrido.CurrentRow.Index);
        }

        private void btnDelMa_Click(object sender, EventArgs e)
        {
            RemoveRow(dgvRecorridoMa);
        }

        private void btnDelMi_Click(object sender, EventArgs e)
        {
            RemoveRow(dgvRecorridoMi);
        }

        private void btnDelJu_Click(object sender, EventArgs e)
        {
            RemoveRow(dgvRecorridoJu);

        }

        private void btnDelVi_Click(object sender, EventArgs e)
        {
            RemoveRow(dgvRecorridoVi);
        }

        private void btnDelSa_Click(object sender, EventArgs e)
        {
            RemoveRow(dgvRecorridoSa);
        }

        private void btnDelDo_Click(object sender, EventArgs e)
        {
            RemoveRow(dgvRecorridoDo);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clean();

        }

        private void btnClean_Click_1(object sender, EventArgs e)
        {
            clean();
        }

        private void btnDownVi_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void tabListado_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }
    }
}
