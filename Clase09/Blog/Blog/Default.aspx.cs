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
    public partial class Default : System.Web.UI.Page
    {
        private readonly PostNegocio postNegocio;

        public Default()
        {
            postNegocio = new PostNegocio();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<Post> listado = postNegocio.ObtenerTodasLosPost();
                lstPosteos.DataSource = listado;
                lstPosteos.DataBind();
            }
        }
    }
}