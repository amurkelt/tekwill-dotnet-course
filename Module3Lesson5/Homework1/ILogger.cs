namespace Logger
{
    internal interface ILogger
    {
        public void LogInformation(string message);
        public void LogWarning(string message);
        public void LogError(string message);
    }
}