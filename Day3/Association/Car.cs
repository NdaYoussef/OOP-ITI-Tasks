using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDay3
{
    internal class Car
    {
        public string Model { get; set; }
        public Car(string model)
        {
            Model = model;
        }


        public void useMotor(Motor motor)
        {
            Console.WriteLine($"Car Model: {Model}, uses motor: {motor.Name}");
        }
    }
}
