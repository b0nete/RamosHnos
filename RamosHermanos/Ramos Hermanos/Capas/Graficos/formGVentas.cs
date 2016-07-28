using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Reportes;
using RamosHermanos.Capas.Reportes.Ventas;

namespace RamosHermanos.Capas.Graficos
{
    public partial class formGVentas : Form
    {
        public formGVentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chartCompras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }

        private void rbAnual_CheckedChanged(object sender, EventArgs e)
        {
            string desde = dtpDesdeAño.Value.Year.ToString();
            string hasta = dtpHastaAño.Value.Year.ToString();
                
            DataTable dtGrafico = FacturaB.GenerarGraficoAnual(desde, hasta);

            chartCompras.Series.Clear();
            chartCompras.DataBindTable(dtGrafico.AsDataView(), "año");

            //chartCompras.Series["año"].Enabled = false;

            for (int i = 0; i < chartCompras.Series["total"].Points.Count(); i++)
            {
                chartCompras.Series["total"].Points[i].Label = "$" + Convert.ToDouble(dtGrafico.Rows[i]["total"].ToString());
            }
        }

        private void formGVentas_Load(object sender, EventArgs e)
        {
            //Año
            dtpDesdeAño.CustomFormat = "yyyy";
            dtpHastaAño.CustomFormat = "yyyy";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //formReports frm = new formReports();
            //frm.Show();

            //string desde = dtpAñoDesde.Value.Year.ToString();
            //string hasta = dtpAñoHasta.Value.Year.ToString();

            //dsVentas ds = new dsVentas();
            //ds.Tables["dtGrafico"] = FacturaB.GenerarGraficoAnual(desde, hasta);

            //frm.crvReporte.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chartCompras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void rbMensual_CheckedChanged(object sender, EventArgs e)
        {
            string desde = dtpDesdeMensual.Value.Month.ToString();
            string hasta = dtpHastaMensual.Value.Month.ToString();

            DataTable dtGrafico = FacturaB.GenerarGraficoMensual(desde, hasta);

            chartCompras.Series.Clear();
            chartCompras.DataBindTable(dtGrafico.AsDataView(), "año");

            //chartCompras.Series["año"].Enabled = false;

            for (int i = 0; i < chartCompras.Series["total"].Points.Count(); i++)
            {
                chartCompras.Series["total"].Points[i].Label = "$" + Convert.ToDouble(dtGrafico.Rows[i]["total"].ToString());
            }
        }

        private void rbDiario_CheckedChanged(object sender, EventArgs e)
        {
            string desde = dtpDesdeDia.Value.Day.ToString();
            string hasta = dtpHastaDia.Value.Day.ToString();

            DataTable dtGrafico = FacturaB.GenerarGraficoMensual(desde, hasta);

            chartCompras.Series.Clear();
            chartCompras.DataBindTable(dtGrafico.AsDataView(), "año");

            //chartCompras.Series["año"].Enabled = false;

            for (int i = 0; i < chartCompras.Series["total"].Points.Count(); i++)
            {
                chartCompras.Series["total"].Points[i].Label = "$" + Convert.ToDouble(dtGrafico.Rows[i]["total"].ToString());
            }
        }


    }
}
