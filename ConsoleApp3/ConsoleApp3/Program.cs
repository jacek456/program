using ConsoleApp3;
using System.Reflection.Metadata;

var employee = new Employee("Adam", "Cebulski");
employee.AddGrade("Koń");
employee.AddGrade("457");
employee.AddGrade(888);
employee.AddGrade(6f);
employee.AddGrade(4);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");