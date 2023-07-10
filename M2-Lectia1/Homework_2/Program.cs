// Tema: Validarea datelor de autentificare
// 1.	Creați un program care să simuleze un proces de autentificare.
// 2.	Solicitați utilizatorului să introducă un nume de utilizator și o parolă.
// 3.	Realizați diverse verificări asupra datelor de autentificare:
//   •	Verificați dacă numele de utilizator este gol sau dacă parola este prea scurtă.
//   •	Verificați dacă parola conține cel puțin o literă mare, o literă mică și un număr.
//   •	Verificați dacă numele de utilizator și parola corespund cu o pereche validă dintr-o bază de date simulată.
// 4.	Aruncați excepții specifice pentru fiecare caz de validare eșuată (de exemplu, NumeUtilizatorGolException, ParolaPreaScurtaException, ParolaInvalidaException, CredentialeInvalideException).
// 5.   Prindeți și gestionați corespunzător fiecare excepție aruncată, afișând un mesaj de eroare corespunzător la ecran.
using System;

class Program
{
    struct UserCredentials
    {
        public string name;
        public string password;
    }
    static void Main()
    {
        var dataBase = new UserCredentials[]
        {
            new UserCredentials() { name = "Balaur14", password = "Parola1" },
            new UserCredentials() { name = "IosifIntai", password = "Parola2!" },
            new UserCredentials() { name = "FlexRicardo", password = "PAROOOks1" },
        };

         Console.WriteLine("Introduceti nume de utilizator si parola: ");
         string userName = Console.ReadLine();
         string userPassword = Console.ReadLine();
         bool found = false;

        try
        {
            foreach (var user in dataBase)
            {
                if (user.name.ToUpper() == userName.ToUpper() && user.password.ToUpper() == userPassword.ToUpper())
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                throw new InvalidCredentialsException("Credentiale Invalide");
            }

            NameValidation(userName);
            Console.WriteLine("Nume de utilizator este valid!");
            PasswordValidation(userPassword);
            Console.WriteLine("Parola este valida!");
        }
        catch (UserNameNullException ex)
        {
            Console.WriteLine($"Eroare: {ex.Message}");
        }
        catch (PasswordTooShortException ex)
        {
            Console.WriteLine($"Eroare: {ex.Message}");
        }
        catch (InvalidPasswordException ex)
        {
            Console.WriteLine($"Eroare: {ex.Message}");
        }
        catch (InvalidCredentialsException ex)
        {
            Console.WriteLine($"Eroare: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("S-a produs o eroare necunoscuta");
        }
    }
    static void NameValidation(string? userName)
    {
        if (userName is null)
        {
            throw new UserNameNullException("Nume nu poate fi gol");
        }
    }

    static void PasswordValidation(string? userPassword)
    {
        if (userPassword.Length < 6)
        {
            throw new PasswordTooShortException("Lungimea minima parolei este 6 caractere");
        }

        if (!userPassword.Any(c => char.IsUpper(c)))
        {
            throw new InvalidPasswordException("Parola trebuie sa contina macar o litera mare");
        }

        if (!userPassword.Any(c => char.IsLower(c)))
        {
            throw new InvalidPasswordException("Parola trebuie sa contina macar o litera mica");
        }

        if (!userPassword.Any(c => char.IsDigit(c)))
        {
            throw new InvalidPasswordException("Parola trebuie sa contina macar o cifra");
        }
    }
}

class UserNameNullException : Exception
{
    public UserNameNullException(string message) : base(message)
    {
    }
}
class PasswordTooShortException : Exception
{
    public PasswordTooShortException(string message) : base(message)
    {
    }
}
class InvalidPasswordException : Exception
{
    public InvalidPasswordException(string message) : base(message)
    {
    }
}
class InvalidCredentialsException : Exception
{
    public InvalidCredentialsException(string message) : base(message)
    {
    }
}