namespace PracticeDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   Console.WriteLine("Hello, World!");

            #region Association #1 
            Student student = new Student("Nda");
            Card card = new Card(123566);

            student.useCard(card);
            #endregion


            #region Association #2
            Fan fan = new Fan("Fan1");
            Stand stand = new Stand(1);

            stand.Hold(fan);
            #endregion

            #region Association #3
            Car car = new Car("Kia");
            Motor motor = new Motor("motor1");

            car.useMotor(motor);
            #endregion


        }
    }
}
