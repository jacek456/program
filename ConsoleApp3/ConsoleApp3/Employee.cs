namespace ConsoleApp2
{
    public class Employee
    {
        public string Name;
        public string Surname;
        public int Age;
        public int Result
        {
            get
            {
                return score.Sum();
            }
        }
        List<int> score = new List<int>();
        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;


        }

        public void AddScore(int points)
        {
            this.score.Add(points);
        }
    }
}
