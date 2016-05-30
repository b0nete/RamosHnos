using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class PrecioInsumoEntity
    {
        public int idPrecioInsumo { get; set; }
        public int insumo { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public decimal precio { get; set; }
        public bool estado { get; set; }
    }
}
