using System.Xml.Linq;

namespace Homework1
{
    internal class Manager : Employee
    {
        private string Department { get; set; }

        public Manager(string name, string department)
            :base(name)
        {
            Department = department;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
        }
    }
}