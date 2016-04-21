using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Negocio
{
    class LogStockProductoEntity
    {
        public int idStockProductoLog { get; set; }
        public string operacion { get; set; }
        public int comprobante { get; set; }
        public int idProducto { get; set; }
        public int cantidad { get; set; }
        public int stockActual { get; set; }
        public int stockNuevo { get; set; }
        public DateTime fechaActualizacion { get; set; }
    }
}
