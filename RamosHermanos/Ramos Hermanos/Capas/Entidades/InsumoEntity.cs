using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class InsumoEntity
    {
        public int idInsumo { get; set; }
        public DateTime fecha { get; set; }
        public int rubro { get; set; }
        public int proveedor { get; set; }
        public string marca { get; set; }
        public string insumo { get; set; }
        public string descripcion { get; set; }
        public string stockMin { get; set; }
        public bool estado { get; set; }
    }
}
