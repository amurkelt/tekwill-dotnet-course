namespace Homework1
{
    internal class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
