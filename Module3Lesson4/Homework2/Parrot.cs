namespace Homework2
{
    internal class Parrot : Bird
    {
        private string Vocabulary { get; set; }

        public Parrot(string name, string typeOfFlight, string vocabulary)
            : base(name, typeOfFlight)
        {
            Vocabulary = vocabulary;
        }

        public override void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type of flight: {TypeOfFlight}");
            Console.WriteLine($"Vocabulary: {Vocabulary}");
        }
    }
}