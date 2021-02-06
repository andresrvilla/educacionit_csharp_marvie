using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesComunes
{
    /*
     public-> desde cualquier ensablando
     internal ( o nada) -> desde el propio ensamblado
     private -> solo de manera privada dentro de la misma clase
     */
    public class Persona
    {
        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"Hola {Nombre} {Apellido}!!!";
        }
    }
}
