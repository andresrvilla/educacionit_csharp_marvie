using CapaEntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ComentarioDatos
    {

        private BlogEntities entidades = new BlogEntities(); //representa la "conexion" con la base de datos

        public List<Comentario> TodosLosComentarios(int postId)
        {
            List<Comentario> resultado;
            
            var consulta = from c in entidades.Comentarios
                           where c.IdPost == postId
                           select c;
            resultado = consulta.ToList(); //Aca efectivamente hace la consulta con la base de datos
            return resultado;
        }

        public void PruebaObjetosAnonimos(int postId)
        {
            var consulta = from c in entidades.Comentarios
                           where c.IdPost == postId
                           select new { c.Autor, c.Comentario1 };
        }

        public void InsertarComentario(Comentario comentario)
        {
            entidades.Comentarios.Add(comentario);
            entidades.SaveChanges();
        }

        public void ActualizarComentario(Comentario comentarioAactualizar)
        {
            Comentario comentario = entidades.Comentarios.Where(x => x.Id == comentarioAactualizar.Id).FirstOrDefault();
            comentario.Autor = comentarioAactualizar.Autor;
            comentario.Comentario1 = comentarioAactualizar.Comentario1;
            entidades.SaveChanges();
        }

        public void BorrarComentario(int idComentario)
        {
            Comentario comentario = entidades.Comentarios.Where(x => x.Id == idComentario).FirstOrDefault();
            entidades.Comentarios.Remove(comentario);
            entidades.SaveChanges();
        }

        public void BorrarTodosLosComentarios(int idPost)
        {
            List<Comentario> comentarios = entidades.Comentarios.Where(x => x.IdPost == idPost).ToList();
            entidades.Comentarios.RemoveRange(comentarios);
            entidades.SaveChanges();
        }
    }
}
