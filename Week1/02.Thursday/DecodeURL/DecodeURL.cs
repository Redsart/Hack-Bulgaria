using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeURL
{
    class DecodeURL
    {
        static void Main(string[] args)
        {
            string input = "'kitten%20pic.jpg' Output 'kitten pic.jpg'";
            DecodeUrl(input);
        }

        private static void DecodeUrl(string input)
        {
            for(int i=0; i < input.Length; i++)
            {
                switch (input)
                {
                    case "%20":
                        input.Replace("%20"," ");
                        break;
                    case "%3A":
                        input.Replace("%3A",":");
                        break;
                    case "%3D":
                        input.Replace("%3D", "?");
                        break;
                    case "%2F":
                        input.Replace("%3F", "/");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(input);
        }
    }
}
