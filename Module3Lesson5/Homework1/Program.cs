using Logger;

class Program
{
    public static void Main(string[] args)
    {
        const string filePath = @"C:\Users\ataras.INTHER\Desktop\Playground\tekwill-dotnet-course\Module3Lesson5\Homework1\loggs.txt";

        ILogger fileLogger = new FileLogger(filePath);
        ILogger consoleLogger = new ConsoleLogger();

        var paymentManagerFile = new PaymentManager(fileLogger);
        var paymentManagerConsole = new PaymentManager(consoleLogger);

        paymentManagerFile.ProcessPayment(200, "1234567891234567");
        paymentManagerConsole.ProcessPayment(200, "1234567891234567");

        paymentManagerFile.ProcessRefund(100, "3523");
        paymentManagerConsole.ProcessRefund(100, "3523");

        paymentManagerFile.RefundPayment(696, null);
        paymentManagerConsole.RefundPayment(696, null);

    }
}