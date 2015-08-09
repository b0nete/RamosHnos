using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHnos.Capas.Entidades
{
    class UsuarioEntity
    {
        //Atributos
        //idusuario , tipoDoc , numDoc, sexo, rol , nombre, apellido, cuil, email ,estado
 
        public int idUsuario { get; set; }
        public int tipoDoc { get; set; }
        public string numDoc { get; set; }
        public string sexo { get; set; }
        public int rol { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cuil { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }
    }
}
