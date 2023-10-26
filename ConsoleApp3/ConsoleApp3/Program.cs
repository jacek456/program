using ConsoleApp3;
using System.Reflection.Metadata;


Console.WriteLine("Witamy w programie oceny pracowników");
Console.WriteLine("======================================");
Console.WriteLine();   

var employee = new EmployeeInMemory("Adam", "Cebulski");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

employee.AddGrade(0.2f); 

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
        employee.AddGrade(input);
    }
    catch (Exception exception)
        {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"Avrage: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"AvrageLetter: {statistics.AverageLetter}");