using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class FacturaEntity
    {
        public int idFactura { get; set; }
        public string tipoFactura { get; set; }
        public int numFactura { get; set; }
        public DateTime fechaFactura { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public DateTime fechaEntrega { get; set; }
        public string formaPago { get; set; }
        public string observaciones { get; set; }
        public double total { get; set; }
        public int porcDescuento { get; set; }
        public double totalFinal { get; set; }
        public string estado { get; set; }
        public int cliente { get; set; }
        public int domicilio { get; set; }

        //Secundarios

        public string nombreCompleto { get; set; }
        public string domicilioCompleto { get; set; }
        public int proveedor { get; set; }
    }
}
