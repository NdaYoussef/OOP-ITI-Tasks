using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObjectMethods
{
    internal class Student
    {
        public string Name;
        public int Id;
        public string Grade;


       
        public Student(string name, int id, string grade)
        {
            Name = name;
            Id = id;
            Grade = grade;
        }


        //public override string ToString()
        //{
        //    return $"Student Name: {Name}, Student Id: {Id}, Student Grade: {Grade}";
        //}

        public override string ToString()
        {
            return base.ToString();
        }

     

        public Student ShallowCopy()
        {
            return (Student)MemberwiseClone();
        }

        public Student DeepCopy()
        {
            return new Student(Name, Id, Grade);
        }


        public override bool Equals(object obj)
        {
            if (obj is Student other)
                return Name == other.Name && Id == other.Id && Grade == other.Grade;

            return false;
        }


        public override int GetHashCode()
        {
            return 
                base.GetHashCode();
        }

    }
}
