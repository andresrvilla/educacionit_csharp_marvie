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

            FiguraGeometrica[] figuras = new FiguraGeometrica[3];

            FiguraGeometrica unaFigura = new Rectangulo()
            {
                LadoUno = 10,
                LadoDos = 30
            };

            figuras[0] = unaFigura;

            FiguraGeometrica otraFigura = new Cuadrado()
            {
                LadoDos = 100
            };

            figuras[1] = otraFigura;

            Circunferencia circunferencia = new Circunferencia()
            {
                Radio = 3
            };

            figuras[2] = circunferencia;

            for (int i = 0; i < figuras.Length; i++)
            {
                //figuras[i].Area()
                FiguraGeometrica figuraBucle = figuras[i];
                Console.WriteLine(figuraBucle.GetType());
                Console.WriteLine(figuraBucle.Area());
                Console.WriteLine(figuraBucle.Perimetro());
            }

            Console.ReadKey();
        }
    }
}
