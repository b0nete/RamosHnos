using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    public class ProductoEntity
    {
        public int idProducto { get; set; }
        public DateTime fechaAlta { get; set; }
        public int tipoProducto { get; set; }
        public int marca { get; set; }
        public string producto { get; set; }
        public string descripcion { get; set; }
        public double cantidad { get; set; }
        public int medida { get; set; }
        public bool estado { get; set; }
        public double costo { get; set; }
    }
}
