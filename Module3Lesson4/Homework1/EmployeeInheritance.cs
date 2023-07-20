//Tema: Utilizarea moștenirii de un nivel și apelul constructorului de bază:
//1.Creați o clasă de bază numită Angajat care să conțină următoarele proprietăți și metode:
//•	Proprietatea Nume pentru a reține numele angajatului.
//•	Metoda AfisareDetalii() pentru a afișa detaliile despre angajat.
//•	Un constructor cu un singur parametru pentru a inițializa numele angajatului.
//2.	Creați o clasă derivată din clasa Angajat numită Manager care să conțină o proprietate suplimentară numită Departament și să suprascrie metoda AfisareDetalii() pentru a include și detalii despre departament.
//•	În constructorul clasei Manager, utilizați base() pentru a apela constructorul de bază al clasei Angajat și pentru a inițializa numele angajatului.
//3.	Testați moștenirea și apelul constructorului de bază în funcția Main a programului.
//•	Creați un obiect de tip Manager și atribuiți-i numele și departamentul.
//•	Apelați metoda AfisareDetalii() pentru a afișa detaliile despre manager.
using Homework1;

class EmployeeInheritance
{
    static void Main()
    {
        Manager one = new Manager("Alexei", "Сynologist");
        one.ShowDetails();
    }
}