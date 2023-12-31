﻿using System;

namespace Lectia3_1
{
    // [modificator de acces]
    internal class Program
    {
        public static void Hello(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        // static [tip return | void] [name of of the method in Pascal Case | MainMethod]
        // (list of input parameters)
        public static void Main()
        {
            Hello("Dorin");
            Hello("Alex");
            Hello("Cristian");
                   
            // 1. Preluam de la tastatura si convertim in numar prima valoare
            // introdus de catre utilizator in consola.

            // Variabila => un spatiu in memoria ram
            Console.Write("Introdu, te rog frumos, primul numar: ");
            double PrimulNumar = double.Parse(Console.ReadLine());

            // 2. Preluam de la tastatura si convertim in numar a doua valoare
            Console.Write("Introdu, te rog frumos, al doilea numar: ");
            double alDoileaNumar = double.Parse(Console.ReadLine());

            // 3. Calculam suma numerelor
            double suma = PrimulNumar + alDoileaNumar;

            // 4. Afisam rezultatul obtinut la ecran
            Console.WriteLine($"Suma numerelor este: {suma}");

            Console.ReadLine();
        }
    }
}
