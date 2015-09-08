using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamosHermanos.Capas.Entidades
{
    class DistribuidoresEntity
    {
        public int idDistribuidor { get; set; }
        public int rol { get; set; }
        public DateTime fechaAlta { get; set; }
        public int tipoDoc { get; set; }
        public string numDoc { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string sexo { get; set; }
        public string cuil { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string estadoCivil { get; set; }
        public bool estado { get; set; }
        public int vehiculo { get; set; }
    }
}
