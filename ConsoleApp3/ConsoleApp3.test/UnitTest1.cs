using ConsoleApp2;
using static System.Formats.Asn1.AsnWriter;

namespace ConsoleApp3.test
{
    public class Tests

    {
        [Test]
        public void WhenAnEmployeeScoresOnlyPositivePoints()
        {

            var employee = new Employee("Jarek", "Kowalski", 27);
            employee.AddScore(5);
            employee.AddScore(8);
            employee.AddScore(3);
            employee.AddScore(6);

            var result = employee.Result;

            Assert.AreEqual(22, result);
        }
        [Test]
        public void WhenAnEmployeeScoresPositiveAndNegativePoints()
        {

            var employee = new Employee("Roman", "Kostka", 37);
            employee.AddScore(5);
            employee.AddScore(8);
            employee.AddScore(-10);
            employee.AddScore(3);
            employee.AddScore(6);

            var result = employee.Result;

            Assert.AreEqual(12, result);
        }
        [Test]
        public void WhenAnEmployeeScoresOnlyNegativePoints()
        {

            var employee = new Employee("Jan", "Bela", 47);
            employee.AddScore(-5);
            employee.AddScore(-8);
            employee.AddScore(-10);
            employee.AddScore(-3);
            employee.AddScore(-6);

            var result = employee.Result;

            Assert.AreEqual(-32, result);
        }
    }
}