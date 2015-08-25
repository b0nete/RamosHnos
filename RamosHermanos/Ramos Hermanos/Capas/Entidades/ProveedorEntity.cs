using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class ProveedorEntity
    {
        public int idProveedor { get; set; }
        public DateTime fecha { get; set; }
        public int rol { get; set; }
        public string razsocial { get; set; }
        public string cuit { get; set; }
        public bool estado { get; set; }
        public int tipoProveedor { get; set; }
        public string condicioniva { get; set; }

    }
}
