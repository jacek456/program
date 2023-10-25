using ConsoleApp3;

namespace TypeTests
{
    public class Tests  
    {
        [Test]
        public void CheckingTheMaximumValue()
        {
            var employee = new EmployeeInFile("Jan", "Cebulski");
            employee.AddGrade('B');
            employee.AddGrade('c');
            employee.AddGrade('a');
            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
        }
        [Test]
        public void CheckingTheMinimumValue()
        {
            var employee = new Supervisor("Jan", "Cebulski");
            employee.AddGrade("3");
            employee.AddGrade("5-");
            employee.AddGrade("1");
            var statistics = employee.GetStatistics();

            Assert.AreEqual(0, statistics.Min);
        }
        [Test]
        public void CheckingTheAverageValue()
        {
           var employee = new Supervisor("Jan", "Cebulski");
            employee.AddGrade("4-");
            employee.AddGrade("+2");
            employee.AddGrade(34);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(38.0f, statistics.Average);
        }

      
    }
}