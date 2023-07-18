using System.Runtime.ConstrainedExecution;

public class Program
{
    static void Main()
    {
        var persoana = new Persoana("Andrei", 30);
        var persoana2 = new Persoana();

        persoana.AfiseazaDetalii();
        Console.WriteLine();
        var email = new Persoana.Email();        

        Cerc cr = new Cerc(); //crearea unui exemplar al clasei Cerc
                              //Apelul constantei clasei Cerc
        Console.WriteLine("pi = {0}", Cerc.pi);
        //Apel la cimpul static al clasei Cerc
        Console.Write(Cerc.name);
        //Apel la cimpurile obisnuite ale clasei Cerc
        Console.WriteLine(" cu centrul in punctul ({0},{1}) si raza {2}", cr.x, cr.y, cr.raza);
        Console.WriteLine("are aria = {0}", cr.Aria());
        //Stabilim valori noi pentru cimpurile obiectului cr
        cr.Set(1, 1, 10);
        Console.WriteLine("\nCerc nou cu centrul in punctul ({0},{1}) si raza {2}", cr.x, cr.y, cr.raza);
        Console.WriteLine("are aria = {0}", cr.Aria());
        //Obtinem o referinta la obiectul cr, analogul b=c
        Cerc b = cr.Acest();
        Console.WriteLine("\nCerc nou cu centrul in punctul ({0},{1}) si raza {2}", b.x, b.y, b.raza);
        Console.WriteLine("are aria = {0}", b.Aria());
    }
}