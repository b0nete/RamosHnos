using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class BarriosEntity
    {
        public int idBarrio { get; set; }
        public int idLocalidad { get; set; }
        public string barrio { get; set; }
        public bool estado { get; set; }
    }
}
