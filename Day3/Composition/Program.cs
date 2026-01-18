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


            List<Shelf> shelf = new List<Shelf>()
            {
                new Shelf(1),
                new Shelf(2),
                new Shelf(3),
                new Shelf(4),
                new Shelf(5),
            };
            int shelfs = shelf.Count;
                
            
            Closet closet = new Closet("BedRoom",shelfs);
            closet.ShowTotalNoOfShelfes();
            #endregion

        }
    }
}
