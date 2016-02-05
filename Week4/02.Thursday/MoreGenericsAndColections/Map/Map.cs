using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicArray;

namespace Map
{
    public class Map<T, U>
    {
        private DynamicArray<T> keys;
        private DynamicArray<U> values;

        public Map()
        {
            this.keys=new DynamicArray<T>();
            this.values=new DynamicArray<U>();
        }

        public void Add(T key, U value)
        {
            if (key.Equals(0))
            {
                throw new Exception("The key cannot be 0");
            }
            if (this.keys.Cointains(key))
            {
                throw new ArgumentException("This key already exists");
            }
            this.keys.Add(key);
            this.values.Add(value);
        }

        public bool CointainsKey(T key)
        {
            return this.keys.Cointains(key);
        }

        public bool ContainsValue(U value)
        {
            return this.values.Cointains(value);
        }

        public void Remove(T key)
        {
            if (this.keys.Cointains(key))
            {
                var value = this[key];
                this.keys.Remove(key);
                this.values.Remove(value);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }

        public void Clear()
        {
            this.keys.Clear();
            this.values.Clear();
        }

        public U this[T key]
        {
            get
            {
                if (this.keys.Cointains(key))
                {
                    var index = this.keys.IndexOf(key);

                    return this.values[index];
                }
                throw new KeyNotFoundException();
            }
            set
            {
                if (key.Equals(0))
                {
                    throw new Exception("The key cannot be 0");
                }
                if (this.keys.Cointains(key))
                {
                    var index = keys.IndexOf(key);
                    this.values[index] = value;
                }
                else
                {
                    this.keys.Add(key);
                    this.values.Add(value);
                }
            }
        }
    }
}
