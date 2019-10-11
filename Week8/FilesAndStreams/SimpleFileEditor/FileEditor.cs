using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleFileEditor
{
    class FileEditor
    {
        static string filePath = "../../";
        string fileName;

        string FileName
        {
            get
            {
                return this.fileName;
            }
            set
            {
                this.fileName = value;
            }
        }

        public FileEditor(string fileName)
        {
            this.fileName = fileName;
        }

        public void List()
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath+this.fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File {0} Not Found!",this.fileName);
            }
            catch (IOException)
            {
                Console.WriteLine("Can't open this file!");
            }
        }

        public void Clear()
        {
            try
            {
                File.WriteAllText(filePath + this.fileName, string.Empty);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File {0} Not Found!", this.fileName);
            }
        }

        public void AppendLine()
        {
            try
            {
                using (var writer=File.AppendText(filePath+fileName))
                {
                    writer.WriteLine("\n");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File {0} Not Found!", this.fileName);
            }
            catch (IOException)
            {
                Console.WriteLine("Can't open this file!");
            }
        }

        public void AppendText()
        {
            try
            {
                using (var writer=File.AppendText(filePath+fileName))
                {
                    string line = Console.ReadLine();
                    writer.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File {0} Not Found!", this.fileName);
            }
            catch (IOException)
            {
                Console.WriteLine("Can't open this file!");
            }
        }

        public int LineCount()
        {
            int count = 0;
            try
            {
                using (StreamReader reader=new StreamReader(filePath+fileName))
                {
                    string line;
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        count++;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File {0} Not Found!", this.fileName);
            }
            catch (IOException)
            {
                Console.WriteLine("Can't open this file!");
            }

            return count;
        }
    }
}
