// 2.Evaluarea calificativului studenților:
// •	Solicitați utilizatorului să introducă nota sa de la un test.
// •	Utilizați o instrucțiune if-else pentru a evalua calificativul în funcție de nota introdusă.
// •	Afișați calificativul corespunzător la ecran (de exemplu, "Excelent" pentur 10, "Bun" pentru 8-9, "Suficient" pentru 5-7, "Necalificat" pentru 1-4).
class Program
{
    static void Main()
    {
        Console.WriteLine("Introduceti nota Dmv (in baremul 1-10): ");
        int nota = int.Parse(Console.ReadLine());
        if (nota == 10)
        {
            Console.WriteLine("Excelent");
        }
        else if (nota == 9 || nota == 8)
        {
            Console.WriteLine("Bun");
        }
        else if (nota >= 5 && nota <= 7)
        {
            Console.WriteLine("Suficient");
        }
        else 
        {
            Console.WriteLine("Necalificat");
        }
    }
}

