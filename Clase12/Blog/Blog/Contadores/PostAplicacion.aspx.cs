using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Contadores
{
    public partial class PostAplicacion : System.Web.UI.Page
    {
        private int contador = 0;

        private const string CLAVE_APLICACION = "Contador";

        protected void Page_Load(object sender, EventArgs e)
        {
            // Esto puedo comentarlo porque me aseguré de que existe la clave "Contador" en las variables de aplicacion en el global.asax
            /*if (Application[CLAVE_APLICACION] == null)
            {
                Application[CLAVE_APLICACION] = 0;
            }
            else
            {*/
                contador = (int)Application[CLAVE_APLICACION];
                lblContador.Text = contador.ToString();
            /*}*/
        }

        protected void btnContar_Click(object sender, EventArgs e)
        {
            contador++;
            Application[CLAVE_APLICACION] = contador;
            lblContador.Text = contador.ToString();
        }
    }
}