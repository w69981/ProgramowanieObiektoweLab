using Lab03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class DocumentaryBook : Book
    {
        private string genre = "Documentary";

        public string Genre => genre;

        public DocumentaryBook(string title, Person author, int publicationYear)
            : base(title, author, publicationYear)
        {
        }

        public override string View()
        {
            return base.View() + $", Genre: {Genre}";
        }
    }
}
