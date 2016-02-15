using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class itemsRepartoEntity
    {
        public int idItemReparo { get; set; }
        public int reparto { get; set; }
        public int cliente { get; set; }
        public int domicilio { get; set; }
        public int idComprobante { get; set; }
    }
}
