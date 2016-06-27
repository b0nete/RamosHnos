namespace RamosHermanos.Capas.Graficos
{
    partial class formGInsumos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCompras = new System.Windows.Forms.TabPage();
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbDiario = new System.Windows.Forms.RadioButton();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.dtpDiariaDesde = new System.Windows.Forms.DateTimePicker();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.dtpDiariaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartCompras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabCompras.SuspendLayout();
            this.gbParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCompras);
            this.tabControl1.Location = new System.Drawing.Point(3, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCompras
            // 
            this.tabCompras.Controls.Add(this.gbParametros);
            this.tabCompras.Controls.Add(this.chartCompras);
            this.tabCompras.Location = new System.Drawing.Point(4, 22);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompras.Size = new System.Drawing.Size(773, 502);
            this.tabCompras.TabIndex = 1;
            this.tabCompras.Text = "Compras";
            this.tabCompras.UseVisualStyleBackColor = true;
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.txtID);
            this.gbParametros.Controls.Add(this.button1);
            this.gbParametros.Controls.Add(this.rbDiario);
            this.gbParametros.Controls.Add(this.rbAnual);
            this.gbParametros.Controls.Add(this.dtpDiariaDesde);
            this.gbParametros.Controls.Add(this.rbMensual);
            this.gbParametros.Controls.Add(this.dtpDiariaHasta);
            this.gbParametros.Controls.Add(this.label1);
            this.gbParametros.Controls.Add(this.label2);
            this.gbParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbParametros.Location = new System.Drawing.Point(8, 6);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(760, 109);
            this.gbParametros.TabIndex = 8;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parametros";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(679, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbDiario
            // 
            this.rbDiario.AutoSize = true;
            this.rbDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiario.Location = new System.Drawing.Point(16, 25);
            this.rbDiario.Name = "rbDiario";
            this.rbDiario.Size = new System.Drawing.Size(52, 17);
            this.rbDiario.TabIndex = 5;
            this.rbDiario.TabStop = true;
            this.rbDiario.Text = "Diario";
            this.rbDiario.UseVisualStyleBackColor = true;
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAnual.Location = new System.Drawing.Point(16, 71);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(52, 17);
            this.rbAnual.TabIndex = 7;
            this.rbAnual.TabStop = true;
            this.rbAnual.Text = "Anual";
            this.rbAnual.UseVisualStyleBackColor = true;
            // 
            // dtpDiariaDesde
            // 
            this.dtpDiariaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDiariaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiariaDesde.Location = new System.Drawing.Point(181, 32);
            this.dtpDiariaDesde.Name = "dtpDiariaDesde";
            this.dtpDiariaDesde.Size = new System.Drawing.Size(96, 20);
            this.dtpDiariaDesde.TabIndex = 1;
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMensual.Location = new System.Drawing.Point(16, 48);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(65, 17);
            this.rbMensual.TabIndex = 6;
            this.rbMensual.TabStop = true;
            this.rbMensual.Text = "Mensual";
            this.rbMensual.UseVisualStyleBackColor = true;
            // 
            // dtpDiariaHasta
            // 
            this.dtpDiariaHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDiariaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDiariaHasta.Location = new System.Drawing.Point(181, 58);
            this.dtpDiariaHasta.Name = "dtpDiariaHasta";
            this.dtpDiariaHasta.Size = new System.Drawing.Size(96, 20);
            this.dtpDiariaHasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // chartCompras
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCompras.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCompras.Legends.Add(legend1);
            this.chartCompras.Location = new System.Drawing.Point(8, 121);
            this.chartCompras.Name = "chartCompras";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCompras.Series.Add(series1);
            this.chartCompras.Size = new System.Drawing.Size(760, 406);
            this.chartCompras.TabIndex = 0;
            this.chartCompras.Text = "chart1";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(784, 30);
            this.lblTitle.TabIndex = 104;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(654, -3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 9;
            // 
            // formGInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControl1);
            this.Name = "formGInsumos";
            this.Text = "Grafico Estadístico";
            this.Load += new System.EventHandler(this.formGInsumos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCompras.ResumeLayout(false);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCompras;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCompras;
        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.RadioButton rbDiario;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.DateTimePicker dtpDiariaDesde;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.DateTimePicker dtpDiariaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label lblTitle;
    }
}