using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class EmailEntity
    {
        public int idEmail { get; set; }
        public int rol { get; set; }
        public int idPersona { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }
    }
}
