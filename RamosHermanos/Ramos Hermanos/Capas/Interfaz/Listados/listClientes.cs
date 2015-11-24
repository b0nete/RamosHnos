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
            //CheckListado();
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

        private void button1_Click(object sender, EventArgs e)
        {
            formBuscarCliente frm = new formBuscarCliente();
            frm.Show(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbParametro.SelectedIndex == 3)
            {
                string parametro = txtParametro.Text;
                ClienteB.CargarDGVParametros(dgvCliente, parametro);
            }
        }
    }
}
