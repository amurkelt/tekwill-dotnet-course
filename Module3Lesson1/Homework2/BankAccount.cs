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
using Homework2;
using System;

namespace BankAccount
{
        public class BankAccountClass
        {
        // Variabile membru (câmpuri)
        public readonly DateTime creationDate;
        public string person;
        public readonly string accountNumber;
        public string currency;
        public string pin;
        public decimal suma;
        private List<Tranzactie> istoricTranzactii;

        // Constructor
        public BankAccountClass(string person, string accountNumber, string currency, string pin)
        {
            this.person = person;
            this.accountNumber = accountNumber;
            this.currency = currency;
            this.pin = pin;

            istoricTranzactii = new List<Tranzactie>();
            creationDate = DateTime.UtcNow;
        }

        // Metode
        public void Deposit()
        {            
            Console.Write($"Introdu summa in {currency} pentru alimentare cont: ");
            suma = decimal.Parse(Console.ReadLine());
            var tranzactie = new Tranzactie(suma);
            istoricTranzactii.Add(tranzactie);
                        
            Console.WriteLine($"Soldul curent: {showBalance()}");
            Console.WriteLine();
        }
        public void Withdrawl()
        {            
            Console.Write($"Introdu summa in {currency} pentru extragerea fond: ");
            suma = decimal.Parse(Console.ReadLine());
            var tranzactie = new Tranzactie(suma);
            istoricTranzactii.Add(tranzactie);

            Console.WriteLine($"Soldul curent: {showBalance()}");
            Console.WriteLine();
        }
        public decimal showBalance()
        {
            return istoricTranzactii.Sum(t => t.suma);
        }
    }

    class BankAccount
    {
        static void Main()
        {
            BankAccountClass person = new BankAccountClass("John Doe", "123456", "EUR", "4321");
            person.Deposit();
            person.Withdrawl();
            person.Deposit();
        }
    }
}
