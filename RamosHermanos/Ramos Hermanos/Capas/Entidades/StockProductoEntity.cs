using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    public class StockProductoEntity
    {
        public int idStock { get; set; }
        public int idProducto { get; set; }
        public int stockMinimo { get; set; }
        public int stockMaximo { get; set; }
        public int stockActual { get; set; }
        public int stockNuevo { get; set; }
        public DateTime fechaActualizacion { get; set; }

        //

        public int valorAnterior { get; set; }
        public int valorNuevo { get; set; }
    }
}
