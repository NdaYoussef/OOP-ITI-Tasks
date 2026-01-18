using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle: Shape
    {
        
        public double Redius { get; set; }

        public Circle(double r)
        {
             Redius = r;
        }
        public override double CalculateArea()
        {

           // double Area = PI * Redius * Redius;
            return Math.PI * Redius * Redius;

        }

    }
}
