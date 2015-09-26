using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class PedidoEntity
    {
        public int idPedido { get; set; }
        public int rol { get; set; }
        public int persona { get; set; }
        public string domicilio { get; set; }
        public int tipoPedido { get; set; }
        public string observaciones { get; set; }
        public double total { get; set; }
        public string estado { get; set; }
    }
}
