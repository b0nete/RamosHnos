using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class itemsProductoEntity
    {
        public int producto { get; set; }
        public int idItemProducto { get; set; }
        public int idInsumo { get; set; }
        public string medida { get; set; }
        public double cantidad { get; set; }
    }
}
