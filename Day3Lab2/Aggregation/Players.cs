using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Players
    {
        public string Name { get; set; }    
        public int Age { get; set; }

        public Players(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
