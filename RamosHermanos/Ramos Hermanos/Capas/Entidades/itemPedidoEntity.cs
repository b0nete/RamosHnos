using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class itemPedidoEntity
    {
        public int iditemsPedido { get; set; }
        public int idPedido { get; set; }
        public int cantidad { get; set; }
        public Double preciounitario { get; set; }
        public Double subtotal { get; set; }
    }
}
