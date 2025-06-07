using Dnp.Unittests.Dtos;
using Dnp.Unittests.Services;
using Moq;

namespace Dnp.Unittests.XUnitTests.Services;

public class UglyGreetingServiceTests : IDisposable
{

    private IGreetingService greetingService = null!;

    public UglyGreetingServiceTests()
    {
        // https://xunit.net/docs/shared-context
        var userService = new Mock<IUserService>();
        userService.Setup(u => u.GetCurrentUser()).Returns(new User(Guid.NewGuid(), "Christian"));
        greetingService = new UglyGreetingService(userService.Object);
    }

    [Fact]
    public void ReturnsGreetingWithName()
    {
        var result = greetingService.SayHello();

        Assert.Contains("Christian", result);
    }

    public void Dispose()
    {        
        // Hier nur der Vollständigkeit halber. 
        // Gegebenenfalls erfolgt hier die Freigabe von Resourcen oder das Aufräumen von Testdaten
        // Wird nach jedem Test aufgerufen
    }
}
