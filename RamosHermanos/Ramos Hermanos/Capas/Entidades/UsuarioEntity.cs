using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class UsuarioEntity
    {
        //Atributos
 
        public int idUsuario { get; set; }
        public int privilegios { get; set; }
        public string numDoc { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }
    }
}
