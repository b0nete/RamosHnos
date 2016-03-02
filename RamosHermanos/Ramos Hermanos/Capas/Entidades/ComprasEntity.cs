using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class ComprasEntity
    {
        public int idCompras { get; set; }
        public int proveedor { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public string observaciones { get; set; }
        public double total { get; set; }
        public string estado { get; set; }

    }
}
