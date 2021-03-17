using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class Matematicas
    {
        public static int sumar(int numeroUno, int numeroDos, int numeroTres = 0)
        {
            return numeroUno + numeroDos + numeroTres;
        }

        public static double dividir(double numeroUno, double numeroDos)
        {
            return numeroUno / numeroDos;
        }

        public static double calcular(double numeroUno, double numeroDos, double numeroTres)
        {
            return (numeroUno / numeroDos) * numeroTres;
        }
    }
}
