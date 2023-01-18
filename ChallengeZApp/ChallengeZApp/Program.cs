// Program sprawdzający płeć, wiek i pełnoletność.
// Na koniec kawlifikujący do jednej z grup:
// (1) osób pełnoletnich poniżej 30 lat "z rozróżnieniem płci"
// (2) osób pełnoletnich powyżej 30 lat "z podaniem imienia i wieku"
// (3) osób niepełnoletnim "z rozróżnieniem płci"

// Wprowadzone dane:
string name = "Eddard";
string gender = "Mężczyzna";
int age = 54;

Console.WriteLine("Osoba kwalifikuje się do grupy:");

if (age >= 30)
{
    Console.WriteLine($"(2): \"{name}, lat {age}\"");
}
else if (age < 18)
{
    if (gender == "Mężczyzna")
    {
        Console.WriteLine($"(3): \"Niepełnoletni mężczyzna\"");
    }
    else
    {
        Console.WriteLine($"(3): \"Niepełnoletnia kobieta\"");
    }
}
else
{
    if (gender == "Mężczyzna")
    {
        Console.WriteLine($"(1): \"Mężczyzna poniżej 30 lat\"");
    }
    else
    {
        Console.WriteLine($"(1): \"Kobieta poniżej 30 lat\"");
    }
}
