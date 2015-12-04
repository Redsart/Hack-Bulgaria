using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryTraversal
{
    class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            string path = @"D:\Downloads";
            DirectoryInfo dir = new DirectoryInfo(path);
            Console.WriteLine(IterateDirectory(dir));
        }

        private static IEnumerable<string> IterateDirectory(DirectoryInfo dir)
        {
            DirectoryInfo[] topDirectories = dir.GetDirectories("*",SearchOption.TopDirectoryOnly);
            foreach (var item in topDirectories)
            {
                yield return String.Format("*", topDirectories);
                foreach (var file in topDirectories)
                {
                    
                }
            }
        }
    }
}
