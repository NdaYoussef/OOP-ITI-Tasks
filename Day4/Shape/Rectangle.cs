using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Rectangle: Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double hight )
        {
             Width = width;
            Height = hight;
        }

        public override double CalculateArea()
        {

           // double Area = Width * Height;
            return Width * Height;

        }

    }
}
