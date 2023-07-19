namespace Homework1
{
    internal static class Helper
    {
        public static string GenerateUniqueCode(string prefix)
        {
            var random = new Random();
            int randomNumber = random.Next();
            return $"{prefix}{randomNumber}";
        }
    }
}
