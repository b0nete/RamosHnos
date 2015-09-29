namespace RamosHermanos.Capas.Interfaz
{
    partial class formFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFactura));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabFactura = new System.Windows.Forms.TabPage();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpfechaFactura = new System.Windows.Forms.DateTimePicker();
            this.cbTipoFactura = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtnumFactura = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpfechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbformaPago = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDomicilio = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.txtnumDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.colIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.colIDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCUIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCondicionIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIDtipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabImpresion = new System.Windows.Forms.TabPage();
            this.crvImpresion = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dsFactura = new RamosHermanos.Capas.Reportes.dsFactura();
            this.tabMain.SuspendLayout();
            this.tabFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.tabImpresion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabFactura);
            this.tabMain.Controls.Add(this.tabProductos);
            this.tabMain.Controls.Add(this.tabClientes);
            this.tabMain.Controls.Add(this.tabImpresion);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(784, 729);
            this.tabMain.TabIndex = 0;
            this.tabMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabMain_MouseDoubleClick);
            // 
            // tabFactura
            // 
            this.tabFactura.Controls.Add(this.btnPrint);
            this.tabFactura.Controls.Add(this.cbEstado);
            this.tabFactura.Controls.Add(this.label12);
            this.tabFactura.Controls.Add(this.button3);
            this.tabFactura.Controls.Add(this.button2);
            this.tabFactura.Controls.Add(this.txtObservaciones);
            this.tabFactura.Controls.Add(this.label9);
            this.tabFactura.Controls.Add(this.txtTotal);
            this.tabFactura.Controls.Add(this.label2);
            this.tabFactura.Controls.Add(this.btnClean);
            this.tabFactura.Controls.Add(this.button4);
            this.tabFactura.Controls.Add(this.btnSave);
            this.tabFactura.Controls.Add(this.dgvFactura);
            this.tabFactura.Controls.Add(this.groupBox3);
            this.tabFactura.Controls.Add(this.groupBox2);
            this.tabFactura.Controls.Add(this.groupBox1);
            this.tabFactura.Location = new System.Drawing.Point(4, 22);
            this.tabFactura.Name = "tabFactura";
            this.tabFactura.Padding = new System.Windows.Forms.Padding(3);
            this.tabFactura.Size = new System.Drawing.Size(776, 703);
            this.tabFactura.TabIndex = 1;
            this.tabFactura.Text = "Factura";
            this.tabFactura.UseVisualStyleBackColor = true;
            this.tabFactura.Click += new System.EventHandler(this.tabFactura_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(638, 667);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(28, 28);
            this.btnPrint.TabIndex = 92;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "PENDIENTE",
            "ANULADO",
            "PAGADO"});
            this.cbEstado.Location = new System.Drawing.Point(639, 598);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(129, 21);
            this.cbEstado.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(599, 601);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 91;
            this.label12.Text = "Estado";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(740, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 89;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(706, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 87;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(8, 588);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(573, 78);
            this.txtObservaciones.TabIndex = 86;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 572);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Observaciones:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(639, 572);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(129, 20);
            this.txtTotal.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "TOTAL";
            // 
            // btnClean
            // 
            this.btnClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClean.BackgroundImage")));
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(672, 667);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(28, 28);
            this.btnClean.TabIndex = 84;
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button4.Location = new System.Drawing.Point(740, 667);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 28);
            this.button4.TabIndex = 83;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(706, 667);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(28, 28);
            this.btnSave.TabIndex = 82;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvFactura
            // 
            this.dgvFactura.AllowUserToAddRows = false;
            this.dgvFactura.AllowUserToDeleteRows = false;
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colProducto,
            this.colCantidad,
            this.colPrecio,
            this.colSubTotal});
            this.dgvFactura.Location = new System.Drawing.Point(8, 250);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(760, 316);
            this.dgvFactura.TabIndex = 79;
            this.dgvFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellContentClick);
            this.dgvFactura.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvFactura_CellStateChanged);
            this.dgvFactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFactura_CellValueChanged);
            this.dgvFactura.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvFactura_MouseClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio Unitario";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // colSubTotal
            // 
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpfechaFactura);
            this.groupBox3.Controls.Add(this.cbTipoFactura);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtnumFactura);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(426, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 125);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Soderia";
            // 
            // dtpfechaFactura
            // 
            this.dtpfechaFactura.CustomFormat = "dd/MM/yyyy";
            this.dtpfechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechaFactura.Location = new System.Drawing.Point(83, 70);
            this.dtpfechaFactura.Name = "dtpfechaFactura";
            this.dtpfechaFactura.Size = new System.Drawing.Size(253, 20);
            this.dtpfechaFactura.TabIndex = 11;
            // 
            // cbTipoFactura
            // 
            this.cbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoFactura.FormattingEnabled = true;
            this.cbTipoFactura.Items.AddRange(new object[] {
            "C",
            "E",
            "X"});
            this.cbTipoFactura.Location = new System.Drawing.Point(83, 17);
            this.cbTipoFactura.Name = "cbTipoFactura";
            this.cbTipoFactura.Size = new System.Drawing.Size(60, 21);
            this.cbTipoFactura.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo Factura";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(7, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Fecha Factura";
            // 
            // txtnumFactura
            // 
            this.txtnumFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumFactura.Location = new System.Drawing.Point(83, 44);
            this.txtnumFactura.Name = "txtnumFactura";
            this.txtnumFactura.Size = new System.Drawing.Size(253, 20);
            this.txtnumFactura.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Nº Factura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpfechaEntrega);
            this.groupBox2.Controls.Add(this.dtpVencimiento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbformaPago);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 73);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles Venta";
            // 
            // dtpfechaEntrega
            // 
            this.dtpfechaEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtpfechaEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfechaEntrega.Location = new System.Drawing.Point(91, 46);
            this.dtpfechaEntrega.Name = "dtpfechaEntrega";
            this.dtpfechaEntrega.Size = new System.Drawing.Size(210, 20);
            this.dtpfechaEntrega.TabIndex = 13;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CustomFormat = "dd/MM/yyyy";
            this.dtpVencimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencimiento.Location = new System.Drawing.Point(373, 19);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpVencimiento.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(14, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fecha Entrega";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(307, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Vencimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Forma de Pago";
            // 
            // cbformaPago
            // 
            this.cbformaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbformaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbformaPago.FormattingEnabled = true;
            this.cbformaPago.Items.AddRange(new object[] {
            "Efectivo"});
            this.cbformaPago.Location = new System.Drawing.Point(91, 19);
            this.cbformaPago.Name = "cbformaPago";
            this.cbformaPago.Size = new System.Drawing.Size(210, 21);
            this.cbformaPago.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDomicilio);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtIVA);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtIDcliente);
            this.groupBox1.Controls.Add(this.txtnumDoc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 125);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // cbDomicilio
            // 
            this.cbDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDomicilio.FormattingEnabled = true;
            this.cbDomicilio.Items.AddRange(new object[] {
            "C",
            "E",
            "X"});
            this.cbDomicilio.Location = new System.Drawing.Point(75, 69);
            this.cbDomicilio.Name = "cbDomicilio";
            this.cbDomicilio.Size = new System.Drawing.Size(331, 21);
            this.cbDomicilio.TabIndex = 10;
            this.cbDomicilio.SelectedIndexChanged += new System.EventHandler(this.cbDomicilio_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(142, 17);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 20);
            this.txtNombre.TabIndex = 90;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearch.Location = new System.Drawing.Point(379, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 28);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIVA
            // 
            this.txtIVA.Enabled = false;
            this.txtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(75, 95);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(172, 20);
            this.txtIVA.TabIndex = 11;
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(253, 43);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(154, 20);
            this.txtTel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(198, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(1, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Condicion IVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(26, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Domicilio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Documento";
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Enabled = false;
            this.txtIDcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDcliente.Location = new System.Drawing.Point(75, 17);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.Size = new System.Drawing.Size(61, 20);
            this.txtIDcliente.TabIndex = 6;
            // 
            // txtnumDoc
            // 
            this.txtnumDoc.Enabled = false;
            this.txtnumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumDoc.Location = new System.Drawing.Point(75, 43);
            this.txtnumDoc.Name = "txtnumDoc";
            this.txtnumDoc.Size = new System.Drawing.Size(117, 20);
            this.txtnumDoc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.dgvProducto);
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Size = new System.Drawing.Size(776, 703);
            this.tabProductos.TabIndex = 2;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDProducto,
            this.colTipo,
            this.colMarca,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.colMedida,
            this.colStock,
            this.dataGridViewTextBoxColumn3});
            this.dgvProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducto.Location = new System.Drawing.Point(0, 0);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(776, 703);
            this.dgvProducto.TabIndex = 53;
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            this.dgvProducto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProducto_MouseDoubleClick);
            // 
            // colIDProducto
            // 
            this.colIDProducto.HeaderText = "Nº Producto";
            this.colIDProducto.Name = "colIDProducto";
            this.colIDProducto.ReadOnly = true;
            this.colIDProducto.Visible = false;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // colMedida
            // 
            this.colMedida.HeaderText = "Medida";
            this.colMedida.Name = "colMedida";
            this.colMedida.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.dgvCliente);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Size = new System.Drawing.Size(776, 703);
            this.tabClientes.TabIndex = 3;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDCliente,
            this.colFechaAlta,
            this.colIDTipoDoc,
            this.coltipoDoc,
            this.colNumDoc,
            this.colSexo,
            this.colCUIL,
            this.colApellido,
            this.colNombre,
            this.colEstadoCivil,
            this.colCondicionIVA,
            this.colIDtipoCliente,
            this.coltipoCliente});
            this.dgvCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCliente.Location = new System.Drawing.Point(0, 0);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(776, 703);
            this.dgvCliente.TabIndex = 2;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            this.dgvCliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCliente_MouseDoubleClick);
            // 
            // colIDCliente
            // 
            this.colIDCliente.HeaderText = "Nº Cliente";
            this.colIDCliente.Name = "colIDCliente";
            this.colIDCliente.ReadOnly = true;
            // 
            // colFechaAlta
            // 
            this.colFechaAlta.HeaderText = "Fecha Alta";
            this.colFechaAlta.Name = "colFechaAlta";
            this.colFechaAlta.ReadOnly = true;
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
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            // 
            // colCUIL
            // 
            this.colCUIL.HeaderText = "CUIL";
            this.colCUIL.Name = "colCUIL";
            this.colCUIL.ReadOnly = true;
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
            this.coltipoCliente.HeaderText = "Tipo Cliente";
            this.coltipoCliente.Name = "coltipoCliente";
            this.coltipoCliente.ReadOnly = true;
            // 
            // tabImpresion
            // 
            this.tabImpresion.Controls.Add(this.crvImpresion);
            this.tabImpresion.Location = new System.Drawing.Point(4, 22);
            this.tabImpresion.Name = "tabImpresion";
            this.tabImpresion.Size = new System.Drawing.Size(776, 703);
            this.tabImpresion.TabIndex = 4;
            this.tabImpresion.Text = "Impresion";
            this.tabImpresion.UseVisualStyleBackColor = true;
            // 
            // crvImpresion
            // 
            this.crvImpresion.ActiveViewIndex = -1;
            this.crvImpresion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvImpresion.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvImpresion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvImpresion.Location = new System.Drawing.Point(0, 0);
            this.crvImpresion.Name = "crvImpresion";
            this.crvImpresion.Size = new System.Drawing.Size(776, 703);
            this.crvImpresion.TabIndex = 0;
            this.crvImpresion.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // dsFactura
            // 
            this.dsFactura.DataSetName = "dsFactura";
            this.dsFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 729);
            this.Controls.Add(this.tabMain);
            this.Name = "formFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.formFactura_Load);
            this.tabMain.ResumeLayout(false);
            this.tabFactura.ResumeLayout(false);
            this.tabFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.tabClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.tabImpresion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabFactura;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpfechaFactura;
        private System.Windows.Forms.ComboBox cbTipoFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtnumFactura;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpfechaEntrega;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbformaPago;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.TextBox txtnumDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCUIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCondicionIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDtipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltipoCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbDomicilio;
        private System.Windows.Forms.TabPage tabImpresion;
        private System.Windows.Forms.Button btnPrint;
        private Reportes.dsFactura dsFactura;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvImpresion;

    }
}