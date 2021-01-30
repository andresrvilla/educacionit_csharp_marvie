using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA = 100;
            int valorB = 20;

            if (valorA + valorB > 100)
            {
                Console.WriteLine("La suma de ambas variables es mayor a 100");
            }

            if (valorA + valorB > 100)
                Console.WriteLine("La suma de ambas variables es mayor a 100");
            else
            {
                Console.WriteLine("La suma de ambas variables es menor o igual a 100");
            }


            int valorSwitch = 4;

            switch (valorSwitch)
            {
                case 1:
                    Console.WriteLine("El valor es 1");
                    break;
                case 300:
                    Console.WriteLine("El valor es 300");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("El valor es 2 o 3");
                    break;
                default:
                    Console.WriteLine("El valor no es 1, 2, 3 o 300");
                    break;
            }

            // WHILE

            int contador = 0;
            int otroValor = 101;
            while (contador < 20 && otroValor == 100)
            {
                Console.WriteLine("El valor de contador es {0}", contador);
                contador++;
            }

            contador = 0;

            do
            {
                Console.WriteLine($"El valor de contador (do while) es {contador}"); //string interpolation
                contador++;
            } while (contador < 10);

            var interpolacion = $"{contador} {contador}";
            Console.WriteLine(interpolacion);
            Console.WriteLine("Esto es un texto {0} {1}", contador, otroValor);


            for(int i = 0;i < 20; i++)
            {
                Console.WriteLine($"Bucle for {i}");
            }

            Console.ReadKey();
        }
    }
}
