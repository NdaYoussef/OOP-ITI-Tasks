namespace SystemObjectMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Nda",1, "VG");
            Student student2 = new Student("Youssef", 2, "G");

            Console.WriteLine(student1.Equals(student2));
            Console.WriteLine(student1.Equals(null));
            Console.WriteLine(student1.Equals("true"));
            Console.WriteLine(object.ReferenceEquals(student1,student2));
            Console.WriteLine(student1 == student2);


            Console.WriteLine($"student1 hash code {student1.GetHashCode()}");
            Console.WriteLine($"student2 hash code {student2.GetHashCode()}");


            student1 = student2;
            Console.WriteLine($"student1 hash code {student1.GetHashCode()}");
            Console.WriteLine($"student2 hash code {student2.GetHashCode()}");

           student2 =  student1.ShallowCopy();
           student1 =  student2.DeepCopy();

            Console.WriteLine($"student2 name after shallow copy {student2.Name}");
            Console.WriteLine($"student1 name after deep copy {student1.Name}");

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student1);
            Console.WriteLine($"Student type: {student1.GetType()}");
            Console.WriteLine("------------------------------------------------");

            Book book = new Book("book1", "Author1", "123456");
            

            Console.WriteLine(book.ToString());
            Console.WriteLine(book);


            Console.WriteLine($"Book type: {book.GetType()}");
        
            
        }
    }
}
