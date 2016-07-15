using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RamosHermanos.Capas.Interfaz
{
    public partial class formAbout : Form
    {
        public formAbout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void formAbout_Load(object sender, EventArgs e)
        {

        }

        private void btnDelCalle_Click(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath.Replace(@"\bin\Debug", "");

            //this.Application.Documents.Open(ruta + "ManualDeUsuario.docx", ReadOnly: true);

            System.Diagnostics.Process prohelp = new System.Diagnostics.Process();
            //MessageBox.Show(ruta + @"\ManualDeUsuario.docx");
            prohelp.StartInfo.FileName = "D:\\GitHub Repos\\RamosHnos\\RamosHermanos\\Ramos Hermanos\\ManualDeUsuario.docx"; //ruta de donde se encuentre el archivo


            prohelp.Start();
            prohelp.Close();
        }
    }
}
