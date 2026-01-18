using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part2
{
    internal class Student
    {
        int Id;
        string FirstName;
        string LastName;
        char Grade;
        double AttendancePercentage; 



        public void SetStudentId(int id)
        {
            if (id < 0)
                Console.WriteLine("Id must be positive");
            Id = id;
        }

        public void SetFirstName(string firstName)
        {
            if (firstName.Length == 0)
                Console.WriteLine("Please enter valid value, Name can't be null or empty");
            FirstName = firstName;
        }

        public void SetLastName(string lastName)
        {
            if (lastName.Length == 0)
                Console.WriteLine("Please enter valid value, Name can't be null or empty");

            LastName = lastName;
        }


        public void SetGrade(char grade)
        {
            if( grade>='A' && grade <= 'F')
            Grade = grade;
        }

        public void SetAttendance(double attendancePercentage)
        {
            if(attendancePercentage >= 0.0 && attendancePercentage <= 100.0)
            AttendancePercentage = attendancePercentage;
        }


        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string IsPassing()
        {
            if (Grade != 'F')
                return "Passed";
            return "Not Passed";
        }


        public void PrintStudentInfo()
        {
            Console.WriteLine($"Student Id: {Id},Student Full Name: {FirstName} {LastName}, Student Grade: {Grade}, Attendance Percentage: {AttendancePercentage} ");
            
        }
    }
}
