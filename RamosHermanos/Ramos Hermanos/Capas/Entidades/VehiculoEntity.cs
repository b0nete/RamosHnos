using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class VehiculoEntity
    {
        public int idVehiculo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string patente { get; set; }
        public string color { get; set; }
        public bool estado { get; set; }
    }
}
