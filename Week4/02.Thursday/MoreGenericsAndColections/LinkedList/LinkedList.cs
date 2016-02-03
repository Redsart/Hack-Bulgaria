using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T>
    {
        private Node head;

        private class Node
        {
            public T Value { get; set; }

            public Node Next { get; set; }
        }

        public void Add(T value)
        {
            var node = new Node();
            node.Value = value;

            if (this.head==null)
            {
                this.head = node;
            }

            else
            {
                var current = this.head;
                while (current.Next!=null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }
        }

        public void InsertAfter(T key, T value)
        {
            var node = new Node();
            node.Value = value;

            var currentNode = this.head;
            while (!currentNode.Next.Value.Equals(key))
            {
                if (currentNode.Next==null)
                {
                    throw new ArgumentException(String.Format("Not found key with value {0}",key));
                }
            }
            node.Next = currentNode.Next;
            currentNode.Next = node;
        }

        public void InsertBefore(T key, T value)
        {
            var node = new Node();
            node.Value = value;

            var currentNode = this.head;
            if (currentNode.Next.Value.Equals(key))
            {
                node.Next = this.head;
                this.head = node;
            }
            else
            {
                while (!currentNode.Next.Value.Equals(key))
                {
                    if (currentNode.Next.Next==null)
                    {
                        throw new ArgumentException(String.Format("Not found key with value {0}", key));
                    }
                    currentNode = currentNode.Next;
                }
                node.Next = currentNode.Next;
                currentNode.Next = node;
                currentNode = node;
            }
        }

        public int Count()
        {
            var currentNode = this.head;
            var counter = 0;
            while (currentNode != null)
            {
                counter++;
                currentNode = currentNode.Next;
            }
            return counter;
        }

        public void InsertAt(int index, T value)
        {
            var node = new Node();
            node.Value = value;

            var counter = 0;
            var currentNode = this.head;
            if (index > this.Count() || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (index==0)
            {
                node.Next = this.head;
                this.head = node;
            }

            else
            {
                while (counter < index - 1)
                {
                    currentNode = currentNode.Next;
                    counter++;
                }
                var next = currentNode.Next;
                node.Next = next;
                currentNode.Next = node;
            }
        }

        public void Remove(T value)
        {
            var currentNode = this.head;
            while (!currentNode.Next.Value.Equals(value))
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = currentNode.Next.Next;
        }

        public void RemoveAt(int index)
        {
            var currentNode = this.head;
            var counter = 0;
            if (index >= this.Count() || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (index==0)
            {
                this.head = this.head.Next;
            }

            else
            {
                while (counter < index - 1)
                {
                    currentNode = currentNode.Next;
                    counter++;
                }
                currentNode.Next = currentNode.Next.Next;
            }
        }

        public void Clear()
        {
            for (int i = this.Count() - 1; i >= 0; i--)
            {
                RemoveAt(i);
            }
        }

        public T this[int index]
        {
            get
            {
                var currentNode = this.head;
                var counter = 0;
                while (counter <= index - 1)
                {
                    currentNode = currentNode.Next;
                    counter++;
                }
                return currentNode.Value;
            }
            set
            {
                var currentNode = this.head;
                var counter = 0;
                while (counter <= index-1)
                {
                    currentNode = currentNode.Next;
                    counter++;
                }
                currentNode.Value = value;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = this.head;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
