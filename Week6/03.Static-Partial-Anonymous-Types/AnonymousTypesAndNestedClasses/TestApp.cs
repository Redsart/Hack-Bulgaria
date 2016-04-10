using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypesAndNestedClasses
{
    class TestApp
    {
        static void Main(string[] args)
        {
            var books = new List<Book>();
            books.Add(new Book() { Id = 2, Name = "Introduction to programming" });
            books.Add(new Book() { Id = 5, Name = "Lord of the rings" });
            books.Add(new Book() { Id = 14, Name = "Captain Nemo" });
            books.Add(new Book() { Id = 8, Name = "Alice in wonderland" });
            books.Add(new Book() { Id = 3, Name = "Spartak" });

            var magazines = new List<Magazine>();
            magazines.Add(new Magazine() { ISBN = 4, Title = "Optimetrix" });
            magazines.Add(new Magazine() { ISBN = 7, Title = "Cars" });
            magazines.Add(new Magazine() { ISBN = 3, Title = "Shopevery" });
            magazines.Add(new Magazine() { ISBN = 9, Title = "Greeny" });
            magazines.Add(new Magazine() { ISBN = 11, Title = "Youre home" });

            var list = MagazineAndBookSorter.Sort(books, magazines);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
