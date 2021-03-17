using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasConversionDatos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Casteo

            string datoUno = "100";

            // "BOXING"
            object datoBoxing = datoUno; //Casteo implicito

            string unboxing = (string)datoBoxing; //Casteo explicito

            //int unboxingError = (int)datoBoxing; Esto genera una excepcion porque no es entero

            int? unboxingSeguro = datoBoxing as int?; //Casteo seguro
            // o Nullable<int>

            Console.WriteLine("unboxing Seguro: " + unboxingSeguro);

            object otroDatoBoxing = 100;

            int? otroDatoUnboxingSeguro = otroDatoBoxing as int?;

            Console.WriteLine("otro unboxing seguro: " + otroDatoUnboxingSeguro);


            // Conversiones de tipo de dato

            int datoUnoAEntero = Convert.ToInt32(datoUno);

            Console.WriteLine("Conversion de datoUno a entero" + datoUnoAEntero);

            string noEsNumerico = "A";

            //int datoNumericoFalla = Convert.ToInt32(noEsNumerico); Falla porque no es numerico y no puede convertir

            // Conversiones de tipos de datos implicitos
            int valorEntero = 100;

            long nuevoValor = valorEntero;

            long valorMaximoLong = long.MaxValue;

            int sacoDelLong = (int)valorMaximoLong;

            Console.WriteLine("Saco del long " + sacoDelLong);
            
            Console.ReadKey();
        }
    }
}
