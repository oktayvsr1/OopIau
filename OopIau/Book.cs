using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIau
{
    internal class Book
    {
        public int bookId { get; set; }
        public string title { get; set; }
        public Author author { get; set; }

        public void setAuthor(Author a)
        {
            this.author = a;
        }
        public Author getAuthor()
        {
            return this.author;
        }

        public Book(int bookId, string title)
        {
            this.bookId = bookId;
            this.title = title;
        }


    }
}
