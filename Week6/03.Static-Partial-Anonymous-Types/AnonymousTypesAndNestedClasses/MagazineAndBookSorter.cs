using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypesAndNestedClasses
{
    public static class MagazineAndBookSorter
    {
        public class Edition
        {
            public string EditionName { get; set; }
            public int Order { get; set; }
        }

        public static List<string> Sort(List<Book> books, List<Magazine> magazines)
        {
            var edition = new List<Edition>();
            foreach (var book in books)
            {
                var editionItem = new Edition() { EditionName = book.Name, Order = book.Id };
                edition.Add(editionItem);
            }

            foreach (var magazine in magazines)
            {
                var editionItem = new Edition() { EditionName = magazine.Title, Order = magazine.ISBN };
                edition.Add(editionItem);
            }

            var stringList = new List<string>();
            var orderEditions = edition.OrderBy(x => x.EditionName).ToList();

            while (true)
            {
                if (orderEditions.Count < 1)
                {
                    break;
                }

                var tempEditionList = new List<Edition>();
                var currentItem = orderEditions.FirstOrDefault();
                for (int i = 0; i < orderEditions.Count; i++)
                {
                    if (orderEditions[i].EditionName == currentItem.EditionName)
                    {
                        tempEditionList.Add(orderEditions[i]);
                        orderEditions.Remove(orderEditions[i]);
                        i--;
                    }
                }
                var orderedTemp = tempEditionList.OrderBy(x => x.Order).ToList();
                foreach (var item in orderedTemp)
                {
                    stringList.Add(String.Format("{0} - {1}", item.EditionName, item.Order));
                }
                orderedTemp.Clear();
            }
            return stringList;
        }

        
    }
}
