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
    public abstract class Persona
    {
        private int CantidadVecesAccedido { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public override string ToString()
        {
            return $"Hola {Nombre} {Apellido}!!!";
        }

        //public string Tipo { get; } //Esto es una propiedad de solo lectura

        public TipoPersona Tipo { get; private set; } // Puedo cambiar el valor pero solo desde el mismo objeto


        public Persona(TipoPersona Tipo)
        {
            this.Tipo = Tipo;
            CantidadVecesAccedido = 100;
        }

    }
}
