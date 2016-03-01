using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class itemFacturaEntity
    {
        public int idItemFactura { get; set; }
        public string factura { get; set; }
        public int producto { get; set; }
        public int cantidad { get; set; }
        public double precioUnitario { get; set; }
        public double subTotal { get; set; }
        public string favor { get; set; }
    }
}
