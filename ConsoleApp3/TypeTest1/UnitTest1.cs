using ConsoleApp2;

namespace TypeTest1
{
    public class Tests
    {
        [Test]
        public void EmployeeDifferent()
        {

            var employee1 = GetEmployee ("Jarek", "Kowalski", 27);
            var employee2 = GetEmployee ("Zenek","Drewniak", 24);


            Assert.AreNotEqual(employee1,employee2);
        }
        [Test]
        public void NameDifferent()
        {
            string name1 = ("Jan");
            string name2 = ("Jan");
           

            Assert.AreEqual(name1,name2);
        }
        [Test]
        public void NumberDifferent()
        {
            int number1 = (32);
            int number2 = (32);

            Assert.AreEqual(number1, number2);

        }
        [Test]
        public void LessFloatNumber()
        {
            float number1 = (1.3f);
            float number2 = (2.3f);

            Assert.Less(number1, number2);

        }

        private Employee GetEmployee(string name, string surname, int age)
        {
        return new Employee(name, surname, age);
        }

    }
}