using ConsoleApp3;
using System.Reflection.Metadata;

//var employee = new Employee("Adam", "Cebulski");
//employee.AddGrade("23");
//employee.AddGrade("45");
//employee.AddGrade(888);
//employee.AddGrade(6f);
//employee.AddGrade('A');
//var statistics = employee.GetStatistics();

//Console.WriteLine($"Average: {statistics.Average}");
//Console.WriteLine($"Max: {statistics.Max}");
//Console.WriteLine($"Min: {statistics.Min}");
//Console.WriteLine(statistics.AverageLetter);

Console.WriteLine("Witamy w programie oceny pracowników");
Console.WriteLine("======================================");
Console.WriteLine();   

var employee = new Employee("Adam", "Cebulski");

while (true)
{
    Console.WriteLine("Podaj ocene pracownika");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Avrage: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AvrageLetter: {statistics.AverageLetter}");