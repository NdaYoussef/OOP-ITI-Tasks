using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Cake
    {
        public string Flavor { get; set; }
        public FLour fLour { get; set; }

        public Cake(string flavor)
        {
            Flavor = flavor;
        }

        public void CookFlour(FLour fLour)
        {
            this.fLour = fLour;
        }

        public void MixFlourWithEggs()
        {
            Console.WriteLine($"Cake contains flour: {fLour.Name} with amount: {fLour.Amount} and is mixed with eggs");
        }


    }
}
