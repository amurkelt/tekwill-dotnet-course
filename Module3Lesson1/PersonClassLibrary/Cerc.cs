public class Cerc
{
    public int x = 0;
    public int y = 0;
    public int raza = 5;
    public const double pi = 3.14;
    public static string name = "Cerc";
    public Cerc Acest()
    {
        return this;
    }
    public void Set(int x, int y, int r)
    {
        this.x = x;
        this.y = y;
        raza = r;
    }
    //Metoda ce va calcula aria cercului
    public double Aria()
    {
        return pi * raza * raza;
    }
}