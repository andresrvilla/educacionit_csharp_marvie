using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    class Rectangulo: FiguraGeometrica
    {
        protected double ladoUno = 1;

        public virtual double LadoUno
        {
            get
            {
                return ladoUno;
            }
            set
            {
                // value es por ejemplo "10" en la sentencia o.LadoUno = -1;
                if(value <= 0)
                {
                    ladoUno = 1;
                }
                else
                {
                    ladoUno = value;
                }
            }
        }

        protected double ladoDos = 1;

        public virtual double LadoDos
        {
            get
            {
                return ladoDos;
            }
            set
            {
                if(value <= 0)
                {
                    ladoDos = 1;
                }
                else
                {
                    ladoDos = value;
                }
            }
        }

        public override string ToString()
        {
            return $"[LadoA={LadoUno};LadoB={LadoDos}]";
        }

        public sealed override double Perimetro()
        {
            return LadoUno * 2 + LadoDos * 2;
        }

        public sealed override double Area()
        {
            return LadoUno * LadoDos;
        }
    }
}
