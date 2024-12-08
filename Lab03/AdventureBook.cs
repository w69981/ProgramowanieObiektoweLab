using Lab03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class AdventureBook : Book
    {
        private string genre = "Adventure";

        public string Genre => genre;

        public AdventureBook(string title, Person author, int publicationYear)
            : base(title, author, publicationYear)
        {
        }

        public override string View()
        {
            return base.View() + $", Genre: {Genre}";
        }
    }
}
