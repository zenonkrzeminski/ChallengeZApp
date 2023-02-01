namespace ChallengeZApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surename { get; private set; }

        public Employee(string name, string surename)
        {
            this.Name = name;
            this.Surename = surename;
        }

        private List<float> grades = new();
        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}