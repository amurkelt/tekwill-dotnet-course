namespace Homework2
{
    internal class Tranzactie
    {
        public DateTime data;
        public decimal suma;

        public Tranzactie(decimal suma)
        {
            data = DateTime.UtcNow;
            this.suma = suma;
        }
    }
}
