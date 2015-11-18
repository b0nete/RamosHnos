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

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formBuscarInsumo : Form
    {
        public formBuscarInsumo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        formInsumos frm = new formInsumos();
        InsumoEntity insumo = new InsumoEntity();

        private void BuscarNameInsumo()
        {

            if (txtInsumo.Text == "")
            {
                frm.Show();
                frm.tabMain.SelectedTab = frm.tabListado;
                return;
            }

            //frm.cargarProv();
            insumo.insumo = txtInsumo.Text;
            
            if (InsumoB.ExisteInsumo(insumo) == false)
            {
                MessageBox.Show("El Insumo no existe");
                return;
            }
            else
            {
                InsumoB.BuscarInsumos(insumo);
                txtInsumo.Text = "";
                frm.Show();
                frm.txtidInsumo.Text = Convert.ToString(insumo.idInsumo);
                frm.txtInsumo.Text = Convert.ToString(insumo.insumo);
                frm.txtDescripcion.Text = insumo.descripcion;
                
                return;
            }
        }

        private void BuscarIDInsumo()
        {

            if (txtIDInsumo.Text == "")
            {
                frm.Show();
                frm.tabMain.SelectedTab = frm.tabListado;
                return;
            }

            //frm.cargarProv();
            insumo.idInsumo = Convert.ToInt32(txtIDInsumo.Text);
            
            if (InsumoB.ExisteInsumoID(insumo) == false)
            {
                MessageBox.Show("El Insumo no existe");
                return;
            }
            else
            {
                InsumoB.BuscarInsumosID(insumo);
                txtInsumo.Text = "";
                frm.Show();
                frm.txtidInsumo.Text = Convert.ToString(insumo.idInsumo);
                frm.txtInsumo.Text = Convert.ToString(insumo.insumo);
                frm.txtDescripcion.Text = insumo.descripcion;

                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BuscarIDInsumo();
        }

        private void formBuscarInsumo_Load(object sender, EventArgs e)
        {

        }

    }
}
