using Blog.Contadores;
using Entidades;
using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog
{
    public partial class VerPost : System.Web.UI.Page
    {
        private PostNegocio postNegocio = new PostNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            string parametroId = Request.QueryString["id"];
            int id = Convert.ToInt32(parametroId);

            Post elPost = postNegocio.ObtenerPost(id);
            lblTitulo.Text = elPost.Titulo;
            lblContenido.Text = elPost.Cuerpo;
        }
    }
}