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
        [Required]
        public string Title;
        [Required]
        string Author;
        string ISBN;
        int PublicationYear;
        bool IsAvailable = true;


        //Paramtless ctor
        public Book()
        {
            
        }


        //paramterized ctor
        public Book(string title, string author, string ISBN, int publicationYear, bool isAvailable)
        {
            Title = title;
            Author = author;
            this.ISBN = ISBN;
            PublicationYear = publicationYear;
            IsAvailable = isAvailable;
                
        }

        //overloaded ctor
        public Book(string title, string author, string ISBN = "UnKnown", int publicationYear = 2026)
        {
            Author = author;
            Title = title;
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
