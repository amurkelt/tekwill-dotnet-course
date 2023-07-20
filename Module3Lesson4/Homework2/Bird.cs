namespace Homework2
{
    internal class Bird : Animal
    {
        public string TypeOfFlight { get; set; }

        public Bird(string name, string typeOfFlight)
            : base(name)
        {
            TypeOfFlight = typeOfFlight;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type of flight: {TypeOfFlight}");
        }
    }
}