namespace RamosHermanos.Capas.Interfaz.Listados
{
    partial class listClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listClientes));
            this.rbDGVPJ = new System.Windows.Forms.RadioButton();
            this.rbDGV = new System.Windows.Forms.RadioButton();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.MaskedTextBox();
            this.cbParametro = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.colIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCUIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDtipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDomicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDGVPJ
            // 
            this.rbDGVPJ.AutoSize = true;
            this.rbDGVPJ.Location = new System.Drawing.Point(82, 20);
            this.rbDGVPJ.Name = "rbDGVPJ";
            this.rbDGVPJ.Size = new System.Drawing.Size(121, 17);
            this.rbDGVPJ.TabIndex = 6;
            this.rbDGVPJ.Text = "Persona Jurídica";
            this.rbDGVPJ.UseVisualStyleBackColor = true;
            this.rbDGVPJ.CheckedChanged += new System.EventHandler(this.rbDGVPJ_CheckedChanged_1);
            // 
            // rbDGV
            // 
            this.rbDGV.AutoSize = true;
            this.rbDGV.Checked = true;
            this.rbDGV.Location = new System.Drawing.Point(12, 20);
            this.rbDGV.Name = "rbDGV";
            this.rbDGV.Size = new System.Drawing.Size(71, 17);
            this.rbDGV.TabIndex = 5;
            this.rbDGV.TabStop = true;
            this.rbDGV.Text = "Persona";
            this.rbDGV.UseVisualStyleBackColor = true;
            this.rbDGV.CheckedChanged += new System.EventHandler(this.rbDGV_CheckedChanged_1);
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDCliente,
            this.colApellido,
            this.colNombre,
            this.colIDTipoDoc,
            this.coltipoDoc,
            this.colNumDoc,
            this.colCUIL,
            this.colFechaAlta,
            this.colIDtipoCliente,
            this.colDomicilio,
            this.ColNumero});
            this.dgvCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCliente.Location = new System.Drawing.Point(0, 62);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(847, 499);
            this.dgvCliente.TabIndex = 4;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            this.dgvCliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCliente_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbDGVPJ);
            this.groupBox1.Controls.Add(this.txtParametro);
            this.groupBox1.Controls.Add(this.rbDGV);
            this.groupBox1.Controls.Add(this.cbParametro);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 52);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda Parametrizada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buscar por";
            // 
            // txtParametro
            // 
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(445, 19);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(299, 20);
            this.txtParametro.TabIndex = 108;
            this.txtParametro.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtParametro_MaskInputRejected);
            this.txtParametro.TextChanged += new System.EventHandler(this.txtParametro_TextChanged);
            // 
            // cbParametro
            // 
            this.cbParametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParametro.FormattingEnabled = true;
            this.cbParametro.Items.AddRange(new object[] {
            "Nº Cliente",
            "DNI",
            "CUIL/CUIT",
            "Apellido",
            "Nombre",
            "Domicilio"});
            this.cbParametro.Location = new System.Drawing.Point(290, 19);
            this.cbParametro.Name = "cbParametro";
            this.cbParametro.Size = new System.Drawing.Size(133, 21);
            this.cbParametro.TabIndex = 107;
            this.cbParametro.SelectedIndexChanged += new System.EventHandler(this.cbParametro_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearch.Location = new System.Drawing.Point(750, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 28);
            this.btnSearch.TabIndex = 106;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // colIDCliente
            // 
            this.colIDCliente.HeaderText = "Nº Cliente";
            this.colIDCliente.Name = "colIDCliente";
            this.colIDCliente.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colIDTipoDoc
            // 
            this.colIDTipoDoc.HeaderText = "ID Tipo Doc";
            this.colIDTipoDoc.Name = "colIDTipoDoc";
            this.colIDTipoDoc.ReadOnly = true;
            this.colIDTipoDoc.Visible = false;
            // 
            // coltipoDoc
            // 
            this.coltipoDoc.HeaderText = "Tipo Documento";
            this.coltipoDoc.Name = "coltipoDoc";
            this.coltipoDoc.ReadOnly = true;
            this.coltipoDoc.Visible = false;
            // 
            // colNumDoc
            // 
            this.colNumDoc.HeaderText = "Nº Documento";
            this.colNumDoc.Name = "colNumDoc";
            this.colNumDoc.ReadOnly = true;
            // 
            // colCUIL
            // 
            this.colCUIL.HeaderText = "CUIL";
            this.colCUIL.Name = "colCUIL";
            this.colCUIL.ReadOnly = true;
            this.colCUIL.Visible = false;
            // 
            // colFechaAlta
            // 
            this.colFechaAlta.HeaderText = "Fecha Alta";
            this.colFechaAlta.Name = "colFechaAlta";
            this.colFechaAlta.ReadOnly = true;
            this.colFechaAlta.Visible = false;
            // 
            // colIDtipoCliente
            // 
            this.colIDtipoCliente.HeaderText = "ID Tipo Cliente";
            this.colIDtipoCliente.Name = "colIDtipoCliente";
            this.colIDtipoCliente.ReadOnly = true;
            this.colIDtipoCliente.Visible = false;
            // 
            // colDomicilio
            // 
            this.colDomicilio.HeaderText = "Domicilio";
            this.colDomicilio.Name = "colDomicilio";
            this.colDomicilio.ReadOnly = true;
            // 
            // ColNumero
            // 
            this.ColNumero.HeaderText = "Numero";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            // 
            // listClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCliente);
            this.MaximizeBox = false;
            this.Name = "listClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Clientes";
            this.Load += new System.EventHandler(this.listClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDGVPJ;
        private System.Windows.Forms.RadioButton rbDGV;
        public System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtParametro;
        private System.Windows.Forms.ComboBox cbParametro;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCUIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDtipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDomicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
    }
}