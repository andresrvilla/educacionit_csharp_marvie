using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class PostNegocio
    {
        private readonly PostDatos postDatos;

        public PostNegocio()
        {
            postDatos = new PostDatos();
        }

        public List<Post> ObtenerTodasLosPost()
        {
            return postDatos.ObtenerTodosLosPost();
        }

        public Post ObtenerPost(int id)
        {
            return postDatos.ObtenerPost(id);
        }


    }
}
