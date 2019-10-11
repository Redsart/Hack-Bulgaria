using System;
using System.IO;

namespace DirectoryCopy
{
    class DirectoryPathMain
    {
        static void Main(string[] args)
        {
            string source = "D:\\wallpapers\\animal's";
            string destionation = "D:\\copy";

            try
            {
                Copy(source, destionation);
            }
            catch (IOException copyError)
            {
                Console.WriteLine(copyError.Message);
            }
        }

        static void CopyAll(DirectoryInfo source, DirectoryInfo destination)
        {
            Directory.CreateDirectory(destination.FullName);

            foreach (var file in source.GetFiles())
            {
                Console.WriteLine("Copiyng {0} to {1}",file.Name,destination.FullName);
                file.CopyTo(Path.Combine(destination.FullName, file.Name),true);     
            }

            foreach (var subDirectory in source.GetDirectories())
            {
                DirectoryInfo nextDestinationSubDir = destination.CreateSubdirectory(subDirectory.FullName);
                CopyAll(subDirectory, nextDestinationSubDir);
            }
        }

        public static void Copy(string source, string destionation)
        {
            DirectoryInfo dirSource = new DirectoryInfo(source);
            DirectoryInfo dirDestionation = new DirectoryInfo(destionation);

            CopyAll(dirSource, dirDestionation);
        }
    }
}
