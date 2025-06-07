using Dnp.Unittests.Dtos;
using Dnp.Unittests.Services;
using Moq;

namespace Dnp.Unittests.NUnitTests.Services;

[TestFixture]
public class GreetingServiceTests
{
    private IGreetingService greetingService = null!;    
    private Mock<TimeProvider> timeProvider = new();

    [SetUp]
    public void Setup()
    {
        var userService = new Mock<IUserService>();
        userService.Setup(u => u.GetCurrentUser()).Returns(new User(Guid.NewGuid(), "Christian"));
        greetingService = new GreetingService(userService.Object, timeProvider.Object);
    }

    [Test]
    public void ReturnsGreetingWithName()
    {
        var result = greetingService.SayHello();

        Assert.That(result, Does.Contain("Christian"));
    }

    [TestCase(8, "Moin")]
    [TestCase(23, "Slaap di wat")]
    public void ReturnsGreetingWithTime(int hour, string expectedStart)
    {
        // arrange
        timeProvider.Setup(p => p.GetUtcNow()).Returns(new DateTime(2025, 6, 6, hour, 0, 0, DateTimeKind.Utc));
        
        // act
        var result = greetingService.SayHello();

        //assert
        Assert.That(result, Does.StartWith(expectedStart));
    }
}
