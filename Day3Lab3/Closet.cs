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

       public int _totalNumberOfShelfs;

        public List<Shelf> _Shelfs =new();//new List<Shelf>();

        public Closet(string name, int totalNumberOfShelfs)//, List<Shelf> Shelfes)
        {
            Name = name;
            _totalNumberOfShelfs = totalNumberOfShelfs;
           // _Shelfs = Shelfes;
        }



        public void ShowTotalNoOfShelfes()
        {
            if (_totalNumberOfShelfs < 0)
                Console.WriteLine("No Shelfes found");

            else if (_totalNumberOfShelfs > 0)
                Console.WriteLine($"total Number of shelfes are: {_totalNumberOfShelfs}");
        }
    }
}
