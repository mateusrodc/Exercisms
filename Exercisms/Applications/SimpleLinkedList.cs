using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercisms 
{
    public class SimpleLinkedList<T> : IEnumerable<T>
    {
        private int count = 0;
        private SimpleLinkedList<T>? next;
        private bool isInitialized = false;
        private T? data;

        public SimpleLinkedList() { }

        public SimpleLinkedList(T data)
        {
            this.Push(data);
        }

        public SimpleLinkedList(T[] values)
        {
            foreach (var value in values)
            {
                this.Push(value);
            }
        }

        public int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public void Push(T value)
        {
            if (data.Equals(default(T)) && !this.isInitialized)
            {
                data = value;
                this.isInitialized = true;
            }
            else if (next == null)
            {
                next = new SimpleLinkedList<T>();
                next.Push(this.data);
                this.data = value;
            }
            else
            {
                next.Push(this.data);
                this.data = value;
            }
            this.Count++;
        }
        public T Pop()
        {
            T result = this.data;
            if (next != null)
            {
                this.data = next.data;
                this.next = next.next;
                this.count--;
            }
            else
            {
                this.data = default(T);
                isInitialized = false;
                this.count--;
            }
            return result;
        }
        public IEnumerator<T> GetEnumerator()
        {
            yield return data;
            if (this.next != null)
            {
                foreach (var val in next)
                {
                    yield return val;
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}



