﻿namespace RamosHermanos.Capas.Interfaz.Listados
{
    partial class listVentas
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.colFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoFac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFactura,
            this.colTipoFac,
            this.colFecha,
            this.colTotal,
            this.colNombre,
            this.colEstado});
            this.dgvVentas.Location = new System.Drawing.Point(12, 12);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(760, 537);
            this.dgvVentas.TabIndex = 0;
            // 
            // colFactura
            // 
            this.colFactura.DataPropertyName = "colFactura";
            this.colFactura.HeaderText = "Nº Comprobante";
            this.colFactura.Name = "colFactura";
            this.colFactura.ReadOnly = true;
            // 
            // colTipoFac
            // 
            this.colTipoFac.HeaderText = "Tipo Factura";
            this.colTipoFac.Name = "colTipoFac";
            this.colTipoFac.ReadOnly = true;
            this.colTipoFac.Visible = false;
            // 
            // colFecha
            // 
            this.colFecha.DataPropertyName = "colFecha";
            this.colFecha.HeaderText = "Fecha Factura";
            this.colFecha.Name = "colFecha";
            this.colFecha.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "colTotal";
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "colNombre";
            this.colNombre.HeaderText = "Cliente";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "colEstado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // listVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvVentas);
            this.Name = "listVentas";
            this.Text = "Listado Ventas";
            this.Load += new System.EventHandler(this.listVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}