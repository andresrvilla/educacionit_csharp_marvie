using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.ExtensionsMethods
{
    public static class ObjectExtensions
    {
        /*
         * No quiero hacer "ObjectExtensions.ToInt32("100")
         * sino que quiero hacer lo siguiente
         * "100".ToInt32()
         */
        public static int ToInt32(this object o)
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
