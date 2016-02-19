using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class RepartoEntity
    {
        public int idReparto { get; set; }
        public int distribuidor { get; set; }
        public DateTime fecha { get; set; }
        public string turno { get; set; }
        public bool generado { get; set; }
    }
}
