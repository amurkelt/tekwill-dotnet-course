//Ex 3: Utilizare array bidimensional
//1.	Creați un program care să stocheze și să afișeze o matrice reprezentând o tablă de șah.
//2.	Utilizați un array bidimensional pentru a reprezenta tablă de șah.
//3.	Atribuiți valori corespunzătoare celulelor albe și negre în tablă (1 – alb, 0 – negru)
//4.    Afișați tablă de șah la ecran.
class ChessBoard
{
    static void Main()
    {
        int nrLinii = 8;
        int nrColoane = 8;

        int[,] matrice = new int[nrLinii, nrColoane];
        
        for (int i = 0; i < matrice.GetLength(0); i++) 
        { 
           for (int j = 0; j < matrice.GetLength(1); j++)
            {
                if ((i + j) % 2 == 0 )
                {
                    matrice[i, j] = 1; // celula alba
                }
           }
        }

        // Afisarea la ecran
        for (int i = 0; i < matrice.GetLength(0); i++)
        {
            for (int j = 0; j < matrice.GetLength(1); j++)
            {
                Console.Write(matrice[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
