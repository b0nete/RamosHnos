using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class CostoEntity
    {
        public int idCostoInsumo { get; set; }
        public int insumo { get; set; }
        public double costo { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public bool estado { get; set; }
    }
}
