using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class PostDatos
    {
        private string cadenaDeConexion = "Server=.;Database=Educacionit.blog;Trusted_Connection=True;";
        public List<Post> ObtenerTodosLosPost()
        {
            List<Post> resultado = new List<Post>();

            using (SqlConnection conexion = new SqlConnection(cadenaDeConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM Post", conexion);

                conexion.Open();
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Post elPost = new Post();
                        //Lleno los datos desde la base de datos usando el reader
                        elPost.Id = Convert.ToInt32(reader[0]);
                        elPost.Titulo = reader["Titulo"].ToString();

                        elPost.Resumen = reader.GetString(2);
                        elPost.Cuerpo = reader.GetString(3);

                        resultado.Add(elPost);
                    }
                }
            }

            return resultado;
        }

        public Post ObtenerPost(int id)
        {
            Post resultado = null;

            using (SqlConnection connection = new SqlConnection(cadenaDeConexion))
            {
                SqlCommand comando = new SqlCommand($"SELECT * FROM Post WHERE ID = {id}", connection);

                connection.Open();

                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resultado = new Post();
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
        public void Insertar(Post unPost)
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
