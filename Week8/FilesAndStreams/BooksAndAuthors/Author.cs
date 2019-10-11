using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BooksAndAuthors
{
    [Serializable()]
    class Author : ISerializable,IAuthorSerializer
    {
        string name;
        string email;
        IEnumerable<Book> books;
        IFormatter formatter = new BinaryFormatter();

        string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }

        string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.email = value;
                }
            }
        }

        public IEnumerable<Book> Books
        {
            get
            {
                return this.books;
            }
            set
            {
                this.books = value;
            }
        }

        public Author(string name="No name",string email="No email",IEnumerable<Book> books=null)
        {
            this.name = name;
            this.email = email;
            this.books = books;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Name: {0}, email: {1} \nBooks:", this.name, this.email));
            foreach (var book in this.books)
            {
                sb.Append("\n" + book);
            }
            return sb.ToString();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name);
            info.AddValue("Email", Email);
            info.AddValue("Books", Books);
        }

        public void Serialize(string fileName, Author author)
        {
            using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, author);
            }
        }

        public void Deserialize(string fileName)
        {
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Author author = (Author)formatter.Deserialize(stream);
            }
        }

        public Author(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Email = (string)info.GetValue("Email", typeof(string));
            Books = (IEnumerable<Book>)info.GetValue("Books", typeof(IEnumerable<Book>));
        }
    }
}
