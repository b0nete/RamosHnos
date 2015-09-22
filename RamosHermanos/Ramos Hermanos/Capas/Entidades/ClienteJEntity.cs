using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class ClienteJEntity
    {
        public int idCliente { get; set; }
        public int rol { get; set; }
        public string tipoPersona { get; set; }
        public DateTime fechaAlta { get; set; }
        public string cuil { get; set; }
        public string nombre { get; set; }
        public string condicionIVA { get; set; }
        public int tipoCliente { get; set; }
        public bool estado { get; set; }
    }
}
