using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public static class Conversiones
    {
        public static int ToInt32(object o)
        {
            int resultado = 0;
            try
            {
                resultado = Convert.ToInt32(o);
            }
            catch
            {
                resultado = 0;
            }
            return resultado;
        }

    }
}
