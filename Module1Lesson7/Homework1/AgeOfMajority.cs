// 1.Verificarea eligibilității de vot:
// •	Solicitați utilizatorului să introducă vârsta sa de la tastatură.
// •	Utilizați o instrucțiune if pentru a verifica dacă utilizatorul are vârsta minimă pentru a vota (de exemplu, 18 ani).
// •	Afișați un mesaj corespunzător în funcție de rezultatul verificării.
using System.Threading.Channels;

class AgeOfMajority
{ 
    static void Main()
    {
        Console.WriteLine("Introduceti vârsta Dmv: ");

        int varsta = int.Parse(Console.ReadLine());
        
        if (varsta >= 18) 
        {
            Console.WriteLine("Major - Dmv puteti vota");
        }
        else
        {
            Console.WriteLine("Minor - Dmv NU puteti vota");
        }

    }
}
