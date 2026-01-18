namespace Lab1Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           _3DPoint Point1 = new _3DPoint();    

            _3DPoint Point2 = new _3DPoint();

            Point1.X = 1;
         

            Point2.X = 4;
          


            int AbsDistance = Math.Abs( Point1.X - Point2.X); 
            Console.WriteLine($"Distance between 2 points in coordinate X is:{ AbsDistance} ");
        }
    }
}
