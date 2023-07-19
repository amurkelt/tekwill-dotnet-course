//Tema: Utilizarea constructorului de copiere într-o clasă.
//1.	Creați o clasă numită Student care să reprezinte informații despre un student.
//2.	Adăugați următoarele proprietăți la clasa Student:
//•	Nume - pentru a reține numele studentului
//•	Varsta - pentru a reține vârsta studentului
//•	Specializare - pentru a reține specializarea studentului
//3.	Implementați un constructor cu parametri în clasa Student care să primească argumente pentru nume, vârstă și specializare și să le atribuie proprietăților corespunzătoare.
//4.	Implementați un constructor de copiere în clasa Student care să primească un obiect Student și să creeze o copie a acestuia.
//5.	Adăugați o metodă numită AfisareDetalii în clasa Student care să afișeze toate detaliile studentului.
//6.	Testați constructorul de copiere în funcția Main a programului.
//•	Creați un obiect de tip Student și atribuiți-i valorile pentru nume, vârstă și specializare.
//•	Creați un nou obiect de tip Student utilizând constructorul de copiere și atribuiți-i obiectului anterior.
//•	Modificați valorile proprietăților obiectului original și apoi afișați detaliile ambelor obiecte folosind metoda AfisareDetalii.
using Homework3;

public class Program
{
    static void Main()
    {
        var student1 = new Student()
        {
            name = "Ion",
            age = 21,
            specialization = "Informatica"
        };
        student1.ShowDetails();
        Console.WriteLine();

        var student2 = new Student(student1);
        student2.ShowDetails();
        Console.WriteLine();

        student1.name = "Vasilii";
        student1.age = 88;
        student1.specialization = "Sudor";

        student1.ShowDetails();
        Console.WriteLine();

        student2.ShowDetails();
    }
}