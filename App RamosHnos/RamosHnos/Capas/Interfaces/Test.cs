using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHnos.Capas.Negocio;

namespace RamosHnos.Capas.Interfaces
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void Test_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = RubroB.ObtenerRubros();

            DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(column);

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            dataGridView1.Columns.Add(column2);



        }
    }
}
