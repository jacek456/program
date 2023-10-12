using ConsoleApp3;

namespace TypeTests
{
    public class Tests  
    {
        [Test]
        public void CheckingTheMaximumValue()
        {
            var employee = new Employee("Jan", "Cebulski");
            employee.AddGrade('C');
            employee.AddGrade('A');
            employee.AddGrade('b');
            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
        }
        [Test]
        public void CheckingTheMinimumValue()
        {
            var employee = new Employee("Jan", "Cebulski");
            employee.AddGrade(7);
            employee.AddGrade('e');
            employee.AddGrade("-1");
            var statistics = employee.GetStatistics();

            Assert.AreEqual(7, statistics.Min);
        }
        [Test]
        public void CheckingTheAverageValue()
        {
           var employee = new Employee("Jan", "Cebulski");
            employee.AddGrade('b');
            employee.AddGrade("155");
            employee.AddGrade(34);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(57.0f, statistics.Average);
        }

      
    }
}