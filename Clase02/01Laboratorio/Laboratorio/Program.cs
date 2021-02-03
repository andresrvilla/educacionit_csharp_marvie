using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            DibujarTriangulo(4);
            DibujarTriangulo(7);

            Console.ReadKey();
        }

        static void DibujarTriangulo(int cota)
        {
            for (int i = 0; i <= cota; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            for (int i = cota - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
    }
}
