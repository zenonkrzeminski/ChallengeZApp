namespace ChallengeZApp
{
    public class Employee
    {
        private List<int> score = new ();

        public Employee(string name, string surename,int age)
        {
            this.Name = name;
            this.Surename = surename;
            this.Age = age;
        }
        public Employee(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
        public string Surename { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}