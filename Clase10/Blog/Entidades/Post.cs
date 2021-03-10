using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Post
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Resumen { get; set; }

        public string Cuerpo { get; set; }

        public string Autor { get; set; }

        public DateTime Fecha { get; set; }
    }
}
