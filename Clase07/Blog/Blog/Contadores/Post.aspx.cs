using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Contadores
{
    public partial class Post : System.Web.UI.Page
    {
        private int contador = 0;

        private const string CLAVE_VIEW_STATE = "Contador";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                ViewState[CLAVE_VIEW_STATE] = 0;
            }
            else
            {
                contador = (int)ViewState[CLAVE_VIEW_STATE];
            }

            
        }

        protected void btnContar_Click(object sender, EventArgs e)
        {
            contador++;
            ViewState[CLAVE_VIEW_STATE] = contador;
            lblContador.Text = contador.ToString();
        }
    }
}