// Ex 2: Utilizare array unidimensional
// 1.	Creați un program care să stocheze și stocheze și să gestioneze datele despre angajații unei companii.
// 2.	Citit de la tastatura datele (numele, departamentul, salariul) a 3 angajati. Folosiți structura pentru a indica șablonul unui angajat.
// 3.	Calculați salariul mediu.
// 4.	Afișați la ecran numele angajaților cu salariul mai mare decat media.
using System.Diagnostics.CodeAnalysis;
using System.Linq;

class EmployeesDatabase
{
    struct Angajati
    {
        public string numele;
        public string departamentul;
        public double salariul;
    }

    static void Main()
    {
        const int numarulAngajatilor = 3;
        double sumaSalariala = 0;
        var dateleAngajatilor = new Angajati[numarulAngajatilor];

        for (int i = 0; i < dateleAngajatilor.Length; i++)
        {
            Console.Write($"Introdu numele angajatului {i + 1}: ");
            dateleAngajatilor[i].numele = Console.ReadLine();
            Console.Write($"Introdu departamentul angajatului {i + 1}: ");
            dateleAngajatilor[i].departamentul = Console.ReadLine();
            Console.Write($"Introdu salariul angajatului {i + 1}: ");
            dateleAngajatilor[i].salariul = double.Parse(Console.ReadLine());
            sumaSalariala += dateleAngajatilor[i].salariul;
            Console.WriteLine();
        }

        double mediaSalariala = sumaSalariala / numarulAngajatilor;
        Console.WriteLine($"Media salariala este: {mediaSalariala}");
        Console.WriteLine($"\nUrmatori angajati au salariul mai mare decat media:");

        for (int i = 0; i < dateleAngajatilor.Length; i++)
        {
            if (dateleAngajatilor[i].salariul > mediaSalariala) Console.Write($"{i+1}. {dateleAngajatilor[i].numele}\n");
        }
    }
}