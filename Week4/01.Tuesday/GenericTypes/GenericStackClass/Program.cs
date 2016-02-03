using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 1, 3, 3, 5, 9 };
            LinkedList<int> list = new LinkedList<int>(integers);
            Stack<int> obj = new Stack<int>(list);
            Console.WriteLine(obj.Contains(5));
            Dequeue<int> newObj = new Dequeue<int>(list);
            Console.WriteLine(obj.Contains(7));
        }
    }
}
