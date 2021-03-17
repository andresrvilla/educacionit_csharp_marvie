using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.ExtensionsMethods
{
    public static class StringExtensions
    {
        public static string Concatenar(this string me, string otroValor)
        {
            return me + otroValor;
        }
    }
}
