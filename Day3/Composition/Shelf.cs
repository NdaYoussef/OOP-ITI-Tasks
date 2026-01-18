using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Shelf
    {
       public int Id {  get; set; }
        public Shelf(int id)
        {
        Id = id;
        }
    }
}
