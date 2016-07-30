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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGVentas));
            this.chartCompras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button5 = new System.Windows.Forms.Button();
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
            this.rbDiario = new System.Windows.Forms.RadioButton();
            this.dtpHastaDia = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeDia = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidadVentas = new System.Windows.Forms.Label();
            this.lblPagas = new System.Windows.Forms.Label();
            this.lblNoPagas = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCobrado = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSinCobrar = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompras)).BeginInit();
            this.gbParametros.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartCompras
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCompras.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCompras.Legends.Add(legend2);
            this.chartCompras.Location = new System.Drawing.Point(12, 67);
            this.chartCompras.Name = "chartCompras";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartCompras.Series.Add(series2);
            this.chartCompras.Size = new System.Drawing.Size(526, 482);
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
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.cbTipoChart.Location = new System.Drawing.Point(506, 18);
            this.cbTipoChart.Name = "cbTipoChart";
            this.cbTipoChart.Size = new System.Drawing.Size(194, 21);
            this.cbTipoChart.TabIndex = 102;
            this.cbTipoChart.SelectedIndexChanged += new System.EventHandler(this.cbTipoChart_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Hasta";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Desde";
            this.label1.Visible = false;
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMensual.Location = new System.Drawing.Point(238, 19);
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
            this.label6.Location = new System.Drawing.Point(222, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 115;
            this.label6.Text = "Hasta";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, -8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 114;
            this.label5.Text = "Desde";
            this.label5.Visible = false;
            // 
            // dtpDesdeMensual
            // 
            this.dtpDesdeMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesdeMensual.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeMensual.Location = new System.Drawing.Point(263, -14);
            this.dtpDesdeMensual.Name = "dtpDesdeMensual";
            this.dtpDesdeMensual.Size = new System.Drawing.Size(96, 20);
            this.dtpDesdeMensual.TabIndex = 112;
            this.dtpDesdeMensual.Value = new System.DateTime(2015, 1, 1, 11, 59, 0, 0);
            this.dtpDesdeMensual.Visible = false;
            // 
            // dtpHastaMensual
            // 
            this.dtpHastaMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHastaMensual.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaMensual.Location = new System.Drawing.Point(263, 12);
            this.dtpHastaMensual.Name = "dtpHastaMensual";
            this.dtpHastaMensual.Size = new System.Drawing.Size(96, 20);
            this.dtpHastaMensual.TabIndex = 113;
            this.dtpHastaMensual.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 120;
            this.label4.Text = "Hasta";
            this.label4.Visible = false;
            // 
            // dtpDesdeAño
            // 
            this.dtpDesdeAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesdeAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeAño.Location = new System.Drawing.Point(419, -14);
            this.dtpDesdeAño.Name = "dtpDesdeAño";
            this.dtpDesdeAño.Size = new System.Drawing.Size(96, 20);
            this.dtpDesdeAño.TabIndex = 117;
            this.dtpDesdeAño.Value = new System.DateTime(2015, 1, 1, 11, 59, 0, 0);
            this.dtpDesdeAño.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, -8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 118;
            this.label3.Text = "Desde";
            this.label3.Visible = false;
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnual.Location = new System.Drawing.Point(407, 20);
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
            this.dtpHastaAño.Location = new System.Drawing.Point(419, 13);
            this.dtpHastaAño.Name = "dtpHastaAño";
            this.dtpHastaAño.Size = new System.Drawing.Size(96, 20);
            this.dtpHastaAño.TabIndex = 119;
            this.dtpHastaAño.Visible = false;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.rbAnual);
            this.gbParametros.Controls.Add(this.rbMensual);
            this.gbParametros.Controls.Add(this.rbDiario);
            this.gbParametros.Controls.Add(this.cbTipoChart);
            this.gbParametros.Controls.Add(this.txtID);
            this.gbParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametros.Location = new System.Drawing.Point(12, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(760, 49);
            this.gbParametros.TabIndex = 9;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parametros";
            // 
            // rbDiario
            // 
            this.rbDiario.AutoSize = true;
            this.rbDiario.Checked = true;
            this.rbDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiario.Location = new System.Drawing.Point(102, 19);
            this.rbDiario.Name = "rbDiario";
            this.rbDiario.Size = new System.Drawing.Size(52, 17);
            this.rbDiario.TabIndex = 110;
            this.rbDiario.TabStop = true;
            this.rbDiario.Text = "Diario";
            this.rbDiario.UseVisualStyleBackColor = true;
            this.rbDiario.CheckedChanged += new System.EventHandler(this.rbDiario_CheckedChanged_1);
            // 
            // dtpHastaDia
            // 
            this.dtpHastaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHastaDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaDia.Location = new System.Drawing.Point(114, 12);
            this.dtpHastaDia.Name = "dtpHastaDia";
            this.dtpHastaDia.Size = new System.Drawing.Size(96, 20);
            this.dtpHastaDia.TabIndex = 107;
            this.dtpHastaDia.Visible = false;
            // 
            // dtpDesdeDia
            // 
            this.dtpDesdeDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesdeDia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeDia.Location = new System.Drawing.Point(114, -14);
            this.dtpDesdeDia.Name = "dtpDesdeDia";
            this.dtpDesdeDia.Size = new System.Drawing.Size(96, 20);
            this.dtpDesdeDia.TabIndex = 106;
            this.dtpDesdeDia.Value = new System.DateTime(2015, 1, 1, 11, 59, 0, 0);
            this.dtpDesdeDia.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 101;
            this.label7.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Cantidad Ventas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(617, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 103;
            this.label9.Text = "Pagas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(600, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "No Pagas:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(664, 164);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 13);
            this.lblTotal.TabIndex = 107;
            this.lblTotal.Text = "label13";
            // 
            // lblCantidadVentas
            // 
            this.lblCantidadVentas.AutoSize = true;
            this.lblCantidadVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadVentas.Location = new System.Drawing.Point(664, 193);
            this.lblCantidadVentas.Name = "lblCantidadVentas";
            this.lblCantidadVentas.Size = new System.Drawing.Size(48, 13);
            this.lblCantidadVentas.TabIndex = 108;
            this.lblCantidadVentas.Text = "label13";
            // 
            // lblPagas
            // 
            this.lblPagas.AutoSize = true;
            this.lblPagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagas.Location = new System.Drawing.Point(663, 244);
            this.lblPagas.Name = "lblPagas";
            this.lblPagas.Size = new System.Drawing.Size(48, 13);
            this.lblPagas.TabIndex = 109;
            this.lblPagas.Text = "label13";
            // 
            // lblNoPagas
            // 
            this.lblNoPagas.AutoSize = true;
            this.lblNoPagas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPagas.Location = new System.Drawing.Point(663, 309);
            this.lblNoPagas.Name = "lblNoPagas";
            this.lblNoPagas.Size = new System.Drawing.Size(48, 13);
            this.lblNoPagas.TabIndex = 110;
            this.lblNoPagas.Text = "label13";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(544, 91);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 40);
            this.lblTitle.TabIndex = 121;
            this.lblTitle.Text = "Histórico";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCobrado
            // 
            this.lblCobrado.AutoSize = true;
            this.lblCobrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCobrado.Location = new System.Drawing.Point(664, 268);
            this.lblCobrado.Name = "lblCobrado";
            this.lblCobrado.Size = new System.Drawing.Size(48, 13);
            this.lblCobrado.TabIndex = 123;
            this.lblCobrado.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(608, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 122;
            this.label14.Text = "Cobrado:";
            // 
            // lblSinCobrar
            // 
            this.lblSinCobrar.AutoSize = true;
            this.lblSinCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinCobrar.Location = new System.Drawing.Point(664, 331);
            this.lblSinCobrar.Name = "lblSinCobrar";
            this.lblSinCobrar.Size = new System.Drawing.Size(48, 13);
            this.lblSinCobrar.TabIndex = 125;
            this.lblSinCobrar.Text = "label15";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(598, 331);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 13);
            this.label16.TabIndex = 124;
            this.label16.Text = "Sin Cobrar:";
            // 
            // formGVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblSinCobrar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblCobrado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dtpHastaAño);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNoPagas);
            this.Controls.Add(this.dtpDesdeAño);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPagas);
            this.Controls.Add(this.dtpHastaMensual);
            this.Controls.Add(this.lblCantidadVentas);
            this.Controls.Add(this.dtpDesdeMensual);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpHastaDia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpDesdeDia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartCompras);
            this.Controls.Add(this.gbParametros);
            this.Name = "formGVentas";
            this.Text = "Informe Ventas";
            this.Load += new System.EventHandler(this.formGVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCompras)).EndInit();
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartCompras;
        private System.Windows.Forms.Button button5;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidadVentas;
        private System.Windows.Forms.Label lblPagas;
        private System.Windows.Forms.Label lblNoPagas;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCobrado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblSinCobrar;
        private System.Windows.Forms.Label label16;
    }
}