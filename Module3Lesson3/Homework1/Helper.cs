namespace Homework1
{
    internal static class Helper
    {
        public static string GenerateUniqueCode(string prefix)
        {
            return prefix + new Random().Next(0, 10000);
        }
    }
}
