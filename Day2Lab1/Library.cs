using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay2
{
    internal class Library
    {
        string Name = " "; 
        ICollection<Book> Books = new List<Book>();



        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Book with title: {book.Title} has been added successfully ");

        }


        public void DisplayAllBooks()
        {

            //if()
            //    Console.WriteLine("No books found");

            if(Books == null|| !Books.Any())
               {
                    Console.WriteLine("No books available !");
                    return;
                }
            foreach(Book book in Books)
            {
                Console.WriteLine($"All Books in library: {book.Title}");
            }
        }

        public Book FindBookByTitle(string title)
        {
            if (Books == null)
            {
                Console.WriteLine("No books available !");
                return null!;
            }
            foreach (Book book in Books)
            {
                if(book.Title == title) 
                   return book;
            }
            return null!;
        }


        public bool BorrowBook(Book book)
        {
            if(book))
            {

            }
        }


    }
}
