using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    public class StockEntity
    {
        public int idStock { get; set; }
        public string productoInsumo { get; set; }
        public string idProductoInsumo { get; set; }
        public int stockMinimo { get; set; }
        public int stockMaximo { get; set; }
        public int stockActual { get; set; }
        public DateTime fechaActualizacion { get; set; }
    }
}
