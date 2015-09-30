using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class itemRecorridoEntity
    {
        public int idCallesRecorrido { get; set; }
        public int recorrido { get; set; }
        public int calle { get; set; }
        public string desde { get; set; }
        public string hasta { get; set; }
        public bool estado { get; set; }
    }
}
