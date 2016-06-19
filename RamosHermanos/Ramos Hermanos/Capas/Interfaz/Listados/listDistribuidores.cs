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

namespace RamosHermanos.Capas.Interfaz.Listados
{
    public partial class listDistribuidores : Form
    {
        public listDistribuidores()
        {
            InitializeComponent();
            cbParametro.SelectedIndex = 0;
        }

        private void listDistribuidores_Load(object sender, EventArgs e)
        {
            DistribuidorB.CargarDGV(dgvDistribuidores);
        }


        private void SearchParametro()
        {
            string parametro = '%' + txtParametro.Text + '%';
            DistribuidorB.CargarDGVParametros(dgvDistribuidores,cbParametro, parametro);
        }


        formDistribuidores frmD = new formDistribuidores();
        DistribuidorEntity distribuidor = new DistribuidorEntity();

        private void SeleccionarDGV()
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
                formDistribuidores frmD = new formDistribuidores();
                               
                frmD.Show();
                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el cliente para cargarlo en tabInformación.
                distribuidor.idDistribuidor = Convert.ToInt32(row.Cells["colIDDistribuidor"].Value.ToString());
                DistribuidorB.BuscarIdDistr(distribuidor);
                frmD.txtIDdistribuidor.Text = Convert.ToString(distribuidor.idDistribuidor);
                frmD.txtNombre.Text = distribuidor.nombreCompleto;
                frmD.txtnumDoc.Text = distribuidor.numDoc;
                frmD.cbEstadoCivil.SelectedValue = distribuidor.estadoCivil;
                
            }
        }

        private void txtParametro_TextChanged(object sender, EventArgs e)
        {
            SearchParametro();
        }

    }
}
