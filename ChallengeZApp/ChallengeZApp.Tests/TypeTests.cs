namespace ChallengeZApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ComparisonString()
        {
            string name1 = "Zenek";
            string name2 = "Zenek";

            Assert.AreEqual(name1, name2);
        }

        [Test]
        public void ComparisonValueTypesIntegralTypes()
        {
            int number1 = 1;
            int number2 = 2;

            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void ComparisonValueTypesFloatingPointTypes()
        {
            float number3 = 3.2f;
            float number4 = 3.2f;

            Assert.AreEqual(number3, number4);
        }

        [Test]
        public void GetEmployeeShouldReturnDiffrentObjects()
        {
            var employee1 = GetEmployee("Oberyn");
            var employee2 = GetEmployee("Tyrion");

            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void GetEmployeeLoginShouldReturnSameObjects()
        {
            var employee3 = GetEmployee("Oberyn");
            var employee4 = GetEmployee("Oberyn");

            Assert.AreEqual(employee3.Name, employee4.Name);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
