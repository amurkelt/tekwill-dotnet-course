//Tema: Utilizarea moștenirii în mai multe nivele în C#:
//1.	Creați o clasă de bază numită Animal care să conțină următoarele proprietăți și metode:
//•	Proprietatea Nume pentru a reține numele animalului.
//•	Metoda AfisareDetalii() pentru a afișa detaliile despre animal.
//2.	Creați două clase derivate din clasa Animal: Mamifer și Pasare.
//•	Clasa Mamifer trebuie să conțină o proprietate suplimentară numită CuloareBlana și să suprascrie metoda AfisareDetalii() pentru a include și detalii despre culoarea blănii.
//•	Clasa Pasare trebuie să conțină o proprietate suplimentară numită TipZbor și să suprascrie metoda AfisareDetalii() pentru a include și detalii despre tipul de zbor.
//3.	Creați o clasă derivate din clasa Pasare numită Papagal care să conțină o proprietate suplimentară numită Vocabular și să suprascrie metoda AfisareDetalii() pentru a include și detalii despre vocabularul papagalului.
//4.	Testați moștenirea în mai multe nivele în funcția Main a programului.
//•	Creați un obiect de tip Mamifer și atribuiți-i nume și culoarea blănii.
//•	Creați un obiect de tip Pasare și atribuiți-i nume și tipul de zbor.
//•	Creați un obiect de tip Papagal și atribuiți-i nume, tipul de zbor și un vocabular.
//•	Apelați metoda AfisareDetalii() pentru fiecare obiect pentru a afișa detaliile despre acestea.

using Homework2;

class AnimalInheritance
{
    static void Main()
    {
        Mammal kangaroo = new Mammal("Jakie", "Ginger"); 
        kangaroo.ShowDetails();
        Console.WriteLine();

        Bird owl = new Bird("Hedwig", "Gliding flight");
        owl.ShowDetails();
        Console.WriteLine();

        Parrot macaw = new Parrot("Captain Henry Jr.", "Flapping flight", "Spanish");
        macaw.ShowDetails();
    }
}