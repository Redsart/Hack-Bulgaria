using System;
using System.IO;

namespace ToUpper
{
    class ToUpperMain
    {
        static void Main(string[] args)
        {
            string fileName = "../../someText.txt";

            TextFileToUpperCase(fileName);
            Console.WriteLine("The file content saves succesfuly!");
        }

        //this methos changes all charachter's to upper case and save them in another text file
        static void TextFileToUpperCase(string fileName)
        {
            using (StreamWriter writer = new StreamWriter("../../result.txt"))
            {
                using (StreamReader reader=new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(line.ToUpper());
                    }
                }
            }
        }
    }
}
