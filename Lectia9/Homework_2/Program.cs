// Tema 2: Utilizare while
// 1.	Creați un program care să solicite utilizatorului să introducă numere de la tastatură până când introducerea valorii 0.
// 2.	Utilizați o buclă while pentru a verifica continuu valoarea introdusă și a afișa un mesaj corespunzător în funcție de valoarea introdusă.
// 3.	Întrerupeți bucla atunci când utilizatorul introduce valoarea 0 și afișați un mesaj de încheiere.
using System.Diagnostics.Metrics;

class Program
{
    static void Main()
    {
        int breakpoint = 1;

        while (breakpoint != 0)
        {
            Console.WriteLine("Introduceti numere de la tastatura \nValoarea 0 o sa incheie program");
            breakpoint = int.Parse(Console.ReadLine());
            Console.Clear();

            if (breakpoint == 0)
            {
                Console.WriteLine("Mater has given Dobby a sock. Master has presented Dobby with clothes. Dobby is free.");
            }
        }
    }
}