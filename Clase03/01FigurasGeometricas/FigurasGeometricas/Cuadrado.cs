using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    sealed class Cuadrado: Rectangulo
    {
        public override double LadoUno { 
            get 
            {
                return ladoUno;
            }
            set
            {
                if(value <= 0)
                {
                    ladoUno = 1;
                    ladoDos = 1;
                }
                else
                {
                    ladoUno = value;
                    ladoDos = value;
                }
            }
        }

        public override double LadoDos {
            get
            {
                return ladoDos;
            }
            set
            {
                if(value <= 0)
                {
                    ladoUno = 1;
                    ladoDos = 1;
                }
                else
                {
                    ladoUno = value;
                    ladoDos = value;
                }
            }
        }
    }

    /*
     * 
     * Lo siguiente no lo puedo hacer, porque no puedo heredar de una clase "sellada ( sealed )"
    class SuperCuadrado: Cuadrado
    {

    }

    class SuperString: String
    {

    }*/
}
