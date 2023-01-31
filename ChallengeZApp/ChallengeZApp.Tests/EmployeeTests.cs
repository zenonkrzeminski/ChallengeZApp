namespace ChallengeZApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenCollectSources_ShouldRessult()
        {
            // arrange
            var employee = new Employee("Oberyn", "Martell", 42);
            employee.AddScore(1);
            employee.AddScore(6);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(7, result);
        }

        [Test]
        public void WhenCollectMinusSources_ShouldRessult()
        {
            // arrange
            var employee = new Employee("Oberyn", "Martell", 42);
            employee.AddScore(1);
            employee.AddScore(6);
            employee.AddScore(-4);

            // act
            var result = employee.Result;

            // assert
            Assert.AreEqual(3, result);
        }
    }
}