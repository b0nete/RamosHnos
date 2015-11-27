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
        public int idPersona { get; set; }
        public int rol { get; set; }
        public DateTime fechaPedido { get; set; }
        public DateTime fechaEntrega { get; set; }
        public string domicilio { get; set; }
        public int tipoPedido { get; set; }
        public string observaciones { get; set; }
        public double total { get; set; }
        public string estado { get; set; }
        public int numPedido { get; set; }

        //Atributos Extras

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string calle { get; set; }
    }
}
