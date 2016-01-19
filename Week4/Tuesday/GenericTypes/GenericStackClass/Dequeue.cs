using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackClass
{
    public class Dequeue<T>
    {
        private LinkedList<T> newList=new LinkedList<T>();

        public Dequeue(LinkedList<T> inputList)
        {
            this.newList = inputList;
        }

        public void Clear()
        {
            newList.Clear();
        }

        public bool Contains(T item)
        {
            if (newList.Contains(item))
            {
                return true;
            }
            return false;
        }

        public T RemoveFromFront()
        {
            T first = newList.First();
            newList.RemoveFirst();
            return first;
        }

        public T RemoveFromEnd()
        {
            T last = newList.Last();
            newList.RemoveLast();
            return last;
        }

        public void AddFront(T item)
        {
            newList.AddFirst(item);
        }

        public void AddLast(T item)
        {
            newList.AddLast(item);
        }

        public T PeekFromFront()
        {
            return newList.First();
        }

        public T PeekFromEnd()
        {
            return newList.Last();
        }
    }
}
