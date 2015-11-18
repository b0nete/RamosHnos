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
            this.rbDGVPJ = new System.Windows.Forms.RadioButton();
            this.rbDGV = new System.Windows.Forms.RadioButton();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.colIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCUIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicionIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDtipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // rbDGVPJ
            // 
            this.rbDGVPJ.AutoSize = true;
            this.rbDGVPJ.Location = new System.Drawing.Point(82, 9);
            this.rbDGVPJ.Name = "rbDGVPJ";
            this.rbDGVPJ.Size = new System.Drawing.Size(105, 17);
            this.rbDGVPJ.TabIndex = 6;
            this.rbDGVPJ.Text = "Persona Jurídica";
            this.rbDGVPJ.UseVisualStyleBackColor = true;
            this.rbDGVPJ.CheckedChanged += new System.EventHandler(this.rbDGVPJ_CheckedChanged_1);
            // 
            // rbDGV
            // 
            this.rbDGV.AutoSize = true;
            this.rbDGV.Checked = true;
            this.rbDGV.Location = new System.Drawing.Point(12, 9);
            this.rbDGV.Name = "rbDGV";
            this.rbDGV.Size = new System.Drawing.Size(64, 17);
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
            this.colSexo,
            this.colEstadoCivil,
            this.colCondicionIVA,
            this.colIDtipoCliente,
            this.coltipoCliente});
            this.dgvCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCliente.Location = new System.Drawing.Point(0, 32);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(784, 529);
            this.dgvCliente.TabIndex = 4;
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
            // 
            // colFechaAlta
            // 
            this.colFechaAlta.HeaderText = "Fecha Alta";
            this.colFechaAlta.Name = "colFechaAlta";
            this.colFechaAlta.ReadOnly = true;
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            // 
            // colEstadoCivil
            // 
            this.colEstadoCivil.HeaderText = "Estado Civil";
            this.colEstadoCivil.Name = "colEstadoCivil";
            this.colEstadoCivil.ReadOnly = true;
            // 
            // colCondicionIVA
            // 
            this.colCondicionIVA.HeaderText = "Condicion IVA";
            this.colCondicionIVA.Name = "colCondicionIVA";
            this.colCondicionIVA.ReadOnly = true;
            // 
            // colIDtipoCliente
            // 
            this.colIDtipoCliente.HeaderText = "ID Tipo Cliente";
            this.colIDtipoCliente.Name = "colIDtipoCliente";
            this.colIDtipoCliente.ReadOnly = true;
            this.colIDtipoCliente.Visible = false;
            // 
            // coltipoCliente
            // 
            this.coltipoCliente.HeaderText = "Categoria";
            this.coltipoCliente.Name = "coltipoCliente";
            this.coltipoCliente.ReadOnly = true;
            // 
            // listClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rbDGVPJ);
            this.Controls.Add(this.rbDGV);
            this.Controls.Add(this.dgvCliente);
            this.Name = "listClientes";
            this.Text = "Listado Clientes";
            this.Load += new System.EventHandler(this.listClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDGVPJ;
        private System.Windows.Forms.RadioButton rbDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCUIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicionIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDtipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltipoCliente;
        public System.Windows.Forms.DataGridView dgvCliente;
    }
}