using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }
        public Complex(int real, int img)
        {
            Real = real;
            Img = img;
        }

        // implicit casting
        public static implicit operator int(Complex complex)
        { 
            return complex.Real;
        }


        public static implicit operator Complex((int, int) complex)
        {
            return new Complex(complex.Item1,complex.Item2);
        }

        // explicit casting

        //public static explicit operator int(Complex c)
        //{
        //    return c.Real;
        //}



        public static implicit operator Complex(int number)
        {
            return new Complex(number,0);
        }


        //pre increment 

        public static Complex operator ++(Complex complex)
        {
           
            return new Complex(complex.Real++, complex.Img++);
        }


        public static Complex operator --(Complex complex)
        {
            complex.Real--;
            complex.Img--;
            return complex;
        }



        //greater than 
        public static bool operator <(Complex c1, Complex c2)
        {
            double comparsion1 = Math.Sqrt(c1.Real * c1.Real + c1.Img * c1.Img);
            double comparsion2 = Math.Sqrt(c2.Real * c2.Real + c2.Img * c2.Img);

            return comparsion1 < comparsion2;

        }
        //less than 
        public static bool operator >(Complex c1, Complex c2)
        {
            double comparsion1 = Math.Sqrt(c1.Real * c1.Real + c1.Img * c1.Img);
            double comparsion2 = Math.Sqrt(c2.Real * c2.Real + c2.Img * c2.Img);

            return comparsion1 > comparsion2;
        }
        //greater than or equal
        public static bool operator <=(Complex c1, Complex c2)
        {
            double comparsion1 = Math.Sqrt(c1.Real * c1.Real + c1.Img * c1.Img);
            double comparsion2 = Math.Sqrt(c2.Real * c2.Real + c2.Img * c2.Img);

            return comparsion1 <= comparsion2;
        }
        //less than or equal
        public static bool operator >=(Complex c1, Complex c2)
        {
            double comparsion1 = Math.Sqrt(c1.Real * c1.Real + c1.Img * c1.Img);
            double comparsion2 = Math.Sqrt(c2.Real * c2.Real + c2.Img * c2.Img);
            return comparsion1 >= comparsion2;
        }



    }
}
