using ConsoleApp3;
using System.Reflection.Metadata;

var employee = new Employee("Adam", "Cebulski");
employee.AddGrade("Koń");
employee.AddGrade("457");
employee.AddGrade(888);
employee.AddGrade(6f);
employee.AddGrade(4);
var statistics1 = employee.GetStatisticsWithDoWhile();
var statistics2 = employee.GetStatisticsWithWhile();
var statistics3 = employee.GetStatisticsWithForeach();
var statistics4 = employee.GetStatisticsWithFor();
Console.WriteLine($"Average: {statistics1.Average}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}");

Console.WriteLine($"Average: {statistics2.Average}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Min: {statistics2.Min}");

Console.WriteLine($"Average: {statistics3.Average}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Min: {statistics3.Min}");

Console.WriteLine($"Average: {statistics4.Average}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Min: {statistics4.Min}");