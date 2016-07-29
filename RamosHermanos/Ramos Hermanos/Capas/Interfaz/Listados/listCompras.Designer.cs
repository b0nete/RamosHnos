namespace RamosHermanos.Capas.Interfaz.Listados
{
    partial class listCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listCompras));
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.colCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNoPagas = new System.Windows.Forms.RadioButton();
            this.txtParametro = new System.Windows.Forms.MaskedTextBox();
            this.rbPagas = new System.Windows.Forms.RadioButton();
            this.cbParametro = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.AllowUserToAddRows = false;
            this.dgvCompras.AllowUserToDeleteRows = false;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompra,
            this.colTipoFac,
            this.colFecha,
            this.colTotal,
            this.colProveedor,
            this.colEstado});
            this.dgvCompras.Location = new System.Drawing.Point(12, 107);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.ReadOnly = true;
            this.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompras.Size = new System.Drawing.Size(760, 442);
            this.dgvCompras.TabIndex = 1;
            this.dgvCompras.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCompras_MouseDoubleClick);
            // 
            // colCompra
            // 
            this.colCompra.DataPropertyName = "colCompra";
            this.colCompra.HeaderText = "Nº Comprobante";
            this.colCompra.Name = "colCompra";
            this.colCompra.ReadOnly = true;
            // 
            // colTipoFac
            // 
            this.colTipoFac.HeaderText = "Tipo Factura";
            this.colTipoFac.Name = "colTipoFac";
            this.colTipoFac.ReadOnly = true;
            this.colTipoFac.Visible = false;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "colFecha";
            this.colFecha.HeaderText = "Fecha Factura";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "colTotal";
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colProveedor
            // 
            this.colProveedor.DataPropertyName = "colProveedor";
            this.colProveedor.HeaderText = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "colEstado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEstado.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEstadisticas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbNoPagas);
            this.groupBox1.Controls.Add(this.txtParametro);
            this.groupBox1.Controls.Add(this.rbPagas);
            this.groupBox1.Controls.Add(this.cbParametro);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 89);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda Parametrizada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar por:";
            // 
            // rbNoPagas
            // 
            this.rbNoPagas.AutoSize = true;
            this.rbNoPagas.Checked = true;
            this.rbNoPagas.Location = new System.Drawing.Point(70, 57);
            this.rbNoPagas.Name = "rbNoPagas";
            this.rbNoPagas.Size = new System.Drawing.Size(80, 17);
            this.rbNoPagas.TabIndex = 57;
            this.rbNoPagas.TabStop = true;
            this.rbNoPagas.Text = "No Pagas";
            this.rbNoPagas.UseVisualStyleBackColor = true;
            this.rbNoPagas.CheckedChanged += new System.EventHandler(this.rbNoPagas_CheckedChanged);
            // 
            // txtParametro
            // 
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(223, 23);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(299, 20);
            this.txtParametro.TabIndex = 108;
            // 
            // rbPagas
            // 
            this.rbPagas.AutoSize = true;
            this.rbPagas.Location = new System.Drawing.Point(9, 57);
            this.rbPagas.Name = "rbPagas";
            this.rbPagas.Size = new System.Drawing.Size(60, 17);
            this.rbPagas.TabIndex = 56;
            this.rbPagas.Text = "Pagas";
            this.rbPagas.UseVisualStyleBackColor = true;
            this.rbPagas.CheckedChanged += new System.EventHandler(this.rbPagas_CheckedChanged);
            // 
            // cbParametro
            // 
            this.cbParametro.AutoCompleteCustomSource.AddRange(new string[] {
            "ID",
            "RazonSocial",
            "CUIT"});
            this.cbParametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParametro.FormattingEnabled = true;
            this.cbParametro.Items.AddRange(new object[] {
            "Nº Factura",
            "Fecha Factura",
            "Proveedor"});
            this.cbParametro.Location = new System.Drawing.Point(73, 23);
            this.cbParametro.Name = "cbParametro";
            this.cbParametro.Size = new System.Drawing.Size(133, 21);
            this.cbParametro.TabIndex = 107;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearch.Location = new System.Drawing.Point(528, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 28);
            this.btnSearch.TabIndex = 106;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEstadisticas.BackgroundImage")));
            this.btnEstadisticas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.Location = new System.Drawing.Point(726, 55);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(28, 28);
            this.btnEstadisticas.TabIndex = 118;
            this.btnEstadisticas.UseVisualStyleBackColor = true;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // listCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCompras);
            this.Name = "listCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Compras";
            this.Load += new System.EventHandler(this.listCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton rbNoPagas;
        private System.Windows.Forms.MaskedTextBox txtParametro;
        public System.Windows.Forms.RadioButton rbPagas;
        public System.Windows.Forms.ComboBox cbParametro;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.Button btnEstadisticas;
    }
}