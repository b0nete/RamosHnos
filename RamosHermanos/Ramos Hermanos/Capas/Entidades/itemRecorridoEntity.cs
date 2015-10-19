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
        public int desde { get; set; }
        public int hasta { get; set; }
        public string sentido { get; set; }
        public bool estado { get; set; }
    }
}
