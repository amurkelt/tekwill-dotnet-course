class Program
{
    static void Main(string[] args)
    {
        int number = 5;

        bool isEven = number % 2 == 0;

        if (isEven == true)
        {
            Console.WriteLine("Numarul este par");
        }
        else
        {
            Console.WriteLine("Numarul este impar");
        }
    }
}
