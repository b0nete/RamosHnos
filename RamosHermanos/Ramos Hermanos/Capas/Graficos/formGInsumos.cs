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

namespace RamosHermanos.Capas.Graficos
{
    public partial class formGInsumos : Form
    {
        public formGInsumos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerarGrafico();
        }

        private void GenerarGrafico()
        {
            if (rbDiario.Checked == true)
            {
                DataTable dtGrafico = ProduccionB.GenerarGraficoDiario(Convert.ToInt32(txtID.Text), dtpDiariaDesde.Value, dtpDiariaHasta.Value);

                chartCompras.Series.Clear();
                chartCompras.DataBindTable(dtGrafico.AsDataView(), "fechaProduccion");

                chartCompras.Series["producto"].Enabled = false;

                for (int i = 0; i < chartCompras.Series["Cantidad"].Points.Count(); i++)
                {
                    chartCompras.Series["Cantidad"].Points[i].Label = dtGrafico.Rows[i]["Cantidad"].ToString();
                }
            }
            else if (rbMensual.Checked == true)
            {
                DataTable dtGrafico = ProduccionB.GenerarGraficoMensual(Convert.ToInt32(txtID.Text), dtpDiariaDesde.Value, dtpDiariaHasta.Value);

                chartCompras.Series.Clear();
                chartCompras.DataBindTable(dtGrafico.AsDataView(), "fechaProduccion");

                chartCompras.Series["producto"].Enabled = false;

                for (int i = 0; i < chartCompras.Series["Cantidad"].Points.Count(); i++)
                {
                    chartCompras.Series["Cantidad"].Points[i].Label = dtGrafico.Rows[i]["Cantidad"].ToString();
                }
            }
            else if (rbAnual.Checked == true)
            {
                DataTable dtGrafico = ProduccionB.GenerarGraficoAnual(Convert.ToInt32(txtID.Text), dtpDiariaDesde.Value, dtpDiariaHasta.Value);

                chartCompras.Series.Clear();
                chartCompras.DataBindTable(dtGrafico.AsDataView(), "fechaProduccion");

                chartCompras.Series["producto"].Enabled = false;

                for (int i = 0; i < chartCompras.Series["Cantidad"].Points.Count(); i++)
                {
                    chartCompras.Series["Cantidad"].Points[i].Label = dtGrafico.Rows[i]["Cantidad"].ToString();
                }
            }
        }

        private void formGInsumos_Load(object sender, EventArgs e)
        {

        }

        private void rbAnual_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
