namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region Aggregation #1
            Players p1 = new Players("Ahmed", 22);
            Players p2 = new Players("Sara", 23);
            Players p3 = new Players("Omar", 19);

            Players[] AllTeam = { p1, p2, p3 };

            PlayGround pg = new PlayGround("Cairo Stadium");
            pg.PlayersEntered(AllTeam);
            pg.ShowPlayers();
            #endregion


            Console.WriteLine("------------------------------------------------------");


            #region  Aggregation #2


            Cake CakeFlavor = new Cake("Orange Cake");
            FLour flour = new FLour("1 Kilo", "White flour");

            CakeFlavor.CookFlour(flour);
            CakeFlavor.MixFlourWithEggs();

            #endregion

            Console.WriteLine("------------------------------------------------------");

            #region Aggregation #3
            Laptop laptop = new Laptop("Asus");
            Window window = new Window("windows 11"); 

            laptop.ContainWindow(window);
            laptop.ShowWindowDetails();
            #endregion

        }




    }
   


}

