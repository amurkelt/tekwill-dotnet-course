namespace Homework2
{
    internal class Mammal : Animal
    {
        private string FurColor { get; set; }

        public Mammal(string name, string furColor) 
            : base(name)
        {
            FurColor = furColor;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Fur color: {FurColor}");
        }
    }
}