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
        Supa = 1,
        SalataCaesar = 2,
        SalataGreceasca = 3,
        Inghetata = 4,
    }
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Meniu: ");
            Console.WriteLine("1 - Supa");
            Console.WriteLine("2 - Salata Caesar");
            Console.WriteLine("3 - Salata Greceasca");
            Console.WriteLine("4 - Inghetata");

            Console.WriteLine("\nIntroduceti optiunea: ");
            int optiune = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (optiune)
            {
                case (int)OptiunileDeMeniu.Supa:
                    Console.WriteLine("Supa:\n\tLorem ipsum dolor sit amet, consectetur adipiscing elit\n\t45 MDL\n");
                    break;
                case (int)OptiunileDeMeniu.SalataCaesar:
                    Console.WriteLine("Salata Caesar::\n\tSed do eiusmod tempor incididunt ut labore et dolore magna aliqua\n\t80 MDL\n");
                    Console.WriteLine("Pret: 203\n");
                    break;
                case (int)OptiunileDeMeniu.SalataGreceasca:
                    Console.WriteLine("Salata Greceasca:\n\tUt enim ad minim veniam\n\t69 MDL\n");
                    Console.WriteLine("Pret: 203\n");
                    break;
                case (int)OptiunileDeMeniu.Inghetata:
                    Console.WriteLine("Inghetata:\n\tQuis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat\n\t33 MDL\n");
                    Console.WriteLine("Pret: 203\n");
                    break;
                default:
                    Console.WriteLine("Scuzati. Optiunea de meniu selectata nu e disponibila.\n");
                    break;
            }
        }
    }
}

