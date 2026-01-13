using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDay3
{
    internal class Stand
    {
        public int Number {  get; set; }
        public Stand(int number)
        {
            Number = number;
        }


        public void Hold(Fan fan)
        {
            Console.WriteLine($"Stand {Number} holds fan with name: {fan.Name}");
        }
    }
}
