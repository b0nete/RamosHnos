namespace RamosHermanos.Capas.Interfaz.ABMs
{
    partial class formVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVehiculo));
            this.button1 = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.colIDVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPatente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEstadoVeh = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.MaskedTextBox();
            this.nudModelo = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnUpdVeh = new System.Windows.Forms.Button();
            this.cbEstadoVeh = new System.Windows.Forms.CheckBox();
            this.btnSaveVehi = new System.Windows.Forms.Button();
            this.txtIDvehiculo = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(744, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 76;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDVehiculo,
            this.colMarca,
            this.colModelo,
            this.colPatente,
            this.colColor,
            this.colEstado});
            this.dgvVehiculos.Location = new System.Drawing.Point(11, 201);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.Size = new System.Drawing.Size(761, 314);
            this.dgvVehiculos.TabIndex = 75;
            // 
            // colIDVehiculo
            // 
            this.colIDVehiculo.HeaderText = "Nº Vehiculo";
            this.colIDVehiculo.Name = "colIDVehiculo";
            this.colIDVehiculo.ReadOnly = true;
            // 
            // colMarca
            // 
            this.colMarca.HeaderText = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.ReadOnly = true;
            // 
            // colModelo
            // 
            this.colModelo.HeaderText = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.ReadOnly = true;
            // 
            // colPatente
            // 
            this.colPatente.HeaderText = "Patente";
            this.colPatente.Name = "colPatente";
            this.colPatente.ReadOnly = true;
            // 
            // colColor
            // 
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;
            this.colColor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colColor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEstadoVeh);
            this.groupBox2.Controls.Add(this.txtPatente);
            this.groupBox2.Controls.Add(this.nudModelo);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.cbMarca);
            this.groupBox2.Controls.Add(this.cbColor);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.btnUpdVeh);
            this.groupBox2.Controls.Add(this.cbEstadoVeh);
            this.groupBox2.Controls.Add(this.btnSaveVehi);
            this.groupBox2.Controls.Add(this.txtIDvehiculo);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 183);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vehiculo";
            // 
            // lblEstadoVeh
            // 
            this.lblEstadoVeh.AutoSize = true;
            this.lblEstadoVeh.Location = new System.Drawing.Point(111, 159);
            this.lblEstadoVeh.Name = "lblEstadoVeh";
            this.lblEstadoVeh.Size = new System.Drawing.Size(0, 13);
            this.lblEstadoVeh.TabIndex = 93;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(90, 98);
            this.txtPatente.Mask = ">L>L>L-000";
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 20);
            this.txtPatente.TabIndex = 71;
            // 
            // nudModelo
            // 
            this.nudModelo.Location = new System.Drawing.Point(90, 72);
            this.nudModelo.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudModelo.Minimum = new decimal(new int[] {
            1940,
            0,
            0,
            0});
            this.nudModelo.Name = "nudModelo";
            this.nudModelo.Size = new System.Drawing.Size(120, 20);
            this.nudModelo.TabIndex = 70;
            this.nudModelo.Value = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(44, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 13);
            this.label21.TabIndex = 69;
            this.label21.Text = "Modelo";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Alfa Romeo",
            "Audi",
            "BMW",
            "Chery",
            "Chevrolet",
            "Citroën",
            "Daewoo",
            "Daimler Chrysler",
            "Dodge",
            "Fiat",
            "Ford",
            "General Motors",
            "Honda",
            "Hyundai",
            "Isuzu",
            "Jaguar",
            "Jeep",
            "Kia Motors",
            "Lada",
            "Land Rover",
            "Lexus",
            "Mazda",
            "Mercedes Benz",
            "Mitsubishi",
            "Nissan",
            "Opel",
            "Peugeot",
            "Porsche",
            "Renault",
            "Saab",
            "Seat",
            "Subaru",
            "Suzuki",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.cbMarca.Location = new System.Drawing.Point(90, 45);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(398, 21);
            this.cbMarca.TabIndex = 68;
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagena",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuschia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGreen",
            "LightGray",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "Red",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "Seashell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen",
            "SteelBlue",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato",
            "Turquoise",
            "Violet",
            "Wheat",
            "White",
            "WhiteSmoke",
            "Yellow",
            "YellowGreen"});
            this.cbColor.Location = new System.Drawing.Point(124, 130);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(364, 21);
            this.cbColor.TabIndex = 67;
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged_1);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(44, 159);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "Estado";
            // 
            // btnUpdVeh
            // 
            this.btnUpdVeh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdVeh.BackgroundImage")));
            this.btnUpdVeh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUpdVeh.Location = new System.Drawing.Point(728, 145);
            this.btnUpdVeh.Name = "btnUpdVeh";
            this.btnUpdVeh.Size = new System.Drawing.Size(28, 28);
            this.btnUpdVeh.TabIndex = 65;
            this.btnUpdVeh.UseVisualStyleBackColor = true;
            // 
            // cbEstadoVeh
            // 
            this.cbEstadoVeh.AutoSize = true;
            this.cbEstadoVeh.Checked = true;
            this.cbEstadoVeh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEstadoVeh.Location = new System.Drawing.Point(90, 159);
            this.cbEstadoVeh.Name = "cbEstadoVeh";
            this.cbEstadoVeh.Size = new System.Drawing.Size(15, 14);
            this.cbEstadoVeh.TabIndex = 8;
            this.cbEstadoVeh.UseVisualStyleBackColor = true;
            // 
            // btnSaveVehi
            // 
            this.btnSaveVehi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveVehi.BackgroundImage")));
            this.btnSaveVehi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveVehi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVehi.Location = new System.Drawing.Point(694, 145);
            this.btnSaveVehi.Name = "btnSaveVehi";
            this.btnSaveVehi.Size = new System.Drawing.Size(28, 28);
            this.btnSaveVehi.TabIndex = 64;
            this.btnSaveVehi.UseVisualStyleBackColor = true;
            this.btnSaveVehi.Click += new System.EventHandler(this.btnSaveVehi_Click_1);
            // 
            // txtIDvehiculo
            // 
            this.txtIDvehiculo.Enabled = false;
            this.txtIDvehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDvehiculo.Location = new System.Drawing.Point(90, 19);
            this.txtIDvehiculo.Name = "txtIDvehiculo";
            this.txtIDvehiculo.Size = new System.Drawing.Size(398, 20);
            this.txtIDvehiculo.TabIndex = 5;
            // 
            // btnColor
            // 
            this.btnColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnColor.Location = new System.Drawing.Point(90, 126);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(28, 28);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(53, 134);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 13);
            this.label23.TabIndex = 3;
            this.label23.Text = "Color";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(42, 101);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Patente";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(47, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(37, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Marca";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(21, 22);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 13);
            this.label26.TabIndex = 0;
            this.label26.Text = "Nº Vehículo";
            // 
            // formVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.groupBox2);
            this.Name = "formVehiculo";
            this.Text = "Registrar Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudModelo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEstado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEstadoVeh;
        private System.Windows.Forms.MaskedTextBox txtPatente;
        private System.Windows.Forms.NumericUpDown nudModelo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnUpdVeh;
        private System.Windows.Forms.CheckBox cbEstadoVeh;
        private System.Windows.Forms.Button btnSaveVehi;
        private System.Windows.Forms.TextBox txtIDvehiculo;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
    }
}