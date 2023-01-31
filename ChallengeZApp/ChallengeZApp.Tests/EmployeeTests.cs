namespace ChallengeZApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenCollectPlusPoints_ShouldRessultTotalPoints()
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
        public void WhenCollectPlusAndMinusPoints_ShouldRessultTotalPoints()
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