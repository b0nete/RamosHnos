﻿namespace RamosHermanos.Capas.Interfaz
{
    partial class formInsumos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInsumos));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabInformacion = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInsumo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelInsumo = new System.Windows.Forms.Label();
            this.cbRubro = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMedida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtidInsumo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbProv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRubro = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.dgvinsumos = new System.Windows.Forms.DataGridView();
            this.colidinsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStockActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMain.SuspendLayout();
            this.tabInformacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsumos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabInformacion);
            this.tabMain.Controls.Add(this.tabListado);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(419, 407);
            this.tabMain.TabIndex = 0;
            // 
            // tabInformacion
            // 
            this.tabInformacion.BackColor = System.Drawing.SystemColors.Control;
            this.tabInformacion.Controls.Add(this.button11);
            this.tabInformacion.Controls.Add(this.groupBox1);
            this.tabInformacion.Controls.Add(this.button1);
            this.tabInformacion.Controls.Add(this.btnEdit);
            this.tabInformacion.Location = new System.Drawing.Point(4, 22);
            this.tabInformacion.Name = "tabInformacion";
            this.tabInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformacion.Size = new System.Drawing.Size(411, 381);
            this.tabInformacion.TabIndex = 0;
            this.tabInformacion.Text = "Informacion";
            this.tabInformacion.Click += new System.EventHandler(this.tabInformacion_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button11.Location = new System.Drawing.Point(375, 340);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(28, 28);
            this.button11.TabIndex = 113;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInsumo);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelInsumo);
            this.groupBox1.Controls.Add(this.cbRubro);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbMedida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtidInsumo);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbProv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRubro);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 328);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Insumo";
            // 
            // txtInsumo
            // 
            this.txtInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtInsumo.Location = new System.Drawing.Point(86, 68);
            this.txtInsumo.Name = "txtInsumo";
            this.txtInsumo.Size = new System.Drawing.Size(261, 20);
            this.txtInsumo.TabIndex = 126;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearch.Location = new System.Drawing.Point(350, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 28);
            this.btnSearch.TabIndex = 125;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(22, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 124;
            this.label5.Text = "*";
            // 
            // labelInsumo
            // 
            this.labelInsumo.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.labelInsumo.AutoSize = true;
            this.labelInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelInsumo.Location = new System.Drawing.Point(30, 71);
            this.labelInsumo.Name = "labelInsumo";
            this.labelInsumo.Size = new System.Drawing.Size(41, 13);
            this.labelInsumo.TabIndex = 123;
            this.labelInsumo.Text = "Insumo";
            // 
            // cbRubro
            // 
            this.cbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbRubro.FormattingEnabled = true;
            this.cbRubro.Location = new System.Drawing.Point(87, 147);
            this.cbRubro.Name = "cbRubro";
            this.cbRubro.Size = new System.Drawing.Size(261, 21);
            this.cbRubro.TabIndex = 122;
            this.cbRubro.SelectedIndexChanged += new System.EventHandler(this.cbRubro_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(108, 25);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(351, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 28);
            this.button4.TabIndex = 120;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label27
            // 
            this.label27.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label27.ForeColor = System.Drawing.Color.Red;
            this.label27.Location = new System.Drawing.Point(13, 94);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(11, 13);
            this.label27.TabIndex = 119;
            this.label27.Text = "*";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCantidad.Location = new System.Drawing.Point(87, 263);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(117, 20);
            this.txtCantidad.TabIndex = 118;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label25
            // 
            this.label25.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(26, 265);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(11, 13);
            this.label25.TabIndex = 117;
            this.label25.Text = "*";
            // 
            // label26
            // 
            this.label26.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label26.Location = new System.Drawing.Point(34, 266);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 116;
            this.label26.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(221, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 111;
            this.label10.Text = "*";
            // 
            // cbMedida
            // 
            this.cbMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbMedida.FormattingEnabled = true;
            this.cbMedida.Location = new System.Drawing.Point(276, 263);
            this.cbMedida.Name = "cbMedida";
            this.cbMedida.Size = new System.Drawing.Size(71, 21);
            this.cbMedida.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(228, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "Medida";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(87, 94);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(260, 20);
            this.dtpFecha.TabIndex = 105;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label22.Location = new System.Drawing.Point(23, 97);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 104;
            this.label22.Text = "Fecha Alta";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(351, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 103;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(87, 174);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(261, 21);
            this.cbMarca.TabIndex = 102;
            this.cbMarca.DropDown += new System.EventHandler(this.cbMarca_DropDown);
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(38, 176);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 13);
            this.label20.TabIndex = 101;
            this.label20.Text = "*";
            // 
            // label21
            // 
            this.label21.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label21.Location = new System.Drawing.Point(46, 177);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 100;
            this.label21.Text = "Marca";
            // 
            // txtidInsumo
            // 
            this.txtidInsumo.Enabled = false;
            this.txtidInsumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtidInsumo.Location = new System.Drawing.Point(86, 45);
            this.txtidInsumo.Name = "txtidInsumo";
            this.txtidInsumo.Size = new System.Drawing.Size(261, 20);
            this.txtidInsumo.TabIndex = 96;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label17.Location = new System.Drawing.Point(27, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 95;
            this.label17.Text = "Nº Insumo";
            // 
            // cbProv
            // 
            this.cbProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbProv.FormattingEnabled = true;
            this.cbProv.Location = new System.Drawing.Point(87, 120);
            this.cbProv.Name = "cbProv";
            this.cbProv.Size = new System.Drawing.Size(261, 21);
            this.cbProv.TabIndex = 94;
            this.cbProv.DropDown += new System.EventHandler(this.cbProv_DropDown);
            this.cbProv.SelectedIndexChanged += new System.EventHandler(this.cbProv_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(16, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "*";
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(25, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "Proveedor";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(351, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 87;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(-11, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 84;
            this.label12.Text = "*";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(33, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "*";
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(526, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 28);
            this.button7.TabIndex = 64;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Checked = true;
            this.cbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbEstado.Location = new System.Drawing.Point(87, 25);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(15, 14);
            this.cbEstado.TabIndex = 50;
            this.cbEstado.UseVisualStyleBackColor = true;
            this.cbEstado.CheckedChanged += new System.EventHandler(this.cbEstado_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Estado";
            // 
            // label15
            // 
            this.label15.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(36, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "*";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(87, 204);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(261, 53);
            this.txtDescripcion.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(18, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Descripción";
            // 
            // txtRubro
            // 
            this.txtRubro.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.txtRubro.AutoSize = true;
            this.txtRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtRubro.Location = new System.Drawing.Point(44, 151);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(36, 13);
            this.txtRubro.TabIndex = 26;
            this.txtRubro.Text = "Rubro";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(307, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 113;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEdit.Location = new System.Drawing.Point(341, 340);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(28, 28);
            this.btnEdit.TabIndex = 115;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // tabListado
            // 
            this.tabListado.Controls.Add(this.dgvinsumos);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Size = new System.Drawing.Size(411, 535);
            this.tabListado.TabIndex = 1;
            this.tabListado.Text = "Listado";
            this.tabListado.UseVisualStyleBackColor = true;
            // 
            // dgvinsumos
            // 
            this.dgvinsumos.AllowUserToAddRows = false;
            this.dgvinsumos.AllowUserToDeleteRows = false;
            this.dgvinsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinsumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colidinsumo,
            this.colFechaAlta,
            this.colProv,
            this.colInsumo,
            this.colStockActual,
            this.colRubro,
            this.colMarca});
            this.dgvinsumos.Location = new System.Drawing.Point(3, 3);
            this.dgvinsumos.Name = "dgvinsumos";
            this.dgvinsumos.ReadOnly = true;
            this.dgvinsumos.Size = new System.Drawing.Size(745, 529);
            this.dgvinsumos.TabIndex = 113;
            this.dgvinsumos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvinsumos_MouseDoubleClick);
            // 
            // colidinsumo
            // 
            this.colidinsumo.HeaderText = "IDinsumo";
            this.colidinsumo.Name = "colidinsumo";
            this.colidinsumo.ReadOnly = true;
            // 
            // colFechaAlta
            // 
            this.colFechaAlta.HeaderText = "Fecha Alta";
            this.colFechaAlta.Name = "colFechaAlta";
            this.colFechaAlta.ReadOnly = true;
            // 
            // colProv
            // 
            this.colProv.HeaderText = "Proveedor";
            this.colProv.Name = "colProv";
            this.colProv.ReadOnly = true;
            // 
            // colInsumo
            // 
            this.colInsumo.HeaderText = "Insumo";
            this.colInsumo.Name = "colInsumo";
            this.colInsumo.ReadOnly = true;
            // 
            // colStockActual
            // 
            this.colStockActual.HeaderText = "Stock Actual";
            this.colStockActual.Name = "colStockActual";
            this.colStockActual.ReadOnly = true;
            // 
            // colRubro
            // 
            this.colRubro.HeaderText = "Rubro";
            this.colRubro.Name = "colRubro";
            this.colRubro.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // formInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 407);
            this.Controls.Add(this.tabMain);
            this.Name = "formInsumos";
            this.Text = "Insumos";
            this.Load += new System.EventHandler(this.formInsumos_Load);
            this.tabMain.ResumeLayout(false);
            this.tabInformacion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinsumos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtRubro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView dgvinsumos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidinsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStockActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.Button button11;
        public System.Windows.Forms.TabControl tabMain;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.ComboBox cbMedida;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.ComboBox cbMarca;
        public System.Windows.Forms.TextBox txtidInsumo;
        public System.Windows.Forms.ComboBox cbProv;
        public System.Windows.Forms.CheckBox cbEstado;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TabPage tabInformacion;
        public System.Windows.Forms.TabPage tabListado;
        public System.Windows.Forms.TextBox txtInsumo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelInsumo;
        public System.Windows.Forms.ComboBox cbRubro;
    }
}