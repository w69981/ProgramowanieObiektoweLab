
using System;
using System.Collections.Generic;


namespace Lab03
{
    internal class Reader : Person
    {
        private List<Book> readBooks; // Pozostaje `private`

        protected List<Book> ReadBooks // Używamy właściwości
        {
            get => readBooks;
            set => readBooks = value ?? new List<Book>();
        }

        public Reader(string firstName, string lastName, int age, List<Book> readBooks)
            : base(firstName, lastName, age)
        {
            this.ReadBooks = readBooks;
        }

        public override string View()
        {
            string books = ReadBooks.Count > 0
                ? string.Join("\n", ReadBooks.Select(b => $"- {b.Title}"))
                : "No books read yet.";
            return base.View() + $"\nBooks read:\n{books}";
        }

        public void AddBook(Book book)
        {
            ReadBooks.Add(book);
        }
    }
}
