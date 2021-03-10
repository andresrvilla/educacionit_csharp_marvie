using Entidades;
using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Blog.Administracion.Categorias
{
    public partial class Editar : System.Web.UI.Page
    {
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                Categoria categoria = categoriaNegocio.ObtenerCategoria(id);
                if (categoria == null)
                {
                    pnlError.Visible = true;
                }
                else
                {
                    pnlFormulario.Visible = true;
                    txtNombre.Text = categoria.Nombre;
                }
            }
        }

        protected void btnAccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administracion/Categorias/");
            // Hay otra forma de "moverse" a otra pagina
            //Server.Transfer("~/Administracion/Categorias/Default.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria()
            {
                Id = Convert.ToInt32(Request.QueryString["id"]),
                Nombre = txtNombre.Text
            };

            categoriaNegocio.ActualizarCategoria(categoria);
            Response.Redirect("~/Administracion/Categorias/");
        }
    }
}