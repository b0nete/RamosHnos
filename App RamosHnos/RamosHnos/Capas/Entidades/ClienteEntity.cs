using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHnos.Capas.Entidades
{
    public class ClienteEntity
    {
        // Atributos
        public int idCliente { get; set; }
        public int tipoDoc { get; set; }
        public string numDoc { get; set; }
        public string sexo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cuil { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }
    }
}