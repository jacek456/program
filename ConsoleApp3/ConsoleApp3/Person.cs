
namespace ConsoleApp3
{
    public abstract class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }
        public Person(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }
        public Person(string name, string surname, char sex)
        {
            this.Name = name;
            this.SurName = surname;
            this.sex = sex;
        }
        public string Name { get;private set; }
        public string SurName { get;private set; }
        public char sex { get; private set; }
    }
}
