//Tema: Utilizarea proprietăților și metodelor într-o clasă.
//1.	Creați o clasă numită Carte care să reprezinte informații despre o carte.
//2.	Adăugați următoarele proprietăți la clasa Carte:
//•	Titlu - pentru a reține titlul cărții
//•	Autor - pentru a reține numele autorului cărții
//•	AnPublicare - pentru a reține anul de publicare al cărții
//•	NumarPagini - pentru a reține numărul de pagini al cărții
//3.	Implementați un constructor cu parametri în clasa Carte care să primească argumente pentru titlu, autor, anul de publicare și numărul de pagini și să le atribuie proprietăților corespunzătoare.
//4.	Adăugați o metodă numită AfisareDetalii în clasa Carte care să afișeze toate detaliile cărții.
//5.	Testați clasa Carte în funcția Main a programului.
//•	Creați un obiect de tip Carte, specificând valorile pentru titlu, autor, anul de publicare și numărul de pagini.
//•	Apelați metoda AfisareDetalii pentru a afișa detaliile cărții.
using Homework2;

class BookShelf
{
    static void Main()
    {
        var newbook = new Book()
        {
            Title = "Fascinating Sci-Fi",
            Author = "Luke Skywalker",
            Year = DateOnly.FromDateTime(DateTime.Now),
            Pages = 243
        };
        newbook.ShowDetails();
    }
}