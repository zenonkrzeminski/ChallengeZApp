using ChallengeZApp;

User user1 = new User("Adam", "456");
User user2 = new User("Monika", "345");
User user3 = new User("Zuzia", "234");
User user4 = new User("Damian", "123");

user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(1);
var result = user1.Result;
Console.WriteLine(result);

var name = User.GameName;

var pi = Math.PI;