// 2.Evaluarea calificativului studenților:
// •	Solicitați utilizatorului să introducă nota sa de la un test.
// •	Utilizați o instrucțiune if-else pentru a evalua calificativul în funcție de nota introdusă.
// •	Afișați calificativul corespunzător la ecran (de exemplu, "Excelent" pentur 10, "Bun" pentru 8-9, "Suficient" pentru 5-7, "Necalificat" pentru 1-4).
class GradeEvaluation
{
    static void Main()
    {
        Console.Write("Introduceti nota dvs. (in baremul 1-10): ");
        var nota = double.Parse(Console.ReadLine());

        Console.WriteLine($"Calificativul dvs. e {DeterminaCalificativul(nota)}");
    }

    static string DeterminaCalificativul(double nota)
    {
        if (nota > 0 && nota < 5) return "Necalificat";

        if (nota >= 5 && nota < 8) return "Suficient";

        if (nota >= 8 && nota < 10) return "Bun";

        if (nota == 10) return "Excelent";

        return "Calificativul nu poate fi determinat. Introdu o nota valida.";
    }
}

