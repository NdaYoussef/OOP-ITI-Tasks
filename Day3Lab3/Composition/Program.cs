namespace Composition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Composition #1
            House house = new House("Aswan", "Living Room");
            house.ShowHouseDetails();
            #endregion

            Console.WriteLine("---------------------------------------------------");

            #region Composition #2
            Computer computer = new Computer("12 Generation", "CPU model1");
            computer.ShowComputerComponents();
            #endregion

            Console.WriteLine("---------------------------------------------------");

            #region Composition #3

            Closet closet = new Closet("BedRoom", 3);
            closet.ShowClosetShape();
            #endregion

        }
    }
}
