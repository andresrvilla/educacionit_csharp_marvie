using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesComunes;

namespace AlumnosConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpIntensivo = new Curso();

            Instructor instructor = new Instructor()
            {
                Apellido="Villa",
                Nombre="Andrés"
            };

            csharpIntensivo.Participantes.Add(instructor);

            csharpIntensivo.Participantes.Add(new Alumno() { Apellido = "Ramirez", Nombre = "Emiliano" });
            csharpIntensivo.Participantes.Add(new Coordinador() { Apellido = "Badoza", Nombre = "Mailen" });
            csharpIntensivo.Participantes.Add(new Alumno() { Apellido = "Leikin", Nombre = "Glenda" });
            csharpIntensivo.Participantes.Add(new Alumno() { Apellido = "Leikin", Nombre = "Glenda" });
            csharpIntensivo.Participantes.Add(new Alumno() { Apellido = "Leikin", Nombre = "Glenda" });
            csharpIntensivo.Participantes.Add(new Alumno() { Apellido = "Leikin", Nombre = "Glenda" });

            Console.WriteLine("Participantes del curso: ");

            foreach(var item in csharpIntensivo.Participantes)
            {
                // verificamos si es valido
                Console.WriteLine(item.Apellido + " " + item.Nombre);
            }

            Console.WriteLine("El curso es valido? " + csharpIntensivo.EsValido());

            Curso otroCurso = new Curso();
            //Bla bla

            Console.WriteLine(otroCurso.EsValido());

            Console.ReadKey();
        }

        private static void PruebaList()
        {
            List<string> cursos = new List<string>();

            cursos.Add("Programacion Web con C#");
            cursos.Add("Javascript desde cero");
            cursos.Add("Introducción a la programación con C#");
            cursos.Add("Introducción a Bases de Datos y SQL");

            // For-Next
            for (int i = 0; i < cursos.Count; i++)
            {
                string elemento = cursos[i];
                Console.WriteLine(cursos[i]);
            }
            Console.WriteLine("*****************");
            // Foreach
            foreach (string elemento in cursos)
            {
                Console.WriteLine(elemento);
            }

            Console.WriteLine("*****************");

            foreach (var item in cursos)
            {
                Console.WriteLine(item);
            }

            //Creo la lista con los 4 apellidos ya dentro de ella cuando se construye
            List<string> apellidos = new List<string>() { "Villa", "Gomez", "Perez", "Suarez" };

            apellidos.Remove("Gomez");
            apellidos.RemoveAt(1);

            foreach (var ape in apellidos)
            {
                Console.WriteLine(ape);
            }
        }

    }
}
