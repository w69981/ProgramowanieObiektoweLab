using Lab03;
using System;

namespace Lab03
{
    internal class Reviewer : Reader
    {
        public Reviewer(string firstName, string lastName, int age, List<Book> readBooks)
            : base(firstName, lastName, age, readBooks)
        {
        }

        public override string View()
        {
            Random rand = new Random();
            string reviews = string.Join("\n",
                ReadBooks.Select(b => $"- {b.Title}, Rated: {rand.Next(1, 11)}"));
            return base.View() + $"\nReviews:\n{reviews}";
        }
    }
}
