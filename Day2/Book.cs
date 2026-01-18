using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDay2
{
    internal class Book
    {
        public string Title;
        string Author;
        string ISBN;
        int PublicationYear;
        bool IsAvailable = true;

        //Default ctor
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            ISBN = "N/A";
            PublicationYear = 0;
            IsAvailable = true;
        }

        //paramterized ctor
        public Book(string title, string author, string isbn, int publicationYear, bool isAvailable)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationYear = publicationYear;
            IsAvailable = isAvailable;
        }


        

        public void DisplayInfo()
        {
            Console.WriteLine($"Book TItle : {Title}, Book Author : {Author},Standard Book Number :{ISBN}, Publication Year : {PublicationYear} ");

        }

        public void BorrowBook()
        {
            IsAvailable = false;
            Console.WriteLine("Book borrowing successeded ");

        }

        public void ReturnBook()
        {
            IsAvailable = true;
            Console.WriteLine("Book has been returned successfully");
        }
    }
}
