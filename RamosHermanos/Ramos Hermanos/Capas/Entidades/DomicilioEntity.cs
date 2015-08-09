using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHnos.Capas.Entidades
{
    public class DomicilioEntity
    {
        // Atributos

        public int idDomicilio { get; set; }
        public int rol { get; set; }
        public int idPersona { get; set; }
        public int cliente { get; set; }
        public int provincia { get; set; }
        public int localidad { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string piso { get; set; }
        public string dpto { get; set; }
        public string CP { get; set; }
    }
}
