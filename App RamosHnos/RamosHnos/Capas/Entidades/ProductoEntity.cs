using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHnos.Capas.Entidades
{
    public class ProductoEntity
    {
        public ProductoEntity()
        {
        }

        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public int tipoProducto { get; set; }
        public int medida { get; set; }
        public string estado { get; set; }
    }
}
