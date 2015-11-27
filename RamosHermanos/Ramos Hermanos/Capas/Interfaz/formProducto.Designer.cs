namespace RamosHermanos.Capas.Interfaz
{
    partial class formProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProducto));
            this.tabProducto = new System.Windows.Forms.TabControl();
            this.tabInformacion = new System.Windows.Forms.TabPage();
            this.dgvClean = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFechaActualizacion = new System.Windows.Forms.TextBox();
            this.txtPrecioActual = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMedida = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipoProducto = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabListado = new System.Windows.Forms.TabPage();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.colIDProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.Label();
            this.cbRubro = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabProducto.SuspendLayout();
            this.tabInformacion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.tabInformacion);
            this.tabProducto.Controls.Add(this.tabListado);
            this.tabProducto.Location = new System.Drawing.Point(3, 33);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.SelectedIndex = 0;
            this.tabProducto.Size = new System.Drawing.Size(760, 424);
            this.tabProducto.TabIndex = 0;
            // 
            // tabInformacion
            // 
            this.tabInformacion.BackColor = System.Drawing.SystemColors.Control;
            this.tabInformacion.Controls.Add(this.button1);
            this.tabInformacion.Controls.Add(this.dgvClean);
            this.tabInformacion.Controls.Add(this.groupBox2);
            this.tabInformacion.Controls.Add(this.groupBox1);
            this.tabInformacion.Controls.Add(this.btnSave);
            this.tabInformacion.Controls.Add(this.btnEdit);
            this.tabInformacion.Location = new System.Drawing.Point(4, 22);
            this.tabInformacion.Name = "tabInformacion";
            this.tabInformacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformacion.Size = new System.Drawing.Size(752, 398);
            this.tabInformacion.TabIndex = 0;
            this.tabInformacion.Text = "Información";
            // 
            // dgvClean
            // 
            this.dgvClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dgvClean.BackgroundImage")));
            this.dgvClean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dgvClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClean.Location = new System.Drawing.Point(325, 362);
            this.dgvClean.Name = "dgvClean";
            this.dgvClean.Size = new System.Drawing.Size(28, 28);
            this.dgvClean.TabIndex = 111;
            this.dgvClean.UseVisualStyleBackColor = true;
            this.dgvClean.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFechaActualizacion);
            this.groupBox2.Controls.Add(this.txtPrecioActual);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 74);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precio";
            // 
            // txtFechaActualizacion
            // 
            this.txtFechaActualizacion.Enabled = false;
            this.txtFechaActualizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtFechaActualizacion.Location = new System.Drawing.Point(113, 43);
            this.txtFechaActualizacion.Name = "txtFechaActualizacion";
            this.txtFechaActualizacion.Size = new System.Drawing.Size(261, 20);
            this.txtFechaActualizacion.TabIndex = 108;
            // 
            // txtPrecioActual
            // 
            this.txtPrecioActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPrecioActual.Location = new System.Drawing.Point(113, 17);
            this.txtPrecioActual.Name = "txtPrecioActual";
            this.txtPrecioActual.Size = new System.Drawing.Size(261, 20);
            this.txtPrecioActual.TabIndex = 100;
            this.txtPrecioActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label14.Location = new System.Drawing.Point(6, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 83;
            this.label14.Text = "Fecha Actualización";
            // 
            // label24
            // 
            this.label24.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label24.Location = new System.Drawing.Point(38, 20);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 106;
            this.label24.Text = "Precio";
            // 
            // label23
            // 
            this.label23.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(30, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(11, 13);
            this.label23.TabIndex = 107;
            this.label23.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtProducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbMedida);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFechaAlta);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtIDProd);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbTipoProducto);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 270);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Producto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(104, 25);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 93;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCantidad.Location = new System.Drawing.Point(85, 236);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(117, 20);
            this.txtCantidad.TabIndex = 118;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // label25
            // 
            this.label25.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label25.ForeColor = System.Drawing.Color.Red;
            this.label25.Location = new System.Drawing.Point(24, 238);
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
            this.label26.Location = new System.Drawing.Point(32, 239);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 116;
            this.label26.Text = "Cantidad";
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(349, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 28);
            this.button5.TabIndex = 112;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(219, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 111;
            this.label10.Text = "*";
            // 
            // cbMedida
            // 
            this.cbMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbMedida.FormattingEnabled = true;
            this.cbMedida.Location = new System.Drawing.Point(274, 236);
            this.cbMedida.Name = "cbMedida";
            this.cbMedida.Size = new System.Drawing.Size(71, 21);
            this.cbMedida.TabIndex = 110;
            this.cbMedida.DropDown += new System.EventHandler(this.cbMedida_DropDown);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(226, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "Medida";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Enabled = false;
            this.dtpFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(85, 71);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(261, 20);
            this.dtpFechaAlta.TabIndex = 105;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label22.Location = new System.Drawing.Point(21, 74);
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
            this.button2.Location = new System.Drawing.Point(349, 147);
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
            this.cbMarca.Location = new System.Drawing.Point(85, 151);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(261, 21);
            this.cbMarca.TabIndex = 102;
            this.cbMarca.DropDown += new System.EventHandler(this.cbMarca_DropDown);
            // 
            // label20
            // 
            this.label20.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(36, 153);
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
            this.label21.Location = new System.Drawing.Point(44, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 100;
            this.label21.Text = "Marca";
            // 
            // txtIDProd
            // 
            this.txtIDProd.Enabled = false;
            this.txtIDProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtIDProd.Location = new System.Drawing.Point(85, 45);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(261, 20);
            this.txtIDProd.TabIndex = 96;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label17.Location = new System.Drawing.Point(13, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 95;
            this.label17.Text = "Nº Producto";
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(349, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 28);
            this.button3.TabIndex = 87;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // label18
            // 
            this.label18.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(9, 180);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 13);
            this.label18.TabIndex = 86;
            this.label18.Text = "*";
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
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearch.Location = new System.Drawing.Point(349, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 28);
            this.btnSearch.TabIndex = 79;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(31, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "*";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(21, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "*";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtProducto.Location = new System.Drawing.Point(85, 98);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(261, 20);
            this.txtProducto.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(29, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Producto";
            // 
            // cbTipoProducto
            // 
            this.cbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbTipoProducto.FormattingEnabled = true;
            this.cbTipoProducto.Location = new System.Drawing.Point(85, 124);
            this.cbTipoProducto.Name = "cbTipoProducto";
            this.cbTipoProducto.Size = new System.Drawing.Size(261, 21);
            this.cbTipoProducto.TabIndex = 54;
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Checked = true;
            this.cbEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cbEstado.Location = new System.Drawing.Point(85, 25);
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
            this.label1.Location = new System.Drawing.Point(38, 25);
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
            this.label15.Location = new System.Drawing.Point(43, 126);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "*";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDescripcion.Location = new System.Drawing.Point(85, 177);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(261, 53);
            this.txtDescripcion.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(16, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(51, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tipo";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(359, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(28, 28);
            this.btnSave.TabIndex = 74;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEdit.Location = new System.Drawing.Point(393, 362);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(28, 28);
            this.btnEdit.TabIndex = 76;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabListado
            // 
            this.tabListado.BackColor = System.Drawing.SystemColors.Control;
            this.tabListado.Controls.Add(this.cbRubro);
            this.tabListado.Controls.Add(this.txtTipo);
            this.tabListado.Controls.Add(this.dgvProducto);
            this.tabListado.Location = new System.Drawing.Point(4, 22);
            this.tabListado.Name = "tabListado";
            this.tabListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabListado.Size = new System.Drawing.Size(752, 398);
            this.tabListado.TabIndex = 1;
            this.tabListado.Text = "Listado";
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDProducto,
            this.colTipo,
            this.colMarca,
            this.colProducto,
            this.colCantidad,
            this.colMedida,
            this.colStock,
            this.colPrecio});
            this.dgvProducto.Location = new System.Drawing.Point(0, 37);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.Size = new System.Drawing.Size(746, 355);
            this.dgvProducto.TabIndex = 52;
            this.dgvProducto.DoubleClick += new System.EventHandler(this.dgvProducto_DoubleClick_1);
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
            this.colCantidad.ReadOnly = true;
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
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(291, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 112;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSize = true;
            this.txtTipo.Location = new System.Drawing.Point(4, 13);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(36, 13);
            this.txtTipo.TabIndex = 53;
            this.txtTipo.Text = "Rubro";
            // 
            // cbRubro
            // 
            this.cbRubro.FormattingEnabled = true;
            this.cbRubro.Location = new System.Drawing.Point(46, 10);
            this.cbRubro.Name = "cbRubro";
            this.cbRubro.Size = new System.Drawing.Size(121, 21);
            this.cbRubro.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(760, 30);
            this.label7.TabIndex = 103;
            this.label7.Text = "Productos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabProducto);
            this.Name = "formProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.formProducto_Load);
            this.tabProducto.ResumeLayout(false);
            this.tabInformacion.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabListado.ResumeLayout(false);
            this.tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.Button dgvClean;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtIDProd;
        public System.Windows.Forms.TextBox txtProducto;
        public System.Windows.Forms.ComboBox cbTipoProducto;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.ComboBox cbMarca;
        public System.Windows.Forms.ComboBox cbMedida;
        public System.Windows.Forms.DateTimePicker dtpFechaAlta;
        public System.Windows.Forms.TextBox txtPrecioActual;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txtFechaActualizacion;
        private System.Windows.Forms.ComboBox cbRubro;
        private System.Windows.Forms.Label txtTipo;
        public System.Windows.Forms.TabControl tabProducto;
        public System.Windows.Forms.TabPage tabInformacion;
        public System.Windows.Forms.TabPage tabListado;
        public System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Label label7;
    }
}