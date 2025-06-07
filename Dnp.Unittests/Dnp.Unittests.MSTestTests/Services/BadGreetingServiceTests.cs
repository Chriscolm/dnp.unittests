using Dnp.Unittests.Services;

namespace Dnp.Unittests.MSTestTests.Services;

[TestClass]
public class BadGreetingServiceTests
{
    private IGreetingService greetingService = null!;

    [TestInitialize]
    public void Setup()
    {
        greetingService = new BadGreetingService();
    }

    [TestMethod]
    public void ReturnsGreeting()
    {
        var result = greetingService.SayHello();

        Assert.IsInstanceOfType<string>(result);
    }

    [TestCleanup]
    public void TearDown()
    {
        // Hier nur der Vollständigkeit halber. 
        // Gegebenenfalls erfolgt hier die Freigabe von Resourcen oder das Aufräumen von Testdaten
        // Wird nach jedem Test aufgerufen
    }
}
