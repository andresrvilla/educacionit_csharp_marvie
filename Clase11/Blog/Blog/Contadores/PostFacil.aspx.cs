using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Contadores
{
    public partial class PostFacil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContar_Click(object sender, EventArgs e)
        {
            int contador = Convert.ToInt32(lblContador.Text);
            contador++;
            lblContador.Text = contador.ToString();
        }
    }
}