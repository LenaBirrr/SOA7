using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA7
{
    public class Node<T>
    {
        public Node<T>? next { get; set; }
        public T? data { get; set; }

        public Node(T data)
        {
            this.data = data;
        }
    }

    public class Stack<T>
    {

        public Node<T>? Top;

        public T Pop()
        {
            if (!IsEmpty())
            {
                T n = Top.data;
                Top = Top.next;
                return default;
            }
            else throw new StackException("Nothing to pop");
           
        }

        public void Push(T i)
        {
            Node<T> n = new Node<T>(i);
            n.next = Top;
            Top = n;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }
    }
}
