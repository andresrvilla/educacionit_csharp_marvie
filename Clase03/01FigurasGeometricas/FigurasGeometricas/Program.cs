using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangulo rectangulo = new Rectangulo()
            {
                LadoUno = 10,
                LadoDos = -20
            };

            Console.WriteLine(rectangulo);
            Console.WriteLine($"Area: {rectangulo.Area()}");
            Console.WriteLine($"Perimemtro: {rectangulo.Perimetro()}");

            Cuadrado miCuadrado = new Cuadrado()
            {
                LadoUno = 10,
                LadoDos = 20
            };

            Console.WriteLine(miCuadrado);
            Console.WriteLine($"Area: {miCuadrado.Area()}");
            Console.WriteLine($"Perimemtro: {miCuadrado.Perimetro()}");

            Console.ReadKey();
        }
    }
}
