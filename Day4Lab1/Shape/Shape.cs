using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Shape
    {
        public virtual double CalculateArea()
        {
            Console.WriteLine("Calculating area for a general shape.");
            return 0;
        }
    }
}
