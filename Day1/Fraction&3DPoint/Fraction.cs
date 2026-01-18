using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part3
{
    internal class Fraction
    {

        public int Numerator {  get; set; } 
        public int Denominator { get; set; }


        
        public Fraction Add(Fraction f1, Fraction f2)
        {

           int newNumerator = f1.Numerator * f2.Denominator + f1.Denominator * f2.Numerator;

            int newDenominator = f1.Denominator * f2.Denominator;

            Fraction res = new();
            res.Numerator = newNumerator;
            res.Denominator = newDenominator;
            return res;
           
        }
    }
}
