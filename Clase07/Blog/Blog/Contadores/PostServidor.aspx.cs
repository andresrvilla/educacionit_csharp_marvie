using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Contadores
{
    public partial class PostServidor : System.Web.UI.Page
    {
        private int contador = 0;

        private const string CLAVE_SESSION = "Contador";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[CLAVE_SESSION] == null)
            {
                Session[CLAVE_SESSION] = 0;
            }
            else
            {
                contador = (int)Session[CLAVE_SESSION];
                lblContador.Text = contador.ToString();
            }
        }

        protected void btnContar_Click(object sender, EventArgs e)
        {
            contador++;
            Session[CLAVE_SESSION] = contador;
            lblContador.Text = contador.ToString();
        }
    }
}