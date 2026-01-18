using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDay3
{
    internal class Student
    {
        public string Name { get; set; }

        public Student(string name)
        {
            Name = name;
        }


        public void useCard(Card card)
        {
            Console.WriteLine($"student {Name} use card number: {card.Number} ");
        }
    }
}
