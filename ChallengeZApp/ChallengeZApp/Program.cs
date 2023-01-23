// Program z losowej listy 20 imion wyświetla:
// - każde unikalne imię
// - podaje w jakiej ilości dane imię występuje

using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

List<string> diary = new List<string>()
{ "Adam", "Monika", "Arek", "Adam", "Monika", "Arek", "Zenon", "Marek", "Eliza", "Adam", "Adam", "Adam", "Monika", "Arek", "Adam", "Monika", "Adam", "Monika", "Arek", "Adam" };

Console.WriteLine("PD+ - dzień 5");
Console.WriteLine($"Osób łącznie: {diary.Count}.\nKażde imię powtarza się:");

byte repeat = 0;
List<string> diaryWithoutRepeats = new List<string>();

foreach (var name in diary)
{
    foreach (var name2 in diary)
    {
        if (name == name2) repeat++;
    }
    if (!diaryWithoutRepeats.Contains(name))
    {
        diaryWithoutRepeats.Add(name);
        Console.WriteLine($"{repeat} razy - imię {name}");
    }
    repeat = 0;
}



// Program sprawdza ile i jakich cyfr występuje w danej liczbie.

Console.WriteLine("\nPD - dzień 5");

int checkedumber = 19711;
string numberInString = checkedumber.ToString();
char[] letters = numberInString.ToArray();

Console.WriteLine($"W liczbie {checkedumber} występują cyfry:");

byte repeatLetter = 0;

List<char> numbers = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

foreach (var number in numbers)
{
    foreach (var letter in letters)
    {
        if (letter == number) repeatLetter++;
    }
    Console.WriteLine($"{number} => {repeatLetter} razy");
    repeatLetter = 0;
}