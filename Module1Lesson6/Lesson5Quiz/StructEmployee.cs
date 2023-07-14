struct Employee
{
    public string name;
    public double salary;
}

public class StructEmployee
{
    static void Main()
    {
        var angajat1 = new Employee
        {
            name = "Ion",
            salary = 2500
        };

        var angajat2 = angajat1;

        angajat2.salary = 3000;

        Console.WriteLine(angajat1.salary);
        Console.WriteLine(angajat2.salary);
    }
}
