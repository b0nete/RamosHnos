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

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formDistribuidores : Form, IAddItem
    {
        public int tabVar;

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
            tabDistribuidor.Controls.Add(tabHojaRuta);
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
                string strLu = "LU";
                CargarRecorrido(strLu);
                RecorridoB.BuscarRecorrido(recorrido, txtIDRecorridoLu);

                if (txtIDRecorridoLu.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridoLu.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, dgvRecorridoLu);
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

        RecorridoEntity recorrido = new RecorridoEntity();
        private void CargarRecorrido(string strDia)
        {
            recorrido.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
            recorrido.dia = strDia;
        }

        itemRecorridoEntity itemRecorrido = new itemRecorridoEntity();
        private void CargarItemRecorrido(DataGridViewRow row)
       { 
            itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridoLu.Text);
            itemRecorrido.calle = Convert.ToInt32(row.Cells["colLuIDcalle"].Value);
            itemRecorrido.desde = Convert.ToInt32(row.Cells["colLuDesde"].Value);
            itemRecorrido.hasta = Convert.ToInt32(row.Cells["colLuHasta"].Value);
            itemRecorrido.sentido = Convert.ToString(row.Cells["colLuSentido"].Value);

            //if (itemRecorrido.desde < itemRecorrido.hasta)
            //    // "M" = Mano
            //    itemRecorrido.sentido = "M";
            //else if (itemRecorrido.desde > itemRecorrido.hasta)
            //    // "C" = ContraMano
            //    itemRecorrido.sentido = "C";

            itemRecorrido.estado = Convert.ToBoolean(row.Cells["colLuEstado"].Value);
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

        private void cbVehiculo_DropDown(object sender, EventArgs e)
        {
            VehiculoB.CargarCB(cbVehiculo);
        }

        // Contratos

        //#region IAddItem Members

        public void AddNewItem(DataGridViewRow row)
        {
            string idCalle = row.Cells["colCIDcalle"].Value.ToString();
            string calle = row.Cells["colCCalle"].Value.ToString();
            string check = "true";

            this.dgvRecorridoLu.Rows.Add(new[] {idCalle, calle, "", "", "", check});
        }

        //#endregion

        //interface IAddItem
        //{
        //    void AddNewItem(DataGridViewRow row);
        //}

        private void btnSaveRecLu_Click(object sender, EventArgs e)
        {

            //Validacion.
            if (txtIDdistribuidor.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un distribuidor!");
            }

            //Borramos Recorrido e itemsRecorrido anteriores.
            if (txtIDRecorridoLu.Text != string.Empty)
            {
                itemRecorrido.recorrido = Convert.ToInt32(txtIDRecorridoLu.Text);
                itemsRecorridoB.DeleteItemRecorrido(itemRecorrido);
                recorrido.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
                RecorridoB.DeleteRecorrido(recorrido);
            }

            //Cargamos encabezado del recorrido.
            string strDia = "LU";
            CargarRecorrido(strDia);
            RecorridoB.InsertRecorrido(recorrido, txtIDRecorridoLu);

            //Cargamos los nuevos items del recorrido
            foreach (DataGridViewRow row in dgvRecorridoLu.Rows)
            {
                CargarItemRecorrido(row);
                itemsRecorridoB.InsertItemRecorrido(itemRecorrido);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            formDomicilio frm = new formDomicilio();
            frm.tabVar = 0;
            frm.DGVvar = 2;
            frm.Show(this);

            //Valores Predeterminados
            frm.cbProvinciaCalle.SelectedValue = 5; // Cordoba
            frm.cbLocalidadesCalle.SelectedValue = 26; // Cordoba Capital.
        }

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

        private void btnUp_Click(object sender, EventArgs e)
        {
            DataGridView grid = dgvRecorridoLu;
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
            DataSet ds = GenerarReparto(); 

            //Cargar Reporte
            formReports frm = new formReports();
            frm.Show();
            ReportDocument rd = new ReportDocument();
            rd.Load(ruta + rep);
            //rd.Load("C:/Users/b0nete/Documents/GitHub/RamosHnos/RamosHermanos/Ramos Hermanos/Capas/Reportes/Recorridos/crFactura.rpt");
            rd.SetDataSource(ds);
            frm.crvReporte.ReportSource = rd;
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
                MessageBox.Show("No existe ningun recorrido!");
            }
            else
            {
                formRepartos frm = new formRepartos();
                frm.Show();

                // Verificamos que ya no se haya generado un reparto para ese mismo día y el mismo distribuidor.
                reparto.distribuidor = Convert.ToInt32(txtIDdistribuidor.Text);
                reparto.fecha = DateTime.Today;

                if (RepartoB.ExisteReparto(reparto) == true)
                {
                    RepartoB.BuscarReparto(reparto);
                    frm.dtpFechaReparto.Value = reparto.fecha;
                    frm.cbDistribuidores.SelectedValue = reparto.distribuidor;
                    frm.txtReparto.Text = Convert.ToString(reparto.idReparto);

                    itemsReparto.reparto = reparto.idReparto;
                    frm.dgvRepartos.DataSource = itemsRepartoB.BuscarItemsReparto(itemsReparto);
                }
                else
                {
                    DataSet ds = GenerarReparto();

                    frm.dgvRepartos.DataSource = ds;
                    frm.dgvRepartos.DataMember = "dtItemsRecorrido";
                    frm.setRowNumber(frm.dgvRepartos);
                }
            }
        }

        private DataSet GenerarReparto()
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
            reparto.generado = true;
            int numReparto = RepartoB.InsertReparto(reparto);
            
            //dtItemsRecorrido
            DataTable dtItemsRecorridoTest = itemsRecorridoB.GetItemsRecorrido(dgvRecorridoLu, txtIDRecorridoLu);

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
            }

            //Guardamos los items del Reparto
            foreach (DataRow dr in ds.Tables["dtItemsRecorrido"].Rows)
            {
                itemsReparto.reparto = numReparto;
                itemsReparto.cliente = Convert.ToInt32(dr["idCliente"].ToString());
                itemsReparto.domicilio = Convert.ToInt32(dr["idDomicilio"].ToString());
                itemsReparto.idComprobante = itemsRepartoB.UltimoComprobante() + 1;
                itemsRepartoB.InsertItemReparto(itemsReparto);

                factura.numFactura = itemsRepartoB.UltimoComprobante() + 1;
                factura.cliente = Convert.ToInt32(dr["idCliente"].ToString());
                FacturaB.InsertFactura(factura);
            }

            return ds;
        }

        

        private void dgvRecorridoLu_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvRecorridoLu.Rows)
            {
                // Se ejecutan las operaciones solo si la columna cantidad y precio tienen algún valor, ya que de lo contrario nos dará un error.
                if (Convert.ToString(row.Cells["colLuDesde"].Value) == "" || Convert.ToString(row.Cells["colLuHasta"].Value) == "")
                {
                    return;
                }
                
                if (Convert.ToInt32(row.Cells["colLuDesde"].Value) < Convert.ToInt32(row.Cells["colLuHasta"].Value))
                {
                    row.Cells["colLuSentido"].Value = "M";
                }
                else
                {
                    row.Cells["colLuSentido"].Value = "C";
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        //Entidades
        FacturaEntity factura = new FacturaEntity();

        RepartoEntity reparto = new RepartoEntity();

        itemsRepartoEntity itemsReparto = new itemsRepartoEntity();


    }
}
