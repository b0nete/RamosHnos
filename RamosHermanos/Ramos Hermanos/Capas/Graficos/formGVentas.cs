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
            
        }

        private void rbAnual_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void formGVentas_Load(object sender, EventArgs e)
        {
            cbTipoChart.SelectedIndex = 0;

            //Dia
            dtpDesdeDia.CustomFormat = "dd/MM/yyyy";
            dtpHastaDia.CustomFormat = "dd/MM/yyyy";
            //Mes
            dtpDesdeMensual.CustomFormat = "MM/yyyy";
            dtpHastaMensual.CustomFormat = "MM/yyyy";
            //Año
            dtpDesdeAño.CustomFormat = "yyyy";
            dtpHastaAño.CustomFormat = "yyyy";

            //Historico
            double total = Convert.ToDouble(FacturaB.totalVentas());
            lblTotal.Text = "$" + total.ToString("N2");
            lblCantidadVentas.Text = FacturaB.cantidadVentas();

            lblPagas.Text = FacturaB.cantidadPagas();
            double cobrado = Convert.ToDouble(FacturaB.cantidadCobrado());
            lblCobrado.Text = "$" + cobrado.ToString("N2");
            
            lblNoPagas.Text = FacturaB.cantidadNoPagas();
            double sincobrar = Convert.ToDouble(FacturaB.cantidadDeuda());
            lblSinCobrar.Text = "$" + sincobrar.ToString("N2");

            //

            string desde = dtpDesdeDia.Value.DayOfWeek.ToString();
            string hasta = dtpHastaDia.Value.DayOfWeek.ToString();

            DataTable dtGrafico = FacturaB.GenerarGraficoDiario(desde, hasta);

            chartCompras.Series.Clear();
            chartCompras.DataBindTable(dtGrafico.AsDataView(), "dia");

            //chartCompras.Series["año"].Enabled = false;

            for (int i = 0; i < chartCompras.Series["Total"].Points.Count(); i++)
            {
                chartCompras.Series["Total"].Points[i].Label = "$" + Convert.ToDouble(dtGrafico.Rows[i]["Total"].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chartCompras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void rbMensual_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbDiario_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checks()
        {
            rbDiario.Checked = false;
            rbMensual.Checked = false;
            rbAnual.Checked = false;

            if (rbDiario.Checked == true)
            {
                rbMensual.Checked = false;
                rbAnual.Checked = false;
            }
            else if (rbMensual.Checked == true)
            {
                rbDiario.Checked = false;
                rbAnual.Checked = false;
            }
            else if (rbAnual.Checked == true)
            {
                rbDiario.Checked = false;
                rbMensual.Checked = false;
            }
        }

        private void rbDiario_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void rbMensual_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void rbAnual_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void rbAnual_CheckedChanged_1(object sender, EventArgs e)
        {
            string desde = dtpDesdeAño.Value.Year.ToString();
            string hasta = dtpHastaAño.Value.Year.ToString();

            DataTable dtGrafico = FacturaB.GenerarGraficoAnual(desde, hasta);

            chartCompras.Series.Clear();
            chartCompras.DataBindTable(dtGrafico.AsDataView(), "año");

            //chartCompras.Series["año"].Enabled = false;

            for (int i = 0; i < chartCompras.Series["Total"].Points.Count(); i++)
            {
                chartCompras.Series["Total"].Points[i].Label = "$" + Convert.ToDouble(dtGrafico.Rows[i]["Total"].ToString());
            }
        }

        private void rbMensual_CheckedChanged_1(object sender, EventArgs e)
        {
            string desde = dtpDesdeMensual.Value.Month.ToString();
            string hasta = dtpHastaMensual.Value.Month.ToString();

            DataTable dtGrafico = FacturaB.GenerarGraficoMensual(desde, hasta);

            chartCompras.Series.Clear();
            chartCompras.DataBindTable(dtGrafico.AsDataView(), "mes");

            //chartCompras.Series["año"].Enabled = false;

            for (int i = 0; i < chartCompras.Series["Total"].Points.Count(); i++)
            {
                chartCompras.Series["Total"].Points[i].Label = "$" + Convert.ToDouble(dtGrafico.Rows[i]["Total"].ToString());
            }
        }

        private void rbDiario_CheckedChanged_1(object sender, EventArgs e)
        {
            string desde = dtpDesdeDia.Value.DayOfWeek.ToString();
            string hasta = dtpHastaDia.Value.DayOfWeek.ToString();

            DataTable dtGrafico = FacturaB.GenerarGraficoDiario(desde, hasta);

            chartCompras.Series.Clear();
            chartCompras.DataBindTable(dtGrafico.AsDataView(), "dia");

            //chartCompras.Series["año"].Enabled = false;

            for (int i = 0; i < chartCompras.Series["Total"].Points.Count(); i++)
            {
                chartCompras.Series["Total"].Points[i].Label = "$" + Convert.ToDouble(dtGrafico.Rows[i]["Total"].ToString());
            }
        }

        int caseSwitch = 1;

        private void cbTipoChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            caseSwitch = cbTipoChart.SelectedIndex;

            switch (caseSwitch)
            {
                case 0:
                    chartCompras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 1:
                    chartCompras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
                    break;
                case 2:
                    chartCompras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    break;
                case 3:
                    chartCompras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                    break;
                case 4:
                    chartCompras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
                    break;
                case 5:
                    chartCompras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
                    break;
                case 6:
                    chartCompras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Stock;
                    break;
                case 7:
                    chartCompras.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel;
                    break;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            formReports frm = new formReports();
            frm.Show();

            string desde = dtpDesdeAño.Value.Year.ToString();
            string hasta = dtpDesdeAño.Value.Year.ToString();

            dsVentas ds = new dsVentas();
            //ds.Tables["dtGrafico"] = FacturaB.GenerarGraficoAnual(desde, hasta);

            frm.crvReporte.RefreshReport();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }




    }
}
