using Entidades;
using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilidades;

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

                //Pruebo mi lista generica
                GenericList<int> miLista = new GenericList<int>();

                miLista.Add(100);
                miLista.Add(4000);
                miLista.Add(50);
                miLista.Add(10);
                miLista.Add(600);

                foreach(int actual in miLista)
                {

                }

                double resultadoDivision = Matematicas.dividir(numeroDos: 10.3, numeroUno: 90.5);

                Matematicas.calcular(100, numeroTres: 100, numeroDos: 300);

                Matematicas.sumar(100, 50);

                Matematicas.sumar(100, 50, 15);

                var persona = new { Apellido = "Villa", Nombre = "Andres" };

                Console.WriteLine($"Apellido: {persona.Apellido}, Nombre: {persona.Nombre} ");

                // No puedo modificar las Propiedades del tipo de dato que genera el objeto anonimo
                //persona.Apellido = "VILLAR";
            }
        }
    }
}