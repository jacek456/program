string name = "Ewa";
string sex = "Kobieta";
int age = 33;
if (age <= 30 && sex == "Kobieta")
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)

{
    Console.WriteLine("ewa lat 33");
}
else if (age < 18 && sex == "mężczyzna")
{
    Console.WriteLine("nie pełnoletni mężczyzna");
}
