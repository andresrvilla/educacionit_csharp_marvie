using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    //abstract class evita que pueda crear una instancia. (new FiguraGeometrica() tira error)
    abstract class FiguraGeometrica
    {
        //Metodo Area
        public abstract double Area();

        //Metodo Perimetro
        public abstract double Perimetro();
    }
}
