using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIau
{
    internal class Author
    {
        public int authorId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public List<Book> books = new List<Book>();

        public void addBook(Book b)
        {
            this.books.Add(b);
        }

        public Author(int authorId, string firstName, string lastName)
        {
            this.authorId = authorId;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
