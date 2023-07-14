// Ex 1: Utilizare array unidimensional
// 1.	Creați un program care să stocheze și să afișeze notele unui grup de studenți.
// 2.	Solicitați utilizatorului să introducă numărul de studenți și să completeze notele fiecărui student.
// 3.	Utilizați un array unidimensional pentru a stoca notele.
// 4.	Afișați toate notele la ecran.
// 5.	Calculați și afișați media notelor.
class SingleDimensionalArray
{
    static void Main()
    {
        Console.Write("Introdu numarul de studenti: ");
        int nrStudenti = int.Parse(Console.ReadLine());

        var notele = new double[nrStudenti];

        for (int i = 0; i < nrStudenti; i++)
        {
            Console.Write($"Introdu nota studentului {i + 1}: ");
            notele[i] = int.Parse(Console.ReadLine());
        }

        Console.Write($"\nNotele studentilor sunt: ");

        for (int i = 0; i < nrStudenti; i++)
        {
            Console.Write($"{notele[i]} ");
        }

        double mediaNotelor = notele.Average();
        Console.WriteLine($"\n\nMedia notelor este: {mediaNotelor}");
    }
}