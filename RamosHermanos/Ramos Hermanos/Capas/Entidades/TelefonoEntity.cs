using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    public class TelefonoEntity
    {
        // Atributos        
        public int idTelefono { get; set; }
        public int rol { get; set; }
        public int idPersona { get; set; }
        public int tipoTel { get; set; }
        public string caracteristica { get; set; }
        public string numTel { get; set; }
        public bool estado { get; set; }
    }
}
