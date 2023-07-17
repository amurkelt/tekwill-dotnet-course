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
        public class BankAccountClass
        {
        // Variabile membru (câmpuri)
        public DateTime creationDate;
        public string person;
        public string accountNumber;
        public string currency;
        public string pin;
        public double balance;
        public string[] transactionHistory = new string[100];
        public string transaction;
        public int transactionsCounter = 0;

        // Constructor
        public BankAccountClass(DateTime creationDate, string person, string accountNumber, string currency, string pin, double balance)
        {
            this.creationDate = creationDate;
            this.person = person;
            this.accountNumber = accountNumber;
            this.currency = currency;
            this.pin = pin;
            this.balance = balance;            
        }

        // Metode
        public void Deposit()
        {            
            Console.WriteLine($"Introdu summa in {currency} pentru alimentare cont: ");
            transaction = Console.ReadLine();
            balance = balance + double.Parse(transaction);                       
            transactionHistory[transactionsCounter] = ($"{DateTime.Now} Alimentare cont  -  {transaction} {currency}");
            Console.WriteLine();
            transactionsCounter++;
        }
        public void Withdrawl()
        {            
            Console.WriteLine($"Introdu summa in {currency} pentru extragerea fond: ");
            transaction = Console.ReadLine();
            balance = balance - double.Parse(transaction);            
            transactionHistory[transactionsCounter] = ($"{DateTime.Now} Extragerea fond  -  {transaction} {currency}");
            transactionsCounter++;
            Console.WriteLine();
        }
        public void showBalance()
        {
            Console.WriteLine("Istoricul tranzactiilor: ");
            for (int i = 0; i < transactionsCounter; i++)
            {
                Console.WriteLine(transactionHistory[i]);
            }
            Console.WriteLine($"{DateTime.Now} Soldul curent este: {balance} {currency}");
        }
    }

    class BankAccount
    {
        static void Main()
        {
            BankAccountClass person = new BankAccountClass(DateTime.Now, "John Doe", "123456", "EUR", "4321", 0);
            person.Deposit();
            person.Withdrawl();
            person.Deposit();
            person.showBalance();
        }
    }
}
