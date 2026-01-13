using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Laptop
    {
        public string Model { get; set; }
        public Window   window { get; set; }
        public Laptop(string model) 
        {
            Model = model;
        }

        public void ContainWindow(Window window)
        {
            this.window = window;
        }

        public void ShowWindowDetails()
        {
            Console.WriteLine($"Laptop Model: {Model} contains windows version of {window.version}");
        }


        
    }
}
