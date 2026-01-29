using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Structs
{
    internal struct Pizza
    {
        public PizzaSize Size;
        public PizzaType Type;
        public double Price;
        public bool IsReady;


        public Pizza(PizzaSize size, PizzaType type, double price)
        {
            Size = size;
            Type = type;
            Price = price;
        }


        public string GetSizeName()
        {
            switch (Size)
            {
                case PizzaSize.Small:
                    return "Small";
                   
                case PizzaSize.Medium:
                    return "Medium";
                  
                case PizzaSize.Large:
                    return "Large";
                    
                case PizzaSize.ExtraLarge:
                    return "ExtraLarge";

                default:
                    return "no size valid!";
            }

        }

        public string GetTypeDescription()
        {
            switch (Type)
            {

                case PizzaType.Cheese:
                    return "Classic cheese pizza";

                case PizzaType.Pepperoni:
                    return "Pepperoni pizza";

                case PizzaType.Veggie:
                    return "Veggie pizza";

                case PizzaType.Supreme:
                    return "Everuthing pizza";

                default:
                    return "no type valid !";
            }
        }
    }
}
