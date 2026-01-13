using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Computer
    {
        public string Model { get; set; }
        public CPU CPU = new("");

        public Computer(string model, string cpuModel)
        {
            Model = model;
            CPU = new CPU(cpuModel);
        }


        public void ShowComputerComponents()
        {
            Console.WriteLine($"Computer model: {Model} has CPU of type {CPU.Model}");
        }
    }
}
