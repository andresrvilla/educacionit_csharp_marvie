using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Defino la variable "Persona" pero puedo ponerle un objeto "Instructor"
             * porque "Instructor" hereda de "Persona". Es decir el "Hijo" puede
             * tomar el lugar del padre
             */
            Persona miPrimerObjeto = new Instructor(); 
            miPrimerObjeto.Apellido = "Villa";          // llama al "set" de la property
            Console.WriteLine(miPrimerObjeto.Apellido); // llama al "get" de la property
            miPrimerObjeto.SetNombre("Andrés");
            miPrimerObjeto.Denominacion = "Instructor";
            miPrimerObjeto.InformarNombre();

            //miPrimerObjeto.CBU = "1231231241231";

            Alumno miAlumno = new Alumno()
            {
                Apellido = "Ramirez",
                //Nombre = "Emiliano", No puedo usarlo por estar programando de la forma "teorica"
                Denominacion = "Alumno"
            };
            miAlumno.SetNombre("Emiliano");
            miAlumno.PagoAlDia = true;
            miAlumno.InformarNombre();

            Console.WriteLine("--------------------");
            Console.WriteLine(miPrimerObjeto);
            Console.WriteLine(miAlumno);

            Console.ReadKey();
        }
    }
}
