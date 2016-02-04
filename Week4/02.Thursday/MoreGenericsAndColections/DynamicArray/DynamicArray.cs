using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynamicArray<T> : IEnumerable
    {
        private int size;
        private T[] array;

        public DynamicArray()
        {
            this.size = 10;
            this.array = new T[this.size];
        }

        public DynamicArray(int size)
        {
            this.size = size;
            this.array = new T[this.size];
        }

        public int Capacity
        {
            get
            {
                return this.size;
            }
        }

        public int Count
        {
            get
            {
                int counter = 0;
                int forbidden = 0;
                foreach (var item in this.array)
                {
                    if (item==null || forbidden.Equals(item))
                    {
                        break;
                    }
                    counter++;
                }
                return counter;
            }
        }

        public bool Cointains(T value)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.array[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.array[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Add(T value)
        {
            if (this.Count > this.Capacity - 2)
            {
                if (this.size < 2048)
                {
                    this.size *= 2;
                }
                else
                {
                    this.size += 256;
                }
            }

            var array = new T[this.size];
            for (int i = 0; i < this.Count; i++)
            {
                array[i] = this.array[i];
            }
            array[this.Count] = value;
            this.array = array;
        }

        public void InsertAt(int index, T value)
        {
            if (index > this.Count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            var array = this.array.ToList();
            array.Insert(index, value);
            this.array = array.ToArray();
        }

        public void Remove(T value)
        {
            var array = this.array.ToList();
            array.Remove(value);
            this.array = array.ToArray();

            if (this.Count < this.Capacity /3)
            {
                this.size /= 2;
                var arr = new T[this.size];
                for (int i = 0; i < this.Count; i++)
                {
                    arr[i] = this.array[i];
                }
                this.array = arr;
            }
        }

        public void RemoveAt(int index)
        {
            var array = this.array.ToList();
            for (int i = 0; i < this.Count; i++)
            {
                if (i == index)
                {
                    array.Remove(array[i]);
                }
            }
            this.array.ToArray();

            if (this.Count < this.Capacity / 3)
            {
                this.size /= 2;
                var arr = new T[this.size];
                for (int i = 0; i < this.Count; i++)
                {
                    arr[i] = this.array[i];
                }
                this.array = arr;
            }
        }

        public void Clear()
        {
            var array = this.array.ToList();
            array.Clear();
            this.array = array.ToArray();
        }

        public T this[int index]
        {
            get
            {
                if (index > this.Count-1)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.array[index];
            }
            set
            {
                if (index > this.Count-1)
                {
                    throw new IndexOutOfRangeException();
                }
                this.array[index] = value;
            }
        }

        public T[] ToArray()
        {
            var array = new T[this.Count];
            for (int i = 0; i < this.Count; i++)
            {
                array[i] = this.array[i];
            }
            return array;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.array[i];
            }
        }
    }
}
