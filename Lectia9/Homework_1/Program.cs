// Tema 1: Utilizare for
// 1.	Creați un program care să afișeze toate numerele pare într-un interval dat.
// 2.	Solicitați utilizatorului să introducă un număr de început și un număr de sfârșit al intervalului.
// 3.	Utilizați o buclă for pentru a itera prin toate numerele din interval.
// 4.	În fiecare iterație, verificați dacă numărul este par și, dacă este, afișați-l la ecran.
class Program
{
    static void Main()
    {
        int arrayStart = 0;
        int arrayEnd = 0;
        int intervalLength = 0;

        do
        {
            Console.WriteLine("Introdu un numar de inceput al intervalului");
            arrayStart = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu un numar de sfarsit al intervalului");
            arrayEnd = int.Parse(Console.ReadLine());                      
        }
        while (arrayStart >= arrayEnd);

        intervalLength = arrayEnd - arrayStart + 1;
        int[] interval = new int[intervalLength];
        Console.WriteLine("Urmatoare numere in intervalul dat sunt pare: ");

        for (int i = 0; i < intervalLength; i++)
        {
            interval[i] = arrayStart + i;

            if (interval[i] % 2 == 0)
            {
                Console.Write($"{interval[i]} ");
            }
        }
    }
}
