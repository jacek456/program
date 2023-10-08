using ConsoleApp3;
using System.Reflection.Metadata;

var employee = new Employee("Adam", "Cebulski");
employee.AddGrade(1);
employee.AddGrade(8);
employee.AddGrade(6);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");