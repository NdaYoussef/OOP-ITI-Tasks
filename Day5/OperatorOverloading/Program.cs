namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(0, 0);


            //implicit casting 
             complex = 5;
            Console.WriteLine($"value of impilicit casting of real part of complex object = {complex.Real}");

            //implicit casting with tuple
            complex = (7, 8);
            Console.WriteLine($"value of casting complex object into tuple int = ({complex.Real} , {complex.Img}) ");

            #region Increment
            Console.WriteLine($"pre increment = ({++complex.Real},{++complex.Img}) ");

            Console.WriteLine($"after pre increment = ({complex.Real},{complex.Img}) ");

            Console.WriteLine($"post increment = ({complex.Real++},{complex.Img++}) ");

            Console.WriteLine($"after post  increment = ({complex.Real},{complex.Img}) ");

            #endregion
            #region decrement

            Console.WriteLine($"pre decrement {--complex.Real}, {--complex.Img}");
            Console.WriteLine($"after pre decrement = ({complex.Real},{complex.Img}) ");

            Console.WriteLine($"post decrement = ({complex.Real--},{complex.Img--}) ");

            Console.WriteLine($"after post  decrement = ({complex.Real},{complex.Img}) ");

            #endregion


            Complex complex2 = new Complex(5, 10);
            bool result = complex > complex2;
            Console.WriteLine($"value of greater comparison : {result}");

            
            // Console.WriteLine($"Value of increment: {}");
        }
    }
}
