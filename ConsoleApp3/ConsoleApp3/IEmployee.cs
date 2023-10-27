using static ConsoleApp3.EmployeeBase;

namespace ConsoleApp3
{
    public interface IEmployee
    {
        string Name { get; }
        string Surname { get; }
        void AddGrade(float grade);
        void AddGrade(int grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(char grade);
        void AddGrade(string grade);

        event GradeAddedDelegate GradeAdded;
        public Statistics GetStatistics();
    }
}
