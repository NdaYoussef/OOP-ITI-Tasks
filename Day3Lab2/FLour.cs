using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class FLour
    {
        public string Name { get; set; }
        public string Amount { get; set; }
        public FLour( string amount, string name)
        {
            Amount = amount;
            Name = name;
        }



    }
}
