﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RamosHnos.Capas.Negocio;
using RamosHnos.Capas.Entidades;
using RamosHnos.Capas.Interfaces;

namespace RamosHnos
{
    public partial class formDomicilio : Form
    {
        public formDomicilio()
        {
            InitializeComponent();
        }

        private void formDomicilio_Load(object sender, EventArgs e)
        {
            //Cargar Provincia
            ProvinciaB.CargarProvincia(cbProvincia);

            //Cargar Localidad
            LocalidadEntity localidad = new LocalidadEntity()
            {
                provincia = Convert.ToInt32(cbProvincia.SelectedValue)
            };
            LocalidadB.CargarLocalidad(cbLocalidad, localidad); 

            //Cargar Cliente
            string cliente = txtIDCliente.Text;
            DomicilioB.CargarDomicilio2(dgvDomicilio, cliente);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formProvincia frm = new formProvincia();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formLocalidad frm = new formLocalidad();
            frm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DomicilioEntity domicilio = new DomicilioEntity()
            {
                cliente = Convert.ToInt32(txtIDCliente.Text),
                provincia = Convert.ToInt32(cbProvincia.SelectedValue),
                localidad = Convert.ToInt32(cbLocalidad.SelectedValue),
                calle = txtCalle.Text,
                numero = txtnumCalle.Text,
                piso = txtPiso.Text,
                dpto = txtDpto.Text,
                CP = txtCP.Text
            };

            DomicilioB.InsertDomicilio(domicilio);
            DomicilioB.CargarDomicilio(dgvDomicilio, domicilio);
            
  
        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadEntity localidad = new LocalidadEntity()
            {
                provincia = Convert.ToInt32(cbProvincia.SelectedValue)
            };

            LocalidadB.CargarLocalidad(cbLocalidad, localidad);
        }

        private void cbProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            LocalidadEntity localidad = new LocalidadEntity()
            {
                provincia = Convert.ToInt32(cbProvincia.SelectedValue)
            };

            LocalidadB.CargarLocalidad(cbLocalidad, localidad);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Cargar Cliente
            string cliente = txtIDCliente.Text;
            DomicilioB.CargarDomicilio2(dgvDomicilio, cliente);
        }
    }
}
