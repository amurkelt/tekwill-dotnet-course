// Tema 3: Utilizare foreach
// 1.	Creați o listă de persoane, unde fiecare persoană este reprezentată de o structură care conține informații precum Nume, Vârstă și Ocupație.
// 2.	Adăugați câteva persoane în lista de persoane, fiecare persoană fiind un dicționar cu informațiile corespunzătoare.
// 3.	Utilizați o buclă foreach pentru a itera prin lista de persoane și a afișa informațiile despre fiecare persoană.
// 4.	Permiteți utilizatorului să introducă o ocupație de referință.
// 5.	Utilizați o buclă foreach pentru a itera prin lista de persoane și afișați doar persoanele care au aceeași ocupație ca și cea introdusă de utilizator.
using System.Runtime.InteropServices;

class Program
{
    struct Persoana
    {
        public string numele;
        public string varsta;
        public string ocupatie;
    }

    static void Main()
    {
        var listaPersoanelor = new Persoana[3]
        {
            new Persoana()
            {
                numele = "Stefan",
                varsta = "18",
                ocupatie = "Psiholog"
            },
            new Persoana()
            {
                numele = "Ivan",
                varsta = "27",
                ocupatie = "Inginer"
            },
             new Persoana()
             {
                numele = "Nicolae",
                varsta = "34",
                ocupatie = "Hamal"
            },
        };

        //for (int i = 0; i < listaPersoanelor.Length; i++)
        //{
        //    Console.Write($"Introdu numele persoanei {i + 1}: ");
        //    listaPersoanelor[i].numele = Console.ReadLine();
        //    Console.Write($"Introdu varsta persoanei {i + 1}: ");
        //    listaPersoanelor[i].varsta = Console.ReadLine();
        //    Console.Write($"Introdu ocupatie persoanei {i + 1}: ");
        //    listaPersoanelor[i].ocupatie = Console.ReadLine();
        //    Console.WriteLine();
        //}

        Console.WriteLine("Lista tuturor persoanelor disponibile:");

        foreach (var persoana in listaPersoanelor)
        {
            Console.WriteLine(persoana.numele);
            Console.WriteLine(persoana.varsta);
            Console.WriteLine(persoana.ocupatie);
            Console.WriteLine();
        }

        Console.WriteLine("Introduceti o ocupatie de referinta pentru filtrarea datelor:");
        var referinta = Console.ReadLine();
        Console.WriteLine();

        foreach (var persoana in listaPersoanelor)
        {
            if (persoana.ocupatie ==  referinta)
            {
                Console.WriteLine(persoana.numele);
                Console.WriteLine(persoana.varsta);
                Console.WriteLine(persoana.ocupatie);
                Console.WriteLine();
            }
        }
    }
}