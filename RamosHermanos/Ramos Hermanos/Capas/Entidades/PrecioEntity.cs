using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class PrecioEntity
    {
        public int idPrecioProducto { get; set; }
        public int producto { get; set; }
        public DateTime fechaActualizacion { get; set; }
        public double precio { get; set; }
        public bool estado { get; set; }
    }
}
