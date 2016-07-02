using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class itemComprasEntity
    {
        public int iditemCompra { get; set; }
        public int compra { get; set; }
        public int idInsumo { get; set; }
        public int idRubro { get; set; }
        public string marca { get; set; }
        public double precioUnitario { get; set; }
        public int cantidad { get; set; }
        public double subTotal { get; set; }
    }
}
