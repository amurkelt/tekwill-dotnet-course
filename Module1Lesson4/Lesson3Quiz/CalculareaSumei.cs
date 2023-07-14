using System;

namespace HelloTekwill
{
    class CalculareaSumei
    {   
        static void Main()
        {
        Console.WriteLine("Introduceți trei numere:");

        // Citirea primului număr
        Console.Write("Primul numar:");
        int numar1 = int.Parse(Console.ReadLine());

        // Citirea celui de-al doilea număr
        Console.Write("Al doilea numar: ");
        int numar2 = int.Parse(Console.ReadLine());

        // Citirea celui de-al treilea număr
        Console.Write("Al 3-lea numar: ");
        int numar3 = int.Parse(Console.ReadLine());

        // Calcularea sumei
        int suma = numar1 + numar2 + numar3;

        // Afișarea rezultatului
        Console.WriteLine("Suma numerelor: {0},{1},{2} este {3}", numar1, numar2, numar3, suma);
    }
}
}
