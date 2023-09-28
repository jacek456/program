using ConsoleApp2;
using System.Reflection.Metadata;
Employee employee1 = new Employee("Jarek", "Kowalski", 27);
Employee employee2 = new Employee("Basia", "Lalik", 48);
Employee employee3 = new Employee("Zbyszek", "Nowak", 36);

employee1.AddScore(5);
employee1.AddScore(7);
employee1.AddScore(4);
employee1.AddScore(2);
employee1.AddScore(3);

employee2.AddScore(6);
employee2.AddScore(2);
employee2.AddScore(8);
employee2.AddScore(9);
employee2.AddScore(2);

employee3.AddScore(1);
employee3.AddScore(6);
employee3.AddScore(2);
employee3.AddScore(7);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
    employee1,employee2,employee3
};
int maxResult = -1;
Employee? employeeWithMaxResult = null;
foreach(Employee employee in employees)
    {
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}
Console.WriteLine("Najlepszy wynik ma " + employeeWithMaxResult?.Name + " " + employeeWithMaxResult?.Surname + " zdobył " + employeeWithMaxResult.Result + " punktów");
