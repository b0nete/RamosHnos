namespace RamosHermanos.Capas.Interfaz
{
    partial class formBuscarProv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formBuscarProv));
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNproveedor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBnproveedor = new System.Windows.Forms.RadioButton();
            this.RBcuit = new System.Windows.Forms.RadioButton();
            this.RBrazonsocial = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(90, 19);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(154, 20);
            this.txtRazonSocial.TabIndex = 0;
            this.txtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRazonSocial_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Razon Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CUIT";
            // 
            // txtCuit
            // 
            this.txtCuit.Enabled = false;
            this.txtCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit.Location = new System.Drawing.Point(90, 49);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(154, 20);
            this.txtCuit.TabIndex = 2;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nª Proveedor";
            // 
            // txtNproveedor
            // 
            this.txtNproveedor.Enabled = false;
            this.txtNproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNproveedor.Location = new System.Drawing.Point(90, 79);
            this.txtNproveedor.Name = "txtNproveedor";
            this.txtNproveedor.Size = new System.Drawing.Size(154, 20);
            this.txtNproveedor.TabIndex = 4;
            this.txtNproveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNproveedor_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBnproveedor);
            this.groupBox1.Controls.Add(this.RBcuit);
            this.groupBox1.Controls.Add(this.RBrazonsocial);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.txtCuit);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNproveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // RBnproveedor
            // 
            this.RBnproveedor.AutoSize = true;
            this.RBnproveedor.Location = new System.Drawing.Point(250, 82);
            this.RBnproveedor.Name = "RBnproveedor";
            this.RBnproveedor.Size = new System.Drawing.Size(14, 13);
            this.RBnproveedor.TabIndex = 95;
            this.RBnproveedor.TabStop = true;
            this.RBnproveedor.UseVisualStyleBackColor = true;
            this.RBnproveedor.CheckedChanged += new System.EventHandler(this.RBnproveedor_CheckedChanged);
            // 
            // RBcuit
            // 
            this.RBcuit.AutoSize = true;
            this.RBcuit.Location = new System.Drawing.Point(250, 52);
            this.RBcuit.Name = "RBcuit";
            this.RBcuit.Size = new System.Drawing.Size(14, 13);
            this.RBcuit.TabIndex = 94;
            this.RBcuit.TabStop = true;
            this.RBcuit.UseVisualStyleBackColor = true;
            this.RBcuit.CheckedChanged += new System.EventHandler(this.RBcuit_CheckedChanged);
            // 
            // RBrazonsocial
            // 
            this.RBrazonsocial.AutoSize = true;
            this.RBrazonsocial.Location = new System.Drawing.Point(250, 22);
            this.RBrazonsocial.Name = "RBrazonsocial";
            this.RBrazonsocial.Size = new System.Drawing.Size(14, 13);
            this.RBrazonsocial.TabIndex = 93;
            this.RBrazonsocial.TabStop = true;
            this.RBrazonsocial.UseVisualStyleBackColor = true;
            this.RBrazonsocial.CheckedChanged += new System.EventHandler(this.RBrazonsocial_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSearch.Location = new System.Drawing.Point(286, 85);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 28);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // formBuscarProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 141);
            this.Controls.Add(this.groupBox1);
            this.Name = "formBuscarProv";
            this.Text = "Buscar Proveedor";
            this.Load += new System.EventHandler(this.formBuscarProv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNproveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton RBnproveedor;
        private System.Windows.Forms.RadioButton RBcuit;
        private System.Windows.Forms.RadioButton RBrazonsocial;
    }
}