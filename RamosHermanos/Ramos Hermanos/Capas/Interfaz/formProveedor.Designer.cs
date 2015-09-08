namespace RamosHermanos.Capas.Interfaz
{
    partial class formProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProveedor));
            this.tabProveedor = new System.Windows.Forms.TabControl();
            this.tabInformacion = new System.Windows.Forms.TabPage();
            this.btnClean = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSaldoActual = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDebmax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbIVA = new System.Windows.Forms.ComboBox();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcuit = new System.Windows.Forms.MaskedTextBox();
            this.txtidprov = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRubro = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDomicilio = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.btnTelefono = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbVisita = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button4 = new System.Windows.Forms.Button();
            this.btnGuardarProv = new System.Windows.Forms.Button();
            this.tabAdicional = new System.Windows.Forms.TabPage();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.colidprov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMovimientos = new System.Windows.Forms.TabPage();
            this.tabPedido = new System.Windows.Forms.TabPage();
            this.idColRub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabProveedor.SuspendLayout();
            this.tabInformacion.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbVisita.SuspendLayout();
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProveedor
            // 
            this.tabProveedor.Controls.Add(this.tabInformacion);
            this.tabProveedor.Controls.Add(this.tabAdicional);
            this.tabProveedor.Controls.Add(this.tabListado);
            this.tabProveedor.Controls.Add(this.tabMovimientos);
            this.tabProveedor.Controls.Add(this.tabPedido);
            this.tabProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProveedor.Location = new System.Drawing.Point(0, 0);
            this.tabProveedor.Name = "tabProveedor";
            this.tabProveedor.SelectedIndex = 0;
            this.tabProveedor.Size = new System.Drawing.Size(784, 562);
            this.tabProveedor.TabIndex = 0;
            // 
            // tabInformacion
            // 
            this.tabInformacion.Controls.Add(this.btnClean);
            this.tabInformacion.Controls.Add(this.groupBox6);
            this.tabInformacion.Controls.Add(this.groupBox2);
            this.tabInformacion.Controls.Add(this.groupBox1);
            this.tabInformacion.Controls.Add(this.gbVisita);
            this.tabInformacion.Controls.Add(this.button4);
            this.tabInformacion.Controls.Add(this.btnGuardarProv);
            this.tabInformacion.Location = new System.Drawing.Point(4, 22);
            this.tabInformacion.Name = "tabInformacion";
            this.tabInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformacion.Size = new System.Drawing.Size(776, 536);
            this.tabInformacion.TabIndex = 0;
            this.tabInformacion.Text = "Informacion";
            this.tabInformacion.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClean.BackgroundImage")));
            this.btnClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Location = new System.Drawing.Point(666, 498);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(28, 28);
            this.btnClean.TabIndex = 71;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txtSaldoActual);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtDebmax);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.btnSearch);
            this.groupBox6.Controls.Add(this.cbIVA);
            this.groupBox6.Controls.Add(this.dtpFechaAlta);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.cbEstado);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtcuit);
            this.groupBox6.Controls.Add(this.txtidprov);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.txtRazonSocial);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(6, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(494, 354);
            this.groupBox6.TabIndex = 67;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Informacion Personal";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(16, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "*";
            // 
            // txtSaldoActual
            // 
            this.txtSaldoActual.Enabled = false;
            this.txtSaldoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSaldoActual.Location = new System.Drawing.Point(102, 202);
            this.txtSaldoActual.Name = "txtSaldoActual";
            this.txtSaldoActual.Size = new System.Drawing.Size(355, 20);
            this.txtSaldoActual.TabIndex = 96;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(59, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 98;
            this.label13.Text = "Saldo";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(10, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 94;
            this.label6.Text = "*";
            // 
            // txtDebmax
            // 
            this.txtDebmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDebmax.Location = new System.Drawing.Point(102, 176);
            this.txtDebmax.Name = "txtDebmax";
            this.txtDebmax.Size = new System.Drawing.Size(355, 20);
            this.txtDebmax.TabIndex = 93;
            this.txtDebmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebmax_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(20, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "Débito Máximo";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearch.Location = new System.Drawing.Point(463, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 28);
            this.btnSearch.TabIndex = 88;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbIVA
            // 
            this.cbIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIVA.FormattingEnabled = true;
            this.cbIVA.Items.AddRange(new object[] {
            "IVA Responsable Inscripto",
            "IVA Responsable no Inscripto",
            "IVA no Responsable",
            "IVA Sujeto Exento",
            "Consumidor Final",
            "Responsable Monotributo",
            "Sujeto no Categorizado",
            "Proveedor del Exterior",
            "Cliente del Exterior",
            "IVA Liberado – Ley Nº 19.640",
            "IVA Responsable Inscripto – Agente de Percepción",
            "Pequeño Contribuyente Eventual",
            "Monotributista Social",
            "Pequeño Contribuyente Eventual Social"});
            this.cbIVA.Location = new System.Drawing.Point(102, 150);
            this.cbIVA.Name = "cbIVA";
            this.cbIVA.Size = new System.Drawing.Size(355, 21);
            this.cbIVA.TabIndex = 83;
            this.cbIVA.SelectedIndexChanged += new System.EventHandler(this.cbIVA_SelectedIndexChanged);
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaAlta.Enabled = false;
            this.dtpFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaAlta.Location = new System.Drawing.Point(102, 68);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(355, 20);
            this.dtpFechaAlta.TabIndex = 81;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label20.Location = new System.Drawing.Point(25, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(74, 13);
            this.label20.TabIndex = 80;
            this.label20.Text = "Condicion IVA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(41, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 78;
            this.label12.Text = "Fecha Alta";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Checked = true;
            this.cbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEstado.Location = new System.Drawing.Point(102, 22);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(15, 14);
            this.cbEstado.TabIndex = 77;
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(59, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 76;
            this.label11.Text = "Estado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(31, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nº Proveedor";
            // 
            // txtcuit
            // 
            this.txtcuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuit.Location = new System.Drawing.Point(102, 95);
            this.txtcuit.Mask = "00-00000000-0";
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.Size = new System.Drawing.Size(355, 20);
            this.txtcuit.TabIndex = 61;
            this.txtcuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtcuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcuit_KeyPress);
            // 
            // txtidprov
            // 
            this.txtidprov.Enabled = false;
            this.txtidprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtidprov.Location = new System.Drawing.Point(102, 42);
            this.txtidprov.Name = "txtidprov";
            this.txtidprov.Size = new System.Drawing.Size(355, 20);
            this.txtidprov.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(57, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(23, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 70;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.Location = new System.Drawing.Point(65, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 69;
            this.label14.Text = "CUIT";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRazonSocial.Location = new System.Drawing.Point(102, 124);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(355, 20);
            this.txtRazonSocial.TabIndex = 62;
            this.txtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonSocial_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(31, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Razon Social";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRubro);
            this.groupBox2.Location = new System.Drawing.Point(502, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 261);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rubros";
            // 
            // dgvRubro
            // 
            this.dgvRubro.AllowUserToAddRows = false;
            this.dgvRubro.AllowUserToDeleteRows = false;
            this.dgvRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRubro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColRub,
            this.colSeleccion,
            this.colRubro});
            this.dgvRubro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRubro.Location = new System.Drawing.Point(3, 16);
            this.dgvRubro.Name = "dgvRubro";
            this.dgvRubro.Size = new System.Drawing.Size(259, 242);
            this.dgvRubro.TabIndex = 0;
            this.dgvRubro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRubro_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDomicilio);
            this.groupBox1.Controls.Add(this.btnEmail);
            this.groupBox1.Controls.Add(this.btnTelefono);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(6, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 125);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contacto";
            // 
            // btnDomicilio
            // 
            this.btnDomicilio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDomicilio.BackgroundImage")));
            this.btnDomicilio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDomicilio.Location = new System.Drawing.Point(463, 55);
            this.btnDomicilio.Name = "btnDomicilio";
            this.btnDomicilio.Size = new System.Drawing.Size(28, 28);
            this.btnDomicilio.TabIndex = 56;
            this.btnDomicilio.UseVisualStyleBackColor = true;
            this.btnDomicilio.Click += new System.EventHandler(this.btnDomicilio_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmail.BackgroundImage")));
            this.btnEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEmail.Location = new System.Drawing.Point(463, 27);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(28, 28);
            this.btnEmail.TabIndex = 58;
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click_1);
            // 
            // btnTelefono
            // 
            this.btnTelefono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelefono.BackgroundImage")));
            this.btnTelefono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnTelefono.Location = new System.Drawing.Point(463, 83);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(28, 28);
            this.btnTelefono.TabIndex = 57;
            this.btnTelefono.UseVisualStyleBackColor = true;
            this.btnTelefono.Click += new System.EventHandler(this.btnTelefono_Click_1);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtEmail.Location = new System.Drawing.Point(102, 30);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(355, 20);
            this.txtEmail.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(65, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Emails";
            // 
            // txtTel
            // 
            this.txtTel.Enabled = false;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTel.Location = new System.Drawing.Point(102, 86);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(355, 20);
            this.txtTel.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(48, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Domicilios";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Enabled = false;
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDomicilio.Location = new System.Drawing.Point(102, 59);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(355, 20);
            this.txtDomicilio.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(48, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Telefonos";
            // 
            // gbVisita
            // 
            this.gbVisita.Controls.Add(this.monthCalendar1);
            this.gbVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVisita.Location = new System.Drawing.Point(505, 277);
            this.gbVisita.Name = "gbVisita";
            this.gbVisita.Size = new System.Drawing.Size(265, 215);
            this.gbVisita.TabIndex = 64;
            this.gbVisita.TabStop = false;
            this.gbVisita.Text = "Pedidos";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 62;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button4.Location = new System.Drawing.Point(734, 498);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 28);
            this.button4.TabIndex = 62;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGuardarProv
            // 
            this.btnGuardarProv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarProv.BackgroundImage")));
            this.btnGuardarProv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProv.Location = new System.Drawing.Point(700, 498);
            this.btnGuardarProv.Name = "btnGuardarProv";
            this.btnGuardarProv.Size = new System.Drawing.Size(28, 28);
            this.btnGuardarProv.TabIndex = 61;
            this.btnGuardarProv.UseVisualStyleBackColor = true;
            this.btnGuardarProv.Click += new System.EventHandler(this.btnGuardarProv_Click);
            // 
            // tabAdicional
            // 
            this.tabAdicional.Location = new System.Drawing.Point(4, 22);
            this.tabAdicional.Name = "tabAdicional";
            this.tabAdicional.Size = new System.Drawing.Size(776, 536);
            this.tabAdicional.TabIndex = 2;
            this.tabAdicional.Text = "Adicional";
            this.tabAdicional.UseVisualStyleBackColor = true;
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.dgvProveedor);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(776, 536);
            this.tabListado.TabIndex = 1;
            this.tabListado.Text = "Listado";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.AllowUserToAddRows = false;
            this.dgvProveedor.AllowUserToDeleteRows = false;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colidprov,
            this.colRazonSocial,
            this.colCuit,
            this.colEstado,
            this.colTipoIVA,
            this.colFechaAlta});
            this.dgvProveedor.Location = new System.Drawing.Point(6, 6);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.ReadOnly = true;
            this.dgvProveedor.Size = new System.Drawing.Size(762, 522);
            this.dgvProveedor.TabIndex = 0;
            this.dgvProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedor_CellContentClick);
            this.dgvProveedor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvProveedor_MouseDoubleClick);
            // 
            // colidprov
            // 
            this.colidprov.HeaderText = "ID Proveedor";
            this.colidprov.Name = "colidprov";
            this.colidprov.ReadOnly = true;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.HeaderText = "Razon Social";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.ReadOnly = true;
            // 
            // colCuit
            // 
            this.colCuit.HeaderText = "Cuit";
            this.colCuit.Name = "colCuit";
            this.colCuit.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // colTipoIVA
            // 
            this.colTipoIVA.HeaderText = "Tipo IVA";
            this.colTipoIVA.Name = "colTipoIVA";
            this.colTipoIVA.ReadOnly = true;
            // 
            // colFechaAlta
            // 
            this.colFechaAlta.HeaderText = "Fecha Alta";
            this.colFechaAlta.Name = "colFechaAlta";
            this.colFechaAlta.ReadOnly = true;
            // 
            // tabMovimientos
            // 
            this.tabMovimientos.Location = new System.Drawing.Point(4, 22);
            this.tabMovimientos.Name = "tabMovimientos";
            this.tabMovimientos.Size = new System.Drawing.Size(776, 536);
            this.tabMovimientos.TabIndex = 3;
            this.tabMovimientos.Text = "Movimientos";
            this.tabMovimientos.UseVisualStyleBackColor = true;
            // 
            // tabPedido
            // 
            this.tabPedido.Location = new System.Drawing.Point(4, 22);
            this.tabPedido.Name = "tabPedido";
            this.tabPedido.Size = new System.Drawing.Size(776, 536);
            this.tabPedido.TabIndex = 4;
            this.tabPedido.Text = "Pedido";
            this.tabPedido.UseVisualStyleBackColor = true;
            // 
            // idColRub
            // 
            this.idColRub.HeaderText = "IdRubro";
            this.idColRub.Name = "idColRub";
            this.idColRub.Visible = false;
            // 
            // colSeleccion
            // 
            this.colSeleccion.HeaderText = "Seleccion";
            this.colSeleccion.Name = "colSeleccion";
            this.colSeleccion.ReadOnly = true;
            this.colSeleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSeleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colRubro
            // 
            this.colRubro.HeaderText = "Rubro";
            this.colRubro.Name = "colRubro";
            // 
            // formProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabProveedor);
            this.Name = "formProveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.formProveedor_Load);
            this.tabProveedor.ResumeLayout(false);
            this.tabInformacion.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRubro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbVisita.ResumeLayout(false);
            this.tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProveedor;
        private System.Windows.Forms.TabPage tabInformacion;
        private System.Windows.Forms.TabPage tabListado;
        private System.Windows.Forms.TabPage tabAdicional;
        private System.Windows.Forms.TabPage tabMovimientos;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.TabPage tabPedido;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbIVA;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtcuit;
        public System.Windows.Forms.TextBox txtidprov;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRubro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDomicilio;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Button btnTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbVisita;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnGuardarProv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSaldoActual;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDebmax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidprov;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAlta;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColRub;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRubro;
    }
}