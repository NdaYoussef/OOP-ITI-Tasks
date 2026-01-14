namespace Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[2];

            shapes[0] = new Rectangle(5.4,6);
            shapes[1] = new Circle(3.3);

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"Area of {shapes[i]} = {shapes[i].CalculateArea()} ");
                 
            }
        }
    }
}
