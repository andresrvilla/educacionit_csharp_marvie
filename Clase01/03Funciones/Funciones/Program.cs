using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Saludar("Andres");
            int resultado = suma(10, 20);
            Console.WriteLine($"El resultado es {resultado}");
            Console.ReadKey();
        }

        static void Saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }

        static int suma(int valorA,int valorB)
        {
            return valorA + valorB;
        }
    }
}
