using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class CategoriaDatos
    {
        private string cadenaDeConexion;

        public CategoriaDatos()
        {
            cadenaDeConexion = ConfigurationManager.ConnectionStrings["BlogDatabase"].ConnectionString;
        }

        public List<CategoriaEntidad> TodasLasCategorias()
        {
            List<CategoriaEntidad> resultado = new List<CategoriaEntidad>();
            using(SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT Id, Nombre FROM Categorias", conexion);
                conexion.Open();
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CategoriaEntidad categoria = new CategoriaEntidad()
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };
                        resultado.Add(categoria);
                    }
                }
            }
            return resultado;
        }

        public List<CategoriaEntidad> TodasLasCategoriasStoredProcedure()
        {
            List<CategoriaEntidad> resultado = new List<CategoriaEntidad>();
            using(SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                SqlCommand comando = new SqlCommand("SP_Categorias", conexion);
                comando.CommandType = CommandType.StoredProcedure;

                // Estos parametros son simplemente para poder ver como se configuran
                // No afectan en nada el resultado del Stored Procedure
                // Porque no se los usa en la consulta
                SqlParameter parametroNumerico = new SqlParameter("@ParametroNumerico", 100);
                comando.Parameters.Add(parametroNumerico);

                comando.Parameters.AddWithValue("@ParametroTexto", "Cualquier cosa");
                conexion.Open();
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CategoriaEntidad categoria = new CategoriaEntidad()
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };
                        resultado.Add(categoria);
                    }
                }

            }

            return resultado;
        }

        public CategoriaEntidad ObtenerCategoria(int id)
        {
            CategoriaEntidad resultado = null;

            using(SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                SqlCommand comando = new SqlCommand($"SELECT Id, Nombre FROM Categorias Where Id={id}", conexion);
                conexion.Open();
                using(SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resultado = new CategoriaEntidad()
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };
                    }
                }
            }

            return resultado;
        }

        public void InsertarCategoria(CategoriaEntidad categoria)
        {
            using(SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                SqlCommand comando = new SqlCommand($"INSERT INTO Categorias (Nombre) VALUES ('{categoria.Nombre}')", conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void ActualizarCategoria(CategoriaEntidad categoria)
        {
            using(SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                SqlCommand comando = new SqlCommand($"UPDATE Categorias SET Nombre = '{categoria.Nombre}' WHERE Id = {categoria.Id}", conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }

        public void BorrarCategoria(CategoriaEntidad categoria)
        {
            using(SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                SqlCommand comando = new SqlCommand($"DELETE FROM Categorias WHERE Id={categoria.Id}",conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}
