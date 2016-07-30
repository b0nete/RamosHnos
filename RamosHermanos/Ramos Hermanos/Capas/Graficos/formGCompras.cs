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
    public partial class formGCompras : Form
    {
        public formGCompras()
        {
            InitializeComponent();
        }

        private void formGCompras_Load(object sender, EventArgs e)
        {
            //Dia
            dtpDesdeDia.CustomFormat = "dd/MM/yyyy";
            dtpHastaDia.CustomFormat = "dd/MM/yyyy";
            //Mes
            dtpDesdeMensual.CustomFormat = "MM/yyyy";
            dtpHastaMensual.CustomFormat = "MM/yyyy";
            //Año
            dtpDesdeAño.CustomFormat = "yyyy";
            dtpHastaAño.CustomFormat = "yyyy";
        }

        private void rbDiario_CheckedChanged(object sender, EventArgs e)
        {
            string desde = dtpDesdeDia.Value.DayOfWeek.ToString();
            string hasta = dtpHastaDia.Value.DayOfWeek.ToString();

            DataTable dtGrafico = ComprasB.GenerarGraficoDiario(desde, hasta);

            chartCompras.Series.Clear();
            chartCompras.DataBindTable(dtGrafico.AsDataView(), "dia");

            //chartCompras.Series["año"].Enabled = false;

            for (int i = 0; i < chartCompras.Series["Total"].Points.Count(); i++)
            {
                chartCompras.Series["Total"].Points[i].Label = "$" + Convert.ToDouble(dtGrafico.Rows[i]["Total"].ToString());
            }
        }

        private void rbMensual_CheckedChanged(object sender, EventArgs e)
        {
            string desde = dtpDesdeMensual.Value.Month.ToString();
            string hasta = dtpHastaMensual.Value.Month.ToString();

            DataTable dtGrafico = ComprasB.GenerarGraficoMensual(desde, hasta);

            chartCompras.Series.Clear();
            chartCompras.DataBindTable(dtGrafico.AsDataView(), "mes");

            //chartCompras.Series["año"].Enabled = false;

            for (int i = 0; i < chartCompras.Series["Total"].Points.Count(); i++)
            {
                chartCompras.Series["Total"].Points[i].Label = "$" + Convert.ToDouble(dtGrafico.Rows[i]["Total"].ToString());
            }
        }

        private void rbAnual_CheckedChanged(object sender, EventArgs e)
        {
            string desde = dtpDesdeAño.Value.Year.ToString();
            string hasta = dtpHastaAño.Value.Year.ToString();

            DataTable dtGrafico = ComprasB.GenerarGraficoAnual(desde, hasta);

            chartCompras.Series.Clear();
            chartCompras.DataBindTable(dtGrafico.AsDataView(), "año");

            //chartCompras.Series["año"].Enabled = false;

            for (int i = 0; i < chartCompras.Series["Total"].Points.Count(); i++)
            {
                chartCompras.Series["Total"].Points[i].Label = "$" + Convert.ToDouble(dtGrafico.Rows[i]["Total"].ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
