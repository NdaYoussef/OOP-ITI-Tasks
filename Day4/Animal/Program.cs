namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[3];
            animal[0] = new Bird("Tweety");
            animal[1] = new Dog("Buddy");
            animal[2] = new Cat("Milo");

            for(int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine($"Animal Name: {animal[i].Name}");
                animal[i].MakeSound();
                animal[i].Eat();
            }
        }
    }
}
