using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHnos.Capas.Entidades
{
    public class TelefonoEntity
    {
        public TelefonoEntity()
        {
        }

        // Atributos
        
        public int idTelefono { get; set; }
        public int cliente { get; set; }
        public int tipoTel { get; set; }
        public string caracteristica { get; set; }
        public string numTel { get; set; }
    }
}
