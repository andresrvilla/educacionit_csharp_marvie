using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class GenericList<T>
    {

        private class Node
        {
            public T Data { get; set; }

            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;

        public GenericList()
        {
            head = null;
        }

        public void Add(T data)
        {
            Node nuevo = new Node(data);
            nuevo.Next = head;
            head = nuevo;
        }

        public IEnumerator<T> GetEnumerator() {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
