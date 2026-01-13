namespace Lab1Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            student.SetFirstName("Nda");
            student.SetLastName("Youssef");
            student.SetStudentId(1);
            student.SetGrade('B');
            student.SetAttendance(50.5);

            student.PrintStudentInfo();

            string IsPassed = student.IsPassing();
            Console.WriteLine(IsPassed);

            
        }
    }
}
