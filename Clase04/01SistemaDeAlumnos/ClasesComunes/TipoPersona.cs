using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesComunes
{
    //El tipo subyacente por defecto es "int"
    public enum TipoPersona: byte
    {
        Alumno = 10,
        Instructor = 11,
        Coordinador = 12,
        Administrativo = 13
    }
}
