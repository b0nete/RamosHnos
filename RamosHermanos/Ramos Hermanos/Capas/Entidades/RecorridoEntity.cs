using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class RecorridoEntity
    {
        public int idRecorrido { get; set; }
        public int distribuidor { get; set; }
        public string dia { get; set; }
        public bool estado { get; set; }
    }
}
