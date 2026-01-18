using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Dog : Animal
    {
        public string Name;
        public Dog(string name) : base(name) 
        {
            Name = name;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Dog Sounds");
        }
    }
}
