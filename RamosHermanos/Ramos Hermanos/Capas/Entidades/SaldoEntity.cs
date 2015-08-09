using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class SaldoEntity
    {
        public int idSaldo { get; set; }
        public int rol { get; set; }
        public int idPersona { get; set; }
        public double creditoMax { get; set; }
        public double saldoActual { get; set; }  
    }
}
