using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Saludador
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            //if(!IsPostBack)
            {
                txtNombrePersona.Text = "Usuario";
            }
            
        }

        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            if (txtNombrePersona.Text != "")
            {
                string nombre = txtNombrePersona.Text;
                lblSaludo.Visible = true;
                salto.Visible = true;
                lblSaludo.Text = $"Hola {nombre}";
                txtNombrePersona.Text = "";
            }
            else
            {
                lblSaludo.Visible = false;
                salto.Visible = false;
                lblError.Text = "Debe ingresar un nombre";
            }
            
        }

        protected void btnResetear_Click(object sender, EventArgs e)
        {
            txtNombrePersona.Text = "";
        }
    }
}