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
        public string horarioVisitaA { get; set; }
        public string horarioVisitaB { get; set; }

        //Días
        public int idDias { get; set; }
        public bool dlunes { get; set; }
        public bool dmartes { get; set; }
        public bool dmiercoles { get; set; }
        public bool djueves { get; set; }
        public bool dviernes { get; set; }
        public bool dsabado { get; set; }
        public bool ddomingo { get; set; }

        //Orden
        public int idOrden { get; set; }
        public int olunes { get; set; }
        public int omartes { get; set; }
        public int omiercoles { get; set; }
        public int ojueves { get; set; }
        public int oviernes { get; set; }
        public int osabado { get; set; }
        public int odomingo { get; set; }
    }
}
