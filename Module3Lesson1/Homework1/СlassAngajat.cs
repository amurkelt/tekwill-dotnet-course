// Creați o clasă numită Angajat care să reprezinte informații despre un angajat.
// Adăugați următoarele proprietăți la clasa Angajat:
// -    Nume - pentru a reține numele angajatului
// -    Salariu - pentru a reține salariul angajatului
// -    Departament - pentru a reține departamentul în care lucrează angajatul
// Implementați un constructor pentru clasa Angajat care să primească argumente pentru nume, salariu și departament și să le atribuie proprietăților corespunzătoare.
// Adăugați o metodă numită AfisareDetalii în clasa Angajat care să afișeze numele, salariul și departamentul angajatului.
// Testați clasa Angajat în funcția Main a programului.
// Creați mai mulți obiecte de tip Angajat, specificând valorile pentru nume, salariu și departament.
// Apelați metoda AfisareDetalii pentru fiecare obiect de tip Angajat pentru a afișa detaliile angajaților.
using System;

namespace ClassEmployees
{
    public class Angajat
    {
        // Variabile membru (câmpuri)
        private string nume;
        private double salariu;
        private string departamentul;

        // Constructor
        public Angajat(string nume, double salariu, string departamentul)
        {
            this.nume = nume;
            this.salariu = salariu;
            this.departamentul = departamentul;
        }

        // Metode
        public void AfisareDetalii()
        {
            Console.WriteLine("Nume: " + nume);
            Console.WriteLine("Salariu: " + salariu);
            Console.WriteLine("Departamentul: " + departamentul);
            Console.WriteLine();
        }
    }
    class СlassAngajat
    {
        static void Main()
        {
            Angajat persoana1 = new Angajat("John Doe", 3000, "RND");
            Angajat persoana2 = new Angajat("Carl Klephas", 2800, "Operational");
            Angajat persoana3 = new Angajat("Ivan Levinski", 2100, "Installation");

            persoana1.AfisareDetalii();
            persoana2.AfisareDetalii();
            persoana3.AfisareDetalii();
        }
    }
}
