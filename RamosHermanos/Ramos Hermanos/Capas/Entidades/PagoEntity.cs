using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class PagoEntity
    {
        public int idPago { get; set; }
        public int cliente { get; set; }
        public double monto { get; set; }
        public DateTime fechaPago { get; set; }
    }
}
