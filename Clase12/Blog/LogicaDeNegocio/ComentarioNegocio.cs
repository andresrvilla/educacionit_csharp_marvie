using AccesoDatos;
using CapaEntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class ComentarioNegocio
    {
        private ComentarioDatos comentarioDatos = new ComentarioDatos();

        public List<Comentario> TodosLosComentarios(int postId)
        {
            return comentarioDatos.TodosLosComentarios(postId);
        }

        public void AgregarComentario(Comentario comentario)
        {
            if (string.IsNullOrWhiteSpace(comentario.Autor))
            {
                throw new ArgumentException("No se cargo el autor");
            }

            if (string.IsNullOrWhiteSpace(comentario.Comentario1))
            {
                throw new ArgumentException("No se cargo el comentario");
            }

            comentarioDatos.InsertarComentario(comentario);
        }
    }
}
