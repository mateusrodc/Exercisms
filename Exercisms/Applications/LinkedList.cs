using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisms
{
    public class LinkedList<T>
    {
        private class Node
        {
            public T Value;
            public Node Next;
            public Node Prev;
            public Node()
            {
                Next = this;
                Prev = this;
            }
            public void Append(T value)
            {
                Next = Next.Prev = new Node
                {
                    Value = value,
                    Prev = this,
                    Next = this.Next
                };
            }
            public T Remove()
            {
                Prev.Next = Next;
                Next.Prev = Prev;
                return Value;
            }
        }

        Node item = new Node();
        public void Push(T value) => item.Prev.Append(value);
        public T Pop() => item.Prev.Remove();
        public void Unshift(T value) => item.Append(value);
        public T Shift() => item.Next.Remove();
    }
}


