using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Administracion.Categorias
{
    public partial class Default : System.Web.UI.Page
    {
        private CategoriaNegocio categoriasNegocio = new CategoriaNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            lstCategorias.DataSource = categoriasNegocio.ObtenerTodasLasCategorias();
            lstCategorias.DataBind();
        }
    }
}