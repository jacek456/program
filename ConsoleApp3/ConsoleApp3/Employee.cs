using ConsoleApp3;

namespace ConsoleApp3
{
    public class Employee
    {
        private List<float> grandes = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }
        public string Name { get; private set; }
        public string SurName { get; private set; }

        public void AddGrade(float grade)
        {
            this.grandes.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grandes)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grandes.Count;
            return statistics;
        }
    }
}
