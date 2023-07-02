using System;

namespace Exemplu
{
    public class MyClasa
    {
        public string Nume;

        private int var1;

        public void AfiseazaNumar(int numar)
        {
            if (numar > 0)
                Console.WriteLine("Numarul este pozitiv.");
            else
                Console.WriteLine("Numarul este negativ.");
        }

        public static void CalculeazaProdus(int a, int b)
        {
            int produs = a * b;
            Console.WriteLine("Produsul numerelor este: " + produs);
        }

        public void CalculeazaSuma(int a, int b)
        {
            int suma = a + b;
            Console.WriteLine("Suma numerelor este: " + suma);
        }


    }
    //home cotroller

    class Program
    {
        static void Main(string[] args)
        {
            MyClasa obj = new MyClasa();
            obj.AfiseazaNumar(10);
            obj.Nume = "Exemplu";
            Console.WriteLine(obj.Nume);
            obj.CalculeazaSuma(5, 3);
            MyClasa.CalculeazaProdus(2, 4);
            Console.ReadLine();
        }
    }
}
