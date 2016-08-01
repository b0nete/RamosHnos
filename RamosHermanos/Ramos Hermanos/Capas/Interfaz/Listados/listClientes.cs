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
using RamosHermanos.Capas.Interfaz.Contratos;
using RamosHermanos.Capas.Interfaz.ABMs;

namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listClientes : Form
    {
        // Globales.
        public int caseSwitch = 2;

        public listClientes()
        {
            InitializeComponent();
        }

        private void rbDGVPJ_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbDGV_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckListado();
        }

        private void CheckListado()
        {
            if (rbDGV.Checked == true)
            {
                //Agregamos Elementos
                cbParametro.Items.Clear();
                cbParametro.Items.Add("Nº Cliente");
                cbParametro.Items.Add("DNI");
                cbParametro.Items.Add("CUIL/CUIT");
                cbParametro.Items.Add("Apellido");
                cbParametro.Items.Add("Nombre");
                //Establecemos valor por defecto
                cbParametro.SelectedIndex = 3;

                // Mostramos columnas desabilitadas para mostrar una PJ.
                dgvCliente.Columns[1].Visible = true;
                dgvCliente.Columns[4].Visible = true;
                dgvCliente.Columns[5].Visible = true;
                dgvCliente.Columns[8].Visible = true;
                dgvCliente.Columns[9].Visible = true;
                ClienteB.CargarDGV(dgvCliente);
            }
            else
            {
                //Agregamos Elementos
                cbParametro.Items.Clear();
                cbParametro.Items.Add("Nº Cliente");
                cbParametro.Items.Add("CUIL/CUIT");
                cbParametro.Items.Add("Nombre");
                //Establecemos valor por defecto
                cbParametro.SelectedIndex = 2;
                 
                // Ocultamos columnas innecesarias.
                dgvCliente.Columns[1].Visible = false;
                dgvCliente.Columns[4].Visible = false;
                dgvCliente.Columns[5].Visible = false;
                dgvCliente.Columns[8].Visible = false;
                dgvCliente.Columns[9].Visible = false;
                ClienteB.CargarDGVPJ(dgvCliente);
            }

        }

        private void rbDGVPJ_CheckedChanged_1(object sender, EventArgs e)
        {
            CheckListado();
        }

        private void listClientes_Load(object sender, EventArgs e)
        {
            cbParametro.SelectedIndex = 3;
            CheckListado();
        }

        //#region IAddItem Members

        //public void AddParametro(TextBox text)
        //{
        //    formBuscarCliente frm = new formBuscarCliente();
        //    cliente.idCliente = Convert.ToInt32(frm.txtIDCliente.Text);

        //    ClienteB.CargarDGVParametros(dgvCliente, cliente);
        //}

        //public void AddNewItem(DataGridViewRow row)
        //{
        //    string idCalle = row.Cells["colCIDcalle"].Value.ToString();
        //    string calle = row.Cells["colCCalle"].Value.ToString();
        //    string check = "true";

        //    this.dgvRecorridoLu.Rows.Add(new[] { idCalle, calle, "", "", "", check });
        //}

        //#endregion

        //Entidades
        ClienteEntity cliente = new ClienteEntity();
        VisitaEntity visita = new VisitaEntity();

        private void button1_Click(object sender, EventArgs e)
        {
            formBuscarCliente frm = new formBuscarCliente();
            frm.Show(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchParametro();
        }

        private void SearchParametro()
        {
            if (rbDGV.Checked == true)
            {    
                string parametro = '%' + txtParametro.Text + '%';
                ClienteB.CargarDGVParametros(dgvCliente, cbParametro, parametro);
            }
            else
            {
                string parametro = '%' + txtParametro.Text + '%';
                ClienteB.CargarDGVParametrosJ(dgvCliente, cbParametro, parametro);
            }
            
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            SearchParametro();
        }

        private void cbParametro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbDGV.Checked == true && cbParametro.SelectedIndex == 2 || rbDGVPJ.Checked == true && cbParametro.SelectedIndex == 1)
            {
                txtParametro.Mask = "";
            }
            else
            {
                txtParametro.Mask = "";
            }
        }

        private void SeleccionarDGV()
        {
            //Instanciamos Interfaces
            formCliente frm = new formCliente();
            formContacto frmContacto = new formContacto();
            //Instanciamos Entidades
            SaldoEntity saldo = new SaldoEntity();

            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvCliente.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;

                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                cliente.rol = 1;
                cliente.idCliente = Convert.ToInt32(row.Cells["colIDCliente"].Value.ToString());

                ClienteB.BuscarClienteID(cliente);
                
                if (cliente.tipoPersona == "P")
                {
                    this.Close();
                    //Actualizar Label
                    frm.lblTitle.Text = ClienteB.BuscarNombreCliente(cliente.idCliente);
                    frm.Show();                    
                    frm.txtIDcliente.Text = Convert.ToString(cliente.idCliente);
                    frm.dtpFechaAlta.Value = cliente.fechaAlta;
                    frm.cbTipoDoc.SelectedValue = cliente.tipoDoc;
                    frm.txtnumDoc.Text = cliente.numDoc;
                    frm.cbSexo.Text = cliente.sexo;
                    frm.txtCUIL.Text = cliente.cuil;
                    frm.txtApellido.Text = cliente.apellido;
                    frm.txtNombre.Text = cliente.nombre;
                    frm.cbEstadoCivil.Text = cliente.estadoCivil;
                    frm.cbIVA.Text = cliente.condicionIVA;
                    frm.cbTipoCliente.SelectedValue = cliente.tipoCliente;
                    frm.cbEstado.Checked = cliente.estado;
                    
                    //frm.CargarTXTSaldo();

                    //Contacto
                    DomicilioB.CargarTXT(frm.txtDomic, frm.txtIDcliente, 1);
                    EmailB.CargarTXT(frm.txtEmail, frm.txtIDcliente, 1);
                    TelefonoB.CargarTXT(frm.txtTel, frm.txtIDcliente, 1);
                    
                    DomicilioB.CargarCB(frm.cbDomicilio, frm.txtIDcliente, "1");
                    DistribuidorB.CargarCB(frm.cbDistribuidora, frm.txtIDcliente);

                    //Movimientos
                        if (frm.rbNoPagas.Checked == true)
                        {
                            FacturaB.SearchPendientes(cliente, frm.dgvMovimientos);
                        }
                        else if (frm.rbPagas.Checked == true)
                        {
                            FacturaB.SearchPagas(cliente, frm.dgvMovimientos);
                        }
                        else if (frm.rbAnuladas.Checked == true)
                    {
                        FacturaB.SearchAnuladas(cliente, frm.dgvMovimientos);
                    }

                    //Saldo $
                    frm.txtCreditoMax.Text = Convert.ToString(cliente.creditoMax);
                    frm.txtSaldo.Text = SaldoB.GenerarSaldo(Convert.ToInt32(frm.txtIDcliente.Text));
                    //Saldo Envases Aguas
                    frm.txt4LT.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 1));
                    frm.txt10LT.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 3));
                    frm.txt12LT.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 4));
                    frm.txt20LT.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 5));
                    frm.txt25LT.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 6));
                    frm.txtCajon.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 8));
                    frm.txtCanasta.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 9));
                    frm.txtPie.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 10));
                    frm.txtDispenser.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 11));
                    //Salgo Envase Soda
                    frm.txtRetornable.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 7));
                    //Visitas
                    visita = VisitaB.BuscarVisita(Convert.ToInt32(frm.txtIDcliente.Text), DomicilioB.BuscarIDPrimerDomicilio(Convert.ToInt32(frm.txtIDcliente.Text), 1));
                    frm.cbLunes.Checked = visita.lunes;
                    frm.cbMartes.Checked = visita.martes;
                    frm.cbMiercoles.Checked = visita.miercoles;
                    frm.cbJueves.Checked = visita.jueves;
                    frm.cbViernes.Checked = visita.viernes;
                    frm.cbSabado.Checked = visita.sabado;
                    //Tabs
                    frm.CasePersona();
                }

                else if (cliente.tipoPersona == "PJ")
                {
                    this.Close();
                    frm.lblTitle.Text = ClienteB.BuscarNombreClientePJ(cliente.idCliente);
                    frm.Show();
                    frm.txtIDcliente.Text = Convert.ToString(cliente.idCliente);

                    //frm.lblTitle.Text = ClienteB.BuscarNombreCliente(cliente.idCliente);
                    frm.txtIDclientePJ.Text = Convert.ToString(cliente.idCliente);
                    frm.dtpFechaAltaPJ.Value = cliente.fechaAlta;
                    frm.txtCUILPJ.Text = cliente.cuil;
                    frm.txtNombrePJ.Text = cliente.nombre;
                    frm.cbIVAPJ.Text = cliente.condicionIVA;
                    frm.cbtipoClientePJ.SelectedValue = cliente.tipoCliente;
                    frm.cbEstadoPJ.Checked = cliente.estado;

                    //frm.CargarTXTSaldo();

                    //Visita
                    //visita.rol = 1;
                    //visita.idPersona = Convert.ToInt32(txtIDcliente.Text);
                    //string dia = "LU";
                    //VisitaB.BuscarVisita(visita, dgvLu, dia);

                    //Contacto
                    DomicilioB.CargarTXT(frm.txtDomic, frm.txtIDcliente, 1);
                    EmailB.CargarTXT(frm.txtEmail, frm.txtIDcliente, 1);
                    TelefonoB.CargarTXT(frm.txtTel, frm.txtIDcliente, 1);

                    DomicilioB.CargarCB(frm.cbDomicilio, frm.txtIDcliente, "1");
                    DistribuidorB.CargarCB(frm.cbDistribuidorPJ, frm.txtIDcliente);

                    //Movimientos
                    if (frm.rbNoPagas.Checked == true)
                    {
                        FacturaB.SearchPendientes(cliente, frm.dgvMovimientos);
                    }
                    else if (frm.rbPagas.Checked == true)
                    {
                        FacturaB.SearchPagas(cliente, frm.dgvMovimientos);
                    }
                    else if (frm.rbAnuladas.Checked == true)
                    {
                        FacturaB.SearchAnuladas(cliente, frm.dgvMovimientos);
                    }

                    //Saldo $
                    frm.txt4LTPJ.Text = SaldoB.GenerarSaldo(Convert.ToInt32(frm.txtIDclientePJ.Text));
                    //Saldo Envases
                    frm.txt4LTPJ.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 1));
                    frm.txt10LTPJ.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 3));
                    frm.txt12LTPJ.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 4));
                    frm.txt20LTPJ.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 5));
                    frm.txt25LTPJ.Text = Convert.ToString(SaldoEnvasesB.GenerarSaldoEnvases(cliente.idCliente, 6));

                    //Visitas
                    visita = VisitaB.BuscarVisita(Convert.ToInt32(frm.txtIDcliente.Text), DomicilioB.BuscarIDPrimerDomicilio(Convert.ToInt32(frm.txtIDcliente.Text), 1));
                    frm.cbLunes.Checked = visita.lunes;
                    frm.cbMartes.Checked = visita.martes;
                    frm.cbMiercoles.Checked = visita.miercoles;
                    frm.cbJueves.Checked = visita.jueves;
                    frm.cbViernes.Checked = visita.viernes;
                    frm.cbSabado.Checked = visita.sabado;
                    //VisitaB.BuscarVisita(visita);

                    //Tabs
                    frm.CasePersonaJuridica();
                }

            }
        }

        private void dgvCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            formPedidos frmP = new formPedidos();

            switch (caseSwitch)
            {
                case 1:
                    DataGridViewCell cell = null;
                    foreach (DataGridViewCell selectedCell in dgvCliente.SelectedCells)
                    {
                        cell = selectedCell;
                        break;
                    }
                    if (cell != null)
                    {
                        DataGridViewRow row = cell.OwningRow;

                        //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.

                        cliente.idCliente = Convert.ToInt32(row.Cells["colIDCliente"].Value.ToString());


                        ClienteB.BuscarClienteID(cliente);
                        //Actualizar Label
                        frmP.txtidCliente.Text = Convert.ToString(cliente.idCliente);
                        frmP.txtNombre.Text = cliente.apellido + ',' + cliente.nombre;

                        DomicilioB.CargarCB(frmP.cbDomicilio, frmP.txtidCliente, "1");
                        
                        frmP.tabMain.SelectedTab = frmP.tabPedido;
                        Close();
                        frmP.Show();

                    }
                    break;

                case 2:
                    {
                        SeleccionarDGV();
                    }
                    break;
            }
        }

        private void txtParametro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
