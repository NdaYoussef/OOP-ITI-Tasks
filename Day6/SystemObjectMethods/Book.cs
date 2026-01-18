using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObjectMethods
{
    internal class Book
    {
        public string Title;
        public string Author;
        public string ISBN;

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        public override string ToString()
        {
            return $"title is {Title}, Author is {Author}, IsBN number is  {ISBN}";
        }

        //public override string ToString()
        //{
        //    return base.ToString();
        //}


        public Book ShallowCopy()
        {
            return (Book)MemberwiseClone() ;
        }

        public Book DeepCopy()
        {
            return new Book(Title, Author, ISBN) ;
        }

    }
}
