using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHnos.Capas.Entidades
{
    public class ProveedorEntity
    {
       public ProveedorEntity()
       {
       }

        // Atributos        
       public int idProveedor { get; set;}
       public string razonSocial { get; set; }
       public string cuit { get; set; }
       public string email { get; set; }



    }
}
