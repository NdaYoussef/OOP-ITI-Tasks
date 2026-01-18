using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Bird : Animal
    {
        public string Name { get; set; }
        public Bird(string name): base(name) 
        {
            Name = name;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Bird Sounds");
        }


        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating");
        }
    }
}
