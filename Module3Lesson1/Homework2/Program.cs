// Bank Account:
// Un cont bancar poate apartinte unei singure persoane, fie ea fizica sau juridica. O persoana este identificată prin: codul de identificare fiscală (CIF) dacă e juridică, sau IDNP – dacă e persoană fizică.
// Contul bancar pastrează istoricul tranzactiilor și are următoarele caracteristici:
// - Data crearii
// - Persoana cui ii apartine
// - numarul contului
// - Moneda contului
// - PIN

// Pentru interactiunea cu contul bancar, el oferă 3 metode:
// - Determina sold – Calculează și returnează soldul curent, în baza tranzacțiilor înregistrate. 
// - Alimentare cont.
// - Extrage fond.

// Creați o persoană și un cont bancar care îi aparține. Creati căteva tranzacții (alimentare cont sau extragere fond) și afișați la ecran solul curent, după efectuarea tranzacțiilor.
// Notă: Istoricul tranzacțiilor trebuie să fie stocat.
using System;

namespace BankAccount
{
        public class ContBancar
        {
        // Variabile membru (câmpuri)
        public DateTime dataCrearii;
        public string persoana;
        public string numarulContului;
        public string monedaContului;
        public string pin;
        public double sold;
        public string[] istoria = new string[100];
        public string summa;
        public int counter = 0;

        // Constructor
        public ContBancar(DateTime dataCrearii, string persoana, string numarulContului, string monedaContului, string pin, double sold)
        {
            this.dataCrearii = dataCrearii;
            this.persoana = persoana;
            this.numarulContului = numarulContului;
            this.monedaContului = monedaContului;
            this.pin = pin;
            this.sold = sold;            
        }

        // Metode
        public void AlimentareCont()
        {            
            Console.WriteLine($"Introdu summa in {monedaContului} pentru alimentare cont: ");
            summa = Console.ReadLine();
            sold = sold + double.Parse(summa);                       
            istoria[counter] = ($"Alimentare cont  -  {summa} {monedaContului}");
            Console.WriteLine();
            counter++;
        }
        public void ExtragereaFond()
        {            
            Console.WriteLine($"Introdu summa in {monedaContului} pentru extragerea fond: ");
            summa = Console.ReadLine();
            sold = sold - double.Parse(summa);            
            istoria[counter] = ($"Extragerea fond  -  {summa} {monedaContului}");
            counter++;
            Console.WriteLine();
        }
        public void DeterminareaSold()
        {
            Console.WriteLine("Istoricul tranzactiilor: ");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(istoria[i]);
            }
            Console.WriteLine($"Soldul curent este: {sold} {monedaContului}");
        }
    }

    class Program
    {
        static void Main()
        {
            ContBancar persoana = new ContBancar(DateTime.Now, "John Doe", "123456", "EUR", "4321", 0);
            persoana.AlimentareCont();
            persoana.ExtragereaFond();
            persoana.AlimentareCont();
            persoana.DeterminareaSold();
        }
    }
}
