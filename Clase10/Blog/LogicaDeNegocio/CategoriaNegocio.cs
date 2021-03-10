using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class CategoriaNegocio
    {
        private CategoriaDatos categoriaDatos = new CategoriaDatos();

         public List<Categoria> ObtenerTodasLasCategorias()
        {
            //return categoriaDatos.TodasLasCategorias();
            //Llamo al stored procedure para probarlo
            return categoriaDatos.TodasLasCategoriasStoredProcedure();
        }

        public Categoria ObtenerCategoria(int id)
        {
            return categoriaDatos.ObtenerCategoria(id);
        }

        public bool InsertarCategoria(Categoria categoria)
        {
            bool esValido = true;

            if(string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                esValido = false;
            }

            if (esValido == true)
            {
                categoriaDatos.InsertarCategoria(categoria);
            }

            return esValido;
        }

        public bool ActualizarCategoria(Categoria categoria)
        {
            bool esValido = true;

            if (string.IsNullOrWhiteSpace(categoria.Nombre))
            {
                esValido = false;
            }

            if (esValido == true)
            {
                categoriaDatos.ActualizarCategoria(categoria);
            }

            return esValido;
        }

        public void BorrarCategoria(Categoria categoria)
        {
            categoriaDatos.BorrarCategoria(categoria);
        }
    }
}
