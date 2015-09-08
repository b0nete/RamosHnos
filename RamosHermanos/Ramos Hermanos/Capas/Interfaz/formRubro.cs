using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHermanos.Capas.Negocio;
using RamosHermanos.Capas.Entidades;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formRubro : Form
    {
        public formRubro()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GuardarRubro();
            RubroB.CargarDGV(dgvRubro);
        }

        private bool VerificarCampos()
        {
            if (txtRubro.Text == string.Empty)
            {
                MessageBox.Show("Campos Obligatorios Incompletos");
                return false;
            }
            return true;    

        }

        private void GuardarRubro()
        {
            if (VerificarCampos() == false)
            {
                return;
            }
            else
            {
                rubro.rubro = txtRubro.Text;
                if (RubroB.ExisteRubro(rubro) == false)
                {
                    cargarRubro();
                    RubroB.InsertRubro(rubro, txtidRubro);
                }
                else
                {
                    DialogResult result = MessageBox.Show("El rubro ya existe", "Rubro Existe", MessageBoxButtons.OK);
                    {
                        return;
                    }
                          
                
                
                }
            
            
            }

        
        
        }

        RubroEntity rubro = new RubroEntity();

        private void cargarRubro()
        {
            rubro.rubro = txtRubro.Text;
            rubro.estado = cbEstado.Checked;
        }

       
        private void formRubro_Load(object sender, EventArgs e)
        {
            RubroB.CargarDGV(dgvRubro);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    
    
    }
}
