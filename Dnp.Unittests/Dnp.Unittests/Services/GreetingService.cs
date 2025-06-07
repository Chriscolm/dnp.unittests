using Dnp.Unittests.Dtos;

namespace Dnp.Unittests.Services;

public class GreetingService(IUserService userService, TimeProvider timeProvider) : IGreetingService
{
    public string SayHello()
    {
        var greeting = GetGreeting();
        var user = GetUser();
        return $"{greeting} {user.Name}";
    }

    private User GetUser()
    {
        return userService.GetCurrentUser();
    }

    private string GetGreeting()
    {
        var t = timeProvider.GetUtcNow().UtcDateTime.TimeOfDay;
        if (t.TotalHours > 5 && t.TotalHours < 22)
        {
            return "Moin";
        }
        return "Slaap di wat";
    }
}


