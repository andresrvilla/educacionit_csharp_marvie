using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesComunes
{
    public class Curso
    {
        public int Id { get; set; }

        public List<Persona> Participantes { get; set; } = new List<Persona>();

        public Curso()
        {
            //Participantes = new List<Persona>();
        }

        public bool EsValido()
        {
            int cantidadInstructores = 0;
            int cantidadAlumnos = 0;
            int cantidadCoordinadores = 0;

            foreach(var participante in Participantes)
            {
                switch (participante.Tipo)
                {
                    case TipoPersona.Instructor:
                        cantidadInstructores++;
                        break;
                    case TipoPersona.Alumno:
                        cantidadAlumnos++;
                        break;
                    case TipoPersona.Coordinador:
                        cantidadCoordinadores++;
                        break;
                }
            }

            bool esValido = false;
            if(cantidadInstructores==1 && cantidadCoordinadores==1 && cantidadAlumnos > 4)
            {
                esValido = true;
            }
            return esValido;
        }
    }
}
