using ChallengeZApp;

var employee = new Employee("Oberyn", "Martell");

employee.AddGrade(1);
employee.AddGrade(3);
employee.AddGrade(4);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}\n");