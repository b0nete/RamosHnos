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
            cargarProv();
            ProveedorB.InsertProveedor(proveedor, txtid);

        }

        ProveedorEntity proveedor = new ProveedorEntity();

        private void cargarProv()
    
        {
            proveedor.cuit = txtcuit.Text;
            proveedor.razsocial = txtRazonSocial.Text;
            proveedor.estado = cbEstado.Checked;
            proveedor.condicioniva = cbIVA.SelectedText;
            proveedor.tipoProveedor = Convert.ToInt32(cbTipoProveedor.SelectedValue);
            proveedor.rol = 2;          

        }

        private void MetodoFantasma88()
        {


        }
        
    }
}
