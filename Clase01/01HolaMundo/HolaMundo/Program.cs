using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");

            // Declaracion de variables

            /*
             * ambito tipo nombre = valor;
             */

            int numero = 10;
            int otroNumero = 20;
            int unValor;

            string texto = "Nuevo Texto";

            bool valorTrueFalse = true;

            double unValorDecimal = 100.5;

            var unNumeroVar = 100;

            //unNumeroVar = "texto";

            var unTextoVar = "texto";

            var unArrayDeEnteros = new int[0];

            //var noValido;

            Console.Write("Ingrese un texto a copiar: ");

            var dato = Console.ReadLine();

            Console.WriteLine(dato);

            Console.ReadKey();
        }
    }
}
