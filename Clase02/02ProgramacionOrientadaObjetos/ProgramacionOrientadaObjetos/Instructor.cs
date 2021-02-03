using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaObjetos
{
    class Instructor: Persona // Instructor hereda de persona
    {
        public string CBU { get; set; }

        public override string ToString()
        {
            return $"Instructor {nombre} {Apellido}";
        }
    }
}
