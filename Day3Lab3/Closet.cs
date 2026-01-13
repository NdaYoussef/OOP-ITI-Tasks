using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Closet
    {
        public string Name { get; set; }

        public Shelf Shelf;

        public Closet(string name, int NoOfShelfes)
        {
            Name = name;

            Shelf = new Shelf(NoOfShelfes);
        }


        public void ShowClosetShape()
        {
            Console.WriteLine($"Closet Name:{Name}, and has shelfes {Shelf.Number} ");
        }
    }
}
