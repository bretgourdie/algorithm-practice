using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_practice.Common
{
    public class Node<T>
    {
        public T Data { get; protected set; }
        Node<T> next { get; set; }

        public Node(T data)
        {
            this.Data = data;
        }
    }
}
