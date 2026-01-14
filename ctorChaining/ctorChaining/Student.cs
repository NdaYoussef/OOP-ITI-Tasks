using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctorChaining
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Defauld ctor
        public Student()
        {
            Id = 0;
            Name = "Empty space";
            Console.WriteLine($"{Name}, {Id} in default ctor");
        }


        // parameterized ctor
        public Student(string name, int id)
        {
            Id = id;
            Name = name;
            Console.WriteLine($"{Name}, {Id} in parameterized ctor");

        }


        //ctor Chaining 
        public Student(string name) : this(name,0) //chaining to paramtereized ctor with name 
        {
            Name = name;
            Console.WriteLine($"{Name}, {Id} in chaining ctor to name");

        }


        public Student(int id) : this() //chaining to paramtereized ctor with id 
        {
            Id = id;
            Console.WriteLine($"{Name}, {Id} in chaining ctor to id");

        }


    }
}
