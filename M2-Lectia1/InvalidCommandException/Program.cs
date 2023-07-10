using System;

class Program
{
    static void Main()
    {
        try
        {
            // Simulăm procesarea comenzii
            ProcesareComanda();
        }
        catch (ComandaInvalidaException ex)
        {
            Console.WriteLine("Eroare: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Eroare neprevăzută: " + ex.Message);
        }
    }

    static void ProcesareComanda()
    {
        Console.Write("Introduceți numărul comenzii: ");
        int numarComanda = int.Parse(Console.ReadLine());

        // Simulăm validarea comenzii
        if (numarComanda <= 0)
        {
            throw new ComandaInvalidaException("Numărul comenzii nu este valid.");
        }

        // Simulăm procesarea comenzii
        Console.WriteLine("Comanda " + numarComanda + " a fost procesată cu succes.");
    }
}

class ComandaInvalidaException : Exception
{
    public ComandaInvalidaException(string message) : base(message)
    {
    }
}
