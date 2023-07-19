// Tema: Utilizarea unei clase statice.
// 1.Creați o clasă statică numită Helper care să conțină o metodă statică numită GenerareCodUnic care să genereze un cod unic format dintr-un prefix și un număr.
// 2.	Metoda GenerareCodUnic trebuie să primească un prefix și să returneze un cod unic format din prefix și un număr generat aleatoriu.
// 3.	Testați clasa Helper în funcția Main a programului.
// •	Apelați metoda GenerareCodUnic de mai multe ori cu diferite valori de prefix și afișați codurile generate.
using Homework1;

class GenerateUniqueCode
{
    static void Main()
    {
        Console.Write("Introduceti prefix pentru a genera cod unic: ");
        string uniqueCode = Helper.GenerateUniqueCode(Console.ReadLine());
        Console.WriteLine(uniqueCode);
    }
}