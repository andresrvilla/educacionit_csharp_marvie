using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaObjetos
{
    class Persona
    {
        /*
         * Visibilidad de Miembros (Atributos y Metodos)
         * 
         * public -> Visible desde el propio objeto y desde fuera del objeto
         * protected (o nada) -> Visible desde el propio objeto y en sus clases derivadas (Herencia)
         * private -> Visible solo para el propio objeto, desde afuera no se puede ver
         */

        //Atributos. Representan el estado del objeto. Datos

        // Encapsulamiento por medio de getter y setter (De la teoria)
        protected string nombre;

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        // Encapsulamiento por medio de Property autoimplementada

        //private string apellido;

        public string Apellido { get; set; }

        // Encapsulamiento por medio de una Property Full Implementada

        private string denominacion; // Sr, Sra, Dr, etc

        public string Denominacion
        {
            get
            {
                //Hacer cosas
                int a =  2 + 2;

                return denominacion;
            }
            set
            {
                // palabra reservada "value" que es donde esta el valor que le estoy pasando a la property
                denominacion = value;
            }
        }

        //Metodos (Procedimientos y Funciones). Comportamiento
        public void InformarNombre()
        {
            //String interpolation
            Console.WriteLine($"{denominacion} {Apellido} {nombre}");
        }

        public void Vaciar()
        {
            nombre = "";
            Apellido = "";
            denominacion = string.Empty;
        }
    }
}
