using ConsoleApp3;
using System.Reflection.Metadata;


Console.WriteLine("Witamy w programie oceny pracowników");
Console.WriteLine("======================================");
Console.WriteLine();   

var supervisor = new Supervisor("Adam", "Cebulski");

while (true)
{
    Console.WriteLine("Podaj ocene pracownika");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception exception)
        {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
}

var statistics = supervisor.GetStatistics();
Console.WriteLine($"Avrage: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AvrageLetter: {statistics.AverageLetter}");