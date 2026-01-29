using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Structs
{
    internal struct Order
    {
        public int OrderNumber;
        public string CustomerName;

        Pizza[] Pizzas = new Pizza[5];

        public double TotalAmount;

        private int pizzaCount = 0;

        public Order(int orderNumber, string customerName) 
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            
        }


        public void AddPizza(Pizza pizza)
        {
            if (pizzaCount < Pizzas.Length)
            {
                Pizzas[pizzaCount] = pizza;
                pizzaCount++;

                TotalAmount += pizza.Price; 
            }
            else
            {
                Console.WriteLine("Cannot add more pizzas");
            }
        }

        public void CalculateTotal()
        {
            TotalAmount = 0;
            for (int i = 0; i < pizzaCount; i++)
            {
                TotalAmount += Pizzas[i].Price;
            }
        }

     
        public string GetOrderStatus()
        {
            if (pizzaCount == 0)
                return "New Order";
            else if (pizzaCount >= 1 && pizzaCount <= 3)
                return "In Progress";
            else 
                return "Large Order";
        }

        public void ShowOrder()
        {
            Console.WriteLine($"Order #{OrderNumber} for {CustomerName}");
            for (int i = 0; i < pizzaCount; i++)
            {
                Console.WriteLine($"- {Pizzas[i].GetSizeName()} {Pizzas[i].GetTypeDescription()} - ${Pizzas[i].Price}");
            }
            Console.WriteLine($"Total: ${TotalAmount}");
            Console.WriteLine($"Status: {GetOrderStatus()}");
        }
    }
}
