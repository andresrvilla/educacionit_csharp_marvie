using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesComunes
{
    public class Alumno : Persona
    {
        //Esto tambien permitiria que yo cree un objeto Alumno con otro tipo
        // new Alumno(TipoPersona.Alumno)
        // new Alumno(TipoPersona.Instructor)
        /*public Alumno(TipoPersona tipo): base(tipo)
        {
            //Aca inicializaria todo lo relativo al alumno
            base.ToString(); //Llamo a un metodo del padre con la palabra reservada base
        }*/

        // new Alumno()
        public Alumno() : base(TipoPersona.Alumno)
        {

        }

    }
}
