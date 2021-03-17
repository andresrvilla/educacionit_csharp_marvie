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

        public List<PostEntidad> ObtenerTodasLosPost()
        {
            return postDatos.ObtenerTodosLosPost();
        }

        public PostEntidad ObtenerPost(int id)
        {
            return postDatos.ObtenerPost(id);
        }


    }
}
