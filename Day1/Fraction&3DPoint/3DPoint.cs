using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part3
{
    internal class _3DPoint
    {
      public  int X;
      public  int Y;
      public  int Z;


        //public void SetX(int x)
        //    { this.X = x; }
        //public void SetY(int y)
        //{ this.Y = y; }
        //public void SetZ(int x)
        //{ this.X = x; }

        public void Display(int x, int y, int z)

        {
            X = x; 
            Y = y;
            Z = z;
        }


        public int CalcDistance(_3DPoint p1,  _3DPoint p2)
        {
           int  AbsValue = Math.Abs( p1.X - p2.X);
           return AbsValue;
        }

    }
}
