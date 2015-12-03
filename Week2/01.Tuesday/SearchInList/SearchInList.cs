using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInList
{
    class SearchInList
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "audi", "bmw", "opel", "mercedes" };
            string searched = "mercedes";
            int? foundIndex;

            bool isFound = TryFindSubstring(list, searched, out foundIndex);
            Console.WriteLine("Word '{0}' is found at possition {1}",searched,foundIndex);
        }

        private static bool TryFindSubstring(List<string> list, string searched, out int? foundIndex)
        {
            for (int i = 0; i < list.Count(); i++ )
            {
                if (list[i]==searched)
                {
                    foundIndex = i;
                    return true;
                }
            }
            foundIndex = null;
            return false;
        }
    }
}
