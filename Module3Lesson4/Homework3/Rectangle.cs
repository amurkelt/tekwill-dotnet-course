namespace GeometricShape
{
    internal class Rectangle : Shape
    {
        public double Length { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double length, double height) : base(nameof(Rectangle))
        {
            Length = length;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Length * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Length + Height);
        }
    }
}
