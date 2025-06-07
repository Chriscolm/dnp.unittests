using Dnp.Unittests.Dtos;

namespace Dnp.Unittests.Services;

public class BadGreetingService : IGreetingService
{
    public string SayHello()
    {
        var greeting = GetGreeting();
        var user = GetUser();
        return $"{greeting} {user.Name}";
    }

    private static User GetUser()
    {
        return new UserService().GetCurrentUser();
    }

    private static string GetGreeting()
    {
        var t = DateTime.UtcNow.TimeOfDay;
        if (t.TotalHours > 5 && t.TotalHours < 22)
        {
            return "Moin";
        }
        return "Slaap di wat";
    }
}