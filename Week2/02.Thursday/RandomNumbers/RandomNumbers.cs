using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            string fileName = @"..\..\Output.txt";

            GenerateRandomMatrix(rows, columns, fileName);
        }

        private static void GenerateRandomMatrix(int rows, int columns, string fileName)
        {
            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();
            double number = rnd.NextDouble() * 1000;
            List<string> matrix = new List<string>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                        sb.Append(string.Format("{0,3:F2} ", number));
                        Thread.Sleep(150);
                }
                
                matrix.Add(sb.ToString());
                sb.Clear();
            }
            File.WriteAllLines(fileName, matrix);
        }
    }
}
