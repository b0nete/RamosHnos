using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHermanos.Capas.Entidades;
using RamosHermanos.Capas.Negocio;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formProveedor : Form
    {
        public formProveedor()
        {
            InitializeComponent();
        }

        private void formProveedor_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            cargarProveedor();
            ProveedorB.InsertProv(prov, txtIDprov);
            SaldoB.InsertSaldo(saldo);



        }

        ProveedorEntity prov = new ProveedorEntity();
        
        private void cargarProveedor()
        {
            prov.nombreprov = txtprov.Text;
            prov.cuitprov = txtcuit.Text;
            prov.estadoprov = cbEstado.Checked;
            prov.rolprov = 2;
            
        }

        SaldoEntity saldo = new SaldoEntity();

        private void cargarSaldo()

        {
            saldo.creditoMax = Convert.ToDouble(txtSaldo.Text);
            saldo.saldoActual = Convert.ToDouble(txtsaldoActual.Text);
            saldo.rol = 2;
        }
    }
}
