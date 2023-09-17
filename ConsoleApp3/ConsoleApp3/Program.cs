string imie = "Ewa";
int wiek = 33;
string płeć = "Kobieta";
if (wiek <= 30 && płeć == "Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30lat");
}
else if (imie == "Ewa" && wiek == 33) 
{
    Console.WriteLine("Ewa lat 33");
}
else if (płeć == "mężczyzna" && wiek <18)
{
    Console.WriteLine("Jestem młodym mężczyzną");
}