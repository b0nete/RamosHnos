using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHnos.Capas.Entidades
{
    public class ProductoEntity
    {
        public int idProducto { get; set; }
        public int tipoProducto { get; set; }
        public string producto { get; set; }
        public double medida { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public int stockMin { get; set; }
        public string estado { get; set; }
    }
}
