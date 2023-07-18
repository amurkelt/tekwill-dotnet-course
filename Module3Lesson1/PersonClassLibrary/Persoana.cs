public class Persoana
{
    public class Email
    {
        string address;
    }

    // Variabile membru (câmpuri)

    // Public -> Accesibil de catre oricine
    // Private -> Accesibil doar in interior clasei
    // Internal -> Accesibil de catre toti clienti
    // ce fac parte din acelasi proiect.

    private string _nume;
    private int varsta;

    // Constructor explicit
    public Persoana(string nume, int varsta)
    {
        _nume = nume;
        this.varsta = varsta;
    }
    public Persoana(string nume)
    {
        _nume = nume;
    }

    // Constructor implicit
    public Persoana()
    {
 
    }

    // Metode
    public void AfiseazaDetalii()
    {
        Console.WriteLine("Nume: " + _nume);
        Console.WriteLine("Varsta: " + varsta);
    }
}