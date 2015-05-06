using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHnos.Capas.Entidades
{
    public class TipoProductoEntity
    {
        public TipoProductoEntity()
        {
        }

        public int idTipoProducto { get; set; }
        public string tipoProducto { get; set; }
        public bool estado { get; set; }
    }
}
