using System;
using System.Runtime.Serialization;

namespace BooksAndAuthors
{
    [Serializable]
    class Book : ISerializable
    {
        string title;
        DateTime publishDate;

        string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.title = value;
                }
            }
        }

        DateTime PublishDate
        {
            get
            {
                return this.publishDate;
            }
            set
            {
                this.publishDate = value;
            }
        }

        public Book(string title, DateTime publishDate)
        {
            this.title = title;
            this.publishDate = publishDate;
        }

        public override string ToString()
        {
            return string.Format("Title: {0}, publish date: {1:dd,MM,yyyy}", this.title, this.publishDate);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Title", Title);
            info.AddValue("PublishDate", PublishDate);
        }

        public Book(SerializationInfo info, StreamingContext context)
        {
            Title = (string)info.GetValue("Title", typeof(string));
            PublishDate = (DateTime)info.GetValue("PublishDate", typeof(DateTime));
        }
    }
}
