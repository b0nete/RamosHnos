using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class logEntity
    {
        public int usuario { get; set; }
        public int idLog { get; set; }
        public string accion { get; set; }
        public string detalle { get; set; }
        public DateTime hora { get; set; }
    }
}
