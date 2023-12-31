﻿using System.Globalization;

class DataTypeDateTime
{
    static void Main()
    {
        var s = System.DateTime.UnixEpoch;

        Console.WriteLine($"UTC Date time (Greenwhich): {System.DateTime.UtcNow}");
        Console.WriteLine($"Local time (Chisinau): {System.DateTime.Now}");

        var yesterday = new System.DateTime(2023, 6, 27, 7, 20, 30);
        var tomorrow = new System.DateTime(2023, 6, 29, 7, 20, 30);

        TimeSpan timeInterval = tomorrow - yesterday;

        Console.WriteLine(timeInterval.Days);

        // yyyy/MM/ddThh:mm:ss
        // 2023/01/02T12:12:12

        // yyyy-MM-dd hh:mm:ss
        Console.WriteLine("Introdu data nasterii : ");

        var dataNasterii = System.DateTime.ParseExact(
            "2023-01-01 09:09:09",
            "yyyy-MM-dd hh:mm:ss",
            CultureInfo.InvariantCulture);

        Console.WriteLine(dataNasterii);
    }
}