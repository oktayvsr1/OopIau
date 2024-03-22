using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIau
{
    internal class Univrsity
    {
        public List<Author> authors = new List<Author>();
        

        public void newAuthor()
        {
            Console.WriteLine("Author Id: ");
            int authorId=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Author name: ");
            string name=Console.ReadLine();

            Console.WriteLine("Author surname: ");
            string surname=Console.ReadLine();  

            Author author = new Author(authorId, name, surname);

            this.authors.Add(author);
            Console.WriteLine("New author saved!");

        }
    

        public void newBook(int authorId)
        {

            Console.WriteLine("Book ıd: ");
            int bookId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Book name: ");
            string title = Console.ReadLine();   

            Book book = new Book(bookId, title);

            foreach(Author a in authors) 
            {
                if(a.authorId == authorId)
                {
                    a.books.Add(book);
                    book.setAuthor(a);
                }
                
            }
            Console.WriteLine("Book saved for author with Id:"+authorId);

            //this.authors.FindAll(a => a.authorId == authorId).ForEach(a=> { a.books.Add(book); book.setAuthor(a); });

        }

        public void getAuthor()
        {
            foreach(Author a in authors)
            {
                Console.WriteLine(a.authorId + " " + a.firstName + " " + a.lastName);
            }
        }
        public void getAuthor(int authorId)
        {
            

            foreach(Author a in authors)
            {
                if(a.authorId == authorId)
                {
                    Console.WriteLine(a.authorId + " " + a.firstName + " " + a.lastName );
                    foreach (Book b in a.books)
                    {
                        Console.WriteLine(b.title+" "+b.title);
                    }
                }
                
            }
            
        }
        public void getBook()
        {
            foreach (Author a in authors)
            {
               foreach(Book b in a.books)
                {
                    Console.WriteLine(b.title+" "+b.bookId);
                }
            }
        }


        public void getBook(int authorId)
        {
            foreach(Author a in authors)
            {
                if (a.authorId == authorId)
                {
                    foreach(Book b in a.books)
                    {
                        Console.WriteLine(b.title + " " + b.bookId + " " + b.author);
                    }
                }
            }
        }




    }
}
