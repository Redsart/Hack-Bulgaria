using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class NotifyCollectionApp
    {
        static void Main(string[] args)
        {
            NotifyCollection collection=new NotifyCollection();
            collection.CollectionChanged += OnCollectionChange;
            collection.Add(14);
            collection.Add(24);
            collection.Add(3);
            collection.Clear();
            collection.Add(15);
            collection[0] = 25;
        }

        private static void OnCollectionChange(object sender,NotifyArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
