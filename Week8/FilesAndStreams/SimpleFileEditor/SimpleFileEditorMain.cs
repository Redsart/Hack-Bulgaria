using System;

namespace SimpleFileEditor
{
    class SimpleFileEditorMain
    {
        static void Main(string[] args)
        {
            string fileName="texta.txt";
            var fileEditor = new FileEditor(fileName);
            fileEditor.List();
            Console.WriteLine(fileEditor.LineCount());

            Console.WriteLine("Hello to File Editor! Here is info about the comands you can use." +"\nlist - lists the contents of the file \nclear - clears the contents of the file " +
                "\nappendline - appends a new line to the file \nappend <text> - appends the text to the file \nlinecount - outputs the numbers of lines in the file");

            //if you try to write new data to a document who does'nt exist, after entering the new data the document will be created
            Console.Write("Enter youre choice: ");
            string choice = Console.ReadLine();

                switch (choice)
                {
                    case "list":
                        fileEditor.List();
                        break;
                    case "clear":
                        fileEditor.Clear();
                        break;
                    case "appendline":
                        fileEditor.AppendLine();
                        break;
                    case "append <text>":
                        fileEditor.AppendText();
                        break;
                    case "linecount":
                        fileEditor.LineCount();
                        break;
                    default:
                        Console.WriteLine("Incorect choice!");
                        break;
                } 
        }
    }
}
