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
            base.ShowDetails();
            Console.WriteLine($"Type of flight: {TypeOfFlight}");
        }
    }
}