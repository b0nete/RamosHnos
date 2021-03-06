﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    public class DomicilioEntity
    {
        // Atributos
        public int idDomicilio { get; set; }
        public int rol { get; set; }
        public int idPersona { get; set; }
        public int provincia { get; set; }
        public int localidad { get; set; }
        public int barrio { get; set; }
        public int calle { get; set; }
        public string numero { get; set; }
        public string piso { get; set; }
        public string dpto { get; set; }
        public string CP { get; set; }
        public bool estado { get; set; }

        // Atributos Extra
        public string domCompleto { get; set; }
    }
}
