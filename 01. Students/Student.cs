using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Students
{
    internal class Student
    {
        //fields -> характеристики

        private string firstName;
        private string lastName;
        private double grade;

        //properties -> осигуряват достъп до полетата

        public string FirstName
        { 
            get { return firstName; } 
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set {  lastName = value; }
        }

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        // constructor - метод, чрез който създаваме обекти от класа
        public Student(string firstName, string lastName, double grade)
        { 
            // нов празен обект
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

    }
}
