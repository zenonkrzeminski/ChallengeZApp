// Program wyszukuje pracownika z najwyższą liczbą ocen
// a następnie wyświetla jego dane oraz wyniki

using ChallengeZApp;

Employee employee1 = new ("Oberyn", "Martell", 40);
Employee employee2 = new ("Tyrion", "Lannister", 32);
Employee employee3 = new ("Eddard", "Stark", 41);

List<Employee> employees = new()
{
    employee1, employee2, employee3
};

employee1.AddScore(9);
employee1.AddScore(8);
employee1.AddScore(9);
employee1.AddScore(10);
employee1.AddScore(7);

employee2.AddScore(7);
employee2.AddScore(8);
employee2.AddScore(6);
employee2.AddScore(10);
employee2.AddScore(4);

employee3.AddScore(3);
employee3.AddScore(8);
employee3.AddScore(2);
employee3.AddScore(10);
employee3.AddScore(1);

int maxResult = -1;
Employee employeeWithMaxResult = null;
foreach (var employee in employees)
{
    if (employee.Result > maxResult) 
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee; 
    }
}

Console.WriteLine($"\tNajwyższą liczbę ocen o sumie równej: {maxResult}\n\tosiągnął: {employeeWithMaxResult.Name} {employeeWithMaxResult.Surename}, wiek {employeeWithMaxResult.Age}\n");

Console.WriteLine("Wyniki pracowników:");
foreach (var employee in employees)
{
    var result = employee.Result;
    Console.WriteLine($"\t{employee.Name} {employee.Surename}, wiek {employee.Age}, suma ocen: {result}");
}