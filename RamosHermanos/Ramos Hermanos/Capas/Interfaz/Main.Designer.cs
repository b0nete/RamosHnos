namespace RamosHermanos.Capas.Interfaz
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarInsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarInsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rubroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mcAgenda = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.cajaToolStripMenuItem,
            this.insumosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.testToolStripMenuItem,
            this.rubroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarGastoToolStripMenuItem});
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.cajaToolStripMenuItem.Text = "Arqueo de Caja";
            // 
            // ingresarGastoToolStripMenuItem
            // 
            this.ingresarGastoToolStripMenuItem.Name = "ingresarGastoToolStripMenuItem";
            this.ingresarGastoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ingresarGastoToolStripMenuItem.Text = "Generar Comprobante";
            // 
            // insumosToolStripMenuItem
            // 
            this.insumosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarInsumoToolStripMenuItem,
            this.verInsumoToolStripMenuItem,
            this.editarInsumoToolStripMenuItem});
            this.insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            this.insumosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.insumosToolStripMenuItem.Text = "Insumos";
            // 
            // agregarInsumoToolStripMenuItem
            // 
            this.agregarInsumoToolStripMenuItem.Name = "agregarInsumoToolStripMenuItem";
            this.agregarInsumoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.agregarInsumoToolStripMenuItem.Text = "Agregar Insumo";
            // 
            // verInsumoToolStripMenuItem
            // 
            this.verInsumoToolStripMenuItem.Name = "verInsumoToolStripMenuItem";
            this.verInsumoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.verInsumoToolStripMenuItem.Text = "Ver Insumo";
            // 
            // editarInsumoToolStripMenuItem
            // 
            this.editarInsumoToolStripMenuItem.Name = "editarInsumoToolStripMenuItem";
            this.editarInsumoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.editarInsumoToolStripMenuItem.Text = "Editar Insumo";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.verUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            // 
            // verUsuariosToolStripMenuItem
            // 
            this.verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            this.verUsuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // rubroToolStripMenuItem
            // 
            this.rubroToolStripMenuItem.Name = "rubroToolStripMenuItem";
            this.rubroToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.rubroToolStripMenuItem.Text = "Rubro";
            this.rubroToolStripMenuItem.Click += new System.EventHandler(this.rubroToolStripMenuItem_Click);
            // 
            // mcAgenda
            // 
            this.mcAgenda.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mcAgenda.Location = new System.Drawing.Point(539, 42);
            this.mcAgenda.Name = "mcAgenda";
            this.mcAgenda.TabIndex = 25;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.mcAgenda);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarInsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarInsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar mcAgenda;
        private System.Windows.Forms.ToolStripMenuItem rubroToolStripMenuItem;
    }
}