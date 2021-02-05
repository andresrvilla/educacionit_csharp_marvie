using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Circunferencia : FiguraGeometrica
    {

        public double Radio { get; set; } //falta validar que el radio sea mayor o igual a 0

        public override double Area()
        {
            return Math.PI * Radio * Radio;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * Radio;
        }
    }
}
