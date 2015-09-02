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
        public string numDoc { get; set; }
        public string nombre { get; set; }
        public int MyProperty { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool estado { get; set; }
    }
}
