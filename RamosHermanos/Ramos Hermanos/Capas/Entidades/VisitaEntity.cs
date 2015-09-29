using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class VisitaEntity
    {
        public int idVisita { get; set; }
        public int rol { get; set; }
        public int idPersona { get; set; }
        public string dia { get; set; }
        public int domicilio { get; set; }
        public int distribuidor { get; set; }
        public bool estado { get; set; }
    }
}
