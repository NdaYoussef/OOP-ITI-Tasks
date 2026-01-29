namespace Enums_Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create different pizzas using enums
            Pizza pizza1 = new Pizza(PizzaSize.Large, PizzaType.Cheese, 15.99);
            Pizza pizza2 = new Pizza(PizzaSize.Medium, PizzaType.Pepperoni, 13.99);
            Pizza pizza3 = new Pizza(PizzaSize.Small, PizzaType.Veggie, 11.99);

            // Create an order
            Order order = new Order(101, "John");

            // Add pizzas to order
            order.AddPizza(pizza1);
            order.AddPizza(pizza2);

            // Display the order
            order.ShowOrder();

            // Create another order with more pizzas
            Order order2 = new Order(102, "Sarah");
            order2.AddPizza(pizza3);
            order2.AddPizza(pizza1);
            order2.AddPizza(pizza2);
            order2.AddPizza(new Pizza(PizzaSize.Large, PizzaType.Supreme, 18.99));

            // Display the second order
            order2.ShowOrder();

            // Demonstrate enum usage
            Console.WriteLine(" === Enum Examples === ");
            Console.WriteLine($"Pizza size: {pizza1.Size}");
            Console.WriteLine($"Pizza type: {pizza1.Type}");
            Console.WriteLine($"Size name: {pizza1.GetSizeName()}");
            Console.WriteLine($"Type description: {pizza1.GetTypeDescription()}");

       
        }
    }
}
