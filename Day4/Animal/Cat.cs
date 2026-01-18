using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Cat : Animal
    {
        public string Name { get; set; }
        public Cat(string name) :base(name)
        {
            Name = name;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Cat Sounds");
        }
    }
}
