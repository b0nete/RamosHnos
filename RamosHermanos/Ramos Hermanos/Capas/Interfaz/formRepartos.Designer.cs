namespace RamosHermanos.Capas.Interfaz
{
    partial class formRepartos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRepartos));
            this.dtpFechaReparto = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReparto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDistribuidores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRepartos = new System.Windows.Forms.DataGridView();
            this.colOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colASaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colACarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDCarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colADescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCDescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCDescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPDescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDDescarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCobro = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepartos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaReparto
            // 
            this.dtpFechaReparto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReparto.Location = new System.Drawing.Point(64, 12);
            this.dtpFechaReparto.Name = "dtpFechaReparto";
            this.dtpFechaReparto.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaReparto.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Reparto:";
            // 
            // txtReparto
            // 
            this.txtReparto.Location = new System.Drawing.Point(576, 14);
            this.txtReparto.Name = "txtReparto";
            this.txtReparto.Size = new System.Drawing.Size(100, 20);
            this.txtReparto.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Distribuidor:";
            // 
            // cbDistribuidores
            // 
            this.cbDistribuidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistribuidores.FormattingEnabled = true;
            this.cbDistribuidores.Location = new System.Drawing.Point(300, 13);
            this.cbDistribuidores.Name = "cbDistribuidores";
            this.cbDistribuidores.Size = new System.Drawing.Size(121, 21);
            this.cbDistribuidores.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha:";
            // 
            // dgvRepartos
            // 
            this.dgvRepartos.AllowUserToAddRows = false;
            this.dgvRepartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrden,
            this.colIDCliente,
            this.colCliente,
            this.colIDDomicilio,
            this.Column3,
            this.Column4,
            this.colASaldo,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.colSaldo,
            this.colSCarga,
            this.colACarga,
            this.colCCarga,
            this.colCCCarga,
            this.colPCarga,
            this.colDCarga,
            this.colSDescarga,
            this.colADescarga,
            this.colCDescarga,
            this.colCCDescarga,
            this.colPDescarga,
            this.colDDescarga,
            this.colVenta,
            this.colCobro,
            this.Column25,
            this.colComprobante});
            this.dgvRepartos.Location = new System.Drawing.Point(12, 39);
            this.dgvRepartos.Name = "dgvRepartos";
            this.dgvRepartos.Size = new System.Drawing.Size(984, 678);
            this.dgvRepartos.TabIndex = 12;
            this.dgvRepartos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRepartos_CellEndEdit_1);
            this.dgvRepartos.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRepartos_CellLeave);
            this.dgvRepartos.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvRepartos_CellStateChanged);
            this.dgvRepartos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRepartos_CellValueChanged);
            this.dgvRepartos.CurrentCellChanged += new System.EventHandler(this.dgvRepartos_CurrentCellChanged);
            this.dgvRepartos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvRepartos_CurrentCellDirtyStateChanged);
            this.dgvRepartos.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvRepartos_EditingControlShowing);
            this.dgvRepartos.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvRepartos_RowStateChanged);
            this.dgvRepartos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRepartos_KeyDown);
            // 
            // colOrden
            // 
            this.colOrden.HeaderText = "Nº";
            this.colOrden.Name = "colOrden";
            this.colOrden.Width = 30;
            // 
            // colIDCliente
            // 
            this.colIDCliente.DataPropertyName = "idCliente";
            this.colIDCliente.HeaderText = "ID Cliente";
            this.colIDCliente.Name = "colIDCliente";
            this.colIDCliente.Visible = false;
            // 
            // colCliente
            // 
            this.colCliente.DataPropertyName = "clienteCompleto";
            this.colCliente.HeaderText = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Width = 270;
            // 
            // colIDDomicilio
            // 
            this.colIDDomicilio.DataPropertyName = "idDomicilio";
            this.colIDDomicilio.HeaderText = "ID Domicilio";
            this.colIDDomicilio.Name = "colIDDomicilio";
            this.colIDDomicilio.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "domicilioCompleto";
            this.Column3.HeaderText = "Domicilio";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "colSSaldo";
            this.Column4.HeaderText = "S";
            this.Column4.Name = "Column4";
            this.Column4.Width = 25;
            // 
            // colASaldo
            // 
            this.colASaldo.DataPropertyName = "colASaldo";
            this.colASaldo.HeaderText = "A";
            this.colASaldo.Name = "colASaldo";
            this.colASaldo.Width = 25;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "colCSaldo";
            this.Column6.HeaderText = "C";
            this.Column6.Name = "Column6";
            this.Column6.Width = 25;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "colCCSaldo";
            this.Column7.HeaderText = "C";
            this.Column7.Name = "Column7";
            this.Column7.Width = 25;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "colPSaldo";
            this.Column8.HeaderText = "P";
            this.Column8.Name = "Column8";
            this.Column8.Width = 25;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "colDSaldo";
            this.Column9.HeaderText = "D";
            this.Column9.Name = "Column9";
            this.Column9.Width = 25;
            // 
            // colSaldo
            // 
            this.colSaldo.DataPropertyName = "colSCCSaldo";
            this.colSaldo.HeaderText = "Saldo CC";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.Width = 50;
            // 
            // colSCarga
            // 
            this.colSCarga.DataPropertyName = "colSCarga";
            this.colSCarga.HeaderText = "S";
            this.colSCarga.Name = "colSCarga";
            this.colSCarga.Width = 25;
            // 
            // colACarga
            // 
            this.colACarga.DataPropertyName = "colACarga";
            this.colACarga.HeaderText = "A";
            this.colACarga.Name = "colACarga";
            this.colACarga.ReadOnly = true;
            this.colACarga.Width = 25;
            // 
            // colCCarga
            // 
            this.colCCarga.DataPropertyName = "colCCarga";
            this.colCCarga.HeaderText = "C";
            this.colCCarga.Name = "colCCarga";
            this.colCCarga.Width = 25;
            // 
            // colCCCarga
            // 
            this.colCCCarga.DataPropertyName = "colCCCarga";
            this.colCCCarga.HeaderText = "C";
            this.colCCCarga.Name = "colCCCarga";
            this.colCCCarga.Width = 25;
            // 
            // colPCarga
            // 
            this.colPCarga.DataPropertyName = "colPCarga";
            this.colPCarga.HeaderText = "P";
            this.colPCarga.Name = "colPCarga";
            this.colPCarga.Width = 25;
            // 
            // colDCarga
            // 
            this.colDCarga.DataPropertyName = "colDCarga";
            this.colDCarga.HeaderText = "D";
            this.colDCarga.Name = "colDCarga";
            this.colDCarga.Width = 25;
            // 
            // colSDescarga
            // 
            this.colSDescarga.DataPropertyName = "colSDescarga";
            this.colSDescarga.HeaderText = "S";
            this.colSDescarga.Name = "colSDescarga";
            this.colSDescarga.Width = 25;
            // 
            // colADescarga
            // 
            this.colADescarga.DataPropertyName = "colADescarga";
            this.colADescarga.HeaderText = "A";
            this.colADescarga.Name = "colADescarga";
            this.colADescarga.ReadOnly = true;
            this.colADescarga.Width = 25;
            // 
            // colCDescarga
            // 
            this.colCDescarga.DataPropertyName = "colCDescarga";
            this.colCDescarga.HeaderText = "C";
            this.colCDescarga.Name = "colCDescarga";
            this.colCDescarga.Width = 25;
            // 
            // colCCDescarga
            // 
            this.colCCDescarga.DataPropertyName = "colCCDescarga";
            this.colCCDescarga.HeaderText = "C";
            this.colCCDescarga.Name = "colCCDescarga";
            this.colCCDescarga.Width = 25;
            // 
            // colPDescarga
            // 
            this.colPDescarga.DataPropertyName = "colPDescarga";
            this.colPDescarga.HeaderText = "P";
            this.colPDescarga.Name = "colPDescarga";
            this.colPDescarga.Width = 25;
            // 
            // colDDescarga
            // 
            this.colDDescarga.DataPropertyName = "colDDescarga";
            this.colDDescarga.HeaderText = "D";
            this.colDDescarga.Name = "colDDescarga";
            this.colDDescarga.Width = 25;
            // 
            // colVenta
            // 
            this.colVenta.DataPropertyName = "colVenta";
            this.colVenta.HeaderText = "Venta";
            this.colVenta.Name = "colVenta";
            this.colVenta.Width = 50;
            // 
            // colCobro
            // 
            this.colCobro.DataPropertyName = "colCobro";
            this.colCobro.HeaderText = "Cobro";
            this.colCobro.Name = "colCobro";
            this.colCobro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCobro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colCobro.Width = 50;
            // 
            // Column25
            // 
            this.Column25.DataPropertyName = "colSaldoCC";
            this.Column25.HeaderText = "Saldo CC";
            this.Column25.Name = "Column25";
            this.Column25.Visible = false;
            this.Column25.Width = 50;
            // 
            // colComprobante
            // 
            this.colComprobante.DataPropertyName = "idComprobante";
            this.colComprobante.HeaderText = "Comprobante";
            this.colComprobante.Name = "colComprobante";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(968, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 99;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // formRepartos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtpFechaReparto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReparto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDistribuidores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRepartos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formRepartos";
            this.Text = "Repartos";
            this.Load += new System.EventHandler(this.formRepartos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepartos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DateTimePicker dtpFechaReparto;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtReparto;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbDistribuidores;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvRepartos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colASaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colACarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDCarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colADescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCDescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCDescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPDescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDDescarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVenta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComprobante;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button3;

    }
}