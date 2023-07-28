namespace Logger
{
    internal class FileLogger : ILogger
    {
        private string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }

        public void LogInformation(string message)
        {
            LogMessage("Log level - Information.", message);
        }
        public void LogWarning(string message)
        {
            LogMessage("Log level - Warning.", message);
        }
        public void LogError(string message)
        {
            LogMessage("Log level - Error.", message);
        }
        private void LogMessage(string logLevel, string message)
        {
            try
            {
                string logEntry = $"{logLevel} {DateTime.Now:yyyy-MM-dd HH:mm:ss} {message}";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to log message: {ex.Message}");
            }
        }
    }
}
