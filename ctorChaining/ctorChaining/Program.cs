namespace ctorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(); // default
            Student student1 = new Student("Nda", 1);
            Student student2 = new Student("Youssef");
            Student student3 = new Student(2);
        }
    }
}
