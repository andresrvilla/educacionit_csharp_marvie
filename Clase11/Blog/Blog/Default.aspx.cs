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
                try
                {
                    List<PostEntidad> listado = postNegocio.ObtenerTodasLosPost();
                    lstPosteos.DataSource = listado;
                    lstPosteos.DataBind();
                }
                catch(CapaDeDatosException)
                {
                    lblError.Text = "Ha ocurrido un error accediendo a los datos";
                    pnlError.Visible = true;
                }
                finally
                {
                    // Este codigo se ejecuta SIEMPRE, haya o no error
                }
                
            }
        }
    }
}