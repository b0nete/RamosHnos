using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class tipoClienteEntity
    {
        public int idtipoCliente { get; set; }
        public string tipoCliente { get; set; }
        public string descripcion { get; set; }
        public int porcDescuento { get; set; }
        public string color { get; set; }
        public bool estado { get; set; }
    }
}
