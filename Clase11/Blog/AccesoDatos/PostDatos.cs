using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class PostDatos
    {
        private string cadenaDeConexion;

        public PostDatos()
        {
            cadenaDeConexion = ConfigurationManager.ConnectionStrings["BlogDatabase"].ConnectionString;
        }

        public List<PostEntidad> ObtenerTodosLosPost()
        {
            List<PostEntidad> resultado = new List<PostEntidad>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
                {
                    SqlCommand comando = new SqlCommand("SELECT * FROM Post", conexion);

                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PostEntidad elPost = new PostEntidad();
                            //Lleno los datos desde la base de datos usando el reader
                            elPost.Id = Convert.ToInt32(reader[0]);
                            elPost.Titulo = reader["Titulo"].ToString();

                            elPost.Resumen = reader.GetString(2);
                            elPost.Cuerpo = reader.GetString(3);

                            resultado.Add(elPost);
                        }
                    }
                }
            }
            catch (SqlException)
            {
                throw new CapaDeDatosException();
            }         

            return resultado;
        }

        public PostEntidad ObtenerPost(int id)
        {
            PostEntidad resultado = null;

            using (SqlConnection connection = new SqlConnection(cadenaDeConexion))
            {
                SqlCommand comando = new SqlCommand($"SELECT * FROM Post WHERE ID = {id}", connection);

                connection.Open();

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resultado = new PostEntidad();
                        resultado.Id = Convert.ToInt32(reader[0]);
                        resultado.Titulo = reader["Titulo"].ToString();

                        resultado.Resumen = reader.GetString(2);
                        resultado.Cuerpo = reader.GetString(3);
                    }
                }

            }

            return resultado;
        }

        //Con el mismo "formato" puedo hacer insert, update y delete
        public void Insertar(PostEntidad unPost)
        {
            using (SqlConnection connection = new SqlConnection(cadenaDeConexion))
            {
                string consulta = $"INSERT INTO [Post] ([Titulo] ,[Resumen] ,[Cuerpo]) VALUES ('{unPost.Titulo}' ,'{unPost.Resumen}' ,'{unPost.Cuerpo}')";
                SqlCommand comando = new SqlCommand(consulta, connection);
                connection.Open();
                comando.ExecuteNonQuery();
            }
        }
    }
}
