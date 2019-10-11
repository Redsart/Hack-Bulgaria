using System;
using System.IO;

namespace FileNameHistogram
{
    class FileNameHistogramMain
    {
        static void Main(string[] args)
        {
            string fileName = "D:\\Movies\\Starry.Eyes.2014.BRRip.x264-WAR";
            TraverseDir(fileName);
        }

        public static void TraverseDir(DirectoryInfo dir, string spaces)
        {
            Console.WriteLine(spaces + dir.FullName);

            if (dir.Root == null)
            {
                Console.WriteLine("No files!");
            }
            DirectoryInfo[] children = dir.GetDirectories();

            foreach (FileInfo file in dir.GetFiles())
            {
                Console.WriteLine(file.ToString());
            }
            foreach (var child in children)
            {
                TraverseDir(child, spaces + "    ");
            }
        }

        public static void TraverseDir(string dirPath)
        {
            TraverseDir(new DirectoryInfo(dirPath), "   ");
        }
    }
}
