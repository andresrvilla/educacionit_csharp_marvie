using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class PostDatos
    {
        public List<Post> ObtenerTodosLosPost()
        {
            List<Post> resultado = new List<Post>()
            {
                new Post() { Id=1,Titulo="Mi primer post", Resumen="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam sollicitudin eu augue non maximus. In quam est, auctor aliquet lectus id, sodales eleifend tellus. Proin egestas justo eu porta blandit. Donec imperdiet lobortis egestas. Donec rutrum mauris ac fermentum viverra. Mauris purus elit, ultricies nec aliquam tincidunt, tristique eget ipsum. Donec ut nisi sed magna condimentum aliquet. Donec iaculis in orci a dictum. Nunc consectetur urna faucibus quam fermentum scelerisque. Quisque ut tempus nisl, sed viverra augue. Quisque aliquam purus eu risus vestibulum, sed vestibulum odio rhoncus. Nullam elementum rhoncus orci, id ultrices massa fringilla quis. Quisque et tincidunt lorem.", Autor="EducacionIT"},
                new Post() { Id=2,Titulo="Mi segundo post", Resumen="Donec cursus tristique eros, finibus interdum nibh blandit vel. Aenean elementum faucibus ullamcorper. Nullam porttitor, nunc vitae aliquet hendrerit, justo mi cursus eros, vel posuere leo lorem vitae tortor. Phasellus eleifend ligula ut elit imperdiet condimentum. Cras semper ipsum eget nisl aliquam maximus. Integer id elit eu dui congue eleifend at et orci. Ut in risus nunc. Phasellus eget eros in dolor convallis porttitor.", Autor="EducacionIT"},
                new Post() { Id=3,Titulo="Mi tercer post", Resumen="Vivamus orci orci, ultricies eget convallis eu, accumsan id dui. Suspendisse vestibulum sit amet metus eget auctor. Phasellus cursus scelerisque tristique. Curabitur vitae odio ut sem dictum placerat at id orci. Fusce molestie, diam eu maximus cursus, urna lacus fermentum nunc, ut scelerisque arcu ante ut elit. Phasellus tincidunt viverra sapien, at efficitur est cursus vel. Praesent iaculis ipsum quis mauris faucibus tempus. Nulla tempus maximus varius. Integer leo augue, porttitor non risus et, posuere porttitor justo. Nullam elementum venenatis felis id fringilla. In vehicula, est egestas suscipit rhoncus, enim odio fermentum orci, nec mattis mauris justo sed massa. Nulla auctor diam vel interdum faucibus. Integer eu lacus eget eros suscipit tincidunt et eu augue. Etiam eget erat quam. Duis rhoncus mauris porta tellus gravida imperdiet vitae iaculis odio.", Autor="EducacionIT"}
            };

            return resultado;
        }
    }
}
