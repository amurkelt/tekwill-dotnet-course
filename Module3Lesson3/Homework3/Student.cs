using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Student
    {
        public string name;
        public int age;
        public string specialization;

        public Student(string name, int age, string specialization)
        {
            this.name = name;
            this.age = age;
            this.specialization = specialization;
        }

        public Student(Student original)
        {
            this.name = original.name;
            this.age = original.age;
            this.specialization = original.specialization;
        }

        public Student()
        {
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Numele studentului: {name}");
            Console.WriteLine($"Varsta: {age}");
            Console.WriteLine($"Specializarea: {specialization}");
        }
    }
}
