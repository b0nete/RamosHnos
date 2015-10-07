namespace RamosHermanos.Capas.Interfaz
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dNIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaJurídicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.distribuidoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.nºDistribuidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nºProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.regsitrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insumosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.nºInsumoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarGastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categorizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeRamosHnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mcAgenda = new System.Windows.Forms.MonthCalendar();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblSesion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.test1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msPrincipal.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.distribuidoresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.insumosToolStripMenuItem,
            this.cajaToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.testToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(784, 24);
            this.msPrincipal.TabIndex = 23;
            this.msPrincipal.Text = "menuStrip1";
            this.msPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem,
            this.registrarToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dNIToolStripMenuItem,
            this.listadoToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // dNIToolStripMenuItem
            // 
            this.dNIToolStripMenuItem.Name = "dNIToolStripMenuItem";
            this.dNIToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.dNIToolStripMenuItem.Text = "Nº Cliente";
            this.dNIToolStripMenuItem.Click += new System.EventHandler(this.dNIToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.listadoToolStripMenuItem.Text = "Listado";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem,
            this.personaJurídicaToolStripMenuItem});
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.personaToolStripMenuItem.Text = "Persona";
            this.personaToolStripMenuItem.Click += new System.EventHandler(this.personaToolStripMenuItem_Click);
            // 
            // personaJurídicaToolStripMenuItem
            // 
            this.personaJurídicaToolStripMenuItem.Name = "personaJurídicaToolStripMenuItem";
            this.personaJurídicaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.personaJurídicaToolStripMenuItem.Text = "Persona Jurídica";
            this.personaJurídicaToolStripMenuItem.Click += new System.EventHandler(this.personaJurídicaToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem1,
            this.registrarToolStripMenuItem1});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem1
            // 
            this.buscarToolStripMenuItem1.Name = "buscarToolStripMenuItem1";
            this.buscarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.buscarToolStripMenuItem1.Text = "Buscar";
            this.buscarToolStripMenuItem1.Click += new System.EventHandler(this.buscarToolStripMenuItem1_Click);
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.registrarToolStripMenuItem1.Text = "Registrar";
            this.registrarToolStripMenuItem1.Click += new System.EventHandler(this.registrarToolStripMenuItem1_Click);
            // 
            // distribuidoresToolStripMenuItem
            // 
            this.distribuidoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem4,
            this.registrarToolStripMenuItem3});
            this.distribuidoresToolStripMenuItem.Name = "distribuidoresToolStripMenuItem";
            this.distribuidoresToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.distribuidoresToolStripMenuItem.Text = "Distribuidores";
            this.distribuidoresToolStripMenuItem.Click += new System.EventHandler(this.distribuidoresToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem4
            // 
            this.buscarToolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nºDistribuidorToolStripMenuItem,
            this.listadoToolStripMenuItem4});
            this.buscarToolStripMenuItem4.Name = "buscarToolStripMenuItem4";
            this.buscarToolStripMenuItem4.Size = new System.Drawing.Size(116, 22);
            this.buscarToolStripMenuItem4.Text = "Buscar";
            // 
            // nºDistribuidorToolStripMenuItem
            // 
            this.nºDistribuidorToolStripMenuItem.Name = "nºDistribuidorToolStripMenuItem";
            this.nºDistribuidorToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.nºDistribuidorToolStripMenuItem.Text = "Nº Distribuidor";
            // 
            // listadoToolStripMenuItem4
            // 
            this.listadoToolStripMenuItem4.Name = "listadoToolStripMenuItem4";
            this.listadoToolStripMenuItem4.Size = new System.Drawing.Size(141, 22);
            this.listadoToolStripMenuItem4.Text = "Listado";
            this.listadoToolStripMenuItem4.Click += new System.EventHandler(this.listadoToolStripMenuItem4_Click);
            // 
            // registrarToolStripMenuItem3
            // 
            this.registrarToolStripMenuItem3.Name = "registrarToolStripMenuItem3";
            this.registrarToolStripMenuItem3.Size = new System.Drawing.Size(116, 22);
            this.registrarToolStripMenuItem3.Text = "Registrar";
            this.registrarToolStripMenuItem3.Click += new System.EventHandler(this.registrarToolStripMenuItem3_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem2,
            this.regsitrarToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem2
            // 
            this.buscarToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nºProductoToolStripMenuItem,
            this.listadoToolStripMenuItem2});
            this.buscarToolStripMenuItem2.Name = "buscarToolStripMenuItem2";
            this.buscarToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.buscarToolStripMenuItem2.Text = "Buscar";
            // 
            // nºProductoToolStripMenuItem
            // 
            this.nºProductoToolStripMenuItem.Name = "nºProductoToolStripMenuItem";
            this.nºProductoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.nºProductoToolStripMenuItem.Text = "Nº Producto";
            // 
            // listadoToolStripMenuItem2
            // 
            this.listadoToolStripMenuItem2.Name = "listadoToolStripMenuItem2";
            this.listadoToolStripMenuItem2.Size = new System.Drawing.Size(132, 22);
            this.listadoToolStripMenuItem2.Text = "Listado";
            // 
            // regsitrarToolStripMenuItem
            // 
            this.regsitrarToolStripMenuItem.Name = "regsitrarToolStripMenuItem";
            this.regsitrarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.regsitrarToolStripMenuItem.Text = "Registrar";
            // 
            // insumosToolStripMenuItem
            // 
            this.insumosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarToolStripMenuItem3,
            this.registrarToolStripMenuItem2});
            this.insumosToolStripMenuItem.Name = "insumosToolStripMenuItem";
            this.insumosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.insumosToolStripMenuItem.Text = "Insumos";
            this.insumosToolStripMenuItem.Click += new System.EventHandler(this.insumosToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem3
            // 
            this.buscarToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nºInsumoToolStripMenuItem,
            this.listadoToolStripMenuItem3});
            this.buscarToolStripMenuItem3.Name = "buscarToolStripMenuItem3";
            this.buscarToolStripMenuItem3.Size = new System.Drawing.Size(116, 22);
            this.buscarToolStripMenuItem3.Text = "Buscar";
            // 
            // nºInsumoToolStripMenuItem
            // 
            this.nºInsumoToolStripMenuItem.Name = "nºInsumoToolStripMenuItem";
            this.nºInsumoToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.nºInsumoToolStripMenuItem.Text = "Nº Insumo";
            this.nºInsumoToolStripMenuItem.Click += new System.EventHandler(this.nºInsumoToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem3
            // 
            this.listadoToolStripMenuItem3.Name = "listadoToolStripMenuItem3";
            this.listadoToolStripMenuItem3.Size = new System.Drawing.Size(123, 22);
            this.listadoToolStripMenuItem3.Text = "Listado";
            // 
            // registrarToolStripMenuItem2
            // 
            this.registrarToolStripMenuItem2.Name = "registrarToolStripMenuItem2";
            this.registrarToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.registrarToolStripMenuItem2.Text = "Registrar";
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
            this.ingresarGastoToolStripMenuItem.Click += new System.EventHandler(this.ingresarGastoToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem1,
            this.toolStripSeparator1,
            this.cajaToolStripMenuItem1,
            this.categorizaciónToolStripMenuItem,
            this.propiedadesToolStripMenuItem,
            this.toolStripSeparator2,
            this.acercaDeRamosHnosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // cajaToolStripMenuItem1
            // 
            this.cajaToolStripMenuItem1.Name = "cajaToolStripMenuItem1";
            this.cajaToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.cajaToolStripMenuItem1.Text = "Caja";
            // 
            // categorizaciónToolStripMenuItem
            // 
            this.categorizaciónToolStripMenuItem.Name = "categorizaciónToolStripMenuItem";
            this.categorizaciónToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.categorizaciónToolStripMenuItem.Text = "Categorización Cliente";
            // 
            // propiedadesToolStripMenuItem
            // 
            this.propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            this.propiedadesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.propiedadesToolStripMenuItem.Text = "Propiedades";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // acercaDeRamosHnosToolStripMenuItem
            // 
            this.acercaDeRamosHnosToolStripMenuItem.Name = "acercaDeRamosHnosToolStripMenuItem";
            this.acercaDeRamosHnosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.acercaDeRamosHnosToolStripMenuItem.Text = "Acerca de";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.test1ToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click_1);
            // 
            // mcAgenda
            // 
            this.mcAgenda.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mcAgenda.Location = new System.Drawing.Point(526, 33);
            this.mcAgenda.Name = "mcAgenda";
            this.mcAgenda.TabIndex = 25;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.lblSesion);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.lblUser);
            this.pnlInfo.Controls.Add(this.lblHora);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Controls.Add(this.label1);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInfo.Location = new System.Drawing.Point(0, 541);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(784, 21);
            this.pnlInfo.TabIndex = 26;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInfo_Paint);
            // 
            // lblSesion
            // 
            this.lblSesion.AutoSize = true;
            this.lblSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSesion.Location = new System.Drawing.Point(718, 4);
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(0, 13);
            this.lblSesion.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(624, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Tiempo Sesión:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(57, 4);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 30;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(561, 4);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(0, 13);
            this.lblHora.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Hora:";
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.test1ToolStripMenuItem.Text = "Test1";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.mcAgenda);
            this.Controls.Add(this.msPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formMain";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarGastoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insumosToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar mcAgenda;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSesion;
        private System.Windows.Forms.ToolStripMenuItem distribuidoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dNIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaJurídicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nºProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem regsitrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem nºInsumoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem nºDistribuidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem categorizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem acercaDeRamosHnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem test1ToolStripMenuItem;
    }
}