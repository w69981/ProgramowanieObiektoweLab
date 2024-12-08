using Lab03;
using System;

namespace Lab03
{
    internal class Book
    {
        protected string title;
        protected Person author;
        protected int publicationYear;

        public string Title
        {
            get => title;
            set => title = value.Length > 0 ? value : throw new ArgumentException("Title cannot be empty");
        }

        public Person Author
        {
            get => author;
            set => author = value ?? throw new ArgumentNullException("Author cannot be null");
        }

        public int PublicationYear
        {
            get => publicationYear;
            set => publicationYear = value > 0 ? value : throw new ArgumentException("Publication year must be positive");
        }

        public Book(string title, Person author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public virtual string View()
        {
            return $"Title: {Title}, Author: {Author.FirstName} {Author.LastName}, Year: {PublicationYear}";
        }
    }
}
