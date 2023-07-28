namespace Logger
{
    internal class ConsoleLogger : ILogger
    {
        public void LogInformation(string message)
        {
            Console.WriteLine($"Log level - Information. {message}");
        }
        public void LogWarning(string message)
        {
            Console.WriteLine($"Log level - Warninig. {message}");
        }
        public void LogError(string message)
        {
            Console.WriteLine($"Log level - Error. {message}");
        }
    }
}