using Blog.Contadores;
using CapaEntityFramework;
using Entidades;
using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilidades;
using Utilidades.ExtensionsMethods;

namespace Blog
{
    public partial class VerPost : System.Web.UI.Page
    {
        private PostNegocio postNegocio = new PostNegocio();

        private ComentarioNegocio comentarioNegocio = new ComentarioNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                string parametroId = Request.QueryString["id"];
                int id = parametroId.ToInt32();

                string concatenado = parametroId.Concatenar("otro valor");

                if (id > 0)
                {

                    PostEntidad elPost = postNegocio.ObtenerPost(id);

                    lblTitulo.Text = elPost.Titulo;
                    lblContenido.Text = elPost.Cuerpo;

                    List<Comentario> losComentarios = comentarioNegocio.TodosLosComentarios(id);
                    lstComentarios.DataSource = losComentarios;
                    lstComentarios.DataBind();
                }
                else
                {
                    Response.Redirect("~/");
                }
            }
        }

        protected void btnGuardarComentario_Click(object sender, EventArgs e)
        {
            string parametroId = Request.QueryString["id"];
            int id = Convert.ToInt32(parametroId);

            //Faltaria validar antes que los datos sean correctos

            Comentario nuevoComentario = new Comentario()
            {
                Autor = txtAutor.Text,
                Comentario1 = txtComentario.Text,
                IdPost = id
            };

            try
            {
                comentarioNegocio.AgregarComentario(nuevoComentario);
            }
            catch (ArgumentException ex)
            {
                //Puedo usar ex.Message para mostrar el error
            }


            List<Comentario> losComentarios = comentarioNegocio.TodosLosComentarios(id);
            lstComentarios.DataSource = losComentarios;
            lstComentarios.DataBind();
        }
    }
}