using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class ProveedorEntity
    {
        public int IDproveedor { get; set; }
        public int rolprov { get; set; }
        public string nombreprov { get; set; }
        public string cuitprov { get; set; }
        public string emailprov { get; set; }
        public bool estadoprov { get; set; }
    }
}
