using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEachWordInString
{
    class ReverseEachWordInString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            ReverseEveryWord(sentence);
        }

        private static void ReverseEveryWord(string sentence)
        {
            char sign = sentence[sentence.Length - 1];
            sentence = sentence.Remove(sentence.Length - 1);
            string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);
            Console.WriteLine("Result: {0}{1}\n", string.Join(" ", words), sign);
        }
    }
}
