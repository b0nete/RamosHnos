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
    public partial class formGProductos : Form
    {
        public formGProductos()
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
                chartProduccion.Series.Clear();

                DataTable dtGrafico = ProduccionB.GenerarGraficoDiario(Convert.ToInt32(txtID.Text), dtpDesde.Value, dtpHasta.Value);

                chartProduccion.Series.Clear();
                chartProduccion.DataBindTable(dtGrafico.AsDataView(), "fechaProduccion");

                chartProduccion.Series["producto"].Enabled = false;

                for (int i = 0; i < chartProduccion.Series["Cantidad"].Points.Count(); i++)
                {
                    chartProduccion.Series["Cantidad"].Points[i].Label = dtGrafico.Rows[i]["Cantidad"].ToString();
                }
            }
            else if (rbMensual.Checked == true)
            {
                chartProduccion.Series.Clear();

                DataTable dtGrafico = ProduccionB.GenerarGraficoMensual(Convert.ToInt32(txtID.Text), dtpDesde.Value, dtpHasta.Value);

                chartProduccion.Series.Clear();
                chartProduccion.DataBindTable(dtGrafico.AsDataView(), "fechaProduccion");

                chartProduccion.Series["producto"].Enabled = false;

                for (int i = 0; i < chartProduccion.Series["Cantidad"].Points.Count(); i++)
                {
                    chartProduccion.Series["Cantidad"].Points[i].Label = dtGrafico.Rows[i]["Cantidad"].ToString();
                }
            }
            else if (rbAnual.Checked == true)
            {
                chartProduccion.Series.Clear();

                DataTable dtGrafico = ProduccionB.GenerarGraficoAnual(Convert.ToInt32(txtID.Text), dtpDesde.Value, dtpHasta.Value);

                chartProduccion.Series.Clear();
                chartProduccion.DataBindTable(dtGrafico.AsDataView(), "fechaProduccion");

                for (int i = 0; i < chartProduccion.Series["Cantidad"].Points.Count(); i++)
                {
                    chartProduccion.Series["Cantidad"].Points[i].Label = dtGrafico.Rows[i]["Cantidad"].ToString();
                }

                //chartProduccion.Series.Clear();

                //DataTable dtGrafico = ProduccionB.GenerarGraficoAnual(Convert.ToInt32(txtID.Text), dtpDesde.Value, dtpHasta.Value);

                //foreach (DataRow dr in dtGrafico.Rows)
                //{      
                //    string series = dr["fechaProduccion"].ToString();

                //    //Series                    
                //    chartProduccion.Series.Add(series);  

                //    //Points
                //    chartProduccion.Series[series].Points.Add(Convert.ToDouble(dr["cantidad"]));

                //    for (int i = 0; i < chartProduccion.Series[series].Points.Count(); i++)
                //    {
                //        chartProduccion.Series[series].Points[i].Label = dr["cantidad"].ToString();
                //        chartProduccion.Series[series].LabelToolTip = dr["cantidad"].ToString();
                //    }
                //}
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void formGProductos_Load(object sender, EventArgs e)
        {
            ChangeOpc();
        }

        private void ChangeOpc()
        {
            if (rbDiario.Checked == true)
            {
                dtpDesde.CustomFormat = "dd-MM-yyyy";
                dtpHasta.CustomFormat = "dd-MM-yyyy";
            }
            else if (rbMensual.Checked == true)
            {
                dtpDesde.CustomFormat = "MM-yyyy";
                dtpHasta.CustomFormat = "MM-yyyy";
            }
            else if (rbAnual.Checked == true)
            {
                dtpDesde.CustomFormat = "yyyy";
                dtpHasta.CustomFormat = "yyyy";
            }
        }

        private void rbDiario_CheckedChanged(object sender, EventArgs e)
        {
            ChangeOpc();
        }

        private void rbMensual_CheckedChanged(object sender, EventArgs e)
        {
            ChangeOpc();
        }

        private void rbAnual_CheckedChanged(object sender, EventArgs e)
        {
            ChangeOpc();
        }
    }
}
