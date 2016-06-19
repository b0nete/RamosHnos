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
        RecorridoEntity recorrido = new RecorridoEntity();
        itemRecorridoEntity itemRecorrido = new itemRecorridoEntity();

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

        private void listDistribuidores_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvDistribuidores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
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

                frmD.Show();
                //Cargamos el ID de acuerdo a la celda seleccionada y buscamos el distribuidor para cargarlo en tabInformación.

                distribuidor.numDoc = row.Cells["colnumDoc"].Value.ToString();

                DistribuidorB.BuscarDistribuidorDOC(distribuidor);
                frmD.txtIDdistribuidor.Text = Convert.ToString(distribuidor.idDistribuidor);
                frmD.dtpFechaAlta.Value = distribuidor.fechaAlta;
                frmD.cbTipoDoc.SelectedValue = distribuidor.tipoDoc;
                frmD.txtnumDoc.Text = distribuidor.numDoc;
                frmD.cbSexo.Text = distribuidor.sexo;
                frmD.txtCUIL.Text = distribuidor.cuil;
                frmD.txtApellido.Text = distribuidor.apellido;
                frmD.txtNombre.Text = distribuidor.nombre;
                frmD.cbEstadoCivil.Text = distribuidor.estadoCivil;
                frmD.cbVehiculo.SelectedValue = distribuidor.vehiculo;
                frmD.cbEstado.Checked = distribuidor.estado;

                DomicilioB.CargarTXT(frmD.txtDomic, frmD.txtIDdistribuidor, 3);
                EmailB.CargarTXT(frmD.txtEmail, frmD.txtIDdistribuidor, 3);
                TelefonoB.CargarTXT(frmD.txtTel, frmD.txtIDdistribuidor, 3);

                //Se completa el tabRecorrido
                string strDia = "LU";
                frmD.CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, frmD.txtIDRecorridoLu);

                if (frmD.txtIDRecorridoLu.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(frmD.txtIDRecorridoLu.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, frmD.dgvRecorridoLu);
                }

                strDia = "MA";
                frmD.CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, frmD.txtIDRecorridoMa);

                if (frmD.txtIDRecorridoMa.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(frmD.txtIDRecorridoMa.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, frmD.dgvRecorridoMa);
                }

                strDia = "MI";
                frmD.CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, frmD.txtIDRecorridoMi);

                if (frmD.txtIDRecorridoMi.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(frmD.txtIDRecorridoMi.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, frmD.dgvRecorridoMi);
                }

                strDia = "JU";
                frmD.CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, frmD.txtIDRecorridoJu);

                if (frmD.txtIDRecorridoJu.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(frmD.txtIDRecorridoJu.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, frmD.dgvRecorridoJu);
                }

                strDia = "VI";
                frmD.CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, frmD.txtIDRecorridoVi);

                if (frmD.txtIDRecorridoVi.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(frmD.txtIDRecorridoVi.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, frmD.dgvRecorridoVi);
                }

                strDia = "SA";
                frmD.CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, frmD.txtIDRecorridoSa);

                if (frmD.txtIDRecorridoSa.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(frmD.txtIDRecorridoSa.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, frmD.dgvRecorridoSa);
                }

                strDia = "DO";
                frmD.CargarRecorrido(strDia);
                RecorridoB.BuscarRecorrido(recorrido, frmD.txtIDRecorridoDo);

                if (frmD.txtIDRecorridoDo.Text != string.Empty)
                {
                    itemRecorrido.recorrido = Convert.ToInt32(frmD.txtIDRecorridoDo.Text);
                    itemsRecorridoB.BuscarItemRecorrido(itemRecorrido, frmD.dgvRecorridoDo);
                }

                //Case
                frmD.CaseDistribuidor();
        }

    }
}
    }

