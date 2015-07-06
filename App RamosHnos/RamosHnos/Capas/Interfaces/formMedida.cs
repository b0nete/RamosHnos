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

namespace RamosHnos.Capas.Interfaces
{
    public partial class formMedida : Form
    {
        public formMedida()
        {
            InitializeComponent();
        }

        private void txtNumTel_TextChanged(object sender, EventArgs e)
        {
            double temp = 0;

            if (double.TryParse(txtMedida.Text, out temp))
            {
                txtMedida.Text = temp.ToString("N2");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MedidaEntity medida = new MedidaEntity()
            {
                medida = Convert.ToDouble(txtMedida.Text),
                estado = cbEstado.Checked
            };
             MedidaB.InsertMedida(medida);
             MedidaB.MostrarMedidaDGV(dgvMedida);
        }
                    
        }
    }

