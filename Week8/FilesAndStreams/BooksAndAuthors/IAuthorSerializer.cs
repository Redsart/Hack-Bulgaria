using System;

namespace BooksAndAuthors
{
    interface IAuthorSerializer
    {
        void Serialize(string fileName, Author author);
        void Deserialize(string fileName);
    }
}
