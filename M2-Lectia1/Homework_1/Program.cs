// Tema: Calcularea mediei unui set de note
// 1.	Creați un program care să permită utilizatorului să introducă un 4 note.
// 2.	Utilizați un array sau o listă pentru a stoca notele.
// 3.	Calculează media notelor prin împărțirea sumei lor la numărul total de note.
// 4.	Utilizați gestionarea excepțiilor pentru a trata situațiile în care utilizatorul introduce note invalide (de exemplu, note negative sau mai mari decât 10).
// 5.   Aruncați o excepție personalizată în cazul în care se întâmpină o problemă și tratați-o corespunzător în blocul de prindere a excepțiilor.

class Pr
{
    static void Main()
    {        
        try
        {
            Console.Write("Introdu numarul de note n= ");
            int n = int.Parse(Console.ReadLine());

            var ListOfGrades = new double[n];
            double sumOfGrades = 0;
            Console.WriteLine("Introdu notele: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introdu nota {i + 1}: ");
                ListOfGrades[i] = double.Parse(Console.ReadLine());

                if (ListOfGrades[i] > 0 && ListOfGrades[i] <= 10)
                {
                    sumOfGrades += ListOfGrades[i];
                }
                else if (ListOfGrades[i] > 10)
                {
                    throw new Exception("Nota nu poate fi mai mare decat 10");
                }
                else
                {
                    throw new Exception("Nota nu poate fi negativa");
                }
            }
            double average = sumOfGrades / n;
            Console.WriteLine($"Media notelor notelor este: {average}");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }    
}