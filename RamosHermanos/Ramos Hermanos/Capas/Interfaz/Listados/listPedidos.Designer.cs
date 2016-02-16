namespace RamosHermanos.Capas.Interfaz.Listados
{
    partial class listPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listPedidos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParametro = new System.Windows.Forms.MaskedTextBox();
            this.cbParametro = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvListadoPedidos = new System.Windows.Forms.DataGridView();
            this.colIDpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtParametro);
            this.groupBox1.Controls.Add(this.cbParametro);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 52);
            this.groupBox1.TabIndex = 54;
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
            // txtParametro
            // 
            this.txtParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParametro.Location = new System.Drawing.Point(223, 23);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(299, 20);
            this.txtParametro.TabIndex = 108;
            this.txtParametro.TextChanged += new System.EventHandler(this.txtParametro_TextChanged);
            // 
            // cbParametro
            // 
            this.cbParametro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParametro.FormattingEnabled = true;
            this.cbParametro.Items.AddRange(new object[] {
            "ID",
            "IDCliente",
            "Fecha"});
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
            // dgvListadoPedidos
            // 
            this.dgvListadoPedidos.AllowUserToAddRows = false;
            this.dgvListadoPedidos.AllowUserToDeleteRows = false;
            this.dgvListadoPedidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListadoPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDpedido,
            this.colCliente,
            this.colApellidoCli,
            this.colNombreCli,
            this.colFechaPedido,
            this.colEstado});
            this.dgvListadoPedidos.Location = new System.Drawing.Point(12, 70);
            this.dgvListadoPedidos.Name = "dgvListadoPedidos";
            this.dgvListadoPedidos.ReadOnly = true;
            this.dgvListadoPedidos.Size = new System.Drawing.Size(746, 686);
            this.dgvListadoPedidos.TabIndex = 55;
            this.dgvListadoPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoPedidos_CellContentClick);
            this.dgvListadoPedidos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvListadoPedidos_MouseDoubleClick);
            // 
            // colIDpedido
            // 
            this.colIDpedido.HeaderText = "IDPedido";
            this.colIDpedido.Name = "colIDpedido";
            this.colIDpedido.ReadOnly = true;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "IDCliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            // 
            // colApellidoCli
            // 
            this.colApellidoCli.HeaderText = "Apellido";
            this.colApellidoCli.Name = "colApellidoCli";
            this.colApellidoCli.ReadOnly = true;
            // 
            // colNombreCli
            // 
            this.colNombreCli.HeaderText = "Nombre";
            this.colNombreCli.Name = "colNombreCli";
            this.colNombreCli.ReadOnly = true;
            // 
            // colFechaPedido
            // 
            this.colFechaPedido.HeaderText = "FechaPedido";
            this.colFechaPedido.Name = "colFechaPedido";
            this.colFechaPedido.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // listPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.dgvListadoPedidos);
            this.Controls.Add(this.groupBox1);
            this.Name = "listPedidos";
            this.Text = "listPedidos";
            this.Load += new System.EventHandler(this.listPedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtParametro;
        private System.Windows.Forms.ComboBox cbParametro;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvListadoPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}