using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.MasterPages
{
    public partial class Sitio : System.Web.UI.MasterPage
    {
        private const string NOMBRE_COOKIE = "UltimaVezVisto";
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombreBlog.Text = ConfigurationManager.AppSettings["NombreBlog"];

            string mensajeUltimoIngreso = "";

            // Para leer las cookies uso REQUEST!!!
            if (Request.Cookies[NOMBRE_COOKIE] == null || String.IsNullOrWhiteSpace(Request.Cookies[NOMBRE_COOKIE].Value) == true)
            {
                mensajeUltimoIngreso = "Ud. Ingresa por primera vez";
            }
            else
            {
                mensajeUltimoIngreso = Request.Cookies[NOMBRE_COOKIE].Value;
            }

            lblUltimaVez.Text = mensajeUltimoIngreso;
            // Para escribir las cookies uso RESPONSE!!!
            Response.Cookies[NOMBRE_COOKIE].Value = DateTime.Now.ToString();
            Response.Cookies[NOMBRE_COOKIE].Expires = DateTime.Now.AddDays(1);
        }
    }
}