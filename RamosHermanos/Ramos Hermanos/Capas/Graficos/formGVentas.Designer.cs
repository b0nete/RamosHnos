namespace RamosHermanos.Capas.Graficos
{
    partial class formGVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGVentas));
            this.chartCompras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbTipoChart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDesdeMensual = new System.Windows.Forms.DateTimePicker();
            this.dtpHastaMensual = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDesdeAño = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.dtpHastaAño = new System.Windows.Forms.DateTimePicker();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.dtpDesdeDia = new System.Windows.Forms.DateTimePicker();
            this.dtpHastaDia = new System.Windows.Forms.DateTimePicker();
            this.rbDiario = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompras)).BeginInit();
            this.gbParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartCompras
            // 
            chartArea10.Name = "ChartArea1";
            this.chartCompras.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chartCompras.Legends.Add(legend10);
            this.chartCompras.Location = new System.Drawing.Point(12, 127);
            this.chartCompras.Name = "chartCompras";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chartCompras.Series.Add(series10);
            this.chartCompras.Size = new System.Drawing.Size(760, 388);
            this.chartCompras.TabIndex = 10;
            this.chartCompras.Text = "chart1";
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(744, 521);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 100;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::RamosHermanos.Properties.Resources.print;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(710, 521);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 101;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(654, -3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 9;
            this.txtID.Visible = false;
            // 
            // cbTipoChart
            // 
            this.cbTipoChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoChart.FormattingEnabled = true;
            this.cbTipoChart.Items.AddRange(new object[] {
            "Columnas",
            "Barras",
            "Lineas",
            "Puntos",
            "Burbujas",
            "Area",
            "Stock",
            "Embudo"});
            this.cbTipoChart.Location = new System.Drawing.Point(532, 72);
            this.cbTipoChart.Name = "cbTipoChart";
            this.cbTipoChart.Size = new System.Drawing.Size(194, 21);
            this.cbTipoChart.TabIndex = 102;
            this.cbTipoChart.SelectedIndexChanged += new System.EventHandler(this.cbTipoChart_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Desde";
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMensual.Location = new System.Drawing.Point(282, 21);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(65, 17);
            this.rbMensual.TabIndex = 111;
            this.rbMensual.Text = "Mensual";
            this.rbMensual.UseVisualStyleBackColor = true;
            this.rbMensual.CheckedChanged += new System.EventHandler(this.rbMensual_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 115;
            this.label6.Text = "Hasta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 114;
            this.label5.Text = "Desde";
            // 
            // dtpDesdeMensual
            // 
            this.dtpDesdeMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesdeMensual.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeMensual.Location = new System.Drawing.Point(251, 46);
            this.dtpDesdeMensual.Name = "dtpDesdeMensual";
            this.dtpDesdeMensual.Size = new System.Drawing.Size(96, 20);
            this.dtpDesdeMensual.TabIndex = 112;
            this.dtpDesdeMensual.Value = new System.DateTime(2015, 1, 1, 11, 59, 0, 0);
            // 
            // dtpHastaMensual
            // 
            this.dtpHastaMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHastaMensual.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaMensual.Location = new System.Drawing.Point(251, 72);
            this.dtpHastaMensual.Name = "dtpHastaMensual";
            this.dtpHastaMensual.Size = new System.Drawing.Size(96, 20);
            this.dtpHastaMensual.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Hasta";
            // 
            // dtpDesdeAño
            // 
            this.dtpDesdeAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesdeAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeAño.Location = new System.Drawing.Point(407, 46);
            this.dtpDesdeAño.Name = "dtpDesdeAño";
            this.dtpDesdeAño.Size = new System.Drawing.Size(96, 20);
            this.dtpDesdeAño.TabIndex = 117;
            this.dtpDesdeAño.Value = new System.DateTime(2015, 1, 1, 11, 59, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 118;
            this.label3.Text = "Desde";
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnual.Location = new System.Drawing.Point(451, 22);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(52, 17);
            this.rbAnual.TabIndex = 116;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            this.rbAnual.CheckedChanged += new System.EventHandler(this.rbAnual_CheckedChanged_1);
            // 
            // dtpHastaAño
            // 
            this.dtpHastaAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHastaAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaAño.Location = new System.Drawing.Point(407, 73);
            this.dtpHastaAño.Name = "dtpHastaAño";
            this.dtpHastaAño.Size = new System.Drawing.Size(96, 20);
            this.dtpHastaAño.TabIndex = 119;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.dtpHastaAño);
            this.gbParametros.Controls.Add(this.rbAnual);
            this.gbParametros.Controls.Add(this.label3);
            this.gbParametros.Controls.Add(this.dtpDesdeAño);
            this.gbParametros.Controls.Add(this.label4);
            this.gbParametros.Controls.Add(this.dtpHastaMensual);
            this.gbParametros.Controls.Add(this.dtpDesdeMensual);
            this.gbParametros.Controls.Add(this.label5);
            this.gbParametros.Controls.Add(this.label6);
            this.gbParametros.Controls.Add(this.rbMensual);
            this.gbParametros.Controls.Add(this.rbDiario);
            this.gbParametros.Controls.Add(this.dtpHastaDia);
            this.gbParametros.Controls.Add(this.dtpDesdeDia);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Controls.Add(this.cbTipoChart);
            this.gbParametros.Controls.Add(this.txtID);
            this.gbParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametros.Location = new System.Drawing.Point(12, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(760, 109);
            this.gbParametros.TabIndex = 9;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parametros";
            // 
            // dtpDesdeDia
            // 
            this.dtpDesdeDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesdeDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeDia.Location = new System.Drawing.Point(102, 46);
            this.dtpDesdeDia.Name = "dtpDesdeDia";
            this.dtpDesdeDia.Size = new System.Drawing.Size(96, 20);
            this.dtpDesdeDia.TabIndex = 106;
            this.dtpDesdeDia.Value = new System.DateTime(2015, 1, 1, 11, 59, 0, 0);
            // 
            // dtpHastaDia
            // 
            this.dtpHastaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHastaDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaDia.Location = new System.Drawing.Point(102, 72);
            this.dtpHastaDia.Name = "dtpHastaDia";
            this.dtpHastaDia.Size = new System.Drawing.Size(96, 20);
            this.dtpHastaDia.TabIndex = 107;
            // 
            // rbDiario
            // 
            this.rbDiario.AutoSize = true;
            this.rbDiario.Checked = true;
            this.rbDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiario.Location = new System.Drawing.Point(146, 21);
            this.rbDiario.Name = "rbDiario";
            this.rbDiario.Size = new System.Drawing.Size(52, 17);
            this.rbDiario.TabIndex = 110;
            this.rbDiario.TabStop = true;
            this.rbDiario.Text = "Diario";
            this.rbDiario.UseVisualStyleBackColor = true;
            this.rbDiario.CheckedChanged += new System.EventHandler(this.rbDiario_CheckedChanged_1);
            // 
            // formGVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.chartCompras);
            this.Controls.Add(this.gbParametros);
            this.Name = "formGVentas";
            this.Text = "Informe Ventas";
            this.Load += new System.EventHandler(this.formGVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCompras)).EndInit();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCompras;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbTipoChart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDesdeMensual;
        private System.Windows.Forms.DateTimePicker dtpHastaMensual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDesdeAño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.DateTimePicker dtpHastaAño;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.RadioButton rbDiario;
        private System.Windows.Forms.DateTimePicker dtpHastaDia;
        private System.Windows.Forms.DateTimePicker dtpDesdeDia;
    }
}