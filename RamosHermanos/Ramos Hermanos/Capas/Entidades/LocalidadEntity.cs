using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class LocalidadEntity
    {
        public int idLocalidad { get; set; }
        public int idProvincia { get; set; }
        public string localidad { get; set; }
        public bool estado { get; set; }
    }
}
