// 3.Construiți un program simplu de gestionare a meniului unui restaurant.
// Programul trebuie să permită utilizatorului să selecteze diferite opțiuni de meniu și să afișeze informații despre acestea.

// Implementați următoarele cerințe:
// •	Definiți o enumerare pentru opțiunile de meniu disponibile (de exemplu, "Supă", "Salata Caesar", “Salata Greceasca”, “Inghetata” etc.).
// •	Solicitați utilizatorului să introducă numarul de ordie a opțiunii din meniu de la tastatură
// (ex: 1 - "Supă", 2 - "Salata Caesar", 3 -“Salata Greceasca”, 4 - “Inghetata” etc.).
// •	Utilizați o instrucțiune switch pentru a verifica opțiunea de meniu selectată și pentru a afișa informații despre aceasta.
//      Pentru fiecare opțiune de meniu, afișați un mesaj corespunzător, care conține descrierea felului de mâncare și prețul.
// •	Dacă opțiunea de meniu introdusă nu este validă (adică nu este definită în enumerare), afișați un mesaj de eroare.
using static System.Net.Mime.MediaTypeNames;

class Program
{
    enum OptiunileDeMeniu
    {
        Supa,
        SalataCaesar,
        SalataGreceasca,
        Inghetata,
    }
       static void Main()
    {
        Console.WriteLine("Introduceti numarul de ordine a optiunii de meniu");
        Console.WriteLine("1 - Supa");
        Console.WriteLine("2 - Salata Caesar");
        Console.WriteLine("3 - Salata Greceasca");
        Console.WriteLine("4 - Inghetata");

        while (true)
        {
       
        int alegerea = int.Parse(Console.ReadLine());
        
        switch (alegerea)
        {
            case 1:
                Console.WriteLine("Supa");
                Console.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit");
                Console.WriteLine("45 MDL");
                break;
            case 2:
                Console.WriteLine("Salata Caesar");
                Console.WriteLine("Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua");
                Console.WriteLine("80 MDL");
                break;
            case 3:
                Console.WriteLine("Salata Greceasca");
                Console.WriteLine("Ut enim ad minim veniam");
                Console.WriteLine("69 MDL");
                break;
            case 4:
                Console.WriteLine("Inghetata");
                Console.WriteLine("Quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat");
                Console.WriteLine("33 MDL");
                break;
            default:
                Console.WriteLine("Optiunea de meniu selectata nu e disponibila");
                break;
        }
        }
        }
}
 