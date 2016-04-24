using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    public class StockInsumoEntity
    {
        public int idStock { get; set; }
        public int idInsumo { get; set; }
        public int stockMinimo { get; set; }
        public int stockMaximo { get; set; }
        public int stockActual { get; set; }
        public int stockNuevo { get; set; }
        public DateTime fechaActualizacion { get; set; }
    }
}
