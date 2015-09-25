using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class CalleEntity
    {
        public int idCalle { get; set; }
        public int idBarrio { get; set; }
        public string calle { get; set; }
        public bool estado { get; set; }
    }
}
