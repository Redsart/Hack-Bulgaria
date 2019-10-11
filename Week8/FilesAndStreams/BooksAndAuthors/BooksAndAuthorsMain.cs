using System;
using System.Collections.Generic;

namespace BooksAndAuthors
{
    class BooksAndAuthorsMain
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>{new Book("Bqloto konche", new DateTime(1999, 4, 23)),
                                            new Book("Trevata mirishe", new DateTime(2003, 7, 12)) };

            var author = new Author("Ivan Skobelev", "ivanpishe@yahoo.com", books);

            string fileName = "MyFile.bin";
            author.Serialize(fileName, author);
            author.Deserialize(fileName);
        }
    }
}
