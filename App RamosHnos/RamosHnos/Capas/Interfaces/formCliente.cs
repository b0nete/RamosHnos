using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Negocio;
using RamosHnos.Capas.Interfaces;
using RamosHnos.Libs;


namespace RamosHnos.Capas.Interfaces
{
    public partial class formCliente : Form
    {
        
        public formCliente()
        {
            InitializeComponent();  
        }

        private void nuevaPestana(UserControl uc, String titulo)
        {
            int indice = indicePestanaAbierta(titulo);
            if (indice < 0)
            {
                TabPage tab = new TabPage();
                tab.Text = titulo;
                tab.Controls.Add(uc);
                tabMain.TabPages.Add(tab);
                tabMain.SelectedTab = tab;
            }
            else
            {
                //si ya existe vamos a limpiar el usercontrol y volverlo a cargar en la misma pestaña
                tabMain.TabPages[indice].Controls.Clear();
                tabMain.TabPages[indice].Controls.Add(uc);
                tabMain.SelectedTab = tabMain.TabPages[indice];
            }

        }

        private int indicePestanaAbierta(String titulo)
        {
            Boolean enc = false;
            int i = 0;

            while ((i < tabMain.TabPages.Count) && (enc == false))
            {
                if (tabMain.TabPages[i].Text == titulo)
                    enc = true;
                else
                    i++;
            }
            if (enc)
                return i;
            else
                return -1;

        }

        //private void configuracionGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    UCconfiguracionGeneral uc = new UCconfiguracionGeneral();
        //    nuevaPestana(uc, "Configuración");
        //}

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            int indice = tabMain.SelectedIndex;
            if (indice > 0) //no queremos cerrar nunca la inicial.
            {
                tabMain.TabPages.Remove(tabMain.SelectedTab);
                tabMain.SelectedIndex = indice - 1;
                GC.Collect();
            }

        }

        private void formCliente_Load(object sender, EventArgs e)
        {
            UCCliente uc = new UCCliente();
            nuevaPestana(uc, "Cliente");
        }

         
             
           
    }
}

